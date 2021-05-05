using System;
using System.Linq;

namespace Services.DTOs.Employee
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; } 
        public bool IsAdmin { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime QualificationUpdateDate { get; set; }
        public DateTime CertificationTerm { get; set; }
        public DateTime JoinServiceDate { get; set; }
        public string Number { get; set; }

        public PositionWithInfoDTO Position { get; set; }
        public RankWithInfoDTO Rank { get; set; }

        public static explicit operator EmployeeDTO(Storage.Models.Employee entity)
        {
            if (entity is null)
            {
                return null;
            }

            var positionHistory = entity.PositionHistories.FirstOrDefault(x => x.PositionId == entity.PositionId);
            var rankHistory = entity.RankHistories.FirstOrDefault(x => x.RankId == entity.RankId);

            var employeePosition = positionHistory == null
                ? new PositionWithInfoDTO
                {
                    Id = entity.PositionId.GetValueOrDefault(),
                    Name = entity.Position?.Name
                }
                : new PositionWithInfoDTO
                {
                    Id = entity.PositionId.GetValueOrDefault(),
                    Name = entity.Position?.Name,
                    AppointmentDate = positionHistory.AppointmentDate,
                    OrderDate = positionHistory.OrderDate,
                    OrderNumber = positionHistory.OrderNumber
                };

            var employeeRank = rankHistory == null
                ? new RankWithInfoDTO
                {
                    Id = entity.RankId.GetValueOrDefault(),
                    Name = entity.Rank?.Name,
                    Term = entity.Rank?.Term ?? 0
                }
                : new RankWithInfoDTO
                {
                    Id = entity.RankId.GetValueOrDefault(),
                    Name = entity.Rank?.Name,
                    AppointmentDate = rankHistory.AppointmentDate,
                    OrderDate = rankHistory.OrderDate,
                    OrderNumber = rankHistory.OrderNumber,
                    Term = entity.Rank?.Term ?? 0,
                    TermEndDate = rankHistory.AppointmentDate.AddYears(entity.Rank?.Term ?? 0)
                };

            return new EmployeeDTO
            {
                Id = entity.Id,
                Login = entity.Login,
                Password = entity.Password,
                IsAdmin = entity.IsAdmin,
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                FullName = $"{entity.LastName} {entity.FirstName[0]}. {entity.MiddleName[0]}.",
                LastName = entity.LastName,
                BirthDate = entity.BirthDate,
                ContractDate = entity.ContractDate,
                QualificationUpdateDate = entity.QualificationUpdateDate,
                CertificationTerm = entity.CertificationTerm,
                JoinServiceDate = entity.JoinServiceDate,
                Number = entity.Number,
                Position = employeePosition,
                Rank = employeeRank
            };
        }
    }
}
