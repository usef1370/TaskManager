using Cornea.Application.Interfaces.Contexts;
using System;
using System.Linq;

namespace Cornea.Application.Services.Project.Queries.GetProjects
{
    public class GetProjectsService : IGetProjectsService
    {
        private readonly IDataBaseContext _context;
        public GetProjectsService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetProjecsDto Execute()
        {
            var projects = _context.Projects.AsQueryable();
            var projectsList = projects.Select(p => new ResultGetProjects
            {
                Id = p.Id,
                ProjectName = p.ProjectName,
                Status = p.Status,
                Priority = p.Priority,
                StartTime = p.StartTime,
                FinishTime = p.FinishTime,
                Message = p.Message,
                PassedTime = (DateTime.Now - p.StartTime).Days,
                Timeline = p.Timeline,
                Percent = ((DateTime.Now - p.StartTime).Days / p.Timeline) * 100,
            }).ToList();
            return new ResultGetProjecsDto
            {
                projectslist = projectsList
            };
        }

    }
}
