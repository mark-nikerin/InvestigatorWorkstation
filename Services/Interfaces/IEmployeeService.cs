using Services.DTOs.Employee;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO> GetEmployees();
        Task AddEmployee(EmployeeDTO employee);
        Task UpdateEmployee(int id, EmployeeDTO employee);
        Task RemoveEmployee(int id);
    }
}
