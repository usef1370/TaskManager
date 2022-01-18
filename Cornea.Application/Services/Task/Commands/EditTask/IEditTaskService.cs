using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Task.Commands.EditTask
{
    public interface IEditTaskService
    {
        ResultDto Execute(RequestEditTaskService request);
    }
    public class RequestEditTaskService
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string ProjectName { get; set; }
        public string TaskName { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Message { get; set; }
        public string Filedir { get; set; }
    }
    public class EditTaskService : IEditTaskService
    {
        private readonly IDataBaseContext _context;
        public EditTaskService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditTaskService request)
        {
            if (request.ProjectName == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please select a project name"
                };
            }
            if (request.TaskName == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a task name"
                };
            }

            if (request.Status == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter status"
                };
            }
            if (request.Priority == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter priority"
                };
            }
            if (request.StartTime == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter start time"
                };
            }
            if (request.FinishTime == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter finish time"
                };
            }

            var tasks = _context.AllTasks.SingleOrDefault(b => b.Id == request.Id);

            if (tasks != null)
            {
                //tasks.UserId = request.UserId;
                tasks.ProjectName = request.ProjectName;
                tasks.TaskName = request.TaskName;
                //tasks.Owner = request.Owner;
                tasks.Status = request.Status;
                tasks.Priority = request.Priority;
                tasks.StartTime = request.StartTime;
                tasks.FinishTime = request.FinishTime;
                tasks.Message = request.Message;
                tasks.PassedTime = 0;
                tasks.Timeline = Convert.ToInt32((request.FinishTime - request.StartTime).TotalDays);
                tasks.Percent = 0;
                tasks.Filedir = request.Filedir;
                _context.SaveChanges();
            }

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
        
    }

}
