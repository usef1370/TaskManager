using Cornea.Common.Dto;
using System.Collections.Generic;


namespace Cornea.Application.Services.Users.Queries.GetRoles
{
    public interface IGetRolesService
    {
        ResultDto<List<RolesDto>> Execute();
    }
}
