using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Controllers
{
    [Authorize(Roles = "Aluno, Professor, Admin, Dev")]
    public class HomeController : TemploOnlineController
    {

        public HomeController(
            TemploOnlineContext context, 
            UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager)
            : base(context, userManager, roleManager)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
