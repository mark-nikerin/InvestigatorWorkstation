using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAuthService
    {
        Task RegisterUser(string login, string password);
        Task AuthorizeUser(string login, string password);
        void UnauthorizeUser();
    }
}
