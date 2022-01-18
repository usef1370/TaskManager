using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cornea.Site.Areas.Admin.Models
{
    public class ProductViewModel
    {       
        public string ProductName { get; set; }
        public int FactorId { get; set; }
        public string FactorNumber { get; set; }
        public string Price { get; set; }
        public long Number { get; set; }
        public string Issuancedate { get; set; }
        public IFormFile files { get; set; }
        public List<SelectListItem> ProductList { set; get; }
    }
}
