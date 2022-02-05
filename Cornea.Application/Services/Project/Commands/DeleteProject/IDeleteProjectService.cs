using Cornea.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cornea.Application.Services.Project.Commands.DeleteProject
{
    public interface IDeleteProjectService
    {
        ResultDto Execute(string searchKey);
    }
}
