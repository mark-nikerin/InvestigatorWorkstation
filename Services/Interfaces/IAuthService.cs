using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAuthService
    {
        Task RegisterUser();
        Task<string> AuthorizeUser(string login, string password);
        void UnauthorizeUser();
    }
}
