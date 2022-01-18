using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Product.Queries.FindProduct
{
    public interface IFindProductService
    {
        ResultDto<ResultFindProductService> Execute(int searchKey);
    }
    public class FindProductService : IFindProductService
    {
        private readonly IDataBaseContext _context;
        public FindProductService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultFindProductService> Execute(int searchKey)
        {
            var products = _context.Products.SingleOrDefault(b => b.Id == searchKey);

            if (products == null)
            {
                return new ResultDto<ResultFindProductService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "dfdfd"
                };
            }
            var result = new ResultFindProductService
            {
                Id = products.Id,
                Name = products.Name,
                Price = products.Price,
                Number = products.Number,
                Imagedir = products.Imagedir
            };
            return new ResultDto<ResultFindProductService>
            {
                Data = result,
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
    public class ResultFindProductService
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Number { get; set; }
        public string Imagedir { get; set; }

    }
}
