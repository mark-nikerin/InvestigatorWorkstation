﻿using Services.Interfaces;

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

        public async Task RegisterUser(string login, string password)
        {
            var user = await _db.Employees.Where(x => x.Login == login).SingleOrDefaultAsync();

            if (user == null)
                throw new Exception("Employee not found");

            user.Password = _passwordService.GetHashedPassword(password);

            _db.Employees.Update(user);
            await _db.SaveChangesAsync();
        }

        public void UnauthorizeUser()
        {
            throw new System.NotImplementedException();
        }
    }
}