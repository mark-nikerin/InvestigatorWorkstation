using System.Collections.Generic;
using System.Threading.Tasks;
using Services.DTOs;

namespace Services.Interfaces
{
    public interface IAuthorityService
    {
        Task<AuthorityDTO> GetAuthority(int id);
        Task<ICollection<AuthorityDTO>> GetAuthorities();
        Task AddAuthority(AuthorityDTO dto);
        Task UpdateAuthority(int id, AuthorityDTO dto);
        Task RemoveAuthority(int id);
    }
}
