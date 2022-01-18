using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Factor.Queries.FindFactor
{
    public interface IFindFactorService
    {
        ResultDto<ResultFindFactorService> Execute(int searchKey);
    }
    public class FindFactorService : IFindFactorService
    {
        private readonly IDataBaseContext _context;
        public FindFactorService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultFindFactorService> Execute(int searchKey)
        {
            var factors = _context.Factors.SingleOrDefault(b => b.Id == searchKey);

            if (factors == null)
            {
                return new ResultDto<ResultFindFactorService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "dfdfd"
                };
            }
            var result = new ResultFindFactorService
            {
                Id = factors.Id,
                FactorNumber = factors.FactorNumber,
                ProductName = factors.ProductName,
                Price = factors.Price,
                Number = factors.Number,
                Issuancedate = factors.Issuancedate,
                Imagedir = factors.Imagedir
            };
            return new ResultDto<ResultFindFactorService>
            {
                Data = result,
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
    public class ResultFindFactorService
    {
        public long Id { get; set; }
        public string FactorNumber { get; set; }
        public string ProductName { get; set; }
        public long Number { get; set; }
        public string Price { get; set; }
        public DateTime Issuancedate { get; set; }
        public string Imagedir { get; set; }

    }
}
