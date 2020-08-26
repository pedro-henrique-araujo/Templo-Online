using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ApiModels;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/{controller}")]
  [ApiController]
  public class PeopleController : ControllerBase
  {
    private TemploOnlineContext _context;

    public PeopleController(TemploOnlineContext context)
    {
      _context = context;
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
  }
}