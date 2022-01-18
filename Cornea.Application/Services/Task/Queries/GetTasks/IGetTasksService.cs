using Cornea.Common.Dto;
using System.Text;

namespace Cornea.Application.Services.Task.Queries.GetTasks
{
    public interface IGetTasksService
    {
        ResultGetTasksDto Execute(int searchKey = -1);
    }
}
