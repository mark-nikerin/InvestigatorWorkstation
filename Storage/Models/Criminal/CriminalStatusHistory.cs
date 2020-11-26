namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class CriminalStatusHistory : IEntity
    {
        public int Id { get; set; } 
        public DateTime ChangeDate { get; set; } 
        public int QualificationId { get; set; }
        public int ComplicityTypeId { get; set; }
        public int CriminalId { get; set; }
        public int CriminalStatusId { get; set; }

        public virtual Qualification Qualification { get; set; }
        public virtual ComplicityType ComplicityType { get; set; }
        public virtual Criminal Criminal { get; set; }
        public virtual CriminalStatus CriminalStatus { get; set; }
    }
}
