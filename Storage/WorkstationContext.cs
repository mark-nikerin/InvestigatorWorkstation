namespace Storage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Storage.Models;
    using System.Diagnostics;

    public class WorkstationContext : DbContext
    {  
        public WorkstationContext()
        {
        } 
         
        public WorkstationContext(DbContextOptions<WorkstationContext> options) : base(options)
        { 
        }

        #region Criminal
        public virtual DbSet<Criminal> Criminals { get; set; } = null!;
        public virtual DbSet<CriminalStatus> CriminalStatuses { get; set; } = null!;
        public virtual DbSet<CriminalStatusHistory> CriminalStatusHistories { get; set; } = null!;
        public virtual DbSet<Complicity> Complicities { get; set; } = null!;
        #endregion
        #region Employee
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeePosition> EmployeePositions { get; set; } = null!;
        public virtual DbSet<EmployeeRank> EmployeeRanks { get; set; } = null!;
        #endregion
        #region InspectionMaterial
        public virtual DbSet<InspectionMaterial> InspectionMaterials { get; set; } = null!;
        public virtual DbSet<InspectionMaterialDecision> InspectionMaterialDecisions { get; set; } = null!;
        public virtual DbSet<InspectionMaterialMovement> InspectionMaterialMovements { get; set; } = null!;
        public virtual DbSet<InspectionPeriodExtension> InspectionPeriodExtensions { get; set; } = null!;
        #endregion
        #region PreventiveMeasure
        public virtual DbSet<PreventiveMeasure> PreventiveMeasures { get; set; } = null!;
        public virtual DbSet<PreventiveMeasureDecision> PreventiveMeasureDecisions { get; set; } = null!;
        #endregion
        #region CriminalCase
        public virtual DbSet<CriminalCase> CriminalCases { get; set; } = null!;
        public virtual DbSet<CriminalCaseAuthority> CriminalCaseAuthorities { get; set; } = null!;
        public virtual DbSet<CriminalCaseDecision> CriminalCaseDecisions { get; set; } = null!;
        public virtual DbSet<CriminalCaseMovement> CriminalCaseMovements { get; set; } = null!;
        public virtual DbSet<InvestigationPeriodExtension> InvestigationPeriodExtensions { get; set; } = null!;
        #endregion
        public virtual DbSet<CrimeReport> CrimeReports { get; set; } = null!;
        public virtual DbSet<Qualification> Qualifications { get; set; } = null!;
         
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=WorkstationDB;Trusted_Connection=True;", x => x.MigrationsHistoryTable("__WorkstationMigrationHistory"));
            builder.LogTo(message => Debug.WriteLine(message), LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
