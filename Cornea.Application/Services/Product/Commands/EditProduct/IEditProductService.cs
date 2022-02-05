using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Product.Commands.EditProduct
{
    public interface IEditProductService
    {
        ResultDto Execute(RequestEditProductService request);
    }
    public class EditProductService : IEditProductService
    {
        private readonly IDataBaseContext _context;
        public EditProductService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestEditProductService request)
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
                    Message = "Please enter price"
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
            var products = _context.Products.SingleOrDefault(b => b.Id == request.Id);

            if (products != null)
            {
                products.Name = request.Name;
                products.Price = request.Price;
                products.Number = request.Number;
                if(request.Imagedir != null) products.Imagedir = request.Imagedir;
                products.Status = request.Status;

                _context.SaveChanges();
            }

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
    public class RequestEditProductService
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Number { get; set; }
        public string Imagedir { get; set; }
        public bool Status { get; set; }
    }
}
