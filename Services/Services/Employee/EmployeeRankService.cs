using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Services.DTOs.Employee;
using Services.Interfaces.Employee;
using Storage;
using Storage.Models;

namespace Services.Services.Employee
{
    public class EmployeeRankService : IEmployeeRankService
    {
        private readonly WorkstationContext _db;

        public EmployeeRankService(WorkstationContext db)
        {
            _db = db;
        }

        public async Task<ICollection<RankDTO>> GetRanks()
        {
            var ranks = await _db.Ranks
                .AsNoTracking()
                .Select(x => new RankDTO { Id = x.Id, Name = x.Name, Term = x.Term })
                .Where(x => !x.Name.Equals("admin"))
                .ToListAsync();

            return ranks;
        }

        public async Task AddRank(RankDTO rankDTO)
        {

            if (await _db.Ranks.AnyAsync(x => x.Name == rankDTO.Name))
                throw new ArgumentException();

            var rank = new Rank
            {
                Name = rankDTO.Name,
                Term = rankDTO.Term
            };

            await _db.Ranks.AddAsync(rank);
            await _db.SaveChangesAsync();
        }

        public async Task<RankDTO> GetRank(int id)
        {
            return await _db.Ranks
                .AsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => (RankDTO)x)
                .SingleOrDefaultAsync();
        }

        public async Task UpdateRank(int id, RankDTO rankDTO)
        {
            var rank = await _db.Ranks
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (rank == null)
                throw new ArgumentException();

            rank.Term = rankDTO.Term;
            rank.Name = rankDTO.Name;

            _db.Ranks.Update(rank);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveRank(int id)
        {
            var rank = await _db.Ranks
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (rank != null)
            {
                _db.Ranks.Remove(rank);
                await _db.SaveChangesAsync();
            }
        }
    }
}
