using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.EntityModels
{
  public class Person : NomeableEntity
  {
    [MinLength(3)]
    [MaxLength(250)]
    public string Nickname { get; set; }

    public User User { get; set; }

    [Required]
    public bool IsTeacher { get; set; }

    [Required]
    public bool IsStudent { get; set; }

    public List<PersonClassroom> PeopleClassrooms { get; set; }
  }
}