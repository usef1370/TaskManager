using Cornea.Application.Services.Users.Commands.RegisterUsers;
using Cornea.Application.Services.Users.Queries.GetUsers;
using Cornea.Site.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System;
using System.IO;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SourceController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        private readonly IAddUsersService _addUsersService;

        public SourceController(IGetUsersService getUsersService, IAddUsersService addUsersService)
        {
            _getUsersService = getUsersService;
            _addUsersService = addUsersService;
        }
      
        public IActionResult Source()
        {
            ViewBag.activeItem = "itemSourcePage";
            return View(_getUsersService.Execute(new RequestGetUsersDto
            {
                SearchKey = ""
            }));
        }

        public IActionResult AddUser()
        {
            ViewBag.activeItem = "itemAddUser";
            return View();
        }
        
        [HttpPost]
        public IActionResult AddUser(ProfileViewModel model)
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string Resumedirs = ".";//"resumedir" length cannot be less than zero.
            if (model.Resumedir != null)
            {
                Resumedirs = SaveFile(model.Resumedir, Resumedirs, "Project_Files");
            }

            string ImagePath = "/Images/placeholder.jpg";
            if (model.Imagedir != null)
            {
                ImagePath = "";
                IFormFile[] files = new IFormFile[1];
                files[0] = model.Imagedir;
                ImagePath = SaveFile(files, ImagePath, "Images");
            }
            var result = _addUsersService.Execute(new RequestAddUsersService
            {
                RoleId = 2,
                Email = model.Email,
                Fullname = model.Fullname,
                Phone = model.Phone,
                Birthday = Convert.ToDateTime(model.Birthday),
                HireDay = Convert.ToDateTime(model.HireDay),
                Imagedir = ImagePath,
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
                Repeatpassword = model.Repeatpassword,
                Username = model.Username,
            });
            if (!result.IsSuccess)
            {
                return View();
            }
            return Redirect("Source");
        }

        private static string SaveFile(IFormFile[] files, string FilePath, string DirectoryPath)
        {
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(file.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueResumeName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    var newFileName = string.Concat(myUniqueResumeName, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
                    new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", DirectoryPath)).Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }
                    // We add "$" to separate files when we upload multiple files
                    FilePath += "/" + DirectoryPath + "/" + newFileName + "$";
                }
            }

            return FilePath.Substring(0, FilePath.Length - 1);
        }
    }
}
