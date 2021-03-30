using System;

namespace Services.DTOs.Employee
{
    public class RankWithInfoDTO : RankDTO
    {
        public DateTime OrderDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime TermEndDate { get; set; }
        public string OrderNumber { get; set; }
    }
}
