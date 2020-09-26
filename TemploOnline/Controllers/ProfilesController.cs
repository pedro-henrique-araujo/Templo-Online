using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Controllers.IdentityHelpers;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  
  [Authorize(Roles = "Aluno, Professor, Admin, Dev")]
  public class ProfilesController : TemploOnlineController
  {
    public ProfilesController(
      TemploOnlineContext context, 
      UserManager<User> userManager, 
      RoleManager<IdentityRole> roleManager)
      : base(context, userManager, roleManager)
    {
    }

    public ActionResult Index() => Func(() =>View(GetProfileViewModel()));

    public ActionResult Edit() => Func(() =>
    {
      var user = GetUser();
      var person = user.Person;
      if (person != null)
        return View(GetProfileViewModel());
      return RedirectToAction("Index", "Home");
    });

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(ProfileViewModel viewModel) => Func(() =>
    {
      if (ModelState.IsValid)
      {
        var person = _context.People.Find(viewModel.Id);
        person.Name = viewModel.Name;
        person.Nickname = !string.IsNullOrEmpty(viewModel.Nickname) ? viewModel.Nickname : viewModel.Name;
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    });

    public ActionResult ChangePassword(string msg = "") => Func(() => 
    {
      ViewData["Msg"] = msg;
      return View(new ChangePasswordViewModel());
    }, false);

    [ValidateAntiForgeryToken]
    [HttpPost]
    public async Task<ActionResult> ChangePassword(ChangePasswordViewModel viewModel)
      => await FuncAsync(async () =>
    {
      if (ModelState.IsValid)
      {
        var user = GetUser();
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var result = await _userManager.ResetPasswordAsync(user, token, viewModel.Password);
        if (result.Succeeded)
        {
          user.DefaultPassword = false;
          await _context.SaveChangesAsync();
          return RedirectToAction(nameof(Index));
        }
      }
      return View(viewModel);
    }, false);

    #region Helpers

    private ProfileViewModel GetProfileViewModel() => new ProfileViewModel(GetUser(), GetRole());
    private string GetRole()
    {
      if (User.IsInRole(Roles.Dev))
        return "Desenvolvedor";
      if (User.IsInRole(Roles.Admin))
        return "Administrador";
      if (User.IsInRole(Roles.Professor))
        return "Professor";
      return "Aluno";
    }
    #endregion
  }
}