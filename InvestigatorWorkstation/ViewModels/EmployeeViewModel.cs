namespace InvestigatorWorkstation.ViewModels
{
    using System;
    using System.ComponentModel;
    using Services.DTOs.Employee;

    public class EmployeeViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Логин")]
        public string Login { get; set; }

        [DisplayName("Администратор")]
        public bool IsAdmin { get; set; }

        [DisplayName("ФИО")]
        public string FullName { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Дата контракта")]
        public DateTime ContractDate { get; set; }

        [DisplayName("Дата повышения квалификации")]
        public DateTime QualificationUpdateDate { get; set; }

        [DisplayName("Срок аттестации")]
        public DateTime CertificationTerm { get; set; }

        [DisplayName("Дата поступления на службу")]
        public DateTime JoinServiceDate { get; set; }

        [DisplayName("Личный номер")]
        public string Number { get; set; }

        [DisplayName("Должность")]
        public string Position { get; set; }

        [DisplayName("Звание")]
        public string Rank { get; set; }

        public static explicit operator EmployeeViewModel(EmployeeDTO dto) => new EmployeeViewModel
        {
            Id = dto.Id,
            Login = dto.Login,
            IsAdmin = dto.IsAdmin,
            FullName = $"{dto.LastName} {dto.FirstName?[0]}.{dto.MiddleName?[0]}",
            BirthDate = dto.BirthDate,
            ContractDate = dto.ContractDate,
            QualificationUpdateDate = dto.QualificationUpdateDate,
            CertificationTerm = dto.CertificationTerm,
            JoinServiceDate = dto.JoinServiceDate,
            Number = dto.Number,
            Position = dto.Position.Name,
            Rank = dto.Rank.Name
        };
    }
}
