namespace Storage.Models
{
    using Storage.Interfaces; 

    public class EmployeeRank : IEntity
    { 
        public int Id { get; set; }
        public string Rank { get; set; }
    }
}
