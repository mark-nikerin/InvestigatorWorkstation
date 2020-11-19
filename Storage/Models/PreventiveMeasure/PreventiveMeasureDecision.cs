namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class PreventiveMeasureDecision : IEntity
    { 
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
    }
}
