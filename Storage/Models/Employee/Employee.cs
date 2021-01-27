namespace Storage.Models
{
    using Storage.Interfaces;
    using System;
    using System.Collections.Generic;

    public class Employee : IEntity
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
        public int RankId { get; set; }
        public int PositionId { get; set; }

        public virtual Rank Rank { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<InspectionMaterialMovement> InspectionMaterialMovements { get; set; } = new HashSet<InspectionMaterialMovement>();
        public virtual ICollection<CriminalCaseMovement> CriminalCaseMovements { get; set; } = new HashSet<CriminalCaseMovement>();
        public virtual ICollection<PreventiveMeasureDecision> PreventiveMeasureDecisions { get; set; } = new HashSet<PreventiveMeasureDecision>();
        public virtual ICollection<CrimeReport> CrimeReports { get; set; } = new HashSet<CrimeReport>();

    }
}
