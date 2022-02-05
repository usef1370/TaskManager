using Cornea.Application.Interfaces.Contexts;
using System.Linq;

namespace Cornea.Application.Services.Product.Queries.GetProduct
{
    public class GetProductsService : IGetProductsService
    {
        private readonly IDataBaseContext _context;
        public GetProductsService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetProductsDto Execute()
        {
            var products = _context.Products.Where(p => p.Status == true);
            var productsList = products.Select(p => new ResultGetProducts
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Number = p.Number,
                Imagedir = p.Imagedir,
                Status = p.Status
            }).ToList();

            return new ResultGetProductsDto
            {
                productslist = productsList
            };
        }
    }
}
