using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Dto;
using System.Linq;

namespace Cornea.Application.Services.Users.Commands.EditUser
{
    public class EditUserService:IEditUserService
    {
        private readonly IDataBaseContext _context;
        public EditUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestEditUserService request)
        {
            //if (request.UserName == null)
            //{
            //    return new ResultDto
            //    {
            //        IsSuccess = false,
            //        Message = "Please enter a user name"
            //    };
            //}
            //if (request.Email == null)
            //{
            //    return new ResultDto
            //    {
            //        IsSuccess = false,
            //        Message = "Please enter email"
            //    };
            //}
            //if (request.Position == null)
            //{
            //    return new ResultDto
            //    {
            //        IsSuccess = false,
            //        Message = "Please enter position"
            //    };
            //}
            //if (request.Name == null)
            //{
            //    return new ResultDto
            //    {
            //        IsSuccess = false,
            //        Message = "Please enter start time"
            //    };
            //}
            //if (request.Family == null)
            //{
            //    return new ResultDto
            //    {
            //        IsSuccess = false,
            //        Message = "Please enter finish time"
            //    };
            //}

            var users = _context.LoginInfo.SingleOrDefault(b => b.UserId == request.UserId);

            if (users != null)
            {
                users.RoleId = 1;
                users.Email = request.Email;
                users.Fullname = request.Fullname;
                users.Phone = request.Phone;
                users.Birthday = request.Birthday;
                users.HireDay = request.HireDay;
                if (request.Imagedir != "")
                    users.Imagedir = request.Imagedir;
                users.Position = request.Position;
                users.University = request.University;
                users.DegreeLevel = request.DegreeLevel;
                users.Company = request.Company;
                users.Specialization = request.Specialization;
                users.Country = request.Country;
                users.LastjobDescription = request.LastjobDescription;
                users.StartEducationTime = request.StartEducationTime;
                users.FinishEducationTime = request.FinishEducationTime;
                users.StartLastjobTime = request.StartLastjobTime;
                users.FinishLastjobTime = request.FinishLastjobTime;
                users.AdditionalInfo = request.AdditionalInfo;
                if (request.Resumedir != "")
                    users.Resumedir = request.Resumedir;

                _context.SaveChanges();
            }

            return new ResultDto
            {
                IsSuccess = true,
                Message = "successfully saved"
            };
        }
    }
}
