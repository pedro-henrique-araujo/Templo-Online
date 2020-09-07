using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [Required(ErrorMessage = "Campo Obrigatório")]
    public string Nickname { get; set; }

    public User User { get; set; }

    [Required]
    [Display(Name = "É professor?")]
    public bool IsTeacher { get; set; }

    [Required]
    [Display(Name = "É aluno?")]
    public bool IsStudent { get; set; }

    public IEnumerable<SelectListItem> Roles { get; set; }

    [Display(Name = "Permissões")]
    public string RoleId { get; set; }

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