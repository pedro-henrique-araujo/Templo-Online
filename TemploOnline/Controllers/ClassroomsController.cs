using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ViewModels;
using TemploOnline.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authorization;
using TemploOnline.Controllers.IdentityHelpers;
using System.Collections.Generic;
using System.Net;
using System.Drawing;
using Microsoft.AspNetCore.Hosting;
using TemploOnline.FilesHelpers;
using Microsoft.AspNetCore.Identity;

namespace TemploOnline.Controllers
{
  [Authorize(Roles = "Aluno, Professor, Admin, Dev")]
  public class ClassroomsController : TemploOnlineController
  {
    private IWebHostEnvironment _env;

    private FileManager _fileManager;

    public ClassroomsController(
      TemploOnlineContext context,
      UserManager<User> userManager, 
      RoleManager<IdentityRole> roleManager, 
      IWebHostEnvironment env)
      :base(context, userManager, roleManager)
    {
      _env = env;
      _fileManager = new FileManager(_env);
    }

    public ActionResult Index()
    {      
      var classrooms = new List<Classroom>();
      if (User.IsInRole(Roles.Admin) || User.IsInRole(Roles.Dev))
      {
        classrooms = _context.Classrooms.OrderBy(c => c.Name).ToList();        
      } 
      if (User.IsInRole(Roles.Professor) || User.IsInRole(Roles.Aluno))
      {
        var user = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
        classrooms = _context.Classrooms
          .Include(c => c.PeopleClassrooms)
          .Where(c => c.PeopleClassrooms.Any(pc => pc.Person.User.Id == user.Id))
          .ToList();
          
      }

      var viewModel = new ClassroomListingViewModel 
      { 
        Classrooms = classrooms
      };

      return View(viewModel);
    }

     [Authorize(Roles = "Admin, Dev")]
    public ActionResult New()
    {
      return View(new ClassroomViewModel() 
      { 
        People = _context.People.OrderBy(p => p.Name).ToList() 
      });
    }

     [Authorize(Roles = "Admin, Dev")]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(ClassroomViewModel viewModel)
    {
      if (ModelState.IsValid)
      {    
        var classroom = new Classroom 
        { 
          Name = viewModel.Name,
          CoverUrl = DownloadImg(viewModel.CoverUrl)
        };
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
          .Include(c => c.AttendancesLists)
          .Where(c => c.Id == id)
          .FirstOrDefault();
        if (classroom != null)  
          return View(new ClassroomViewModel(classroom)
          {
            People = classroom.PeopleClassrooms.Select(pc => pc.Person),
            AttendancesLists = classroom.AttendancesLists
          });         
      }
      return RedirectToAction(nameof(Index));
    }
     [Authorize(Roles = "Admin, Dev")]
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

    [Authorize(Roles = "Admin, Dev")]
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
        if (classroom.CoverUrl != viewModel.CoverUrl)
        {
          DeleteImg(classroom.CoverUrl);
          classroom.CoverUrl = DownloadImg(viewModel.CoverUrl);
        }
         
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

    #region Helpers
    public string DownloadImg(string imgUrl) => _fileManager.DownloadImg(imgUrl);

    public bool DeleteImg(string coverUrl) => _fileManager.DeleteImg(coverUrl);
    #endregion
  }
}