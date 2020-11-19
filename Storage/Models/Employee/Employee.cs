namespace Storage.Models
{
    using Storage.Interfaces;
    using System; 

    public class Employee : IEntity
    { 
        public int Id { get; set; } 
        public string FirstName { get; set; } 
        public string MiddleName { get; set; } 
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime EndWorkDate { get; set; }
        public DateTime StartWorkSODate { get; set; } 
        public string ReasonOfEndWork { get; set; }
        public int RankId { get; set; }
        public int PositionId { get; set; }
    }
}
