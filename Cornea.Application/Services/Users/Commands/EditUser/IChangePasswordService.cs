using Cornea.Application.Interfaces.Contexts;
using Cornea.Common;
using Cornea.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Users.Commands.EditUser
{
    public interface IChangePasswordService
    {
        ResultDto Execute(RequestChangePasswordService request);
    }
    public class RequestChangePasswordService
    {
        public string UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordService : IChangePasswordService
    {
        private readonly IDataBaseContext _context;
        public ChangePasswordService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestChangePasswordService request)
        {
            if (string.IsNullOrWhiteSpace(request.CurrentPassword) || string.IsNullOrWhiteSpace(request.NewPassword) || string.IsNullOrWhiteSpace(request.ConfirmPassword))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "Please fill all field",
                };
            }

            if (request.NewPassword != request.ConfirmPassword)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "newpassword and confirm password must be same"
                };
            }

            var user = _context.LoginInfo.Where(p => p.UserId.Equals(Convert.ToInt16(request.UserId))).FirstOrDefault();

            if (user == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "Unkown user",
                };
            }
            string hashedPassword = PasswordHasher.SHA256_Hash(request.CurrentPassword);

            if (hashedPassword.Equals(user.Password) == false)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "Incorrect password!",
                };
            }

            user.Password = PasswordHasher.SHA256_Hash(request.NewPassword);

            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
