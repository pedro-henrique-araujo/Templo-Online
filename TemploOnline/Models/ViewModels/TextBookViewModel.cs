using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class TextBookListingViewModel
  {
    public IEnumerable<Textbook> TextBooks { get; set; }
  }

  public class TextBookViewModel : NomeableEntityViewModel
  {
    public List<SelectListItem> Categories { get; set; }

    public int CategoryId { get; set; }

    [Display(Name = "Categoria")]
    public string CategoryName { get; set; }

    public List<Lesson> Lessons { get; set; } = new List<Lesson>();

    public TextBookViewModel()
      :base()
    {
    }

    public TextBookViewModel(Textbook textBook)
      :base(textBook)
    {
      CategoryId = textBook.CategoryId;
      CategoryName = textBook.Category.Name;
      Lessons = textBook.Lessons;
    }
  }
}