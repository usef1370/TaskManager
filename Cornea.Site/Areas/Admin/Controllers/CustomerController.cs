using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cornea.Application.Services.Customer.Commands.AddCustomer;
using Cornea.Application.Services.Customer.Commands.DeleteCustomer;
using Cornea.Application.Services.Customer.Commands.EditCustomer;
using Cornea.Application.Services.Customer.Queries.FindCustomers;
using Cornea.Application.Services.Customer.Queries.GetCustomers;
using Cornea.Application.Services.Product.Queries.GetProduct;
using Cornea.Common.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cornea.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {           
        private readonly IGetCustomersService _getCustomersService;
        private readonly IAddCustomerService _addCustomerService;
        private readonly IEditCustomerService _editCustomerService;
        private readonly IDeleteCustomerService _deleteCustomerService;
        private readonly IFindCustomersService _findCustomersService;
        private readonly IGetProductsService _getProductsService;
        static int id = 0;

        public CustomerController(IGetCustomersService getCustomersService
            , IAddCustomerService addCustomerService
            , IEditCustomerService editCustomerService
            , IDeleteCustomerService deleteCustomerService
            , IFindCustomersService findCustomersService
            , IGetProductsService getProductsService)
        {
                
            _getCustomersService = getCustomersService;
            _addCustomerService = addCustomerService;
            _editCustomerService = editCustomerService;
            _deleteCustomerService = deleteCustomerService;
            _findCustomersService = findCustomersService;
            _getProductsService = getProductsService;
        }
        public IActionResult Customers()
        {
            ViewBag.activeItem = "itemCustomers";
            return View(_getCustomersService.Execute());
        }

        public IActionResult CreateCustomer()
        {
            ViewBag.activeItem = "itemAddCustomer";
            return View(_getProductsService.Execute());
        }

        [HttpPost]
        public IActionResult CreateCustomer(string Name, string LabName, string Phone, long Number, string ProductName, string City, string Address, string SaleDate)
        {
            var result = _addCustomerService.Execute(new RequestAddCustomerService
            {
                Name = Name,
                LabName = LabName,
                Phone = Phone,
                Number = Number,
                ProductName = ProductName,
                City = City,
                Address = Address,
                SaleDate = Convert.ToDateTime(SaleDate)
            });
            return Json(result);
        }

        //[HttpPost]
        //public IActionResult findCustomer(string searchKey)
        //{
        //    var result = _findCustomersService.Execute(Convert.ToInt32(searchKey));
        //    id = Convert.ToInt32(searchKey);
        //    return Json(result);
        //}

        public IActionResult EditCustomer(string searchKey)
        {
            var item1 = _findCustomersService.Execute(Convert.ToInt32(searchKey));
            var item2 = _getProductsService.Execute();
            int i = 0;
            foreach (var item in item2.productslist)
            {
                if (item.Name == item1.Data.ProductName)
                {
                    break;
                }
                i++;
            }
            item2.productslist.RemoveAt(i);
            Tuple<ResultDto<ResultFindCustomersService>, ResultGetProductsDto> _tuple = new Tuple<ResultDto<ResultFindCustomersService>, ResultGetProductsDto>(item1, item2);
            return View(_tuple);
        }

        [HttpPost]
        public IActionResult EditCustomer(string Name, long _id, string LabName, string Phone, long Number, string ProductName, string City, string Address, string SaleDate)
        {
            var result = _editCustomerService.Execute(new RequestEditCustomerService
            {
                Id = _id,
                Name = Name,
                LabName = LabName,
                Phone = Phone,
                Number = Number,
                ProductName = ProductName,
                City = City,
                Address = Address,
                SaleDate = Convert.ToDateTime(SaleDate)
            });
            return Json(result);
        }

        [HttpPost]
        public IActionResult deleteCustomer(string searchKey)
        {
            var result = _deleteCustomerService.Execute(Convert.ToInt32(searchKey));
            id = Convert.ToInt32(searchKey);
            return Json(result);
        }

    }
}