using Storage.Interfaces; 
using System;

namespace Storage.Models
{
    public class InspectionMaterialMovement : IMovement
    { 
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public string Note { get; set; } 
        public int? EmployeeId { get; set; }
        public int InspectionMaterialId { get; set; }
        public int? InspectionMaterialDecisionId { get; set; }

        public virtual Employee.Employee Employee { get; set; }
        public virtual InspectionMaterial InspectionMaterial { get; set; }
        public virtual InspectionMaterialDecision InspectionMaterialDecision { get; set; }
    }
}
