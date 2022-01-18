using System;
using System.Collections.Generic;

namespace Cornea.Application.Services.Task.Queries.GetTasks
{
    public class ResultGetTasks
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string ProjectName { get; set; }
        public string TaskName { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Message { get; set; }
        public long? PassedTime { get; set; }
        public long? Timeline { get; set; }
        public long? Percent { get; set; }
    }
}
