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

        [DisplayName("Дата и время регистрации")]
        public DateTime RegistrationDate { get; set; }

        [DisplayName("Орган регистрации")]
        public string Authority { get; set; }

        [DisplayName("Номер рег. книги")]
        public string RegistrationBookNumber { get; set; }

        [DisplayName("Квалификации")]
        public string Qualification { get; set; }

        [DisplayName("Следователь")]
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
            Authority = dto.Authority.Title,
            Employee = $"{dto.Employee?.LastName} {dto.Employee?.FirstName[0]}. {dto.Employee?.MiddleName[0]}.",
            RegistrationDate = dto.RegistrationDate
        };
    }
}
