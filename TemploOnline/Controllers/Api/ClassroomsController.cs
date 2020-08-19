using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ApiModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/{controller}")]
  [ApiController]
  public class ClassroomsController : ControllerBase
  {    
    private TemploOnlineContext _context;

    public ClassroomsController(TemploOnlineContext context)
    {
      _context = context;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var classroom = _context.Classrooms.Find(id);
      if (classroom != null)
      {
        _context.Classrooms.Remove(classroom);
        _context.SaveChanges();
        return Ok(new ResultMessage(
          "Sucesso!",
          "Sala de aula removida com sucesso!"
        ));
      }
      return BadRequest(new ResultMessage(
        "Desculpe!",
        "Não foi possível encontrar uma sala com este Id"
      ));
    }
  }
}