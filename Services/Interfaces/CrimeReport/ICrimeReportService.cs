using System.Collections.Generic; 
using System.Threading.Tasks;
using Services.DTOs.CrimeReport;

namespace Services.Interfaces.CrimeReport
{
    public interface ICrimeReportService
    {
        Task<CrimeReportDTO> GetCrimeReport(int id);
        Task<ICollection<CrimeReportDTO>> GetCrimeReports();
        Task AddCrimeReport(CrimeReportDTO employee);
        Task UpdateCrimeReport(int id, CrimeReportDTO employee);
        Task RemoveCrimeReport(int id);
    }
}
