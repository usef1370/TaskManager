//using Cornea.Application.Services.Users.Commands.RegisterUsers;
//using Cornea.Application.Services.Users.Queries.GetRoles;
//using Cornea.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {       

        public IActionResult Index()
        {
            return View() ;
        }
    }
}