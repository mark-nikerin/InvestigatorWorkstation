using Storage.Interfaces;
using System;

namespace Storage.Models
{
    public class CrimeReport : IEntity
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; } 
        public DateTime DueDate { get; set; } 
        public string RegistrationNumber { get; set; }
        public string RegistrationBookNumber { get; set; }
        public string Fable { get; set; }
        public string Qualification { get; set; }
        public int? EmployeeId { get; set; }
        public int? AuthorityId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Authority Authority { get; set; }
    }
}
