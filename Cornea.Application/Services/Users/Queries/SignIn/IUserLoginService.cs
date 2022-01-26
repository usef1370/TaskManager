using Cornea.Common.Dto;

namespace Cornea.Application.Services.Users.Queries.Signin
{
    public interface IUserLoginService
    {
        ResultDto<ResultUserloginDto> Execute(string UserName, string Password);
    }
}
