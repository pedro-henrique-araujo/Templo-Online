using System.ComponentModel.DataAnnotations;
using TemploOnline.Controllers.IdentityHelpers;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class ProfileViewModel
  {
    public int Id { get; set; }

    [Display(Name = "Nome de usuário")]
    public string Username { get; set; }

    
    [Display(Name = "Conhecido(a) como")]
    public string Nickname { get; set; } 

    [Required(ErrorMessage = "Campo obrigatório")]

    [Display(Name = "Nome")]
    public string Name { get; set; }

    [Display(Name = "Permissão")]
    public string Role { get; set; }

    [Display(Name = "Professor?")]
    public string IsTeacher { get; set; }

    [Display(Name = "Aluno?")]
    public string IsStudent { get; set; }

    public ProfileViewModel()
    {
        
    }
    public ProfileViewModel(User user, string role)
    {
      Id = user.Person.Id;
      Username = user.UserName;
      Name = user.Person.Name;
      Nickname = user.Person.Nickname;    
      Role = role;
      IsTeacher = user.Person.IsTeacher ? "Sim" : "Não";
      IsStudent = user.Person.IsStudent ? "Sim" : "Não";
    }
  }
}