using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Services.DTOs.Employee;
using Services.Interfaces.Employee;
using Storage;

namespace Services.Services.Employee
{
    public class EmployeeRankService : IEmployeeRankService
    {
        private readonly WorkstationContext _context;

        public EmployeeRankService(WorkstationContext context)
        {
            _context = context;
        }

        public async Task<ICollection<RankDTO>> GetRanks()
        {
            var ranks = await _context.Ranks
                .AsNoTracking()
                .Select(x => new RankDTO { Id = x.Id, Name = x.Name })
                .Where(x => !x.Name.Equals("admin"))
                .ToListAsync();

            return ranks;
        }
    }
}
