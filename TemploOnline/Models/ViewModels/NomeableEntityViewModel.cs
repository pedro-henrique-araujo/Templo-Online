using System.ComponentModel.DataAnnotations;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class NomeableEntityViewModel : EntityViewModel
  {
    [Required(ErrorMessage = "Campo Obrigatório")]
    [Display(Name = "Nome")]
    [MinLength(3, ErrorMessage = "No mínimo {1} caracteres")]
    [MaxLength(250, ErrorMessage = "No máximo {1} caracteres" )]
    
    public string Name { get; set; }

    public NomeableEntityViewModel()
    {
        
    }

    public NomeableEntityViewModel(NomeableEntity nomeableEntity)
      :base(nomeableEntity)
    {        
        Name = nomeableEntity.Name;
    }
  }
}