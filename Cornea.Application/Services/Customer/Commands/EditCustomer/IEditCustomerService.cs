using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Customer.Commands.EditCustomer
{
    public interface IEditCustomerService
    {
        ResultDto Execute(RequestEditCustomerService request);
    }
    public class RequestEditCustomerService
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string LabName { get; set; }
        public long? Number { get; set; }
        public string ProductName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime SaleDate { get; set; }
    }
    public class EditCustomerService : IEditCustomerService
    {
        private readonly IDataBaseContext _context;
        public EditCustomerService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestEditCustomerService request)
        {
            if (request.Name == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a customer name"
                };
            }
            if (request.LabName == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter lab name"
                };
            }
            if (request.Phone == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter phone"
                };
            }
            if (request.Number == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter number"
                };
            }
            if (request.ProductName == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter product name"
                };
            }
            if (request.City == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter city"
                };
            }
            if (request.Address == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter address"
                };
            }

            var customers = _context.Customers.SingleOrDefault(b => b.Id == request.Id);

            if (customers != null)
            {
                customers.Name = request.Name;
                customers.LabName = request.LabName;
                customers.Phone = request.Phone;
                customers.Number = request.Number;
                customers.ProductName = request.ProductName;
                customers.City = request.City;
                customers.Address = request.Address;
                customers.SaleDate = request.SaleDate;

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
