namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class InspectionMaterial : IEntity
    { 
        public int Id { get; set; }
        public DateTime InspectionDate { get; set; }
    }
}
