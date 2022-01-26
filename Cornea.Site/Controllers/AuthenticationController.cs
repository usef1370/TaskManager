using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.RegularExpressions;
using Cornea.Application.Services.Users.Queries.Signin;
using Cornea.Application.Services.Users.Commands.RegisterUsers;
using Cornea.Common.Dto;
using Cornea.Site.Models;
using EndPoint.Site.Models.ViewModels.AuthenticationViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Cornea.Site.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IRegisterUserService _registerUserService;
        private readonly IUserLoginService _userLoginService;

        public AuthenticationController(IRegisterUserService registerUserService, IUserLoginService userLoginService)
        {
            _registerUserService = registerUserService;
            _userLoginService = userLoginService;
        }
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signin(SigninViewModel model)
        {
            if (ModelState.IsValid)
            {
                var signupResult = _userLoginService.Execute(model.UserName, model.Password);
                if (signupResult.IsSuccess == false)
                {
                    return View("Signin");
                }
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, signupResult.Data.UserId.ToString()),
                    new Claim(ClaimTypes.Name, signupResult.Data.Fullname.ToString()),
                    new Claim(ClaimTypes.Role, signupResult.Data.Position.ToString()),
                    new Claim(ClaimTypes.Uri, signupResult.Data.Imagedir.ToString()),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(30),

                };
                HttpContext.SignInAsync(principal, properties);
                return Redirect("Admin/Home/Main");
            }
            return View("Signin");
        }

        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Signin", "Authentication");
        }
    }
}