﻿namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class Rank : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public virtual ICollection<EmployeeRankHistory> EmployeeRankHistories { get; set; } = new HashSet<EmployeeRankHistory>();
    }
}
