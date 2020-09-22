using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Controllers.IdentityHelpers;
using TemploOnline.Data;
using TemploOnline.Models.ApiModels;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/{controller}")]
  [ApiController]
  [Authorize(Roles = "Admin, Dev")]
  public class PeopleController : ControllerBase
  {
    private TemploOnlineContext _context;

    private UserManager<User> _userManager;

    public PeopleController(TemploOnlineContext context, UserManager<User> userManager)
    {
      _context = context;
      _userManager = userManager;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var person = _context.People.Find(id);
      if (person != null)
      {
        _context.People.Remove(person);
        _context.SaveChanges();
        return Ok(new ResultMessage(
          "Sucesso!",
          "Irmão removido com sucesso!"
        ));
      }
      return BadRequest(new ResultMessage(
        "Desculpe!",
        "Não foi possível encontrar um irmão com este id"
      ));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> ResetPassword(int id)
    {
       var person = await _context.People
        .Where(p => p.Id == id)
        .Include(p => p.User)
        .FirstOrDefaultAsync();
        var user = person.User;
        if (user != null)
        {        
          var token = await _userManager.GeneratePasswordResetTokenAsync(user);
          var result = await _userManager.ResetPasswordAsync(user, token, Password.Default);
          if (result.Succeeded)
          {
            user.DefaultPassword = true;
            await _context.SaveChangesAsync();
            return Ok(new ResultMessage(
              "Sucesso!",
              "Senha resetada com sucesso"
            ));
          }
        }
        return BadRequest(new ResultMessage(
          "Desculpe!",
          "Não foi possível encontrar um irmão com esse id"
        ));
    }
  }
}