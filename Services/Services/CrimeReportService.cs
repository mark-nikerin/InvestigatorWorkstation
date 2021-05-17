using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Services.DTOs.CrimeReport;
using Services.Interfaces.CrimeReport;
using Storage;

namespace Services.Services.CrimeReport
{
    public class CrimeReportService : ICrimeReportService
    {
        private readonly WorkstationContext _db;

        public CrimeReportService(WorkstationContext db)
        {
            _db = db;
        }

        public async Task AddCrimeReport(CrimeReportDTO dto)
        {
            var crimeReport = new Storage.Models.CrimeReport
            {
                EmployeeId = dto.Employee.Id,
                Fable = dto.Fable,
                AuthorityId = dto.Authority.Id,
                RegistrationBookNumber = dto.RegistrationBookNumber,
                RegistrationNumber = dto.RegistrationNumber,
                RegistrationDate = dto.RegistrationDate,
                DueDate = dto.RegistrationDate.AddDays(3),
                Qualification = dto.Qualification
            };

            await _db.CrimeReports.AddAsync(crimeReport);
            await _db.SaveChangesAsync();
        }

        public async Task<CrimeReportDTO> GetCrimeReport(int id)
        {
            return await _db.CrimeReports
               .AsNoTracking()
               .Include(x => x.Employee)
                    .ThenInclude(x => x.PositionHistories)
               .Include(x => x.Employee)
                    .ThenInclude(x => x.RankHistories)
               .Include(x => x.Authority)
               .Where(x => x.Id == id)
               .Select(x => (CrimeReportDTO)x)
               .SingleOrDefaultAsync();
        }

        public async Task<ICollection<CrimeReportDTO>> GetCrimeReports()
        {
            return await _db.CrimeReports
                .AsNoTracking()
                .Include(x => x.Employee)
                    .ThenInclude(x => x.PositionHistories)
                .Include(x => x.Employee)
                .ThenInclude(x => x.RankHistories)
                .Include(x => x.Authority)
                .Select(x => (CrimeReportDTO)x)
                .ToListAsync();
        }

        public async Task RemoveCrimeReport(int id)
        {
            var crimeReport = await _db.CrimeReports
                 .Where(x => x.Id == id)
                 .SingleOrDefaultAsync();

            if (crimeReport != null)
            {
                _db.CrimeReports.Remove(crimeReport);
                await _db.SaveChangesAsync();
            }
        }

        public async Task UpdateCrimeReport(int id, CrimeReportDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
