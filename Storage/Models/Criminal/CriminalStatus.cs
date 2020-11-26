﻿namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class CriminalStatus : IEntity
    {
        public int Id { get; set; }
        public string Status { get; set; } 

        public virtual ICollection<Criminal> Criminals { get; set; } = new HashSet<Criminal>();
        public virtual ICollection<CriminalStatusHistory> CriminalStatusHistories { get; set; } = new HashSet<CriminalStatusHistory>();
    }
}
