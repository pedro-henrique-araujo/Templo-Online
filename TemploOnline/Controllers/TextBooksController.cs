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
  public class TextbooksController : Controller
  {
    private TemploOnlineContext _context;

    public TextbooksController(TemploOnlineContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
      var viewModel = new TextBookListingViewModel
      {
        TextBooks = _context.TextBooks.OrderBy(t => t.Name).ToList()
      };
      return View(viewModel);
    }

    public ActionResult New()
    {
      var viewModel = new TextBookViewModel
      {
        Categories = _context.Categories
          .OrderBy(c => c.Name)
          .Select(c => new SelectListItem 
          {
            Value = c.Id.ToString(),
            Text = c.Name
          } ).ToList()
      };

      return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(TextBookViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var textBook = new Textbook
        {
          Name = viewModel.Name,
          CategoryId = viewModel.CategoryId
        };        

        _context.TextBooks.Add(textBook);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      viewModel.Categories = _context.Categories
        .Select(c => new SelectListItem 
        { 
          Value = c.Id.ToString(), 
          Text = c.Name
        }).ToList();

      return View(viewModel);
    }

    public ActionResult Details(int? id)
    {
      if (id != null)
      {
        var textBook = _context.TextBooks
          .Include(t => t.Category)
          .Include(t => t.Lessons)
          .Where(t => t.Id == id)
          .FirstOrDefault();
          
        if (textBook != null)
        {
          var viewModel = new TextBookViewModel(textBook);
          return View(viewModel);
        }
      }
      return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int? id)
    {
      if (id != null)
      {
        var textBook = _context.TextBooks
          .Include(t => t.Category)
          .Include(t => t.Lessons)
          .Where(t => t.Id == id)
          .FirstOrDefault();
        if (textBook != null)
          return View(new TextBookViewModel(textBook)
          {
            Categories = _context.Categories
              .Select(c => new SelectListItem()
              {
                Value = c.Id.ToString(),
                Text = c.Name
              }).ToList()
          });
      }
      return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(TextBookViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var textBook = new Textbook
        {
          Id = viewModel.Id,
          Name = viewModel.Name,
          CategoryId = viewModel.CategoryId
        };        

        _context.TextBooks.Update(textBook);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      viewModel.Categories = _context.Categories
        .Select(c => new SelectListItem
        {
          Value = c.Id.ToString(),
          Text = c.Name
        }).ToList();
      return View(viewModel);
    }
  }
}