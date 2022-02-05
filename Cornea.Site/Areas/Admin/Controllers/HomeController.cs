using Microsoft.AspNetCore.Mvc;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Main()
        {
            //var identity = (ClaimsIdentity)User.Identity;
            //IEnumerable<Claim> claims = identity.Claims;
            //var value = claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
            //       .Select(c => c.Value).SingleOrDefault();

            ViewBag.activeItem = "itemDashboard";
            return View();
        }
    }
}
