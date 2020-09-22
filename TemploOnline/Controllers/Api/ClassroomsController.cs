using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.FilesHelpers;
using TemploOnline.Models.ApiModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/{controller}")]
  [ApiController]
  [Authorize(Roles = "Admin, Dev")]
  public class ClassroomsController : ControllerBase
  {    
    private TemploOnlineContext _context;

    private FileManager _fileManager;

    public ClassroomsController(TemploOnlineContext context, IWebHostEnvironment env)
    {
      _context = context;
      _fileManager = new FileManager(env);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var classroom = _context.Classrooms.Find(id);
      if (classroom != null)
      {
        _fileManager.DeleteImg(classroom.CoverUrl);
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