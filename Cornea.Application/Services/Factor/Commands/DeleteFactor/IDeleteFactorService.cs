using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Factor.Commands.DeleteFactor
{
    public interface IDeleteFactorService
    {
        ResultDto Execute(long Id);
    }
    public class DeleteFactorService : IDeleteFactorService
    {
        private readonly IDataBaseContext _context;
        public DeleteFactorService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long Id)
        {
            Factors factor = new Factors() { Id = Id };
            _context.Factors.Attach(factor);
            _context.Factors.Remove(factor);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "Deleted Successfully"
            };
        }
    }
}
