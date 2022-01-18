using Cornea.Application.Interfaces.Contexts;
using System.Linq;

namespace Cornea.Application.Services.Factor.Queries.GetFactor
{
    public class GetFactorsService : IGetFactorsService
    {
        private readonly IDataBaseContext _context;
        public GetFactorsService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetFactorsDto Execute()
        {
            var factors = _context.Factors.AsQueryable();
            var factorsList = factors.Select(p => new ResultGetFactors
            {
                Id = p.Id,
                FactorNumber = p.FactorNumber,
                ProjectName = p.ProductName,
                Number = p.Number,
                Price = p.Price,
                Issuancedate = p.Issuancedate,
                Imagedir = p.Imagedir
            }).ToList();
            return new ResultGetFactorsDto
            {
                factorslist = factorsList
            };
        }
    }
}
