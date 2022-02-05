using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Linq;

namespace Cornea.Application.Services.Project.Queries.FindProjects
{
    public class FindProjectsService : IFindProjectsService
    {
        private readonly IDataBaseContext _context;
        public FindProjectsService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultFindProjectsService> Execute(string searchKey)
        {
            if(string.IsNullOrWhiteSpace(searchKey))
            {
                return new ResultDto<ResultFindProjectsService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Failed"
                };
            }
           
            var projects = _context.Projects.SingleOrDefault(b => b.Id == Convert.ToInt16(searchKey));

            if (projects == null)
            {
                return new ResultDto<ResultFindProjectsService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Failed"
                };
            }
           
            var result = new ResultFindProjectsService
            {
                Id = projects.Id,
                ProjectName = projects.ProjectName,
                Status = projects.Status,
                Priority = projects.Priority,
                StartTime = projects.StartTime.ToString("MM/dd/yyyy"),
                FinishTime = projects.FinishTime.ToString("MM/dd/yyyy"),
                Message = projects.Message,
                Timeline = Convert.ToInt32((projects.FinishTime - projects.StartTime).TotalDays)
            };
            
            return new ResultDto<ResultFindProjectsService>
            {
                Data = result,
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
