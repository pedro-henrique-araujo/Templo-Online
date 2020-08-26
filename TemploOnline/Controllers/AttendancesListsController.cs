using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  public class AttendancesListsController : Controller
  {
    public TemploOnlineContext _context { get; set; }

    public AttendancesListsController(TemploOnlineContext context)
    {
      _context = context;
    }

    public ActionResult Index()
    {
      return View( new AttendanceListListingViewModel
      {
        AttendancesLists = _context.AttendancesLists
          .OrderByDescending(al => al.Created)
          .ToList(),
        Classrooms = _context.Classrooms
          .OrderBy(c => c.Name)
          .Select(c => new SelectListItem 
          {
            Value = c.Id.ToString(),
            Text = c.Name
          })
          .ToList()
      });
    }

    public ActionResult New(int classroomId)
    {
      var peopleClassrooms = _context.PeopleClassrooms
        .Where(pc => pc.ClassroomId == classroomId);
      
      var teachers = new List<Attendance>();
      foreach(var teacher in peopleClassrooms
        .Include(pc => pc.Person)
        .Where(pc => pc.AsTeacher)
        .Select(pc => pc.Person)
        .ToList())
        teachers.Add(new Attendance 
        {
          PersonId = teacher.Id,
          Person = teacher
        });

      var students = new List<Attendance>();
      foreach (var student in peopleClassrooms
        .Include(pc => pc.Person)
        .Where(pc => !pc.AsTeacher)
        .Select(pc => pc.Person)
        .ToList())
          students.Add(new Attendance 
          { 
            PersonId = student.Id, Person = student
          });
  
      return View(new AttendanceListViewModel()
      { 
        ClassroomId = classroomId,
        Lessons = _context.Lessons
          .OrderBy(c => c.Name)
          .Select(c => new SelectListItem
          {
            Value = c.Id.ToString(),
            Text = c.Name
          }).ToList(),
          TeachersAttendances = teachers,
          StudentsAttendances = students
      });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(AttendanceListViewModel viewModel)
    {
      return View(viewModel);
    }
  }
}