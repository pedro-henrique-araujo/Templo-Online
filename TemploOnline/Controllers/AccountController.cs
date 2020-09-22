using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  public class AccountController : TemploOnlineController
  {
    private SignInManager<User> _signInManager { get; set; }
    public AccountController(
      TemploOnlineContext context, 
      UserManager<User> userManager, 
      RoleManager<IdentityRole> roleManager,
      SignInManager<User> signInManager)
      : base(context, userManager, roleManager) => _signInManager = signInManager;

    public ActionResult Index()
    {
      return View(new LoginViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Login(LoginViewModel viewModel, string returnUrl)
    {
      if (ModelState.IsValid)
      {
        var user = await _userManager.FindByNameAsync(viewModel.UserName);
        if (user != null)
        {
          var result = await _signInManager
            .PasswordSignInAsync(user.UserName, viewModel.Password, true, false);
          if (result.Succeeded)
          {
            if (!string.IsNullOrEmpty(returnUrl))
              return Redirect(returnUrl);
            else
              return RedirectToAction("Index", "Home");
          }
          else
          {
            ViewData["PasswordValidation"] = "Senha incorreta";
          }
        }
        else
        {
          ViewData["UserValidation"] = "Usuário inexistente";
        }
      }
      return View(nameof(Index), viewModel);
    }

    public async Task<ActionResult> Logout()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction(nameof(Index));
    }
  }
}