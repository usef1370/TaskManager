using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Customer.Commands.DeleteCustomer
{
    public interface IDeleteCustomerService
    {
        ResultDto Execute(long Id);
    }
    public class DeleteCustomerService : IDeleteCustomerService
    {
        private readonly IDataBaseContext _context;
        public DeleteCustomerService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long Id)
        {
            Customers customer = new Customers() { Id = Id };
            _context.Customers.Attach(customer);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "Deleted Successfully"
            };
        }
    }
}
