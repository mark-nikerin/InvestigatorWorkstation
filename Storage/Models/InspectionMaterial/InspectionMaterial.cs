namespace Storage.Models
{
    using Storage.Interfaces;
    using System;
    using System.Collections.Generic;

    public class InspectionMaterial : IEntity
    { 
        public int Id { get; set; }
        public DateTime InspectionDate { get; set; }
        public int? QualificationId { get; set; }

        public Qualification Qualification { get; set; }
        public virtual ICollection<InspectionMaterialMovement> InspectionMaterialMovements { get; set; } = new HashSet<InspectionMaterialMovement>();
        public virtual ICollection<InspectionPeriodExtension> InspectionPeriodExtensions { get; set; } = new HashSet<InspectionPeriodExtension>();
    }
}
