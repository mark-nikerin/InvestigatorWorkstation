namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class CriminalCaseDecision : IDecision
    { 
        public int Id { get; set; } 
        public string Decision { get; set; }

        public virtual ICollection<CriminalCaseMovement> CriminalCaseMovements { get; set; } = new HashSet<CriminalCaseMovement>();
    }
}
