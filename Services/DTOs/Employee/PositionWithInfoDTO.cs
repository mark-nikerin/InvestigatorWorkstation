using System;

namespace Services.DTOs.Employee
{
    public class PositionWithInfoDTO : PositionDTO
    {
        public DateTime OrderDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int OrderNumber { get; set; }
    }
}
