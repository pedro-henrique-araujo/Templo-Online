using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Data;
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

    protected User GetUser() => _context.Users
        .Include(u => u.Person)
        .Where(u => u.UserName == User.Identity.Name)
        .FirstOrDefault();
  }
}