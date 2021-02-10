using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAuthService
    { 
        Task AuthorizeUser(string login, string password);
        void UnauthorizeUser();
    }
}
