using Services.DTOs.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces.Employee
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO> GetEmployee(int id);
        Task<ICollection<EmployeeDTO>> GetEmployees();
        Task AddEmployee(EmployeeDTO employee);
        Task UpdateEmployee(int id, EmployeeDTO employee);
        Task RemoveEmployee(int id);
    }
}
