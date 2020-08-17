using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ApiModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/{controller}")]
  [ApiController]
  public class LessonsController : ControllerBase
  { 
    private TemploOnlineContext _context;

    public LessonsController(TemploOnlineContext context)
    {
        _context = context;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var lesson = _context.Lessons.Find(id);
      if (lesson != null)
      {
        _context.Lessons.Remove(lesson);
        _context.SaveChanges();
        return Ok(new ResultMessage
        (
          "Sucesso!",
          "Lição removida com sucesso!"
        ));
      }
      return BadRequest(new ResultMessage
      (
        "Desculpe!",
        "Não foi possível encontrar uma lição com este Id"
      ));
    }

  }
}