namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class Qualification : IEntity
    { 
        public int Id { get; set; }
        public string Name { get; set; } 

        public virtual ICollection<CrimeReport> CrimeReports { get; set; } = new HashSet<CrimeReport>();
        public virtual ICollection<InspectionMaterial> InspectionMaterials { get; set; } = new HashSet<InspectionMaterial>();
        public virtual ICollection<CriminalCase> CriminalCases { get; set; } = new HashSet<CriminalCase>();
        public virtual ICollection<CriminalStatusHistory> CriminalStatusHistories { get; set; } = new HashSet<CriminalStatusHistory>(); 
    }
}
