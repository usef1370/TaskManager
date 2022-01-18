using Cornea.Application.Interfaces.Contexts;
using Cornea.Common;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using static Cornea.Application.Services.Users.Commands.RegisterUsers.RegisterUserService;

namespace Cornea.Application.Services.Users.Commands.RegisterUsers
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }

    public class RegisterUserService : IRegisterUserService
    {
        private readonly IDataBaseContext _context;

        public RegisterUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Email))
                {
                    return new ResultDto<ResultRegisterUserDto>()
                    {
                        Data = new ResultRegisterUserDto()
                        {
                            UserId = 0,
                        },
                        IsSuccess = false,
                        Message = "پست الکترونیک را وارد نمایید"
                    };
                }

                if (string.IsNullOrWhiteSpace(request.Password))
                {
                    return new ResultDto<ResultRegisterUserDto>()
                    {
                        Data = new ResultRegisterUserDto()
                        {
                            UserId = 0,
                        },
                        IsSuccess = false,
                        Message = "رمز عبور را وارد نمایید"
                    };
                }
                if (request.Password != request.RePassword)
                {
                    return new ResultDto<ResultRegisterUserDto>()
                    {
                        Data = new ResultRegisterUserDto()
                        {
                            UserId = 0,
                        },
                        IsSuccess = false,
                        Message = "رمز عبور و تکرار آن برابر نیست"
                    };
                }

                LoginInfo user = new LoginInfo()
                {
                    Email = request.Email,
                    UserName = request.UserName,
                    RoleId = 2,
                    Password = PasswordHasher.SHA256_Hash(request.Password),
                    Imagedir = "/Images/05332091-3c54-414e-ad72-a709649ac948.png",
                    Fullname = "",
                    Position = "",
                };


                _context.LoginInfo.Add(user);

                _context.SaveChanges();

                return new ResultDto<ResultRegisterUserDto>()
                {
                    Data = new ResultRegisterUserDto()
                    {
                        UserId = user.UserId,

                    },
                    IsSuccess = true,
                    Message = "ثبت نام کاربر انجام شد",
                };
        }
            catch (Exception)
            {
                return new ResultDto<ResultRegisterUserDto>()
                {
                    Data = new ResultRegisterUserDto()
        {
            UserId = 0,
                    },
                    IsSuccess = false,
                    Message = "ثبت نام انجام نشد !"
                };
}
        }
    }
    public class RequestRegisterUserDto
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public int ThemeIndex { get; set; }
        public int RoleId { get; set; }
    }

    //public class RolesInRegisterUserDto
    //{
    //    public long Id { get; set; }
    //}

    public class ResultRegisterUserDto
    {
        public long UserId { get; set; }

    }
}
