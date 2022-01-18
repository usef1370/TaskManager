using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cornea.Application.Services.Task.Commands.AddTask
{
    public interface IAddTaskService
    {
        ResultDto Execute(RequestAddTaskService request);
    }
    public class RequestAddTaskService
    {
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
    public class AddTaskService : IAddTaskService
    {
        private readonly IDataBaseContext _context;
        public AddTaskService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestAddTaskService request)
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
            if (request.Owner == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please select owner name"
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
            AllTasks tasks = new AllTasks()
            {
                UserId = request.UserId,
                ProjectName = request.ProjectName,
                TaskName = request.TaskName,
                Owner = request.Owner,
                Status = request.Status,
                Priority = request.Priority,
                StartTime = request.StartTime,
                FinishTime = request.FinishTime,
                Message = request.Message,
                PassedTime = 0,
                Timeline = Convert.ToInt32((request.FinishTime - request.StartTime).TotalDays),
                Percent = 0,
                Filedir = ""
        };

            _context.AllTasks.Add(tasks);
            _context.SaveChanges();
            //string path = @"D:\" + tasks.TaskName;
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }

}
