using System;

namespace Services.DTOs.Employee
{
    public class RankWithInfoDTO : RankDTO
    {
        public DateTime OrderDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int Term { get; set; }
        public int OrderNumber { get; set; }
    }
}
