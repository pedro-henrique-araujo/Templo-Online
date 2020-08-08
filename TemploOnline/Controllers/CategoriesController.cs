using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.EntityModels;
using TemploOnline.Models.ViewModels;

namespace TemploOnline.Controllers
{
  public class CategoriesController : Controller
  {
    public TemploOnlineContext _context;

    public CategoriesController(TemploOnlineContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
      var viewModel = new CategoryListingViewModel
      {
        Categories = _context.Categories.OrderBy(c => c.Name).ToList()
      };

      return View(viewModel);
    }

    public ActionResult New()
    {    
     return View(new CategoryViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(CategoryViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var category = new Category { Name = viewModel.Name };
        _context.Categories.Add(category);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    }

    public ActionResult Details(int? id)
    {
      if (id != null)
      {
        var category = _context.Categories.Find(id);
        if (category != null)
          return View(new CategoryViewModel(category));
      }
      return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int? id)
    {
      if (id != null)
      {
        var category = _context.Categories.Find(id);
        if (category != null)
          return View(new CategoryViewModel(category));
      }
      return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(CategoryViewModel viewModel)
    {
      if (ModelState.IsValid)
      {
        var category = new Category
        {
          Id = viewModel.Id,
          Name = viewModel.Name
        };
        _context.Categories.Update(category);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      return View(viewModel);
    }
  }
}