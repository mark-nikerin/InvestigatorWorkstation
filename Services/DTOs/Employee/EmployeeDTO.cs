using System;

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
        public DateTime BirthDate { get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime QualificationUpdateDate { get; set; }
        public DateTime CertificationTerm { get; set; }
        public DateTime JoinServiceDate { get; set; }
        public int Number { get; set; }

        public PositionDTO Position { get; set; }
        public RankDTO Rank { get; set; }

        public static explicit operator EmployeeDTO(Storage.Models.Employee entity)
        {
            return new EmployeeDTO
            {
                Id = entity.Id,
                Login = entity.Login,
                Password = entity.Password,
                IsAdmin = entity.IsAdmin,
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                BirthDate = entity.BirthDate,
                ContractDate = entity.ContractDate,
                QualificationUpdateDate = entity.QualificationUpdateDate,
                CertificationTerm = entity.CertificationTerm,
                JoinServiceDate = entity.JoinServiceDate,
                Number = entity.Number,
                Position = new PositionDTO
                {
                    Id = entity.PositionId,
                    Name = entity.Position.Name,
                    AppointmentDate = entity.Position.AppointmentDate,
                    OrderDate = entity.Position.OrderDate,
                    OrderNumber = entity.Position.OrderNumber
                },
                Rank = new RankDTO
                {
                    Id = entity.RankId,
                    Name = entity.Rank.Name,
                    AppointmentDate = entity.Rank.AppointmentDate,
                    OrderDate = entity.Rank.OrderDate,
                    OrderNumber = entity.Rank.OrderNumber,
                    Term = entity.Rank.RankTerm
                }
            };
        }
    }
}
