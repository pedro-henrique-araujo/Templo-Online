using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.ViewModels
{
  public class ChangePasswordViewModel
  {
    [DataType(DataType.Password)]
    [Display(Name = "Senha")]
    [StringLength(100, ErrorMessage = "A senha deve ser no ter no mínimo {2} carateres",MinimumLength = 6)]
    [Required(ErrorMessage = "Este campo é obrigatório")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirmar senha")]
    [Compare(nameof(Password), ErrorMessage = "As senhas não correspondem.")]
    public string ConfirmPassword { get; set; }
  }
}