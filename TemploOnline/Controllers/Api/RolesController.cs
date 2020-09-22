using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Models.ApiModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/{controller}")]
  [ApiController]
  [Authorize(Roles = "Dev")]
  public class RolesController : ControllerBase
  {
    private RoleManager<IdentityRole> _roleManager;

    public RolesController(RoleManager<IdentityRole> roleManager)
    {
      _roleManager = roleManager;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id)
    {
      var role = await _roleManager.FindByIdAsync(id);
      if (role != null)
      {
        await _roleManager.DeleteAsync(role);
        return Ok(new ResultMessage(
          "Sucesso!",
          "Permissão removida com sucesso"
        ));
      }
      return BadRequest(new ResultMessage(
        "Desculpe!",
        "Não foi possível encontrar uma permissão com este id"
      ));
    }
  }

}