namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class Criminal : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Citizenship { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PlaceOfRegistration { get; set; }
        public string ActualResidence { get; set; }
        public string MaritalStatus { get; set; }
        public string FamilyComposition { get; set; }
        public bool HasCriminalRecords { get; set; }
    }
}
