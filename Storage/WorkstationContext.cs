using Microsoft.EntityFrameworkCore;
using Storage.Models;
using Storage.Configurations;
using Storage.Configurations.Criminal;
using Storage.Configurations.CriminalCase;
using Storage.Configurations.Employee;
using Storage.Configurations.InspectionMaterial;
using Storage.Configurations.PreventiveMeasure;
using Storage.Models.Employee;
using Storage.Models.PreventiveMeasure;

namespace Storage
{
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
        public virtual DbSet<ComplicityType> ComplicityTypes { get; set; } = null!;
        #endregion
        #region CriminalCase
        public virtual DbSet<CriminalCase> CriminalCases { get; set; } = null!;
        public virtual DbSet<CriminalCaseAuthority> CriminalCaseAuthorities { get; set; } = null!;
        public virtual DbSet<CriminalCaseDecision> CriminalCaseDecisions { get; set; } = null!;
        public virtual DbSet<CriminalCaseMovement> CriminalCaseMovements { get; set; } = null!;
        public virtual DbSet<InvestigationPeriodExtension> InvestigationPeriodExtensions { get; set; } = null!;
        #endregion
        #region Employee
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;
        public virtual DbSet<Rank> Ranks { get; set; } = null!;
        public virtual DbSet<EmployeePositionHistory> EmployeePositionHistories { get; set; } = null!;
        public virtual DbSet<EmployeeRankHistory> EmployeeRankHistories { get; set; } = null!; 
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
        public virtual DbSet<CrimeReport> CrimeReports { get; set; } = null!;
        public virtual DbSet<Authority> Authorities { get; set; } = null!;
         
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=.\\SQLExpress;Database=WorkstationDB;Trusted_Connection=True;",
                x => x.MigrationsHistoryTable("__WorkstationMigrationHistory"));

       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region CriminalConfigurations
            modelBuilder.ApplyConfiguration(new CriminalConfiguration());
            modelBuilder.ApplyConfiguration(new CriminalStatusConfiguration());
            modelBuilder.ApplyConfiguration(new CriminalStatusHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new ComplicityTypeConfiguration());
            #endregion
            #region CriminalConfigurations
            modelBuilder.ApplyConfiguration(new CriminalCaseConfiguration());
            modelBuilder.ApplyConfiguration(new CriminalCaseAuthorityConfiguration());
            modelBuilder.ApplyConfiguration(new CriminalCaseDecisionConfiguration());
            modelBuilder.ApplyConfiguration(new CriminalCaseMovementConfiguration());
            modelBuilder.ApplyConfiguration(new InvestigationPeriodExtensionConfiguration());
            #endregion
            #region EmployeeConfigurations
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new RankConfiguration());
            #endregion
            #region InspectionMaterialConfigurations
            modelBuilder.ApplyConfiguration(new InspectionMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new InspectionMaterialDecisionConfiguration());
            modelBuilder.ApplyConfiguration(new InspectionMaterialMovementConfiguration());
            modelBuilder.ApplyConfiguration(new InspectionPeriodExtensionConfiguration());
            #endregion PreventiveMeasureExtensions 
            #region PreventiveMeasureConfiguration
            modelBuilder.ApplyConfiguration(new PreventiveMeasureConfiguration());
            modelBuilder.ApplyConfiguration(new PreventiveMeasureDecisionConfiguration());
            #endregion
            modelBuilder.ApplyConfiguration(new CrimeReportConfiguration());
        }
    }
}
