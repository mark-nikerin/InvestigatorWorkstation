using Storage.Interfaces;
using Storage.Models;
using System;

namespace Storage.Models.PreventiveMeasure
{
    public class PreventiveMeasureDecision : IEntity
    {
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? PreventiveMeasureId { get; set; }
        public int CriminalId { get; set; }

        public virtual Employee.Employee Employee { get; set; }
        public virtual PreventiveMeasure PreventiveMeasure { get; set; }
        public virtual Criminal Criminal { get; set; }
    }
}
