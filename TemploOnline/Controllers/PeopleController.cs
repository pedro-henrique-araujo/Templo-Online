using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Controllers.IdentityHelpers;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  [Authorize(Roles = "Admin, Dev")]
  public class PeopleController : TemploOnlineController
  {
    public PeopleController(
      TemploOnlineContext context, 
      UserManager<User> userManager, 
      RoleManager<IdentityRole> roleManager)
      : base(context, userManager, roleManager)
    {
    }

    public ActionResult Index()
    {
      return View(new PersonListingViewModel
      {
        People = _context.People.ToList()
      });
    }

    public ActionResult New()
    {
      return View(new PersonViewModel()
      {
        Roles = GetRoles()
      });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> New(PersonViewModel viewModel)
    {
      if (ModelState.IsValid)
      {        
        var person = new Person
        {
          Name = viewModel.Name,
          Nickname = string.IsNullOrEmpty(viewModel.Nickname) ? viewModel.Name : viewModel.Nickname,
          IsTeacher = viewModel.IsTeacher,
          IsStudent = viewModel.IsStudent
        };
        _context.People.Add(person);
        var user = new User 
        { 
          UserName = viewModel.Login,
          Person = person,
          DefaultPassword = true
        };
        var result = await _userManager.CreateAsync(user, Password.Default);
        if (result.Succeeded)
        {
          var role = await _roleManager.Roles
            .FirstOrDefaultAsync(r => r.Id == viewModel.RoleId);
          var roleResult = await _userManager.AddToRoleAsync(user, role.Name);
          if (roleResult.Succeeded)
          {
            _context.SaveChanges();      

            return RedirectToAction(nameof(Index));
          }          
        }       
      }
      viewModel.Roles = GetRoles();
      return View(viewModel);
    }

    public ActionResult Details(int? id)
    {
      if (id != null)
      {
        var person = _context.People
          .Include(c => c.User)
          .Where(c => c.Id == id)
          .FirstOrDefault();
          if (person != null)
            return View(new PersonViewModel(person));
      }
      return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int? id)
    {
      if (id != null)
      {
        var person = _context.People
          .Include(p => p.User)
          .Where(p => p.Id == id)
          .FirstOrDefault();
        if (person != null)
          return View(new PersonViewModel(person)
          {
            RoleId = _context.UserRoles
              .FirstOrDefault(ur => ur.UserId == person.User.Id).RoleId,
            Roles = GetRoles()
          });
      }
      return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(PersonViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var person = _context.People
          .Include(p => p.User)
          .Where(c => c.Id == viewModel.Id)
          .FirstOrDefault();
        person.Name = viewModel.Name;
        person.Nickname = string.IsNullOrEmpty(viewModel.Nickname) ? viewModel.Name : viewModel.Nickname;
        person.IsTeacher = viewModel.IsTeacher;
        person.IsStudent = viewModel.IsStudent;
        person.User.UserName = viewModel.Login;
        var result = await _userManager.UpdateAsync(person.User);
        if (result.Succeeded)
        {
          var user = await _userManager.Users
            .FirstOrDefaultAsync(u => u.Id == person.User.Id);
          
          _context.UserRoles.RemoveRange(
            _context.UserRoles.Where(ur => ur.UserId == user.Id
            ));

          var role = await _roleManager.Roles
            .FirstOrDefaultAsync(r => r.Id == viewModel.RoleId);

          _context.UserRoles.Add(new IdentityUserRole<string> 
          { 
            UserId = user.Id, 
            RoleId = role.Id 
          }); 
          _context.SaveChanges();      

          return RedirectToAction(nameof(Index));
        }       
      }
      viewModel.Roles = GetRoles();
      return View(viewModel);
    }

    #region Helpers
    public IEnumerable<SelectListItem> GetRoles()
    {
      return _context.Roles
          .Select(r => new SelectListItem 
          {
            Value = r.Id,
            Text = r.Name
          }).ToList();
    }
    #endregion
  }
}