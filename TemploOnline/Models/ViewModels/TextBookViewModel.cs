using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class TextBookListingViewModel
  {
    public IEnumerable<TextBook> TextBooks { get; set; }
  }

  public class TextBookViewModel : NomeableEntityViewModel
  {
    public List<SelectListItem> Categories { get; set; }

    public int CategoryId { get; set; }

    public TextBookViewModel()
      :base()
    {
      
    }

    public TextBookViewModel(TextBook textBook)
      :base(textBook)
    {
        CategoryId = textBook.CategoryId;
    }
  }

  public class TextBookDetailsViewModel : NomeableEntityViewModel
  {
    public int CategoryId { get; set; }

    [Display(Name = "Categoria")]
    public string CategoryName { get; set; }

    public TextBookDetailsViewModel()
      :base()
    {
        
    }

    public TextBookDetailsViewModel(TextBook textBook)
      :base(textBook)
    {
        CategoryId = textBook.CategoryId;
        CategoryName = textBook.Category.Name;
    }
  }
}