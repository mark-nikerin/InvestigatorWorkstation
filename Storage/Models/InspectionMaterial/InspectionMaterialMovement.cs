namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class InspectionMaterialMovement : IMovement
    { 
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public string Note { get; set; }
    }
}
