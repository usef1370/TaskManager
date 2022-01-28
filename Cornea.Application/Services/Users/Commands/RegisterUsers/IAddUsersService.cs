using Cornea.Common.Dto;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Users.Commands.RegisterUsers
{
    public interface IAddUsersService
    {
        ResultDto Execute(RequestAddUsersService request);
    }
}
