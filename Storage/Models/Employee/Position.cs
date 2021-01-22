namespace Storage.Models
{
    using Storage.Interfaces;
    using System;
    using System.Collections.Generic;

    public class Position : IEntity
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
