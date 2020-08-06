using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.EntityModels
{
  public class NomeableEntity : Entity
  {
    [Required]
    [MinLength(3)]
    [MaxLength(250)]
    public string Name { get; set; }
  }
}