using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.EntityModels
{
  public class Teacher : Entity
  {
    public Person Person { get; set; }

    [Required]
    public int PersonId { get; set; }

  }
}