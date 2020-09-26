using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Controllers.IdentityHelpers;
using TemploOnline.Data;
using TemploOnline.Models;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Controllers
{
  public abstract class TemploOnlineController : Controller
  {
    protected TemploOnlineContext _context;
    protected UserManager<User> _userManager;

    protected RoleManager<IdentityRole> _roleManager { get; set; }

    protected TemploOnlineController(
      TemploOnlineContext context, 
      UserManager<User> userManager, 
      RoleManager<IdentityRole> roleManager)
    {
      _context = context;
      _userManager = userManager;
      _roleManager = roleManager;
    }


    protected ActionResult Func(Func<ActionResult> func, bool changePwd = true)
    {
      try
      {
        if (changePwd) 
        {
          var user = GetUser();
          if (user.DefaultPassword) 
            return RedirectChangePwd();
        }
        return func.Invoke();
      }
      catch (Exception exception)
      {
        return View("Error", new ErrorViewModel(
          exception.Message + " " + exception.InnerException?.Message
        ));
      }
    }

    protected async Task<ActionResult> FuncAsync(Func<Task<ActionResult>> func, bool changePwd = true)
    {
      try
      {
        if (changePwd) 
        {
          var user = GetUser();
          if (user.DefaultPassword)
            return RedirectChangePwd();
            
        }
        return await func.Invoke();
      }
      catch (Exception exception)
      {
        return View("Error", new ErrorViewModel(
          exception.Message + " " + exception.InnerException?.Message
        ));
      }
    }

    private ActionResult RedirectChangePwd() =>
       RedirectToAction("ChangePassword", "Profiles", new { msg = Password.FirstLoginPasswordChangeMsg });
    protected User GetUser() => _context.Users
        .Include(u => u.Person)
        .Where(u => u.UserName == User.Identity.Name)
        .FirstOrDefault();
  }
}