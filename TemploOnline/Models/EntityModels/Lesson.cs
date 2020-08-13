using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.EntityModels
{
  public class Lesson : NomeableEntity
  {
    [Required]
    public int TextbookId { get; set; }

    public Textbook Textbook { get; set; }

    public int LessonNumber { get; set; }
  }
}