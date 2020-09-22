using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models.ApiModels;

namespace TemploOnline.Controllers.Api
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize(Roles = "Dev")]
  public class CategoriesController : ControllerBase
  {
    public TemploOnlineContext _context;

    public CategoriesController(TemploOnlineContext context)
    {
      _context = context;
    }


    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var message = new ResultMessage();
      var category = _context.Categories.Find(id);
      if (category != null)
      {
        _context.Categories.Remove(category);
        _context.SaveChanges();
        message.Title = "Sucesso!";
        message.Message = "Categoria removida com sucesso!";
        return Ok(message);
      }
      message.Title = "Desculpe!";
      message.Message = "Não foi possível encontrar uma categoria com este Id";
      return BadRequest(message);
    }
  }
}