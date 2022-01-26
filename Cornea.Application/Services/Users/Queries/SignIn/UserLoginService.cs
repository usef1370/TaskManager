using Cornea.Application.Interfaces.Contexts;
using Cornea.Common;
using Cornea.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cornea.Application.Services.Users.Queries.Signin
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IDataBaseContext _context;
        public UserLoginService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultUserloginDto> Execute(string UserName, string Password)
        {

            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "نام کاربری و رمز عبور را وارد نمایید",
                };
            }

            var user = _context.LoginInfo.Include(p => p.Role).Where(p => p.UserName.Equals(UserName)).FirstOrDefault();

            if (user == null)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "کاربری با این ایمیل در سایت  ثبت نام نکرده است",
                };
            }
            string hashedPassword = PasswordHasher.SHA256_Hash(Password);

            if (hashedPassword.Equals(user.Password) == false)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "رمز وارد شده اشتباه است!",
                };
            }

            return new ResultDto<ResultUserloginDto>()
            {
                Data = new ResultUserloginDto()
                {
                    RoleId = user.RoleId,
                    UserId = user.UserId,
                    Fullname = user.Fullname,
                    Imagedir = user.Imagedir,
                    Position = user.Position,
                },
                IsSuccess = true,
                Message = "ورود به سایت با موفقیت انجام شد",
            };


        }
    }
}
