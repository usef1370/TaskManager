using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cornea.Site.Models;
using Cornea.Application.Services.Users.Queries.GetUsers;
using Cornea.Application.Services.Users.Queries.GetRoles;
using Cornea.Application.Services.Users.Commands.RegisterUsers;
using System.Net.WebSockets;
using Cornea.Application.Services.Project.Queries.GetProjects;
using Cornea.Application.Services.Project.Commands.AddProject;
using System;
using Microsoft.AspNetCore.Http;

namespace Cornea.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetProjectsService _getProjectsService;
        public HomeController(IGetProjectsService getProjectsService)
        {
            _getProjectsService = getProjectsService;
        }

        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult test()
        {
            ViewBag.activeItem = "itemProjects";
            return View(_getProjectsService.Execute());
        }
        [HttpPost]
        public IActionResult test(string t="asayeh mosa")
        {
            return View();
        }
    }
}
