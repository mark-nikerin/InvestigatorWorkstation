using System;
using Services.DTOs.Employee;

namespace Services.DTOs.CrimeReport
{
    public class CrimeReportDTO
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationAuthority { get; set; }
        public string RegistrationNumber { get; set; }
        public string RegistrationBookNumber { get; set; }
        public string Fable { get; set; }
        public string Qualification { get; set; }
        public virtual EmployeeDTO Employee { get; set; }

        public static explicit operator CrimeReportDTO(Storage.Models.CrimeReport entity)
        {
            return new CrimeReportDTO
            {
                Id = entity.Id,
                RegistrationDate = entity.RegistrationDate,
                RegistrationAuthority = entity.RegistrationAuthority,
                RegistrationBookNumber = entity.RegistrationBookNumber,
                RegistrationNumber = entity.RegistrationNumber,
                Fable = entity.Fable,
                Employee = (EmployeeDTO)entity.Employee,
                Qualification = entity.Qualification
            };
        }
    }
}
