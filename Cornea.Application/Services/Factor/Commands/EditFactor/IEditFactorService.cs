using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Factor.Commands.EditFactor
{
    public interface IEditFactorService
    {
        ResultDto Execute(RequestEditFactorService request);
    }
    public class RequestEditFactorService
    {
        public long Id { get; set; }
        public string FactorNumber { get; set; }
        public string ProductName { get; set; }
        public long Number { get; set; }
        public string Price { get; set; }
        public DateTime Issuancedate { get; set; }
        public string Imagedir { get; set; }
    }
    public class EditFactorService : IEditFactorService
    {
        private readonly IDataBaseContext _context;
        public EditFactorService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditFactorService request)
        {
            if (request.FactorNumber == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a factor number name"
                };
            }
            if (request.ProductName == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter a project name"
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
           

            var factors = _context.Factors.SingleOrDefault(b => b.Id == request.Id);

            if (factors != null)
            {
                factors.FactorNumber = request.FactorNumber;
                factors.ProductName = request.ProductName;                
                factors.Price = request.Price;
                factors.Number = request.Number;
                factors.Issuancedate = request.Issuancedate;
                if(request.Imagedir != null)
                    factors.Imagedir = request.Imagedir;

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
