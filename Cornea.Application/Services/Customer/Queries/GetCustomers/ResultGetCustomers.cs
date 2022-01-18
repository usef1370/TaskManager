using System;

namespace Cornea.Application.Services.Customer.Queries.GetCustomers
{
    public class ResultGetCustomers
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
