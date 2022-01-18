using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using Cornea.Domain.Entities;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Project.Commands.AddProject
{
    public interface IAddProjectService
    {
        ResultDto Execute(RequestAddProjectService request);
    }
    public class RequestAddProjectService
    {
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Message { get; set; }
    }
    public class AddProjectService : IAddProjectService
    {
        private readonly IDataBaseContext _context;
        public AddProjectService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestAddProjectService request)
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
            Projects projects = new Projects()
            {
                ProjectName = request.ProjectName,
                Status = request.Status,
                Priority = request.Priority,
                StartTime = request.StartTime,
                FinishTime = request.FinishTime,
                Message = request.Message,
                PassedTime = 0,
                Timeline = Convert.ToInt32((request.FinishTime - request.StartTime).TotalDays),
                Percent = 0
            };

            _context.Projects.Add(projects);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }

}


