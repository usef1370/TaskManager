using System;
using System.IO;
using Cornea.Application.Services.Project.Queries.GetProjects;
using Cornea.Application.Services.Task.Commands.AddTask;
using Cornea.Application.Services.Task.Commands.DeleteTask;
using Cornea.Application.Services.Task.Commands.EditTask;
using Cornea.Application.Services.Task.Queries.FindTasks;
using Cornea.Application.Services.Task.Queries.GetTasks;
using Cornea.Application.Services.Users.Queries.GetUsers;
using Cornea.Common.Dto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class TaskController : Controller
    {
        private IWebHostEnvironment Environment;
        private readonly IGetTasksService _getTasksService;
        private readonly IAddTaskService _addTaskService;
        private readonly IEditTaskService _editTaskService;
        private readonly IDeleteTaskService _deleteTaskService;
        private readonly IFindTasksService _findTaskService;
        private readonly IGetProjectsService _getProjectsService;
        private readonly IGetUsersService _getUsersService;
        static int id = 0;


        public TaskController(IGetTasksService getTasksService
            , IAddTaskService addTaskService
            , IEditTaskService editTaskService
            , IDeleteTaskService deleteTaskService
            , IFindTasksService findTaskService
            , IGetProjectsService getProjectsService
            , IGetUsersService getUsersService
            , IWebHostEnvironment _environment)
        {
            _getTasksService = getTasksService;
            _addTaskService = addTaskService;
            _editTaskService = editTaskService;
            _deleteTaskService = deleteTaskService;
            _findTaskService = findTaskService;
            _getProjectsService = getProjectsService;
            _getUsersService = getUsersService;
            Environment = _environment;
        }
        public IActionResult Tasks()
        {
            ViewBag.activeItem = "itemTasks";
            var item1 = _getTasksService.Execute();
            var item2 = _getProjectsService.Execute();
            var item3 = _getUsersService.Execute(new RequestGetUsersDto { SearchKey = "" });
            Tuple<ResultGetTasksDto, ResultGetProjecsDto, ResultGetUsersDto> _tuple = new Tuple<ResultGetTasksDto, ResultGetProjecsDto, ResultGetUsersDto>(item1, item2, item3);
            return View(_tuple);
        }

        public IActionResult CreateTask()
        {
            ViewBag.activeItem = "itemAddTask";
            var item1 = _getProjectsService.Execute();
            var item2 = _getUsersService.Execute(new RequestGetUsersDto { SearchKey = "" });
            Tuple<ResultGetProjecsDto, ResultGetUsersDto> _tuple = new Tuple<ResultGetProjecsDto, ResultGetUsersDto>(item1, item2);
            return View(_tuple);
        }

        [HttpPost]
        public IActionResult CreateTask(string ProjectName, string TaskName, int UserId, string Status, string Priority, string DateRange, string Message)
        {

            var result = _addTaskService.Execute(new RequestAddTaskService
            {
                UserId = UserId,
                ProjectName = ProjectName,
                TaskName = TaskName,
                Owner = "",
                Status = Status,
                Priority = Priority,
                StartTime = Convert.ToDateTime(DateRange.Split('-')[0]),
                FinishTime = Convert.ToDateTime(DateRange.Split('-')[1]),
                Message = Message
            });
            return Json(result);
        }

        [HttpPost]
        public IActionResult findTask(string searchKey)
        {
            var result = _findTaskService.Execute(new RequestTasksService { UserId = 0, TaskId = Convert.ToInt32(searchKey) });
            id = Convert.ToInt32(searchKey);
            ViewBag.filedir = result.Data.Filedir;
            return Json(result);
        }

        public IActionResult EditTask(string searchKey)
        {
            var item1 = _findTaskService.Execute(new RequestTasksService { UserId = 0, TaskId = Convert.ToInt32(searchKey) });
            var item2 = _getProjectsService.Execute();
            var item3 = _getUsersService.Execute(new RequestGetUsersDto { SearchKey = "" });
            Tuple<ResultDto<ResultFindTasksService>, ResultGetProjecsDto, ResultGetUsersDto> _tuple = new Tuple<ResultDto<ResultFindTasksService>, ResultGetProjecsDto, ResultGetUsersDto>(item1, item2, item3);
            return View(_tuple);
        }

        [HttpPost]
        public IActionResult EditTask(long TaskId, string ProjectName, string TaskName, string Status, string Priority, string DateRange, string Message)
        {
            var result = _editTaskService.Execute(new RequestEditTaskService
            {
                Id = TaskId,
                ProjectName = ProjectName,
                TaskName = TaskName,
                Status = Status,
                Priority = Priority,
                StartTime = Convert.ToDateTime(DateRange.Split('-')[0]),
                FinishTime = Convert.ToDateTime(DateRange.Split('-')[1]),
                Message = Message
            });
            return Json(result);
        }

        [HttpPost]
        public IActionResult deleteTask(string searchKey)
        {
            var result = _deleteTaskService.Execute(Convert.ToInt32(searchKey));
            id = Convert.ToInt32(searchKey);
            return Json(result);
        }

        public IActionResult DetailTask(int searchKey)
        {
            var result = _findTaskService.Execute(new RequestTasksService { UserId = 0, TaskId = Convert.ToInt32(searchKey) });
            if(result.Data.Filedir != null)
            {
                ViewBag.filedir = result.Data.Filedir.Split('/')[2];
            }
            
            return View(result);
        }

        public FileResult DownloadFile(string fileName)
        {
            //Build the File Path.
            string path = Path.Combine(this.Environment.WebRootPath, "") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }
    }
}