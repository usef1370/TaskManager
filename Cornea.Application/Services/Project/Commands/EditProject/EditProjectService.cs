using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Linq;

namespace Cornea.Application.Services.Project.Commands.EditProject
{
    public class EditProjectService : IEditProjectService
    {
        private readonly IDataBaseContext _context;
        public EditProjectService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditProjectService request)
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

            var projects = _context.Projects.SingleOrDefault(b => b.Id == request.Id);
            if (projects == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter finish time"
                };
            }
            
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

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
