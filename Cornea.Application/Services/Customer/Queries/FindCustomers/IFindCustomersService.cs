using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Customer.Queries.FindCustomers
{
    public interface IFindCustomersService
    {
        ResultDto<ResultFindCustomersService> Execute(int searchKey);
    }
    public class FindCustomersService : IFindCustomersService
    {
        private readonly IDataBaseContext _context;
        public FindCustomersService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultFindCustomersService> Execute(int searchKey)
        {
            var customers = _context.Customers.SingleOrDefault(b => b.Id == searchKey);

            if (customers == null)
            {
                return new ResultDto<ResultFindCustomersService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = ""
                };
            }
            var result = new ResultFindCustomersService
            {
                Id = customers.Id,
                Name = customers.Name,
                Phone = customers.Phone,
                LabName = customers.LabName,
                Number = customers.Number,
                ProductName = customers.ProductName,
                City = customers.City,
                Address = customers.Address,
                SaleDate = customers.SaleDate

            };
            return new ResultDto<ResultFindCustomersService>
            {
                Data = result,
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
    public class ResultFindCustomersService
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
}
