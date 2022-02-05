using Cornea.Common.Dto;
using Microsoft.EntityFrameworkCore.Storage;

namespace Cornea.Application.Services.Project.Queries.FindProjects
{
    public interface IFindProjectsService
    {
        ResultDto<ResultFindProjectsService> Execute(string searchKey);
    }
}
