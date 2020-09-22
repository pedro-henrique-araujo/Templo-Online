using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  [Authorize(Roles = "Admin, Dev")]
  public class LessonsController : TemploOnlineController
  {
    public LessonsController(
      TemploOnlineContext context, 
      UserManager<User> userManager, 
      RoleManager<IdentityRole> roleManager)
      : base(context, userManager, roleManager)
    {
    }

    public ActionResult New(int? textbookId)
    {
      if (textbookId != null)
      {
        var lessonNumbers = GetAvailableLessonNumbers(textbookId.Value);

        return View(new LessonViewModel()
        {
          TextbookId = textbookId.Value,
          LessonNumbers = lessonNumbers
        });
      }
      return RedirectToAction("Index", "TextBooks");
    }   

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(LessonViewModel viewModel)
    {
      if (ModelState.IsValid)
      {       
        _context.Lessons.Add(new Lesson 
        {
          TextbookId = viewModel.TextbookId,
          Name = viewModel.Name,
          LessonNumber = viewModel.LessonNumber
        });
        _context.SaveChanges();
        return RedirectToAction("Details", "Textbooks", new 
          { 
            Id = viewModel.TextbookId 
          });
        
      }
      viewModel.LessonNumbers = GetAvailableLessonNumbers(viewModel.TextbookId);
      return View(viewModel);
    }

    public ActionResult Details(int? id, int? textbookId)
    {
      if (id != null && textbookId != null)
      {
        var lesson = _context.Lessons
          .Include(l => l.Textbook)
          .Where(l => l.Id == id)
          .FirstOrDefault();
        if (lesson != null)
          return View(new LessonViewModel(lesson));    
        return RedirectToAction("Details", "Textbooks", new { Id = textbookId});
      }
      return RedirectToAction("Index", "Textbooks");
    }


    public ActionResult Edit(int? id, int? textbookId)
    {
      if (id != null && textbookId != null)
      {
        var lesson = _context.Lessons
          .Include(l => l.Textbook)
          .Where(l => l.Id == id)
          .FirstOrDefault();
        
          if (lesson != null)
          {
            var lessonNumbers = GetAvailableLessonNumbers(textbookId.Value);
            lessonNumbers.Add(new SelectListItem(
              lesson.LessonNumber.ToString(), 
              lesson.LessonNumber.ToString()
              ));
            return View(new LessonViewModel(lesson) { LessonNumbers = lessonNumbers });
          }

        return RedirectToAction("Details", "Textbooks", new { Id = textbookId });
      }
      return RedirectToAction("Index", "Textbooks");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(LessonViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var lesson = _context.Lessons.Find(viewModel.Id);
        lesson.Name = viewModel.Name;
        lesson.LessonNumber = viewModel.LessonNumber;
        _context.SaveChanges();
        return RedirectToAction("Details", "Textbooks", new { Id = viewModel.TextbookId});
      }
      var lessonNumbers = GetAvailableLessonNumbers(viewModel.TextbookId);
      lessonNumbers.Add(new SelectListItem(
        viewModel.LessonNumber.ToString(),
        viewModel.LessonNumber.ToString()
      ));
      viewModel.LessonNumbers = lessonNumbers;
      return View(viewModel);
    }

    private List<SelectListItem> GetAvailableLessonNumbers(int textbookId)
    {
      var notAvailableNums = _context.Lessons
                .Where(t => t.TextbookId == textbookId)
                .Select(t => t.LessonNumber)
                .ToList();
      var lessonNumbers = new List<SelectListItem>();
      for (var i = 1; i <= 14; i++)
      {
        if (!notAvailableNums.Contains(i))
        {
          var num = i.ToString();
          lessonNumbers.Add(new SelectListItem(num, num));
        }
      }

      return lessonNumbers;
    }
  }
}