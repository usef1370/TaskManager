using System;

namespace Cornea.Application.Services.Factor.Queries.GetFactor
{
    public class ResultGetFactors
    {
        public long Id { get; set; }
        public string FactorNumber { get; set; }
        public string ProjectName { get; set; }
        public long Number { get; set; }
        public string Price { get; set; }
        public DateTime Issuancedate { get; set; }
        public string Imagedir { get; set; }
    }
}
