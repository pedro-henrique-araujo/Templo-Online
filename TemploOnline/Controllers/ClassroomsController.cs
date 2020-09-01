using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ViewModels;
using TemploOnline.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authorization;

namespace TemploOnline.Controllers
{
  [Authorize(Roles = "Aluno, Professor, Admin, Dev")]
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
      return View(new ClassroomViewModel() 
      { 
        People = _context.People.OrderBy(p => p.Name).ToList() 
      });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(ClassroomViewModel viewModel)
    {
      if (ModelState.IsValid)
      {    
        var classroom = new Classroom { Name = viewModel.Name};
        _context.Classrooms.Add(classroom);
        var teachersIds = Request.Form["Teachers"];
        foreach (var id in teachersIds)
          _context.PeopleClassrooms.Add(new PersonClassroom 
          {
            Classroom = classroom,
            PersonId = Convert.ToInt32(id),
            AsTeacher = true
          });
        var studentsIds = Request.Form["Students"];
        foreach (var id in studentsIds)
        {
          _context.PeopleClassrooms.Add(new PersonClassroom 
          {
            Classroom = classroom,
            PersonId = Convert.ToInt32(id),
            AsTeacher = false
          });
        }
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
          .Include(c => c.PeopleClassrooms)
            .ThenInclude(pc => pc.Person)
          .Where(c => c.Id == id)
          .FirstOrDefault();
        if (classroom != null)  
          return View(new ClassroomViewModel(classroom)
          {
            People = classroom.PeopleClassrooms.Select(pc => pc.Person)
          });
         
      }
      return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int? id)
    {
      if (id != null)
      {
        var classroom = _context.Classrooms
          .Include(c => c.PeopleClassrooms)
          .Where(c => c.Id == id)
          .FirstOrDefault();
        if (classroom != null)
          return View(new ClassroomViewModel(classroom) 
          {
            People = _context.People.OrderBy(p => p.Name).ToList()
          });
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
        _context.PeopleClassrooms.RemoveRange(
          _context.PeopleClassrooms.Where(pc => pc.ClassroomId == classroom.Id)
        );
        var teachersIds = Request.Form["Teachers"];
        foreach (var id in teachersIds)
          _context.PeopleClassrooms.Add(new PersonClassroom 
          {
            Classroom = classroom,
            PersonId = Convert.ToInt32(id),
            AsTeacher = true
          });

          var studentsIds = Request.Form["Students"];
        foreach (var id in studentsIds)
        {
          _context.PeopleClassrooms.Add(new PersonClassroom 
          {
            Classroom = classroom,
            PersonId = Convert.ToInt32(id),
            AsTeacher = false
          });
        }
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    }
  }
}