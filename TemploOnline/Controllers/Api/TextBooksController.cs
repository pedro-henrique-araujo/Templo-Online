using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ApiModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/[controller]")]
  [ApiController]
  public class TextBooksController : ControllerBase
  {
    public TemploOnlineContext _context;

    public TextBooksController(TemploOnlineContext context)
    {
      _context = context;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var message = new ResultMessage();
      var textBook = _context.TextBooks.Find(id);
      if (textBook != null)
      {
        _context.TextBooks.Remove(textBook);
        foreach (var lesson in _context.Lessons
          .Where(l => l.TextbookId == textBook.Id))
          {
            _context.Lessons.Remove(lesson);
          }
        _context.SaveChanges();
        message.Title = "Sucesso!";
        message.Message = "Revista removida com sucesso!";
        return Ok(message);
      }
      message.Title = "Desculpe!";
      message.Message = "Não foi possível encontrar uma revista com este Id";
      return BadRequest(message);
    }

  }
}