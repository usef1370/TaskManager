using Cornea.Common.Dto;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Project.Commands.AddProject
{
    public interface IAddProjectService
    {
        ResultDto Execute(RequestAddProjectService request);
    }

}


