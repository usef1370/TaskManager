using Cornea.Common.Dto;

namespace Cornea.Application.Services.Users.Queries.FindUsers
{
    public interface IFindUsersService
    {
        ResultDto<ResultFindUsersService> Execute(int searchKey);
    }
}
