using Cornea.Application.Interfaces.Contexts;
using Cornea.Common;
using Cornea.Common.Dto;
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
        public long UserId { get; set; }
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
            if(request.NewPassword!= request.ConfirmPassword)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "newpassword and confirm password must be same"
                };
            }
            var users = _context.LoginInfo.SingleOrDefault(b => b.UserId == request.UserId);

            if (users == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "you are unknown :D"
                };
            }
            users.Password = PasswordHasher.SHA256_Hash(request.NewPassword);

            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
