namespace Cornea.Application.Services.Project.Queries.FindProjects
{
    public class ResultFindProjectsService
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public string Message { get; set; }
        public long? PassedTime { get; set; }
        public long? Timeline { get; set; }
        public long? Percent { get; set; }
       
    }
}
