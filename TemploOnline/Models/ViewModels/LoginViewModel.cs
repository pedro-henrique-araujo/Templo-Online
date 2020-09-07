using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.ViewModels
{
  public class LoginViewModel
  {
    [Required(ErrorMessage = "Campo Obrigatório")]
    [Display(Name = "Usuário")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório")]
    [DataType(DataType.Password)]
    [Display(Name = "Senha")]
    public string Password { get; set; }
  }
}