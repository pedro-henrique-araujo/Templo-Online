using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ApiModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/{controller}")]
  [ApiController]

  public class AttendancesListsController : ControllerBase
  {
    private TemploOnlineContext _context;

    public AttendancesListsController(TemploOnlineContext context)
    {
      _context = context;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var attendanceList = _context.AttendancesLists.Find(id);
      if (attendanceList != null)
      {
        _context.AttendancesLists.Remove(attendanceList);

        _context.Attendances.RemoveRange(
          _context.Attendances
          .Where(a => a.AttendanceList.Id == attendanceList.Id)
          .ToList()
        );
        _context.SaveChanges();
        return Ok(new ResultMessage
        (
          "Successo!",
          "Chamada removida com sucesso!"
        ));
      }
      return BadRequest(new ResultMessage
      (
        "Desculpe!",
        "Não foi possível encontrar uma chamada com este Id"
      ));
    }

  }
}