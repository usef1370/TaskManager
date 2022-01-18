using Cornea.Application.Interfaces.Contexts;
using Cornea.Common;
using System;
using System.Linq;

namespace Cornea.Application.Services.Task.Queries.GetTasks
{
    public class GetTasksService : IGetTasksService
    {
        private readonly IDataBaseContext _context;
        public GetTasksService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetTasksDto Execute(int searchKey)
        {
            var tasks = _context.AllTasks.AsQueryable();
            if (searchKey >=0)
            {
                tasks = tasks.Where(p => p.UserId == searchKey);
            }
            var tasksList = tasks.Select(p => new ResultGetTasks
            {
                Id = p.Id,
                UserId = p.UserId,
                ProjectName = p.ProjectName,
                TaskName = p.TaskName,
                Owner = p.Owner,
                Status = p.Status,
                Priority = p.Priority,
                StartTime = p.StartTime,
                FinishTime = p.FinishTime.Date,
                Message = p.Message,
                PassedTime = (DateTime.Now - p.StartTime).Days,
                Timeline = p.Timeline,
                Percent = p.Percent,
            }).OrderBy(o=>o.ProjectName).ToList();
            return new ResultGetTasksDto
            {
                taskslist = tasksList
            };
        }
    }
}
