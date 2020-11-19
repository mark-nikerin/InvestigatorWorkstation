namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class CriminalCase : IEntity
    { 
        public int Id { get; set; }
        public DateTime InitiationDate { get; set; }
    }
}
