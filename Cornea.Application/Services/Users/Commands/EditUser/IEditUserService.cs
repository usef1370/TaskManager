using Cornea.Common.Dto;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Users.Commands.EditUser
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEditUserService request);
    }
}
