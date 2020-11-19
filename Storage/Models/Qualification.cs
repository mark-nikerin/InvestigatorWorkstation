namespace Storage.Models
{
    using Storage.Interfaces; 

    public class Qualification : IEntity
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
