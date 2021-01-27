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
    }
}
