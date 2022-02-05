using System;

namespace Cornea.Application.Services.Project.Commands.AddProject
{
    public class RequestAddProjectService
    {
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Message { get; set; }
    }

}


