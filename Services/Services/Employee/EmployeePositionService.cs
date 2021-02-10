using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Services.DTOs.Employee;
using Services.Interfaces.Employee;
using Storage;

namespace Services.Services.Employee
{
    public class EmployeePositionService : IEmployeePositionService
    {
        private readonly WorkstationContext _context;

        public EmployeePositionService(WorkstationContext context)
        {
            _context = context;
        }

        public async Task<ICollection<PositionDTO>> GetPositions()
        {
            return await _context.Positions
                .AsNoTracking()
                .Select(x => new PositionDTO { Id = x.Id, Name = x.Name })
                .ToListAsync();
        }
    }
}
