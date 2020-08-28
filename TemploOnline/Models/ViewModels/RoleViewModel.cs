using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TemploOnline.Models.ViewModels
{
  public class RoleListingViewModel
  {
    public IEnumerable<IdentityRole> Roles { get; set; }
  }

  public class RoleViewModel : NomeableEntityViewModel
  {
    public new string Id { get; set; }
    public RoleViewModel()
      :base()
    {
      
    }
    public RoleViewModel(IdentityRole role)
    {
      Id = role.Id;
      Name = role.Name;
    }
  }
}