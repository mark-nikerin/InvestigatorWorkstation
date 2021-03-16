using System;
using System.ComponentModel;
using Services.DTOs.CrimeReport; 

namespace InvestigatorWorkstation.ViewModels
{
    public class CrimeReportViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Рег. номер")]
        public string RegistrationNumber { get; set; }

        [DisplayName("Дата регистрации")]
        public DateTime RegistrationDate { get; set; }

        [DisplayName("Орган регистрации")]
        public string RegistrationAuthority { get; set; }

        [DisplayName("Номер рег. книги")]
        public string RegistrationBookNumber { get; set; }

        [DisplayName("Квалификации")]
        public string Qualification { get; set; }

        [DisplayName("Кем получено сообщение")]
        public string Employee { get; set; }

        [DisplayName("Фабула")]
        public string Fable { get; set; }

        public static explicit operator CrimeReportViewModel(CrimeReportDTO dto) => new CrimeReportViewModel
        {
            Id = dto.Id,
            RegistrationNumber = dto.RegistrationNumber,
            RegistrationBookNumber = dto.RegistrationBookNumber,
            Qualification = dto.Qualification,
            Fable = dto.Fable,
            RegistrationAuthority = dto.RegistrationAuthority,
            Employee = dto.Employee.LastName,
            RegistrationDate = dto.RegistrationDate
        };
    }
}
