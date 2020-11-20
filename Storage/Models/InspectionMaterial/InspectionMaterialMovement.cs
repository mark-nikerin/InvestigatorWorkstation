namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class InspectionMaterialMovement : IMovement
    { 
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public string Note { get; set; } 
        public int EmployeeId { get; set; }
        public int InspectionMaterialId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual InspectionMaterial InspectionMaterial { get; set; }
    }
}
