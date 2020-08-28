using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  public class PeopleController : Controller
  {
    private TemploOnlineContext _context;
    private UserManager<User> _userManager;

    public PeopleController(TemploOnlineContext context, UserManager<User> userManager)
    {
      _context = context;
      _userManager = userManager;
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
      return View(new PersonViewModel());
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
          UserName = viewModel.User.UserName,
          Person = person
        };
        var result = await _userManager.CreateAsync(user, "123456");
        if (result.Succeeded)
        {
          _context.SaveChanges();      

          return RedirectToAction(nameof(Index));
        }
       
      }
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
          return View(new PersonViewModel(person));
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
        person.User.UserName = viewModel.User.UserName;
        var result = await _userManager.UpdateAsync(person.User);
        if (result.Succeeded)
        {
          _context.SaveChanges();
          return RedirectToAction(nameof(Index));
        }
       
      }
      return View(viewModel);
    }
  }
}