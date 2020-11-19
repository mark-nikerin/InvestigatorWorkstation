namespace Storage.Models
{
    using Storage.Interfaces; 

    public class EmployeePosition : IEntity
    { 
        public int Id { get; set; }
        public string Position { get; set; }   
    }
}
