namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class ComplicityType : IEntity
    {
        public int Id { get; set; } 
        public string Type { get; set; }

        public virtual ICollection<CriminalStatusHistory> CriminalStatusHistories { get; set; } = new HashSet<CriminalStatusHistory>();
    }
}
