namespace Services.DTOs.Employee
{
    using System;

    public class RankDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int Term { get; set; }
        public int OrderNumber { get; set; }
    }
}
