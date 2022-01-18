using Cornea.Application.Interfaces.Contexts;
using Cornea.Common;
using System.Linq;

namespace Cornea.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDataBaseContext _context;
        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetUsersDto Execute(RequestGetUsersDto request)
        {
            var users = _context.LoginInfo.AsQueryable();
            //if (!string.IsNullOrWhiteSpace(request.SearchKey))
            //{
            //    users = users.Where(p => p.UserName.Contains(request.SearchKey));
            //}
            int rowsCount = 0;
            var usersList = users.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetUsersDto
            {
                UserId = p.UserId,
                Email = p.Email,
                UserName = p.UserName,
                Fullname = p.Fullname,
                Imagedir = p.Imagedir,
                Position = p.Position,
            }).ToList();
            return new ResultGetUsersDto
            {
                Rows = rowsCount,
                Users = usersList,
            };
        }
    }
}
