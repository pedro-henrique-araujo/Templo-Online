using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  [Authorize(Roles = "Aluno, Professor, Admin, Dev")]
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
          .Include(a => a.Classroom)
          .Include(a => a.Lesson)
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
      var attendanceList = new AttendanceList 
      {
        ClassroomId = viewModel.ClassroomId,
        LessonId = viewModel.LessonId,
        Created = DateTime.Now
      };
      _context.AttendancesLists.Add(attendanceList);
      attendanceList.Attendances = new List<Attendance>();
      viewModel.TeachersAttendances.ForEach(ta => 
      {
        ta.AttendanceList = attendanceList;
        ta.AsTeacher = true;
      });
      viewModel.StudentsAttendances.ForEach(sa => 
      {
        sa.AttendanceList = attendanceList;
        sa.AsTeacher = false;
      });
      _context.Attendances.AddRange(viewModel.TeachersAttendances);
      _context.Attendances.AddRange(viewModel.StudentsAttendances);
      
      _context.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
    
    public ActionResult Details(int? id)
    {
      if (id != null)
      {
        var attendanceList = _context.AttendancesLists
          .Include(a => a.Lesson)
          .Include(a => a.Attendances)
            .ThenInclude(a => a.Person)
          .Include(a => a.Classroom)
          .Where(t => t.Id == id)
          .FirstOrDefault();
        if (attendanceList != null)
        {         

          var viewModel = new AttendanceListViewModel(attendanceList)
          {
           TeachersAttendances = _context.Attendances
            .Include(a => a.Person)
            .Where(a => a.AttendanceListId == attendanceList.Id && a.AsTeacher).ToList(),

          StudentsAttendances = _context.Attendances
            .Include(a => a.Person)
            .Where(a => a.AttendanceListId == attendanceList.Id && !a.AsTeacher).ToList()
          };
          return View(viewModel);
        }
      }
      return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int? id)
    {
      if (id != null)
      {
        var attendanceList = _context.AttendancesLists
          .Include(at => at.Lesson)
          .Where(al => al.Id == id)
          .FirstOrDefault();

        if (attendanceList != null)
        {
          return View(new AttendanceListViewModel(attendanceList)
          {
            TeachersAttendances = _context.Attendances
              .Include(a => a.Person)
              .Where(a => a.AttendanceListId == attendanceList.Id && a.AsTeacher).ToList(),

            StudentsAttendances = _context.Attendances
              .Include(a => a.Person)
              .Where(a => a.AttendanceListId == attendanceList.Id && !a.AsTeacher).ToList(),
            Lessons = _context.Lessons
            .Select(l => new SelectListItem 
            {  
              Value = l.Id.ToString(),
              Text = l.Name
            })
            .ToList()
          });
        }
      }
      return RedirectToAction(nameof(Index));
    }    

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(AttendanceListViewModel viewModel)
    {
      var attendanceList = _context.AttendancesLists
        .Where(al => al.Id == viewModel.Id)
        .FirstOrDefault();
      if (attendanceList != null)
      { 
        attendanceList.LessonId = viewModel.LessonId;        

        _context.Attendances
          .RemoveRange(_context.Attendances
            .Where(a => a.AttendanceListId == attendanceList.Id)
            .ToList());
        attendanceList.Attendances = new List<Attendance>();
        
        viewModel.TeachersAttendances.ForEach(ta => 
        {
          ta.AttendanceList = attendanceList;
          ta.AsTeacher = true;
        });
        viewModel.StudentsAttendances.ForEach(sa => 
        {
          sa.AttendanceList = attendanceList;
          sa.AsTeacher = false;
        });
        _context.Attendances.AddRange(viewModel.TeachersAttendances);
        _context.Attendances.AddRange(viewModel.StudentsAttendances);
        
        _context.SaveChanges();
      }
      return RedirectToAction(nameof(Index));
    }
  }
}