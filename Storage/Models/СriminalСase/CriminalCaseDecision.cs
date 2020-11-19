namespace Storage.Models
{
    using Storage.Interfaces; 

    public class CriminalCaseDecision : IDecision
    { 
        public int Id { get; set; } 
        public string Decision { get; set; }
    }
}
