using Storage.Interfaces;
using System.Collections.Generic;

namespace Storage.Models
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public virtual ICollection<EmployeePositionHistory> EmployeePositionHistories { get; set; } = new HashSet<EmployeePositionHistory>();
    }
}
