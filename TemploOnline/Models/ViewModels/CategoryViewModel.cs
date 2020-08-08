using System.Collections.Generic;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class CategoryListingViewModel
  {
    public List<Category> Categories { get; set; }
  }

  public class CategoryViewModel : NomeableEntityViewModel
  {
    public CategoryViewModel()
    {        
    }

    public CategoryViewModel(Category category)
      :base(category)
    {
        
    }
  }
}