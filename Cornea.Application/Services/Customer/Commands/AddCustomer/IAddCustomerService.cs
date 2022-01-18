using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Customer.Commands.AddCustomer
{
    public interface IAddCustomerService
    {
        ResultDto Execute(RequestAddCustomerService request);
    }
    public class RequestAddCustomerService
    {
        public string Name { get; set; }
        public string LabName { get; set; }
        public string Phone { get; set; }
        public long? Number { get; set; }
        public string ProductName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime SaleDate { get; set; }

    }
    public class AddCustomerService : IAddCustomerService
    {
        private readonly IDataBaseContext _context;
        public AddCustomerService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestAddCustomerService request)
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
                    Message = "Please enter labname"
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
            Customers customers = new Customers()
            {
                Name = request.Name,
                LabName = request.LabName,
                Phone = request.Phone,
                Number = request.Number,
                ProductName = request.ProductName,
                City = request.City,
                Address = request.Address,
                SaleDate = request.SaleDate
            };

            _context.Customers.Add(customers);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
