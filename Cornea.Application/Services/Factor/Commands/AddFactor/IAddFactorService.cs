using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Factor.Commands.AddFactor
{
    public interface IAddFactorService
    {
        ResultDto Execute(RequestAddFactorService request);
    }
    public class RequestAddFactorService
    {
        public string FactorNumber { get; set; }
        public string ProductName { get; set; }
        public long Number { get; set; }
        public string Price { get; set; }
        public DateTime Issuancedate { get; set; }
        public string Imagedir { get; set; }
    }
    public class AddFactorService : IAddFactorService
    {
        private readonly IDataBaseContext _context;
        public AddFactorService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestAddFactorService request)
        {
            if (request.FactorNumber == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a factor number"
                };
            }
            if (request.ProductName == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a product name"
                };
            }
            if (request.Price == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter price"
                };
            }
            if (request.Issuancedate == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter issuance date"
                };
            }

            Factors factors = new Factors()
            {
                FactorNumber = request.FactorNumber,
                ProductName = request.ProductName,
                Number = request.Number,
                Price = request.Price,
                Issuancedate = request.Issuancedate,
                Imagedir = request.Imagedir
            };

            _context.Factors.Add(factors);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
