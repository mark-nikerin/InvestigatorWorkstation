using Services.Interfaces;
using Services.Services;

namespace Services
{
    using Microsoft.EntityFrameworkCore;
    using Storage;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class AuthService : IAuthService
    {
        private readonly WorkstationContext _db;

        public AuthService(WorkstationContext db)
        {
            _db = db;
        }

        public async Task AuthorizeUser(string login, string password)
        {
            var user = await _db.Employees.Where(x => x.Login == login).SingleOrDefaultAsync();

            if (user == null)
                throw new ArgumentException("Wrong login or password");

            if (!PasswordService.VerifyPassword(user.Password, password))
            {
                throw new ArgumentException("Wrong login or password");
            }

            CurrentUserService.SetCurrentUser(user);
        }

        public void UnauthorizeUser()
        {
            CurrentUserService.SetCurrentUser(null);
        }
    }
}
