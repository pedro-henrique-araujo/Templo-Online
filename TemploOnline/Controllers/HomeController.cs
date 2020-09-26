using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TemploOnline.Data;
using TemploOnline.Models;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Controllers
{
    
    public class HomeController : TemploOnlineController
    {

        public HomeController(
            TemploOnlineContext context, 
            UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager)
            : base(context, userManager, roleManager)
        {
        }
        
        [Authorize(Roles = "Aluno, Professor, Admin, Dev")]
        public IActionResult Index() => Func(() => View());
    }
}
