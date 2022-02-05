using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;

namespace Cornea.Application.Services.Project.Commands.DeleteProject
{
    public class DeleteProjectService : IDeleteProjectService
    {
        private readonly IDataBaseContext _context;
        public DeleteProjectService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(string searchKey)
        {
            if(string.IsNullOrWhiteSpace(searchKey))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "The operation failed"
                };
            }

            Projects project = new Projects() { Id = Convert.ToInt16(searchKey)};
            _context.Projects.Attach(project);
            _context.Projects.Remove(project);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "Deleted Successfully"
            };
        }
    }
}
