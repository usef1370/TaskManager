using Cornea.Application.Services.Task.Commands.EditTask;
using Cornea.Application.Services.Task.Queries.GetTasks;
using Cornea.Application.Services.Users.Commands.DeleteUser;
using Cornea.Application.Services.Users.Commands.EditUser;
using Cornea.Application.Services.Users.Commands.RegisterUsers;
using Cornea.Application.Services.Users.Queries.FindUsers;
using Cornea.Application.Services.Users.Queries.GetRoles;
using Cornea.Application.Services.Users.Queries.GetUsers;
using Cornea.Site.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MyAccountController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        private readonly IGetRolesService _getRolesService;
        private readonly IRegisterUserService _registerUserService;
        private readonly IDeleteUserService _deleteUserService;
        private readonly IFindUsersService _findUsersService;
        private readonly IEditUserService _editUserService;
        private readonly IGetTasksService _getTasksService;
        private readonly IEditTaskService _editTaskService;
        private readonly IEditStatusService _editStatusService;
        private readonly ISaveFileDirection _saveFileDirection;
        private readonly IChangePasswordService _changePasswordService;
        public MyAccountController(IGetUsersService getUsersService
            , IGetRolesService getRolesService
            , IDeleteUserService deleteUserService
            , IFindUsersService findUsersService
            , IEditUserService editUserService
            , IRegisterUserService registerUserService
            , IGetTasksService getTasksService
            , IEditTaskService editTaskService
            , IEditStatusService editStatusService
            , IChangePasswordService changePasswordService
            , ISaveFileDirection saveFileDirection)
        {
            _getUsersService = getUsersService;
            _getRolesService = getRolesService;
            _registerUserService = registerUserService;
            _deleteUserService = deleteUserService;
            _findUsersService = findUsersService;
            _editUserService = editUserService;
            _getTasksService = getTasksService;
            _editTaskService = editTaskService;
            _editStatusService = editStatusService;
            _changePasswordService = changePasswordService;
            _saveFileDirection = saveFileDirection;
        }

        //Profile
        public IActionResult Profile(string searchKey)
        {
            ViewBag.activeItem = "itemProfile";
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(_getTasksService.Execute(searchKey));
        }

        /// <summary>
        /// Upload task file including code and document
        /// </summary>
        /// <param name="files">file including code and document</param>
        /// <param name="id">Task Id</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Profile(IFormFile[] files, long id)
        {
            if (files != null)
            {
                string Filedirs = "";
                Filedirs = SaveFile(files, Filedirs, "Project_Files");
                _saveFileDirection.Execute(new RequestFileDirectionService
                {
                    Id = id,
                    Filedir = Filedirs
                });
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(_getTasksService.Execute(userId));
        }

        public IActionResult PersonalInfo(string searchKey)
        {
            ViewBag.activeItem = "itemPersonalInfo";//itemChangePassword
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
                Resumedirs = SaveFile(model.Resumedir, Resumedirs, "Project_Files");
            }

            string ImagePath = "";
            if (model.Imagedir != null)
            {
                IFormFile[] files = new IFormFile[1];
                files[0] = model.Imagedir;
                ImagePath = SaveFile(files, ImagePath, "Images");

            }
            _editUserService.Execute(new RequestEditUserService
            {
                UserId = Convert.ToInt64(userId),
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
                Resumedir = Resumedirs.Substring(0, Resumedirs.Length - 1)
            });
            return View(_findUsersService.Execute(Convert.ToInt32(userId)));
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
                    FilePath += "/"+DirectoryPath+"/" + newFileName + "$";
                }
            }

            return FilePath.Substring(0, FilePath.Length - 1);
        }

        public IActionResult ChangePassword(string searchKey)
        {
            ViewBag.activeItem = "itemChangePassword";
            return View(_findUsersService.Execute(Convert.ToInt32(searchKey)));
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

        [HttpPost]
        public IActionResult EditStatus(string TaskId, string Status)
        {
            var result = _editStatusService.Execute(new RequestEditStatusService
            {
                Id = Convert.ToInt64(TaskId),
                Status = Status,
            });
            return Json(result);
        }
    }
}
