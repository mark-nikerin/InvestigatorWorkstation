namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class CrimeReport : IEntity
    { 
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistratinAuthority { get; set; }
        public string Fable { get; set; }
    }
}
