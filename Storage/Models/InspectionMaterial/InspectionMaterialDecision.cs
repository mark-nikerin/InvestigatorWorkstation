namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class InspectionMaterialDecision : IDecision
    { 
        public int Id { get; set; } 
        public string Decision { get; set; }

        public virtual ICollection<InspectionMaterialMovement> InspectionMaterialMovements { get; set; } = new HashSet<InspectionMaterialMovement>();
    }
}
