using Microsoft.AspNetCore.Identity;

namespace TemploOnline.Models.EntityModels
{
  public class User : IdentityUser
  {
    public Person Person { get; set; }

    public int PersonId { get; set; }
  }
}