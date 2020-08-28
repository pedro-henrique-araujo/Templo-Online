using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class PersonListingViewModel
  {
    public IEnumerable<Person> People { get; set; }
  }

  public class PersonViewModel : NomeableEntityViewModel
  {
    [Display(Name = "Conhecido(a) como")]
    public string Nickname { get; set; }

    public User User { get; set; }

    [Required]
    [Display(Name = "É professor?")]
    public bool IsTeacher { get; set; }

    [Required]
    [Display(Name = "É aluno?")]
    public bool IsStudent { get; set; }

    public PersonViewModel()
      :base()
    {
        
    }

    public PersonViewModel(Person person)
      :base(person)
    {
      Nickname = person.Nickname;
      User = person.User;
      IsStudent = person.IsStudent;
      IsTeacher = person.IsTeacher;
    }
  }
}