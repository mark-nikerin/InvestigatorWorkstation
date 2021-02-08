namespace Storage.Models
{
    using Storage.Interfaces;
    using System;
    using System.Collections.Generic;

    public class CriminalCase : IEntity
    { 
        public int Id { get; set; }
        public DateTime InitiationDate { get; set; }
        public int? QualificationId { get; set; }
        public int? CriminalCaseAuthorityId { get; set; }

        public virtual Qualification Qualification { get; set; }
        public virtual CriminalCaseAuthority CriminalCaseAuthority { get; set; }

        public virtual ICollection<CriminalCaseMovement> CriminalCaseMovements { get; set; } = new HashSet<CriminalCaseMovement>();
        public virtual ICollection<InvestigationPeriodExtension> InvestigationPeriodExtensions { get; set; } = new HashSet<InvestigationPeriodExtension>();
        public virtual ICollection<Criminal> Criminals { get; set; } = new HashSet<Criminal>();
    }
}
