using System.ComponentModel;
using Services.DTOs;

namespace InvestigatorWorkstation.ViewModels
{
    public class AuthorityViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Title { get; set; }
        [DisplayName("Подразделение")]
        public string Subdivision { get; set; }
        [DisplayName("Телефон")]
        public string PhoneNumber { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }

        public static explicit operator AuthorityViewModel(AuthorityDTO dto) => new AuthorityViewModel
        {
            Id = dto.Id,
            Title = dto.Title,
            Address = dto.Address,
            PhoneNumber = dto.PhoneNumber,
            Subdivision = dto.Subdivision
        };
    }
}
