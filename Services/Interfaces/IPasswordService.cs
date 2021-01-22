namespace Services.Interfaces
{
    public interface IPasswordService
    {
        string GetHashedPassword(string password);
        bool VerifyPassword(string dbPassword, string password);
    }
}
