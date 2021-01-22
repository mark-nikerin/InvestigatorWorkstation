using Services.DTOs.Employee;
using Services.Interfaces;
using Storage;
using Storage.Models;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly WorkstationContext _db; 
        private readonly IAuthService _authService; 

        public EmployeeService(WorkstationContext db, IAuthService authService)
        {
            _db = db;
            _authService = authService;
        }

        public async Task AddEmployee(EmployeeDTO employeeDTO)
        {
            var employee = new Employee
            {
                FirstName = employeeDTO.FirstName,
                MiddleName = employeeDTO.MiddleName,
                LastName = employeeDTO.LastName,
                Login = employeeDTO.Login,
                BirthDate = employeeDTO.BirthDate,
                CertificationTerm = employeeDTO.CertificationTerm,
                ContractDate = employeeDTO.ContractDate,
                JoinServiceDate = employeeDTO.JoinServiceDate,
                Number = employeeDTO.Number,
                QualificationUpdateDate = employeeDTO.QualificationUpdateDate,
                StartWorkDate = employeeDTO.StartWorkDate,
                Rank = new Rank
                {
                    Name = employeeDTO.Rank.Name,
                    OrderDate = employeeDTO.Rank.OrderDate,
                    AppointmentDate = employeeDTO.Rank.AppointmentDate,
                    OrderNumber = employeeDTO.Number,
                    RankTerm = employeeDTO.Rank.Term
                },
                Position = new Position
                {
                    Name = employeeDTO.Position.Name,
                    OrderDate = employeeDTO.Position.OrderDate,
                    OrderNumber = employeeDTO.Position.OrderNumber,
                    AppointmentDate = employeeDTO.Position.AppointmentDate
                },
            };

            await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();

            await _authService.RegisterUser(employeeDTO.Login, employeeDTO.Password);
        }

        public async Task<EmployeeDTO> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public async Task RemoveEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateEmployee(int id, EmployeeDTO employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
