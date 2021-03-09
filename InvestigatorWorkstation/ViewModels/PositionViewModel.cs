using System.ComponentModel; 
using Services.DTOs.Employee;

namespace InvestigatorWorkstation.ViewModels
{
    public class PositionViewModel
    {
        [DisplayName("№")]
        public int Id { get; set; }

        [DisplayName("Должность")]
        public string Position { get; set; }

        public static explicit operator PositionViewModel(PositionDTO dto)
        {
            return new PositionViewModel
            {
                Id = dto.Id,
                Position = dto.Name
            };
        }
    }
}
