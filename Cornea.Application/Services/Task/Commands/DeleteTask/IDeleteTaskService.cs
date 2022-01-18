using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Task.Commands.DeleteTask
{
    public interface IDeleteTaskService
    {
        ResultDto Execute(long Id);
    }
    public class DeleteTaskService : IDeleteTaskService
    {
        private readonly IDataBaseContext _context;
        public DeleteTaskService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long Id)
        {
            AllTasks task = new AllTasks() { Id = Id };
            _context.AllTasks.Attach(task);
            _context.AllTasks.Remove(task);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "Deleted Successfully"
            };
        }
    }
}
