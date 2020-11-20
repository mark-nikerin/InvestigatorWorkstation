namespace Storage.Models
{
    using Storage.Interfaces; 

    public class Complicity : IEntity
    {
        public int Id { get; set; } 
        public string Type { get; set; } 
    }
}
