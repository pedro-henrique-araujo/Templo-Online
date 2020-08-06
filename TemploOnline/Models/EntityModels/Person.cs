using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.EntityModels
{
  public class Person : NomeableEntity
  {

    [MinLength(3)]
    [MaxLength(250)]
    public string Nickname { get; set; }

    public User User { get; set; }
  }
}