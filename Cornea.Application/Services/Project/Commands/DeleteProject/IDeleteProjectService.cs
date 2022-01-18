using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Project.Commands.DeleteProject
{
    public interface IDeleteProjectService
    {
        ResultDto Execute(long Id);
    }
    public class DeleteProjectService : IDeleteProjectService
    {
        private readonly IDataBaseContext _context;
        public DeleteProjectService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long Id)
        {
            Projects project = new Projects() { Id = Id };
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
