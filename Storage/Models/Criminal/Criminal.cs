namespace Storage.Models
{
    using Storage.Interfaces;
    using Storage.Models.PreventiveMeasure;
    using System;
    using System.Collections.Generic;

    public class Criminal : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Citizenship { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PlaceOfRegistration { get; set; }
        public string ActualResidence { get; set; }
        public string MaritalStatus { get; set; }
        public string FamilyComposition { get; set; }
        public string Education { get; set; }
        public string Job { get; set; }
        public string MilitaryAccounting { get; set; }
        public bool HasCriminalRecords { get; set; }
        public string CriminalRecordsInfo { get; set; }  
        public int? CriminalStatusId { get; set; }

        public virtual ICollection<CriminalCase> CriminalCases { get; set; } = new HashSet<CriminalCase>();
        public virtual ICollection<PreventiveMeasureDecision> PreventiveMeasureDecisions { get; set; } = new HashSet<PreventiveMeasureDecision>();
        public virtual ICollection<CriminalStatusHistory> CriminalStatusHistories { get; set; } = new HashSet<CriminalStatusHistory>();
        public virtual CriminalStatus CriminalStatus { get; set; }
    }
}
