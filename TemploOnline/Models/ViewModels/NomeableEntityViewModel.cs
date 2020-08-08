using System.ComponentModel.DataAnnotations;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class NomeableEntityViewModel : EntityViewModel
  {
    [Required]
    [Display(Name = "Nome")]
    [MinLength(3)]
    [MaxLength(250)]
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