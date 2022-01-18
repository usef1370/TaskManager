using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        ResultGetUsersDto Execute(RequestGetUsersDto request);
    }
}
