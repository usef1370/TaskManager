using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cornea.Application.Services.Factor.Commands.AddFactor;
using Cornea.Application.Services.Factor.Commands.DeleteFactor;
using Cornea.Application.Services.Factor.Commands.EditFactor;
using Cornea.Application.Services.Factor.Queries.FindFactor;
using Cornea.Application.Services.Factor.Queries.GetFactor;
using Cornea.Application.Services.Product.Queries.GetProduct;
using Cornea.Common.Dto;
using Cornea.Site.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FactorController : Controller
    {

        private readonly IGetFactorsService _getFactorsService;
        private readonly IAddFactorService _addFactorService;
        private readonly IEditFactorService _editFactorService;
        private readonly IDeleteFactorService _deleteFactorService;
        private readonly IFindFactorService _findFactorService;
        private readonly IGetProductsService _getProductsService;
        static int id = 0;

        public FactorController(IGetFactorsService getFactorsService
            , IAddFactorService addFactorService
            , IEditFactorService editFactorService
            , IDeleteFactorService deleteFactorService
            , IFindFactorService findFactorService
            , IGetProductsService getProductsService)
        {

            _getFactorsService = getFactorsService;
            _addFactorService = addFactorService;
            _editFactorService = editFactorService;
            _deleteFactorService = deleteFactorService;
            _findFactorService = findFactorService;
            _getProductsService = getProductsService;
        }
        public IActionResult Factors()
        {
            ViewBag.activeItem = "itemFactors";
            return View(_getFactorsService.Execute());
        }

        public IActionResult CreateFactor()
        {
            //ViewBag.Meassage = TempData["Message"] as string;
            ViewBag.activeItem = "itemAddFactor";
            var ResultProducts = _getProductsService.Execute();
            var pvm = new ProductViewModel();
            pvm.ProductList = new List<SelectListItem>();
            foreach (var item in ResultProducts.productslist)
            {
                pvm.ProductList.Add(new SelectListItem { Text = item.Name, Value = item.Name.ToString() });
            }
            return View(pvm);
        }

        [HttpPost]
        public IActionResult CreateFactor(ProductViewModel productViewModel)
        {

            if (productViewModel.files != null)
            {
                if (productViewModel.files.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(productViewModel.files.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
                    new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        productViewModel.files.CopyTo(fs);
                        fs.Flush();
                    }
                    _addFactorService.Execute(new RequestAddFactorService
                    {
                        ProductName = productViewModel.ProductName,
                        FactorNumber = productViewModel.FactorNumber,
                        Price = productViewModel.Price,
                        Number = productViewModel.Number,
                        Issuancedate = Convert.ToDateTime(productViewModel.Issuancedate),
                        Imagedir = "/Images/" + newFileName
                    });
                    TempData["Message"] = "successfully saved";
                    return Redirect("CreateFactor");
                }
            }
            //return Redirect("CreateFactor");
            return RedirectToAction("EditFactor",  new { Area = "Admin" });

        }

        [HttpPost]
        public IActionResult findFactor(string searchKey)
        {
            var result = _findFactorService.Execute(Convert.ToInt32(searchKey));
            id = Convert.ToInt32(searchKey);
            return Json(result);
        }

        public IActionResult EditFactor(string searchKey)
        {
            var item2 = _findFactorService.Execute(Convert.ToInt32(searchKey));
            var ResultProducts = _getProductsService.Execute();
            var pvm = new ProductViewModel();
            pvm.ProductList = new List<SelectListItem>();
            foreach (var item in ResultProducts.productslist)
            {
                if (item.Name != item2.Data.ProductName)
                    pvm.ProductList.Add(new SelectListItem { Text = item.Name, Value = item.Name.ToString() });
            }
            //var item1 = pvm;
            ViewBag.ProuductName = item2.Data.ProductName;
            ViewBag.Id = item2.Data.Id;
            ViewBag.Number = item2.Data.Number;
            ViewBag.FactorNumber = item2.Data.FactorNumber;
            ViewBag.Price = item2.Data.Price;
            ViewBag.Issuancedate = item2.Data.Issuancedate;
            ViewBag.Imagedir = item2.Data.Imagedir;

            //Tuple<ProductViewModel, ResultDto<ResultFindFactorService>> _tuple = new Tuple<ProductViewModel, ResultDto<ResultFindFactorService>>(item1, item2);
            return View(pvm);
        }

        [HttpPost]
        public IActionResult EditFactor(IFormFile files, string FactorNumber, long FactorId, string ProductName, long Number, string Price, string Issuancedate)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(files.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
                    new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        files.CopyTo(fs);
                        fs.Flush();
                    }
                    _editFactorService.Execute(new RequestEditFactorService
                    {
                        Id = FactorId,
                        FactorNumber = FactorNumber,
                        ProductName = ProductName,
                        Number = Number,
                        Price = Price,
                        Issuancedate = Convert.ToDateTime(Issuancedate),
                        Imagedir = "/Images/" + newFileName
                    });
                }
            }
            else
            {
                _editFactorService.Execute(new RequestEditFactorService
                {
                    Id = FactorId,
                    FactorNumber = FactorNumber,
                    ProductName = ProductName,
                    Number = Number,
                    Price = Price,
                    Issuancedate = Convert.ToDateTime(Issuancedate),
                    Imagedir = null
                });
            }
            return Redirect("Factors");

        }


        [HttpPost]
        public IActionResult deleteFactor(string searchKey)
        {
            var result = _deleteFactorService.Execute(Convert.ToInt32(searchKey));
            id = Convert.ToInt32(searchKey);
            return Json(result);
        }
    }
}