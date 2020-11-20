namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class CriminalStatusHistory : IEntity
    {
        public int Id { get; set; } 
        public DateTime ChangeDate { get; set; } 
        public int QualificationId { get; set; }

        public Qualification Qualification { get; set; }
    }
}
