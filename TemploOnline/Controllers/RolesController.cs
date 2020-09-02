using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  [Authorize(Roles = "Dev")]
  public class RolesController : Controller
  {
    private TemploOnlineContext _context;

    private RoleManager<IdentityRole> _roleManager;
    public RolesController(TemploOnlineContext context, RoleManager<IdentityRole> roleManager)
    {
      _context = context;
      _roleManager = roleManager;
    }

    public ActionResult Index()
    {
      return View(new RoleListingViewModel 
      {
        Roles =  _roleManager.Roles
      });
    }

    public ActionResult New()
    {
      return View(new RoleViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> New(RoleViewModel viewModel)
    {
      var result = await _roleManager.CreateAsync(new IdentityRole(viewModel.Name));
      if (result.Succeeded)
      {        
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    }

    public async Task<ActionResult> Details(string id)
    {
      if (id != null)
      {
        var role = await _roleManager.FindByIdAsync(id);
        if (role != null)
          return View(new RoleViewModel(role));
      }
      return RedirectToAction(nameof(Index));
    }

    public async Task<ActionResult> Edit(string id)
    {
      if (id != null)
      {
        var role = await _roleManager.FindByIdAsync(id);
        if (role != null)
          return View(new RoleViewModel(role));
      }
      return RedirectToAction(nameof(Index));
    }
  }
}