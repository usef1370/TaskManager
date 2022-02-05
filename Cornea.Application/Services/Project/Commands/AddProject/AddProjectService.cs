using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using Cornea.Domain.Entities;

namespace Cornea.Application.Services.Project.Commands.AddProject
{
    public class AddProjectService : IAddProjectService
    {
        private readonly IDataBaseContext _context;
        
        public AddProjectService(IDataBaseContext context)
        {
            _context = context;
        }
       
        public ResultDto Execute(RequestAddProjectService request)
        {
            if (string.IsNullOrWhiteSpace(request.ProjectName))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a project name"
                };
            }
            
            if (string.IsNullOrWhiteSpace(request.Status))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter status"
                };
            }
           
            if (string.IsNullOrWhiteSpace(request.Priority))
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


