using Cornea.Application.Interfaces.Contexts;
using Cornea.Application.Services.Project.Commands.AddProject;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Project.Commands.EditProject
{
    public interface IEditProjectService
    {
        ResultDto Execute(RequestEditProjectService request);
    }
    public class RequestEditProjectService
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Message { get; set; }
    }
    public class EditProjectService : IEditProjectService
    {
        private readonly IDataBaseContext _context;
        public EditProjectService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditProjectService request)
        {
            if (request.ProjectName == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a project name"
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

            var projects = _context.Projects.SingleOrDefault(b => b.Id == request.Id);

            if (projects != null)
            {
                projects.ProjectName = request.ProjectName;
                projects.Status = request.Status;
                projects.Priority = request.Priority;
                projects.StartTime = request.StartTime;
                projects.FinishTime = request.FinishTime;
                projects.Message = request.Message;
                projects.PassedTime = 0;
                projects.Timeline = Convert.ToInt32((request.FinishTime - request.StartTime).TotalDays);
                projects.Percent = 0;

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
