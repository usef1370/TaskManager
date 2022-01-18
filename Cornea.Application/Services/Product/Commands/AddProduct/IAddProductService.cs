using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Product.Commands.AddProduct
{
    public interface IAddProductService
    {
        ResultDto Execute(RequestAddProductService request);
    }
    public class RequestAddProductService
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Number { get; set; }
        public string Imagedir { get; set; }
    }
    public class AddProductService : IAddProductService
    {
        private readonly IDataBaseContext _context;
        public AddProductService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestAddProductService request)
        {
            if (request.Name == null)
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
                    Message = "Please enter a price"
                };
            }
            if (request.Number == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please enter Number"
                };
            }
            if (request.Imagedir == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Please select a product photo"
                };
            }
            Products products = new Products()
            {
                Name = request.Name,
                Price = request.Price,
                Number = request.Number,
                Imagedir = request.Imagedir
            };

            _context.Products.Add(products);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
