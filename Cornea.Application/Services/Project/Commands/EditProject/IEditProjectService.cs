using Cornea.Application.Services.Project.Commands.AddProject;
using Cornea.Common.Dto;
using Cornea.Domain.Entities;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Project.Commands.EditProject
{
    public interface IEditProjectService
    {
        ResultDto Execute(RequestEditProjectService request);
    }
}
