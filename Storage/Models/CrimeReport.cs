﻿using Storage.Interfaces;
using System;

namespace Storage.Models
{  
    public class CrimeReport : IEntity
    { 
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistratinAuthority { get; set; }
        public string Fable { get; set; }
        public int? EmployeeId { get; set; }
        public int? QualificationId { get; set; }

        public virtual Employee.Employee Employee { get; set; }
        public virtual Qualification Qualification { get; set; }
    }
}
