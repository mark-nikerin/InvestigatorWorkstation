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
    public class EmployeePositionService : IEmployeePositionService
    {
        private readonly WorkstationContext _db;

        public EmployeePositionService(WorkstationContext db)
        {
            _db = db;
        }

        public async Task<ICollection<PositionDTO>> GetPositions()
        {
            return await _db.Positions
                .AsNoTracking()
                .Select(x => new PositionDTO { Id = x.Id, Name = x.Name })
                .Where(x => !x.Name.Equals("admin"))
                .ToListAsync();
        }

        public async Task AddPosition(PositionDTO positionDTO)
        {
            if (await _db.Positions.AnyAsync(x => x.Name == positionDTO.Name))
                throw new ArgumentException();

            var position = new Position
            {
                Name = positionDTO.Name
            };

            await _db.Positions.AddAsync(position);
            await _db.SaveChangesAsync();
        }

        public async Task<PositionDTO> GetPosition(int id)
        {
            return await _db.Positions
                .AsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => (PositionDTO)x)
                .SingleOrDefaultAsync();
        }

        public async Task UpdatePosition(int id, PositionDTO positionDTO)
        {
            var position = await _db.Positions
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (position == null)
                throw new ArgumentException();

            position.Name = positionDTO.Name;

            _db.Positions.Update(position);
            await _db.SaveChangesAsync();
        }

        public async Task RemovePosition(int id)
        {
            var position = await _db.Positions
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (position != null)
            {
                _db.Positions.Remove(position);
                await _db.SaveChangesAsync();
            }
        }
    }
}
