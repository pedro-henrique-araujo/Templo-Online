using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  public class AccountController : Controller
  {
    private SignInManager<User> _signInManager { get; set; }

    private UserManager<User> _userManager { get; set; }
    public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
    {
      _signInManager = signInManager;
      _userManager = userManager;
    }

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
        }
        
      }
      return View(viewModel);
    }

    public async Task<ActionResult> Logout()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction(nameof(Index));
    }
  }
}