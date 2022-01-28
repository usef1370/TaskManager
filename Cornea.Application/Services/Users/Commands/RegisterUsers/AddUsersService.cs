using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;

namespace Cornea.Application.Services.Users.Commands.RegisterUsers
{
    public class AddUsersService : IAddUsersService
    {
        private readonly IDataBaseContext _context;
        public AddUsersService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestAddUsersService request)
        {

            LoginInfo users = new LoginInfo()
            {
                RoleId = request.RoleId,
                Email = request.Email,
                Fullname = request.Fullname,
                Phone = request.Phone,
                Birthday = request.Birthday,
                HireDay = request.HireDay,
                Imagedir = request.Imagedir,
                Position = request.Position,
                University = request.University,
                DegreeLevel = request.DegreeLevel,
                Company = request.Company,
                Specialization = request.Specialization,
                Country = request.Country,
                LastjobDescription = request.LastjobDescription,
                StartEducationTime = request.StartEducationTime,
                FinishEducationTime = request.FinishEducationTime,
                StartLastjobTime = request.StartLastjobTime,
                FinishLastjobTime = request.FinishLastjobTime,
                AdditionalInfo = request.AdditionalInfo,
                Resumedir = request.Resumedir,
                Password = request.Password,
                UserName = request.Username,
            };

            _context.LoginInfo.Add(users);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
