﻿using System;

namespace Cornea.Application.Services.Project.Commands.EditProject
{
    public class RequestEditProjectService
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Message { get; set; }
    }
}