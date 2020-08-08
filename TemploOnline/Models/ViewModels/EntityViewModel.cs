using System.ComponentModel.DataAnnotations;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class EntityViewModel
  {
    [Required]
    public int Id { get; set; }

    public EntityViewModel()
    {        
    }

    public EntityViewModel(Entity entity) => Id = entity.Id;
  }
}