using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
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
  }
}