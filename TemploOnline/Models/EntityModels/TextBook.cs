using System.Collections.Generic;

namespace TemploOnline.Models.EntityModels
{
  public class Textbook : NomeableEntity
  {
    public Category Category { get; set; }

    public int CategoryId { get; set; }

    public List<Lesson> Lessons { get; set; }
  }
}