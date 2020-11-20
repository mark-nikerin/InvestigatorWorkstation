namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class EmployeePosition : IEntity
    { 
        public int Id { get; set; }
        public string Position { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
