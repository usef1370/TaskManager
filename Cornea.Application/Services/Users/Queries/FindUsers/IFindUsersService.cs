using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cornea.Application.Services.Users.Queries.FindUsers
{
    public interface IFindUsersService
    {
        ResultDto<ResultFindUsersService> Execute(int searchKey);
    }

    public class FindUsersService:IFindUsersService
    {
        private readonly IDataBaseContext _context;
        public FindUsersService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultFindUsersService> Execute(int searchKey)
        {
            var users = _context.LoginInfo.SingleOrDefault(b => b.UserId == searchKey);

            if (users == null)
            {
                return new ResultDto<ResultFindUsersService>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "dfdfd"
                };
            }
            var result = new ResultFindUsersService
            {
                UserId = users.UserId,
                RoleId = users.RoleId,
                UserName = users.UserName,
                Email = users.Email,
                Password = users.Password,
                Fullname = users.Fullname,
                Phone = users.Phone,
                Birthday = users.Birthday,
                HireDay = users.HireDay,
                Imagedir = users.Imagedir,
                Position = users.Position,
                University = users.University,
                DegreeLevel = users.DegreeLevel,
                Company = users.Company,
                Specialization = users.Specialization,
                Country = users.Country,
                LastjobDescription = users.LastjobDescription,
                StartEducationTime = users.StartEducationTime,
                FinishEducationTime = users.FinishEducationTime,
                StartLastjobTime = users.StartLastjobTime,
                FinishLastjobTime = users.FinishLastjobTime,
                AdditionalInfo = users.AdditionalInfo,
                Resumedir = users.Resumedir,
            };
            return new ResultDto<ResultFindUsersService>
            {
                Data = result,
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }

    public class ResultFindUsersService
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? HireDay { get; set; }
        public string Imagedir { get; set; }
        public string Position { get; set; }
        public string University { get; set; }
        public string DegreeLevel { get; set; }
        public string Company { get; set; }
        public string Specialization { get; set; }
        public string Country { get; set; }
        public string LastjobDescription { get; set; }
        public string StartEducationTime { get; set; }
        public string FinishEducationTime { get; set; }
        public string StartLastjobTime { get; set; }
        public string FinishLastjobTime { get; set; }
        public string AdditionalInfo { get; set; }
        public string Resumedir { get; set; }
    }
}
