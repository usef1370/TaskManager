namespace Cornea.Application.Services.Users.Queries.Signin
{
    public class ResultUserloginDto
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public string Fullname { get; set; }
        public string Imagedir { get; set; }
        public string Position { get; set; }
    }
}
