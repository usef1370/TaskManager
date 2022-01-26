using Microsoft.AspNetCore.Mvc;
using Cornea.Application.Services.Users.Queries.GetUsers;


namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IGetUsersService _getUsersService;

        public HomeController(IGetUsersService getUsersService)
        {
            _getUsersService = getUsersService;
        }

        public IActionResult Main()
        {
            //var identity = (ClaimsIdentity)User.Identity;
            //IEnumerable<Claim> claims = identity.Claims;
            //var value = claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
            //       .Select(c => c.Value).SingleOrDefault();

            ViewBag.activeItem = "itemDashboard";
            return View();
        }

        public IActionResult Source()
        {
            ViewBag.activeItem = "itemSourcePage";
            return View(_getUsersService.Execute(new RequestGetUsersDto
            {
                SearchKey = ""
            }));
        }
    }
}
