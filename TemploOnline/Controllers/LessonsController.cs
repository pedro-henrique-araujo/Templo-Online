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
  public class LessonsController : Controller
  {
    private TemploOnlineContext _context;

    public LessonsController(TemploOnlineContext context)
      :base()
    {
        _context = context;
    }

    public ActionResult New(int? textBookId)
    {
      if (textBookId != null)
      {
        var lessonNumbers = GetAvailableLessonNumbers(textBookId.Value);

        return View(new LessonViewModel()
        {
          TextbookId = textBookId.Value,
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

    public ActionResult Details(int? id, int? textBookId)
    {
      if (textBookId != null)
      {
        if (id != null)
        {
          var lesson = _context.Lessons
            .Include(l => l.Textbook)
            .Where(l => l.Id == id)
            .FirstOrDefault();
          if (lesson != null)
          {
            return View(new LessonViewModel(lesson));
          }
          
        }
        return RedirectToAction("Details", "Textbooks", new { Id = textBookId});
      }
      return RedirectToAction("Index", "Textbooks");
    }

    private List<SelectListItem> GetAvailableLessonNumbers(int textBookId)
    {
      var notAvailableNums = _context.Lessons
                .Where(t => t.TextbookId == textBookId)
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