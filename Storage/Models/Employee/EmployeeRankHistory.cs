namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class EmployeeRankHistory : IEntity
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int RankTerm { get; set; }

        public int RankId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Rank Rank { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
