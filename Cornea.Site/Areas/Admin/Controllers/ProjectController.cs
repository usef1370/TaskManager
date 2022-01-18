using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cornea.Application.Services.Project.Commands.AddProject;
using Cornea.Application.Services.Project.Commands.DeleteProject;
using Cornea.Application.Services.Project.Commands.EditProject;
using Cornea.Application.Services.Project.Queries.FindProjects;
using Cornea.Application.Services.Project.Queries.GetProjects;
using Microsoft.AspNetCore.Mvc;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private readonly IGetProjectsService _getProjectsService;
        private readonly IAddProjectService _addProjectService;
        private readonly IEditProjectService _editProjectService;
        private readonly IFindProjectsService _findProjectsService;
        private readonly IDeleteProjectService _deleteProjectService;
        static int id = 0;

        public ProjectController( IGetProjectsService getProjectsService
            , IAddProjectService addProjectService
            , IEditProjectService editProjectService
            , IFindProjectsService findProjectsService
            , IDeleteProjectService deleteProjectService)
        {
            _getProjectsService = getProjectsService;
            _addProjectService = addProjectService;
            _editProjectService = editProjectService;
            _findProjectsService = findProjectsService;
            _deleteProjectService = deleteProjectService;

        }
        public IActionResult Projects()
        {
            ViewBag.activeItem = "itemProjects";
            return View(_getProjectsService.Execute());
        }

        public IActionResult CreateProject()
        {
            ViewBag.activeItem = "itemAddProject";
            return View();
        }
        [HttpPost]
        public IActionResult CreateProject(string ProjectName, string Status, string Priority, string DateRange, string Message)
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = _addProjectService.Execute(new RequestAddProjectService
            {
                ProjectName = ProjectName,
                Status = Status,
                Priority = Priority,
                StartTime = Convert.ToDateTime(DateRange.Split('-')[0]),
                FinishTime = Convert.ToDateTime(DateRange.Split('-')[1]),
                Message = Message
            });
            return Json(result);
        }

        [HttpPost]
        public IActionResult findProject(string searchKey)
        {
            var result = _findProjectsService.Execute(Convert.ToInt32(searchKey));
            id = Convert.ToInt32(searchKey);
            return Json(result);
        }

        public IActionResult EditProject(string searchKey)
        {
            var result = _findProjectsService.Execute(Convert.ToInt32(searchKey));
            ViewBag.status = result.Data.Status;
            return View(result);
        }

        [HttpPost]
        public IActionResult EditProject(long ProjectId, string ProjectName, string Status, string Priority, string DateRange, string Message)
        {
            var result = _editProjectService.Execute(new RequestEditProjectService
            {
                Id = ProjectId,
                ProjectName = ProjectName,
                Status = Status,
                Priority = Priority,
                StartTime = Convert.ToDateTime(DateRange.Split('-')[0]),
                FinishTime = Convert.ToDateTime(DateRange.Split('-')[1]),
                Message = Message
            });
            return Json(result);
        }

        [HttpPost]
        public IActionResult deleteProject(string searchKey)
        {
            var result = _deleteProjectService.Execute(Convert.ToInt32(searchKey));
            id = Convert.ToInt32(searchKey);
            return Json(result);
        }
    }

}