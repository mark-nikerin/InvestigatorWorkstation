namespace Storage.Models
{
    using Storage.Interfaces; 

    public class CriminalStatus : IEntity
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
