using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Users.Commands.DeleteUser
{
    public interface IDeleteUserService
    {
        ResultDto Execute(long Id);
    }
    public class DeleteUserService:IDeleteUserService
    {
        private readonly IDataBaseContext _context;
        public DeleteUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long Id)
        {
            LoginInfo users = new LoginInfo() { UserId = Id };
            _context.LoginInfo.Attach(users);
            _context.LoginInfo.Remove(users);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "Deleted Successfully"
            };
        }
    }
}
