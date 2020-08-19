using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ViewModels;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Controllers
{
  public class ClassroomsController : Controller
  {
    private TemploOnlineContext _context;

    public ClassroomsController(TemploOnlineContext context)
    {
      _context = context;
    }

    public ActionResult Index()
    {
      var viewModel = new ClassroomListingViewModel
      {
        Classrooms = _context.Classrooms.OrderBy(c => c.Name).ToList()
      };

      return View(viewModel);
    }

    public ActionResult New()
    {
      return View(new ClassroomViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(ClassroomViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var classroom = new Classroom { Name = viewModel.Name};
        _context.Classrooms.Add(classroom);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    }

    public ActionResult Details(int? id)
    {
      if (id != null)
      {
        var classroom = _context.Classrooms
          .Where(c => c.Id == id)
          .FirstOrDefault();
          if (classroom != null)
            return View(new ClassroomViewModel(classroom));
      }
      return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int? id)
    {
      if (id != null)
      {
        var classroom = _context.Classrooms
          .Where(c => c.Id == id)
          .FirstOrDefault();
        if (classroom != null)
          return View(new ClassroomViewModel(classroom));
      }
      return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(ClassroomViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var classroom = _context.Classrooms
          .Where(c => c.Id == viewModel.Id)
          .FirstOrDefault();
        classroom.Name = viewModel.Name;
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    }
  }
}