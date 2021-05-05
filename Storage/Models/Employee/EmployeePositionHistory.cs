using Storage.Interfaces;
using System; 

namespace Storage.Models
{
    public class EmployeePositionHistory : IEntity
    {
        public int Id { get; set; } 
        public DateTime AppointmentDate { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }

        public int PositionId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Position Position { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
