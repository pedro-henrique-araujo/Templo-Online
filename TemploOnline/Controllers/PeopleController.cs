using System.Linq;
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

    public PeopleController(TemploOnlineContext context)
    {
      _context = context;
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
    public ActionResult New(PersonViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        _context.People.Add(new Person
        {
          Name = viewModel.Name,
          Nickname = string.IsNullOrEmpty(viewModel.Nickname) ? viewModel.Name : viewModel.Nickname,
          IsTeacher = viewModel.IsTeacher,
          IsStudent = viewModel.IsStudent
        });
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
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
          .Where(p => p.Id == id)
          .FirstOrDefault();
        if (person != null)
          return View(new PersonViewModel(person));
      }
      return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(PersonViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var person = _context.People
          .Where(c => c.Id == viewModel.Id)
          .FirstOrDefault();
        person.Name = viewModel.Name;
        person.Nickname = string.IsNullOrEmpty(viewModel.Nickname) ? viewModel.Name : viewModel.Nickname;
        person.IsTeacher = viewModel.IsTeacher;
        person.IsStudent = viewModel.IsStudent;
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    }
  }
}