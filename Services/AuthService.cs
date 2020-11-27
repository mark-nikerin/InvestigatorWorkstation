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
        private readonly WorkstationContext _context; 
        private readonly IPasswordService _passwordService;

        public AuthService(WorkstationContext context, IPasswordService passwordService)
        {
            _context = context;
            _passwordService = passwordService;
        }

        public async Task<string> AuthorizeUser(string login, string password)
        {
            var user = await _context.Employees.Where(x => x.Login == login).SingleOrDefaultAsync();

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
