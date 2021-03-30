using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Services.DTOs;
using Services.Interfaces;
using Storage;

namespace Services.Services
{
    public class AuthorityService : IAuthorityService
    {
        private readonly WorkstationContext _db;

        public AuthorityService(WorkstationContext db)
        {
            _db = db;
        }

        public async Task AddAuthority(AuthorityDTO dto)
        {
            var authority = new Storage.Models.Authority
            {
                Title = dto.Title,
                Address = dto.Address,
                PhoneNumber = dto.PhoneNumber,
                Subdivision = dto.Subdivision
            };

            await _db.Authorities.AddAsync(authority);
            await _db.SaveChangesAsync();
        }

        public async Task<AuthorityDTO> GetAuthority(int id)
        {
            return await _db.Authorities
                  .AsNoTracking()
                  .Where(x => x.Id == id)
                  .Select(x => (AuthorityDTO)x)
                  .SingleOrDefaultAsync();
        }

        public async Task<ICollection<AuthorityDTO>> GetAuthorities()
        {
            return await _db.Authorities
                   .AsNoTracking()
                   .Select(x => (AuthorityDTO)x)
                   .ToListAsync();
        }

        public async Task RemoveAuthority(int id)
        {
            var authoritiy = await _db.Authorities
                 .Where(x => x.Id == id)
                 .SingleOrDefaultAsync();

            if (authoritiy != null)
            {
                _db.Authorities.Remove(authoritiy);
                await _db.SaveChangesAsync();
            }
        }

        public async Task UpdateAuthority(int id, AuthorityDTO dto)
        {
            var authority = await _db.Authorities
                 .Where(x => x.Id == id)
                 .SingleOrDefaultAsync();

            if (authority != null)
            {
                authority.Title = dto.Title;
                authority.Address = dto.Address;
                authority.PhoneNumber = dto.PhoneNumber;
                authority.Subdivision = dto.Subdivision;

                _db.Authorities.Update(authority);
                await _db.SaveChangesAsync();
            }
        }
    }
}
