namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class InvestigationPeriodExtension : IPeriodExtension
    {
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CriminalCaseId { get; set; }

        public virtual CriminalCase CriminalCase { get; set; }
    }
}
