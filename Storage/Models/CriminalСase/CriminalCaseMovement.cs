using Storage.Interfaces;
using System;
using Storage.Models;

namespace Storage.Models
{
    public class CriminalCaseMovement : IMovement
    { 
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public string Note { get; set; }
        public int? EmployeeId { get; set; }
        public int? DecisionId { get; set; }
        public int CriminalCaseId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual CriminalCaseDecision Decision { get; set; }
        public virtual CriminalCase CriminalCase { get; set; }
    }
}
