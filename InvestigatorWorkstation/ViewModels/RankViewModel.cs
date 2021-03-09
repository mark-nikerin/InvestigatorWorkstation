using System.ComponentModel;
using Services.DTOs.Employee;

namespace InvestigatorWorkstation.ViewModels
{
    public class RankViewModel
    {
        [DisplayName("№")]
        public int Id { get; set; }

        [DisplayName("Звание")]
        public string Rank { get; set; }

        public static explicit operator RankViewModel(RankDTO dto)
        {
            return new RankViewModel
            {
                Id = dto.Id,
                Rank = dto.Name
            };
        }
    }
}
