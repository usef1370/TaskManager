using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Product.Commands.DeleteProduct
{
    public interface IDeleteProductService
    {
        ResultDto Execute(long Id);
    }
    public class DeleteProductService : IDeleteProductService
    {
        private readonly IDataBaseContext _context;
        public DeleteProductService(IDataBaseContext context)
        {
            _context = context;
        }
        //public ResultDto Execute(long Id)
        //{
        //    Products product = new Products() { Id = Id };
        //    _context.Products.Attach(product);
        //    _context.Products.Remove(product);
        //    _context.SaveChanges();
        //    return new ResultDto
        //    {
        //        IsSuccess = true,
        //        Message = "Deleted Successfully"
        //    };
        //}
        public ResultDto Execute(long Id)
        {
            var product = _context.Products.SingleOrDefault(b => b.Id == Id);

            if (product == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Deleted failed"
                };
            }

            product.Status = false;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "Deleted Successfully"
            };
        }
    }
}
