namespace Services
{
    using Microsoft.EntityFrameworkCore;
    using Services.Interfaces;
    using Storage;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class AuthService : IAuthService
    {
        private readonly WorkstationContext _db; 
        private readonly IPasswordService _passwordService;

        public AuthService(WorkstationContext db, IPasswordService passwordService)
        {
            _db = db;
            _passwordService = passwordService;
        }

        public async Task<string> AuthorizeUser(string login, string password)
        {
            var user = await _db.Employees.Where(x => x.Login == login).SingleOrDefaultAsync();

            if (user == null)
                throw new Exception("Wrong login or password"); 

            if (!_passwordService.VerifyPassword(user.Password, password))
            {
                throw new Exception("Wrong login or password");
            }

            return $"{user.LastName} {user.FirstName} {user.MiddleName}";
        }

        public async Task RegisterUser()
        {
            throw new System.NotImplementedException();
        }

        public void UnauthorizeUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
