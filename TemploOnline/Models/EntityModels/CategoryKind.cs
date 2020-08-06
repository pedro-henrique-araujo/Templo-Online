using System.Collections.Generic;

namespace TemploOnline.Models.EntityModels
{
  public class CategoryKind : NomeableEntity
  {
    public List<Category> Categories { get; set; }
  }
}