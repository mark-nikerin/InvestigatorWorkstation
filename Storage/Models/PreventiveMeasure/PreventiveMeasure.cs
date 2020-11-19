namespace Storage.Models
{
    using Storage.Interfaces; 

    public class PreventiveMeasure : IEntity
    { 
        public int Id { get; set; }
        public string Measure { get; set; }
    }
}
