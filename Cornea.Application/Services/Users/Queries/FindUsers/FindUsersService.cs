using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System.Linq;

namespace Cornea.Application.Services.Users.Queries.FindUsers
{
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
}
