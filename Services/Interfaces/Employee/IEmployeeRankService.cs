using System.Collections.Generic; 
using System.Threading.Tasks;
using Services.DTOs.Employee;

namespace Services.Interfaces.Employee
{
    public interface IEmployeeRankService
    {
        Task<ICollection<RankDTO>> GetRanks();
    }
}
