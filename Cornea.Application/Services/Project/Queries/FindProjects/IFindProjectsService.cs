using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;

namespace Cornea.Application.Services.Project.Queries.FindProjects
{
    public interface IFindProjectsService
    {
        ResultDto<ResultFindProjectsService> Execute(int searchKey);
    }
    public class FindProjectsService : IFindProjectsService
    {
        private readonly IDataBaseContext _context;
        public FindProjectsService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultFindProjectsService> Execute(int searchKey)
        {
            var projects = _context.Projects.SingleOrDefault(b => b.Id == searchKey);

            if (projects == null)
            {
                return new ResultDto<ResultFindProjectsService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "dfdfd"
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
                PassedTime = 0,
                Timeline = Convert.ToInt32((projects.FinishTime - projects.StartTime).TotalDays),
                Percent = 0
            };
            return new ResultDto<ResultFindProjectsService>
            {
                Data = result,
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
    public class ResultFindProjectsService
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public string Message { get; set; }
        public long? PassedTime { get; set; }
        public long? Timeline { get; set; }
        public long? Percent { get; set; }
       
    }
}
