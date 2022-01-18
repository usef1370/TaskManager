using System;
using System.Drawing;
using System.IO;
using Cornea.Application.Services.Product.Commands.AddProduct;
using Cornea.Application.Services.Product.Commands.DeleteProduct;
using Cornea.Application.Services.Product.Commands.EditProduct;
using Cornea.Application.Services.Product.Queries.FindProduct;
using Cornea.Application.Services.Product.Queries.GetProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
            
        private readonly IGetProductsService _getProductsService;
        private readonly IAddProductService _addProductService;
        private readonly IEditProductService _editProductService;
        private readonly IDeleteProductService _deleteProductService;
        private readonly IFindProductService _findProductService;
        static int id = 0;

        public ProductController(IGetProductsService getProductsService
            , IAddProductService addProductService
            , IEditProductService editProductService
            , IDeleteProductService deleteProductService
            , IFindProductService findProductService)
        {

            _getProductsService = getProductsService;
            _addProductService = addProductService;
            _editProductService = editProductService;
            _deleteProductService = deleteProductService;
            _findProductService = findProductService;

        }
        public IActionResult Products()
        {
            ViewBag.activeItem = "itemProducts";
            return View(_getProductsService.Execute());
        }
        public IActionResult CreateProduct()
        {
            ViewBag.activeItem = "itemAddProduct";
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(IFormFile files, string Name, string Price, string Number)
        {

            if (files != null)
            {
                if (files.Length > 0)
                {
                    var image =Image.FromStream(files.OpenReadStream());
                    var resized = new Bitmap(image, new Size(256, 256));
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

                    resized.Save(filepath);
                    //using (FileStream fs = System.IO.File.Create(filepath))
                    //{
                    //    files.CopyTo(fs);
                    //    fs.Flush();
                    //}
                    _addProductService.Execute(new RequestAddProductService
                    {
                        Name = Name,
                        Price = Price,
                        Number = Number,
                        Imagedir = "/Images/" + newFileName
                    });
                }
            }
            return View();
        }

        //[HttpPost]
        //public IActionResult findProduct(string searchKey)
        //{
        //    var result = _findProductService.Execute(Convert.ToInt32(searchKey));
        //    //id = Convert.ToInt32(searchKey);
        //    return Json(result);
        //}

        [HttpGet]
        public IActionResult EditProduct(string searchKey)
        {
            //searchKey = "2";
            //return RedirectToAction("EditProduct",_findProductService.Execute(Convert.ToInt32(searchKey)));
            return View(_findProductService.Execute(Convert.ToInt32(searchKey)));
        }

        [HttpPost]
        public IActionResult EditProduct(IFormFile files, string Name, string _id, string Price, string Number)
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
                    _editProductService.Execute(new RequestEditProductService
                    {
                        Id = Convert.ToInt32(_id),
                        Name = Name,
                        Price = Price,
                        Number = Number,
                        Imagedir = "/Images/" + newFileName
                    });
                }
            }
            else
            {
                _editProductService.Execute(new RequestEditProductService
                {
                    Id = Convert.ToInt32(_id),
                    Name = Name,
                    Price = Price,
                    Number = Number,
                    Imagedir = null
                });
            }
            return Redirect("Products");
        }

        [HttpPost]
        public IActionResult deleteProduct(string searchKey)
        {
            var result = _deleteProductService.Execute(Convert.ToInt32(searchKey));
            id = Convert.ToInt32(searchKey);
            return Json(result);
        }
    }
}