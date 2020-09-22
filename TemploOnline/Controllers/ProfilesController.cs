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

    public ActionResult Index() => View(GetProfileViewModel());

    public ActionResult Edit()
    {
      var user = GetUser();
      var person = user.Person;
      if (person != null)
        return View(GetProfileViewModel());
      return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(ProfileViewModel viewModel)
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
    }

    public ActionResult ChangePassword() => View(new ChangePasswordViewModel());

    [ValidateAntiForgeryToken]
    [HttpPost]
    public async Task<ActionResult> ChangePassword(ChangePasswordViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var user = GetUser();
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var result = await _userManager.ResetPasswordAsync(user, token, viewModel.Password);
        if (result.Succeeded)
        {
          return RedirectToAction(nameof(Index));
        }
      }
      return View(viewModel);
    }

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