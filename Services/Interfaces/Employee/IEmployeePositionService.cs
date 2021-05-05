using System.Collections.Generic; 
using System.Threading.Tasks;
using Services.DTOs.Employee;

namespace Services.Interfaces.Employee
{
    public interface IEmployeePositionService
    {
        Task<ICollection<PositionDTO>> GetPositions();
        Task<PositionDTO> GetPosition(int id);
        Task AddPosition(PositionDTO positionDTO);
        Task UpdatePosition(int id, PositionDTO positionDTO);
        Task RemovePosition(int id);
    }
}
