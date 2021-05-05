using System.Collections.Generic; 
using System.Threading.Tasks;
using Services.DTOs.Employee;

namespace Services.Interfaces.Employee
{
    public interface IEmployeeRankService
    {
        Task<ICollection<RankDTO>> GetRanks();
        Task<RankDTO> GetRank(int id);
        Task AddRank(RankDTO rankDTO);
        Task UpdateRank(int id, RankDTO rankDTO);
        Task RemoveRank(int id);
    }
}
