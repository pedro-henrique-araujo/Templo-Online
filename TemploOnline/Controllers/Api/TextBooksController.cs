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
    private TemploOnlineContext _context;

    public TextBooksController(TemploOnlineContext context)
    {
      _context = context;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
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
        return Ok(new ResultMessage
        (
          "Sucesso!", 
          "Revista removida com sucesso!"
        ));
      }
      return BadRequest(new ResultMessage
      (
        "Desculpe!", 
        "Não foi possível encontrar uma revista com este Id"
      ));
    }

  }
}