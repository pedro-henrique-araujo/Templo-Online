namespace TemploOnline.Models.EntityModels
{
  public class Category : NomeableEntity 
  {
    public CategoryKind CategoryKind { get; set; }

    public int CategoryKindId { get; set; }
  }
}