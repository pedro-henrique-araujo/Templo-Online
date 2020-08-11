namespace TemploOnline.Models.EntityModels
{
  public class TextBook : NomeableEntity
  {
    public Category Category { get; set; }

    public int CategoryId { get; set; }
  }
}