namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class PreventiveMeasure : IEntity
    {
        public int Id { get; set; }
        public string Measure { get; set; }

        public virtual ICollection<PreventiveMeasureDecision> PreventiveMeasureDecisions { get; set; } = new HashSet<PreventiveMeasureDecision>();
    }
}
