using Services.DTOs.Employee; 
using Services.Interfaces.Employee;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Storage;
using System;
using Storage.Models.Employee;

namespace Services.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {

        private readonly WorkstationContext _db;

        public EmployeeService(WorkstationContext db)
        {
            _db = db;
        }

        public async Task AddEmployee(EmployeeDTO employeeDTO)
        {
            var rank = await _db.Ranks.FirstOrDefaultAsync(x => x.Id == employeeDTO.Rank.Id);

            if (rank == null)
                throw new ArgumentException();

            var position = await _db.Positions.FirstOrDefaultAsync(x => x.Id == employeeDTO.Position.Id);

            if (position == null)
                throw new ArgumentException();

            var employee = new Storage.Models.Employee.Employee
            {
                FirstName = employeeDTO.FirstName,
                MiddleName = employeeDTO.MiddleName,
                LastName = employeeDTO.LastName,
                Login = employeeDTO.Login, 
                IsAdmin = employeeDTO.IsAdmin,
                Password = employeeDTO.Password,
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
        }

        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            return await _db.Employees
                .AsNoTracking()
                .Include(x => x.Rank)
                .Include(x => x.Position)
                .Include(x => x.PositionHistories)
                .Include(x => x.RankHistories)
                .Where(x => x.Id == id)
                .Select(x => (EmployeeDTO)x)
                .SingleOrDefaultAsync();
        }

        public async Task<ICollection<EmployeeDTO>> GetEmployees()
        {
            return await _db.Employees
                .AsNoTracking()
                .Include(x => x.Rank)
                .Include(x => x.Position)
                .Select(x => (EmployeeDTO)x)
                .ToListAsync();
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
                .Include(x => x.Rank)
                .Include(x => x.Position)
                .Include(x => x.PositionHistories)
                .Include(x => x.RankHistories)
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (employee == null)
                throw new ArgumentException();

            employee.FirstName = employeeDTO.FirstName;
            employee.MiddleName = employeeDTO.MiddleName;
            employee.LastName = employeeDTO.LastName;
            employee.Login = employeeDTO.Login;
            employee.IsAdmin = employeeDTO.IsAdmin;
            if (!string.IsNullOrEmpty(employeeDTO.Password))
            {
                employee.Password = employeeDTO.Password;
            }
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
                    throw new ArgumentException();

                var newRankHistory = new EmployeeRankHistory
                {
                    OrderDate = employeeDTO.Rank.OrderDate,
                    AppointmentDate = employeeDTO.Rank.AppointmentDate,
                    OrderNumber = employeeDTO.Number,
                    RankTerm = employeeDTO.Rank.Term,
                    Rank = rank,
                    RankId = rank.Id
            };

                employee.RankHistories.Add(newRankHistory);
                employee.Rank = rank;
                employee.RankId = rank.Id;
            }

            if (employee.Position.Id != employeeDTO.Position.Id)
            {
                var position = await _db.Positions.FirstOrDefaultAsync(x => x.Id == employeeDTO.Position.Id);

                if (position == null)
                    throw new ArgumentException();

                var newPositionHistory = new EmployeePositionHistory
                {
                    OrderDate = employeeDTO.Position.OrderDate,
                    OrderNumber = employeeDTO.Position.OrderNumber,
                    AppointmentDate = employeeDTO.Position.AppointmentDate,
                    Position = position,
                    PositionId = position.Id
                };

                employee.PositionHistories.Add(newPositionHistory);
                employee.Position = position;
                employee.PositionId = position.Id;
            }

            _db.Employees.Update(employee);
            await _db.SaveChangesAsync();
        }
    }
}
