using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.ViewModels
{
  public class LoginViewModel
  {
    [Required]
    [Display(Name = "Usuário")]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Senha")]
    public string Password { get; set; }
  }
}