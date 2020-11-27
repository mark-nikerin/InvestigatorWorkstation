namespace Services.Interfaces
{
    public interface IPasswordService
    {
        byte[] GetPasswordHash(string password);
        bool VerifyPassword(string dbPassword, string password);
    }
}
