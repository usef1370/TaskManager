using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Task.Commands.EditTask
{
    public interface ISaveFileDirection
    {
        ResultDto Execute(RequestFileDirectionService request);
    }
    public class RequestFileDirectionService
    {
        public long Id { get; set; }
        public string Filedir { get; set; }
    }
    public class SaveFileDirection : ISaveFileDirection
    {
        private readonly IDataBaseContext _context;
        public SaveFileDirection(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestFileDirectionService request)
        {

            var tasks = _context.AllTasks.SingleOrDefault(b => b.Id == request.Id);

            if (tasks != null)
            {              
                tasks.Filedir = request.Filedir;
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
