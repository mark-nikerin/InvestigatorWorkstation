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
        public string FirstName { get; set; } 
        public string MiddleName { get; set; } 
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime EndWorkDate { get; set; }
        public DateTime StartWorkSODate { get; set; } 
        public string ReasonOfEndWork { get; set; }
        public int RankId { get; set; }
        public int PositionId { get; set; }

        public virtual EmployeeRank Rank { get; set; }
        public virtual EmployeePosition Position { get; set; }
        public virtual ICollection<InspectionMaterialMovement> InspectionMaterialMovements { get; set; } = new HashSet<InspectionMaterialMovement>();
        public virtual ICollection<CriminalCaseMovement> CriminalCaseMovements { get; set; } = new HashSet<CriminalCaseMovement>();
        public virtual ICollection<PreventiveMeasureDecision> PreventiveMeasureDecisions { get; set; } = new HashSet<PreventiveMeasureDecision>();
        public virtual ICollection<CrimeReport> CrimeReports { get; set; } = new HashSet<CrimeReport>();

    }
}
