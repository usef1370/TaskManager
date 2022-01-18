using Cornea.Application.Interfaces.Contexts;
using System.Linq;

namespace Cornea.Application.Services.Customer.Queries.GetCustomers
{
    public class GetCustomersService : IGetCustomersService
    {
        private readonly IDataBaseContext _context;
        public GetCustomersService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetCustomersDto Execute()
        {
            var customers = _context.Customers.AsQueryable();
            var customersList = customers.Select(p => new ResultGetCustomers
            {
                Id = p.Id,
                Name = p.Name,
                Phone = p.Phone,
                LabName = p.LabName,
                Number = p.Number,
                ProductName = p.ProductName,
                City = p.City,
                Address = p.Address,
                SaleDate = p.SaleDate
            }).ToList();
            return new ResultGetCustomersDto
            {
                customerslist = customersList
            };
        }
    }
}
