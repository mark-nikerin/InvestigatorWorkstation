namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class PreventiveMeasureDecision : IEntity
    {
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public int EmployeeId { get; set; }
        public int PreventiveMeasureId { get; set; }
        public int CriminalId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual PreventiveMeasure PreventiveMeasure { get; set; }
        public virtual Criminal Criminal { get; set; }
    }
}
