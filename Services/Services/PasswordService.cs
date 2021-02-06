using Services.Interfaces;

namespace Services
{
    using System; 
    using System.Security.Cryptography;

    public sealed class PasswordService : IPasswordService
    {
        private const int SALT_SIZE = 16;
        private const int HASH_SIZE = 20;
        private const int HASH_ITER = 50000;

        public string GetHashedPassword(string password)
        {
            var salt = new byte[SALT_SIZE];

            new RNGCryptoServiceProvider().GetBytes(salt);
            var hash = new Rfc2898DeriveBytes(password, salt, HASH_ITER).GetBytes(HASH_SIZE);

            var hashBytes = new byte[SALT_SIZE + HASH_SIZE];
            Array.Copy(salt, 0, hashBytes, 0, SALT_SIZE);
            Array.Copy(hash, 0, hashBytes, SALT_SIZE, HASH_SIZE);

            var hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword;
        } 

        public bool VerifyPassword(string dbPassword, string password)
        {
            var dbSalt = new byte[SALT_SIZE];
            var dbHash = new byte[HASH_SIZE];

            var dbPasswordBytes = Convert.FromBase64String(dbPassword);
            Array.Copy(dbPasswordBytes, 0, dbSalt, 0, length: SALT_SIZE);
            Array.Copy(dbPasswordBytes, SALT_SIZE, dbHash, 0, length: HASH_SIZE);

            var passwordHash = new Rfc2898DeriveBytes(password, dbSalt, HASH_ITER).GetBytes(HASH_SIZE);

            for (var i = 0; i < HASH_SIZE; i++)
                if (passwordHash[i] != dbHash[i])
                    return false;
            return true;
        }
    }
}
