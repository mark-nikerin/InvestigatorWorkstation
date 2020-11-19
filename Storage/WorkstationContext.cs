namespace Storage
{
    using Microsoft.EntityFrameworkCore;
    using Storage.Models;

    public class WorkstationContext : DbContext
    {
        public const string AppSchema = "app";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public WorkstationContext(DbContextOptions<WorkstationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeePosition> Positions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
