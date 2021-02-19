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

        public async Task AddCrimeReport(CrimeReportDTO crimeReport)
        {
            throw new NotImplementedException();
        }

        public async Task<CrimeReportDTO> GetCrimeReport(int id)
        {
            return await _db.CrimeReports
               .AsNoTracking()
               .Include(x => x.Qualification)
               .Include(x => x.Employee)
               .Where(x => x.Id == id)
               .Select(x => (CrimeReportDTO)x)
               .SingleOrDefaultAsync();
        }

        public async Task<ICollection<CrimeReportDTO>> GetCrimeReports()
        {
            return await _db.CrimeReports
                .AsNoTracking()
                .Include(x => x.Qualification)
                .Include(x => x.Employee)
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

        public async Task UpdateCrimeReport(int id, CrimeReportDTO employee)
        {
            throw new NotImplementedException();
        }
    }
}
