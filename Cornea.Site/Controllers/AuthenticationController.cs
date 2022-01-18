using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cornea.Application.Services.Users.Commands.LoginUser;
using Cornea.Application.Services.Users.Commands.RegisterUsers;
using Cornea.Common.Dto;
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
        public IActionResult Signin(string Username, string Password)
        {
            var signupResult = _userLoginService.Execute(Username, Password);
            if (signupResult.IsSuccess == false)
            {
                return Json(signupResult);
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
            return Json(signupResult);
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Signup(SignupViewModel request)
        {
            if (
                string.IsNullOrWhiteSpace(request.UserName) ||
                string.IsNullOrWhiteSpace(request.Email) ||
                string.IsNullOrWhiteSpace(request.Password) ||
                string.IsNullOrWhiteSpace(request.RePassword))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "لطفا تمامی موارد رو ارسال نمایید" });
            }

            //if (User.Identity.IsAuthenticated == true)
            //{
            //    return Json(new ResultDto { IsSuccess = false, Message = "شما به حساب کاربری خود وارد شده اید! و در حال حاضر نمیتوانید ثبت نام مجدد نمایید" });
            //}
            if (request.Password != request.RePassword)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "رمز عبور و تکرار آن برابر نیست" });
            }
            if (request.Password.Length < 6)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "رمز عبور باید حداقل 6 کاراکتر باشد" });
            }

            string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";

            var match = Regex.Match(request.Email, emailRegex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return Json(new ResultDto { IsSuccess = true, Message = "ایمیل خودرا به درستی وارد نمایید" });
            }

            var signupResult = _registerUserService.Execute(new RequestRegisterUserDto
            {
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password,
                RePassword = request.RePassword,
                ThemeIndex = 0,
                RoleId = 2,
                //roles = new List<RolesInRegisterUserDto>()
                //{
                //     new RolesInRegisterUserDto { Id = 2},
                //}
            });

            
            return Json(signupResult);
        }

        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Signin", "Authentication");
        }
    }
}