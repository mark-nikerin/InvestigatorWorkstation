using Services.DTOs.Employee;
using Services.Interfaces;

namespace Services.Services
{
    using System.Threading.Tasks;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Storage;
    using Storage.Models;
    using System;

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
            var rank = new Rank
            {
                Id = employeeDTO.Rank.Id,
                Name = employeeDTO.Rank.Name,
            };

            var position = new Position
            {
                Id = employeeDTO.Position.Id,
                Name = employeeDTO.Position.Name
            };

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
                Rank = rank,
                Position = position
            };

            var employeeRankHistory = new EmployeeRankHistory
            {
                OrderDate = employeeDTO.Rank.OrderDate,
                AppointmentDate = employeeDTO.Rank.AppointmentDate,
                OrderNumber = employeeDTO.Number,
                RankTerm = employeeDTO.Rank.Term,
                Employee = employee,
                Rank = rank
            };

            var employeePositionHistory = new EmployeePositionHistory
            {
                OrderDate = employeeDTO.Position.OrderDate,
                OrderNumber = employeeDTO.Position.OrderNumber,
                AppointmentDate = employeeDTO.Position.AppointmentDate,
                Employee = employee,
                Position = position
            };

            employee.PositionHistories.Add(employeePositionHistory);
            employee.RankHistories.Add(employeeRankHistory);

            await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();

            await _authService.RegisterUser(employeeDTO.Login, employeeDTO.Password);
        }

        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            var employee = await _db.Employees
                .AsNoTracking()
                .Include(x => x.Rank)
                .Include(x => x.Position)
                .Include(x => x.PositionHistories)
                .Include(x => x.RankHistories)
                .Where(x => x.Id == id)
                .Select(x => (EmployeeDTO)x)
                .FirstOrDefaultAsync();

            return employee;
        }

        public async Task<ICollection<EmployeeDTO>> GetEmployees()
        {
            var employees = await _db.Employees
                .Include(x => x.Rank)
                .Include(x => x.Position)
                .Include(x => x.PositionHistories)
                .Include(x => x.RankHistories)
                .AsNoTracking()
                .Select(x => (EmployeeDTO)x)
                .ToListAsync();

            return employees;
        }

        public async Task RemoveEmployee(int id)
        {
            var employee = await _db.Employees
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (employee != null)
            {
                _db.Employees.Remove(employee);
                await _db.SaveChangesAsync();
            }
        }

        public async Task UpdateEmployee(int id, EmployeeDTO employeeDTO)
        {
            var employee = await _db.Employees
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (employee == null)
            {
                throw new ArgumentException();
            }

            employee.FirstName = employeeDTO.FirstName;
            employee.MiddleName = employeeDTO.MiddleName;
            employee.LastName = employeeDTO.LastName;
            employee.Login = employeeDTO.Login;
            employee.BirthDate = employeeDTO.BirthDate;
            employee.CertificationTerm = employeeDTO.CertificationTerm;
            employee.ContractDate = employeeDTO.ContractDate;
            employee.JoinServiceDate = employeeDTO.JoinServiceDate;
            employee.Number = employeeDTO.Number;
            employee.QualificationUpdateDate = employeeDTO.QualificationUpdateDate;


            if (employee.Rank.Id != employeeDTO.Rank.Id)
            {
                var rank = await _db.Ranks.FirstOrDefaultAsync(x => x.Id == employeeDTO.Rank.Id);

                if (rank == null)
                {
                    throw new ArgumentException();
                }

                var newRankHistory = new EmployeeRankHistory
                {
                    OrderDate = employeeDTO.Rank.OrderDate,
                    AppointmentDate = employeeDTO.Rank.AppointmentDate,
                    OrderNumber = employeeDTO.Number,
                    RankTerm = employeeDTO.Rank.Term,
                    Rank = rank
                };

                employee.RankHistories.Add(newRankHistory);
            }

            if (employee.Position.Id != employeeDTO.Rank.Id)
            {
                var position = await _db.Positions.FirstOrDefaultAsync(x => x.Id == employeeDTO.Position.Id);

                if (position == null)
                {
                    throw new ArgumentException();
                }

                var newPositionHistory = new EmployeePositionHistory
                {
                    OrderDate = employeeDTO.Position.OrderDate,
                    OrderNumber = employeeDTO.Position.OrderNumber,
                    AppointmentDate = employeeDTO.Position.AppointmentDate,
                    Position = position
                };

                employee.PositionHistories.Add(newPositionHistory);
            }

            _db.Employees.Update(employee);
            await _db.SaveChangesAsync();
        }
    }
}
