using Microsoft.AspNetCore.Mvc;
using Cornea.Application.Services.Users.Queries.GetUsers;
using System.IO;
using System;
using Microsoft.Extensions.FileProviders;
using Cornea.Site.Areas.Admin.Models;
using Cornea.Application.Services.Users.Commands.RegisterUsers;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        private readonly IAddUsersService _addUsersService;

        public HomeController(IGetUsersService getUsersService, IAddUsersService addUsersService)
        {
            _getUsersService = getUsersService;
            _addUsersService = addUsersService;
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

        public IActionResult AddNewUser()
        {
            ViewBag.activeItem = "itemRegister";
            return View();
        }
        [HttpPost]
        public IActionResult AddNewUser(ProfileViewModel model)
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string Resumedirs = ".";//"resumedir" length cannot be less than zero.
            if (model.Resumedir != null)
            {
                if (model.Resumedir.Length > 0)
                {
                    foreach (var file in model.Resumedir)
                    {
                        //Getting FileName
                        var resumeName = Path.GetFileName(file.FileName);

                        //Assigning Unique Filename (Guid)
                        var myUniqueResumeName = Convert.ToString(Guid.NewGuid());

                        //Getting file Extension
                        var resumeExtension = Path.GetExtension(resumeName);

                        // concatenating  FileName + FileExtension
                        var newResumeName = String.Concat(myUniqueResumeName, resumeExtension);

                        // Combines two strings into a path.
                        var resumepath =
                        new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Project_Files")).Root + $@"\{newResumeName}";

                        using (FileStream fs = System.IO.File.Create(resumepath))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                        Resumedirs += "/Project_Files/" + newResumeName + "$";
                    }
                }
            }

            string newFileName = "placeholder.jpg";
            if (model.Imagedir != null)
            {
                if (model.Imagedir.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(model.Imagedir.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
                    new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        model.Imagedir.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
            var result = _addUsersService.Execute(new RequestAddUsersService
            {
                RoleId = 2,
                Email = model.Email,
                Fullname = model.Fullname,
                Phone = model.Phone,
                Birthday = Convert.ToDateTime(model.Birthday),
                HireDay = Convert.ToDateTime(model.HireDay),
                Imagedir = "/Images/" + newFileName,
                Position = model.Position,
                University = model.University,
                DegreeLevel = model.DegreeLevel,
                Company = model.Company,
                Specialization = model.Specialization,
                LastjobDescription = model.LastjobDescription,
                StartEducationTime = model.StartEducationTime,
                FinishEducationTime = model.FinishEducationTime,
                StartLastjobTime = model.StartLastjobTime,
                FinishLastjobTime = model.FinishLastjobTime,
                AdditionalInfo = model.AdditionalInfo,
                Resumedir = Resumedirs.Substring(0, Resumedirs.Length - 1),
                Password = model.Password,
                Username = model.Username,
            });
            return Json(result);
        }
    }
}
