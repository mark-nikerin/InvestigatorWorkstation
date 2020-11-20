namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class EmployeeRank : IEntity
    { 
        public int Id { get; set; }
        public string Rank { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
