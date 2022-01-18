using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Task.Queries.FindTasks
{
    public interface IFindTasksService
    {
        ResultDto<ResultFindTasksService> Execute(RequestTasksService request);
    }
    public class FindTasksService : IFindTasksService
    {
        private readonly IDataBaseContext _context;
        public FindTasksService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultFindTasksService> Execute(RequestTasksService request)
        {

            var tasks = _context.AllTasks.SingleOrDefault(b => b.Id == request.TaskId);
            if (request.UserId != 0)
            {
                tasks = _context.AllTasks.SingleOrDefault(b => b.Id == request.UserId);
            }
            
            if (tasks == null)
            {
                return new ResultDto<ResultFindTasksService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "dfdfd"
                };
            }

            var result = new ResultFindTasksService
            {
                Id = tasks.Id,
                UserId = tasks.UserId,
                ProjectName = tasks.ProjectName,
                TaskName = tasks.TaskName,
                Owner = tasks.Owner,
                Status = tasks.Status,
                Priority = tasks.Priority,
                StartTime = tasks.StartTime,
                FinishTime = tasks.FinishTime,
                Message = tasks.Message,
                PassedTime = 0,
                Timeline = Convert.ToInt32((tasks.FinishTime - tasks.StartTime).TotalDays),
                Percent = 0,
                Filedir = tasks.Filedir
            };
            return new ResultDto<ResultFindTasksService>
            {
                Data = result,
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
    public class ResultFindTasksService
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
        public long? PassedTime { get; set; }
        public long? Timeline { get; set; }
        public long? Percent { get; set; }
        public string Filedir { get; set; }
    }
    public class RequestTasksService
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
    }

}
