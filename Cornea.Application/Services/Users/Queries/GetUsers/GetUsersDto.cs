namespace Cornea.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersDto
    {
        public long UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Fullname { get; set; }
        public string Imagedir { get; set; }
        public string Position { get; set; }
    }
}
