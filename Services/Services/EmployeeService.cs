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
                    Id = employeeDTO.Rank.Id,
                    Name = employeeDTO.Rank.Name,
                    OrderDate = employeeDTO.Rank.OrderDate,
                    AppointmentDate = employeeDTO.Rank.AppointmentDate,
                    OrderNumber = employeeDTO.Number,
                    RankTerm = employeeDTO.Rank.Term
                },
                Position = new Position
                {
                    Id = employeeDTO.Position.Id,
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

        public async Task<ICollection<EmployeeDTO>> GetEmployees()
        {
            var employees = await _db.Employees
                .Include(x => x.Rank)
                .Include(x => x.Position)
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

            var updatedEmployee = new Employee
            {
                Id = id,
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
                    Id = employeeDTO.Rank.Id,
                    Name = employeeDTO.Rank.Name,
                    OrderDate = employeeDTO.Rank.OrderDate,
                    AppointmentDate = employeeDTO.Rank.AppointmentDate,
                    OrderNumber = employeeDTO.Number,
                    RankTerm = employeeDTO.Rank.Term
                },
                Position = new Position
                {
                    Id = employeeDTO.Position.Id,
                    Name = employeeDTO.Position.Name,
                    OrderDate = employeeDTO.Position.OrderDate,
                    OrderNumber = employeeDTO.Position.OrderNumber,
                    AppointmentDate = employeeDTO.Position.AppointmentDate
                },
            };

            _db.Attach(updatedEmployee);
            await _db.SaveChangesAsync();
        }
    }
}
