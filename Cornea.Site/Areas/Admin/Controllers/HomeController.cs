using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cornea.Application.Services.Users.Queries.GetUsers;
using Cornea.Application.Services.Users.Queries.GetRoles;
using Cornea.Application.Services.Users.Commands.RegisterUsers;
using System;
using System.Security.Claims;
using Cornea.Application.Services.Users.Commands.DeleteUser;
using Cornea.Application.Services.Users.Queries.FindUsers;
using Cornea.Application.Services.Users.Commands.EditUser;
using Cornea.Application.Services.Task.Queries.GetTasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Cornea.Application.Services.Task.Commands.EditTask;
using Cornea.Site.Areas.Admin.Models;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        private readonly IGetRolesService _getRolesService;
        private readonly IRegisterUserService _registerUserService;
        private readonly IDeleteUserService _deleteUserService;
        private readonly IFindUsersService _findUsersService;
        private readonly IEditUserService _editUserService;
        private readonly IGetTasksService _getTasksService;
        private readonly IEditTaskService _editTaskService;
        private readonly ISaveFileDirection _saveFileDirection;
        private readonly IChangePasswordService _changePasswordService;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger
            , IGetUsersService getUsersService
            , IGetRolesService getRolesService
            , IDeleteUserService deleteUserService
            , IFindUsersService findUsersService
            , IEditUserService editUserService
            , IRegisterUserService registerUserService
            , IGetTasksService getTasksService
            , IEditTaskService editTaskService
            , IChangePasswordService changePasswordService
            , ISaveFileDirection saveFileDirection)
        {
            _logger = logger;
            _getUsersService = getUsersService;
            _getRolesService = getRolesService;
            _registerUserService = registerUserService;
            _deleteUserService = deleteUserService;
            _findUsersService = findUsersService;
            _editUserService = editUserService;
            _getTasksService = getTasksService;
            _editTaskService = editTaskService;
            _changePasswordService = changePasswordService;
            _saveFileDirection = saveFileDirection;
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

        //Profile
        public IActionResult Profile(string searchKey)
        {
            ViewBag.activeItem = "itemProfile";
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(_getTasksService.Execute(Convert.ToInt32(searchKey)));
        }

        [HttpPost]
        public IActionResult Profile(IFormFile[] files, long id)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    string Filedirs = "";
                    foreach (var file in files)
                    {
                        //Getting FileName
                        var fileName = Path.GetFileName(file.FileName);

                        //Assigning Unique Filename (Guid)
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                        //Getting file Extension
                        var fileExtension = Path.GetExtension(fileName);

                        // concatenating  FileName + FileExtension
                        var newFileName = String.Concat(myUniqueFileName, fileExtension);

                        // Combines two strings into a path.
                        var filepath =
                        new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Project_Files")).Root + $@"\{newFileName}";

                        using (FileStream fs = System.IO.File.Create(filepath))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                        Filedirs += "/Project_Files/" + newFileName + "$";
                    }
                    _saveFileDirection.Execute(new RequestFileDirectionService
                    {
                        Id = Convert.ToInt32(id),
                        Filedir = Filedirs.Substring(0, Filedirs.Length-1)
                    });
                }   
            }
            else
            {
                _saveFileDirection.Execute(new RequestFileDirectionService
                {
                    Id = Convert.ToInt32(id),
                    Filedir = null
                });
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(_getTasksService.Execute(Convert.ToInt32(userId)));
        }

        public IActionResult AccountSetting(string searchKey)
        {
            ViewBag.activeItem = "itemaccountSetting";
            return View(_findUsersService.Execute(Convert.ToInt32(searchKey)));
        }

        [HttpPost]
        public IActionResult AccountSetting(  string Email, string Fullname, string Phone, string Birthday, string HireDay, IFormFile files, string Position
            , string University, string DegreeLevel, string Company, string Specialization, string Country, string LastjobDescription, string StartEducationTime,
             string FinishEducationTime, string StartLastjobTime, string FinishLastjobTime, string AdditionalInfo, IFormFile[] resume)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            string Resumedirs = ".";//"resumedir" length cannot be less than zero.
            if (resume != null)
            {
                if (resume.Length > 0)
                {
                    foreach (var file in resume)
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

            string newFileName = "05332091-3c54-414e-ad72-a709649ac948.png";
            if (files != null)
            {
                if (files.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(files.FileName);

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
                        files.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
            _editUserService.Execute(new RequestEditUserService
            {
                UserId = Convert.ToInt64(userId),
                Email = Email,
                Fullname = Fullname,
                Phone = Phone,
                Birthday = Convert.ToDateTime(Birthday),
                HireDay = Convert.ToDateTime(HireDay),
                Imagedir = "/Images/" + newFileName,
                Position = Position,
                University = University,
                DegreeLevel = DegreeLevel,
                Company = Company,
                Specialization = Specialization,
                Country = Country,
                LastjobDescription = LastjobDescription,
                StartEducationTime = StartEducationTime,
                FinishEducationTime = FinishEducationTime,
                StartLastjobTime = StartLastjobTime,
                FinishLastjobTime = FinishLastjobTime,
                AdditionalInfo = AdditionalInfo,
                Resumedir = Resumedirs.Substring(0, Resumedirs.Length - 1)
            });
            return View(_findUsersService.Execute(Convert.ToInt32(userId)));
        }

        public IActionResult PersonalInfo(string searchKey)
        {
            ViewBag.activeItem = "itemPersonalInfo";
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(_findUsersService.Execute(Convert.ToInt32(searchKey)));
        }

 
        [HttpPost]
        public IActionResult PersonalInfo(ProfileViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
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

            string newFileName = "05332091-3c54-414e-ad72-a709649ac948.png";
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
            _editUserService.Execute(new RequestEditUserService
            {
                UserId = Convert.ToInt64(userId),
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
                Resumedir = Resumedirs.Substring(0, Resumedirs.Length - 1)
            });
            return View(_findUsersService.Execute(Convert.ToInt32(userId)));
        }

        public IActionResult Source()
        {
            ViewBag.activeItem = "itemSourcePage";
            return View(_getUsersService.Execute(new RequestGetUsersDto
            {
                SearchKey = ""
            }));
        }
        [HttpPost]
        public IActionResult ChangePassword(string NewPassword, string ConfirmPassword)
        {
            var result = _changePasswordService.Execute(new RequestChangePasswordService
            {
                UserId = Convert.ToInt64(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                NewPassword = NewPassword,
                ConfirmPassword = ConfirmPassword,
            });
            return Json(result);
        }
    }
}
