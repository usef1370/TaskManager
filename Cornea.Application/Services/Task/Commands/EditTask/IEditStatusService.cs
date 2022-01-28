using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Task.Commands.EditTask
{
    public interface IEditStatusService
    {
        ResultDto Execute(RequestEditStatusService request);
    }
    public class RequestEditStatusService
    {
        public long Id { get; set; }
        public string Status { get; set; }

    }
    public class EditStatusService : IEditStatusService
    {
        private readonly IDataBaseContext _context;
        public EditStatusService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditStatusService request)
        {

            var tasks = _context.AllTasks.SingleOrDefault(b => b.Id == request.Id);

            if (tasks != null)
            {
                tasks.Status = request.Status;
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
