﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Storage;

namespace Storage.Migrations
{
    [DbContext(typeof(WorkstationContext))]
    [Migration("20210330221320_AddAuthorities")]
    partial class AddAuthorities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CriminalCriminalCase", b =>
                {
                    b.Property<int>("CriminalCasesId")
                        .HasColumnType("int");

                    b.Property<int>("CriminalsId")
                        .HasColumnType("int");

                    b.HasKey("CriminalCasesId", "CriminalsId");

                    b.HasIndex("CriminalsId");

                    b.ToTable("CriminalCriminalCase");
                });

            modelBuilder.Entity("Storage.Models.Authority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subdivision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("Storage.Models.ComplicityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ComplicityTypes");
                });

            modelBuilder.Entity("Storage.Models.CrimeReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Fable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationBookNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("CrimeReports");
                });

            modelBuilder.Entity("Storage.Models.Criminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActualResidence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Citizenship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriminalRecordsInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CriminalStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyComposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasCriminalRecords")
                        .HasColumnType("bit");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MilitaryAccounting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CriminalStatusId");

                    b.ToTable("Criminals");
                });

            modelBuilder.Entity("Storage.Models.CriminalCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CriminalCaseAuthorityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InitiationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CriminalCaseAuthorityId");

                    b.ToTable("CriminalCases");
                });

            modelBuilder.Entity("Storage.Models.CriminalCaseAuthority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CriminalCaseAuthorities");
                });

            modelBuilder.Entity("Storage.Models.CriminalCaseDecision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Decision")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CriminalCaseDecisions");
                });

            modelBuilder.Entity("Storage.Models.CriminalCaseMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CriminalCaseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DecisionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DecisionId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CriminalCaseId");

                    b.HasIndex("DecisionId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("CriminalCaseMovements");
                });

            modelBuilder.Entity("Storage.Models.CriminalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CriminalStatuses");
                });

            modelBuilder.Entity("Storage.Models.CriminalStatusHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ComplicityTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CriminalId")
                        .HasColumnType("int");

                    b.Property<int?>("CriminalStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComplicityTypeId");

                    b.HasIndex("CriminalId");

                    b.HasIndex("CriminalStatusId");

                    b.ToTable("CriminalStatusHistories");
                });

            modelBuilder.Entity("Storage.Models.Employee.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CertificationTerm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoinServiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("QualificationUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RankId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("RankId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Storage.Models.Employee.EmployeePositionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PositionId");

                    b.ToTable("EmployeePositionHistories");
                });

            modelBuilder.Entity("Storage.Models.Employee.EmployeeRankHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RankId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RankId");

                    b.ToTable("EmployeeRankHistories");
                });

            modelBuilder.Entity("Storage.Models.Employee.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Storage.Models.Employee.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("Storage.Models.InspectionMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("InspectionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InspectionMaterials");
                });

            modelBuilder.Entity("Storage.Models.InspectionMaterialDecision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Decision")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InspectionMaterialDecisions");
                });

            modelBuilder.Entity("Storage.Models.InspectionMaterialMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DecisionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("InspectionMaterialDecisionId")
                        .HasColumnType("int");

                    b.Property<int>("InspectionMaterialId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("InspectionMaterialDecisionId");

                    b.HasIndex("InspectionMaterialId");

                    b.ToTable("InspectionMaterialMovements");
                });

            modelBuilder.Entity("Storage.Models.InspectionPeriodExtension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DecisionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InspectionMaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InspectionMaterialId");

                    b.ToTable("InspectionPeriodExtensions");
                });

            modelBuilder.Entity("Storage.Models.InvestigationPeriodExtension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CriminalCaseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DecisionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CriminalCaseId");

                    b.ToTable("InvestigationPeriodExtensions");
                });

            modelBuilder.Entity("Storage.Models.PreventiveMeasure.PreventiveMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Measure")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PreventiveMeasures");
                });

            modelBuilder.Entity("Storage.Models.PreventiveMeasure.PreventiveMeasureDecision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CriminalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DecisionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("PreventiveMeasureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CriminalId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PreventiveMeasureId");

                    b.ToTable("PreventiveMeasureDecisions");
                });

            modelBuilder.Entity("CriminalCriminalCase", b =>
                {
                    b.HasOne("Storage.Models.CriminalCase", null)
                        .WithMany()
                        .HasForeignKey("CriminalCasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Storage.Models.Criminal", null)
                        .WithMany()
                        .HasForeignKey("CriminalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Storage.Models.CrimeReport", b =>
                {
                    b.HasOne("Storage.Models.Employee.Employee", "Employee")
                        .WithMany("CrimeReports")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Storage.Models.Criminal", b =>
                {
                    b.HasOne("Storage.Models.CriminalStatus", "CriminalStatus")
                        .WithMany("Criminals")
                        .HasForeignKey("CriminalStatusId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("CriminalStatus");
                });

            modelBuilder.Entity("Storage.Models.CriminalCase", b =>
                {
                    b.HasOne("Storage.Models.CriminalCaseAuthority", "CriminalCaseAuthority")
                        .WithMany("CriminalCases")
                        .HasForeignKey("CriminalCaseAuthorityId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("CriminalCaseAuthority");
                });

            modelBuilder.Entity("Storage.Models.CriminalCaseMovement", b =>
                {
                    b.HasOne("Storage.Models.CriminalCase", "CriminalCase")
                        .WithMany("CriminalCaseMovements")
                        .HasForeignKey("CriminalCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Storage.Models.CriminalCaseDecision", "Decision")
                        .WithMany("CriminalCaseMovements")
                        .HasForeignKey("DecisionId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Storage.Models.Employee.Employee", "Employee")
                        .WithMany("CriminalCaseMovements")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("CriminalCase");

                    b.Navigation("Decision");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Storage.Models.CriminalStatusHistory", b =>
                {
                    b.HasOne("Storage.Models.ComplicityType", "ComplicityType")
                        .WithMany("CriminalStatusHistories")
                        .HasForeignKey("ComplicityTypeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Storage.Models.Criminal", "Criminal")
                        .WithMany("CriminalStatusHistories")
                        .HasForeignKey("CriminalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Storage.Models.CriminalStatus", "CriminalStatus")
                        .WithMany("CriminalStatusHistories")
                        .HasForeignKey("CriminalStatusId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ComplicityType");

                    b.Navigation("Criminal");

                    b.Navigation("CriminalStatus");
                });

            modelBuilder.Entity("Storage.Models.Employee.Employee", b =>
                {
                    b.HasOne("Storage.Models.Employee.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Storage.Models.Employee.Rank", "Rank")
                        .WithMany("Employees")
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Position");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("Storage.Models.Employee.EmployeePositionHistory", b =>
                {
                    b.HasOne("Storage.Models.Employee.Employee", "Employee")
                        .WithMany("PositionHistories")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Storage.Models.Employee.Position", "Position")
                        .WithMany("EmployeePositionHistories")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Storage.Models.Employee.EmployeeRankHistory", b =>
                {
                    b.HasOne("Storage.Models.Employee.Employee", "Employee")
                        .WithMany("RankHistories")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Storage.Models.Employee.Rank", "Rank")
                        .WithMany("EmployeeRankHistories")
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("Storage.Models.InspectionMaterialMovement", b =>
                {
                    b.HasOne("Storage.Models.Employee.Employee", "Employee")
                        .WithMany("InspectionMaterialMovements")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Storage.Models.InspectionMaterialDecision", "InspectionMaterialDecision")
                        .WithMany("InspectionMaterialMovements")
                        .HasForeignKey("InspectionMaterialDecisionId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Storage.Models.InspectionMaterial", "InspectionMaterial")
                        .WithMany("InspectionMaterialMovements")
                        .HasForeignKey("InspectionMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("InspectionMaterial");

                    b.Navigation("InspectionMaterialDecision");
                });

            modelBuilder.Entity("Storage.Models.InspectionPeriodExtension", b =>
                {
                    b.HasOne("Storage.Models.InspectionMaterial", "InspectionMaterial")
                        .WithMany("InspectionPeriodExtensions")
                        .HasForeignKey("InspectionMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InspectionMaterial");
                });

            modelBuilder.Entity("Storage.Models.InvestigationPeriodExtension", b =>
                {
                    b.HasOne("Storage.Models.CriminalCase", "CriminalCase")
                        .WithMany("InvestigationPeriodExtensions")
                        .HasForeignKey("CriminalCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CriminalCase");
                });

            modelBuilder.Entity("Storage.Models.PreventiveMeasure.PreventiveMeasureDecision", b =>
                {
                    b.HasOne("Storage.Models.Criminal", "Criminal")
                        .WithMany("PreventiveMeasureDecisions")
                        .HasForeignKey("CriminalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Storage.Models.Employee.Employee", "Employee")
                        .WithMany("PreventiveMeasureDecisions")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Storage.Models.PreventiveMeasure.PreventiveMeasure", "PreventiveMeasure")
                        .WithMany("PreventiveMeasureDecisions")
                        .HasForeignKey("PreventiveMeasureId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Criminal");

                    b.Navigation("Employee");

                    b.Navigation("PreventiveMeasure");
                });

            modelBuilder.Entity("Storage.Models.ComplicityType", b =>
                {
                    b.Navigation("CriminalStatusHistories");
                });

            modelBuilder.Entity("Storage.Models.Criminal", b =>
                {
                    b.Navigation("CriminalStatusHistories");

                    b.Navigation("PreventiveMeasureDecisions");
                });

            modelBuilder.Entity("Storage.Models.CriminalCase", b =>
                {
                    b.Navigation("CriminalCaseMovements");

                    b.Navigation("InvestigationPeriodExtensions");
                });

            modelBuilder.Entity("Storage.Models.CriminalCaseAuthority", b =>
                {
                    b.Navigation("CriminalCases");
                });

            modelBuilder.Entity("Storage.Models.CriminalCaseDecision", b =>
                {
                    b.Navigation("CriminalCaseMovements");
                });

            modelBuilder.Entity("Storage.Models.CriminalStatus", b =>
                {
                    b.Navigation("Criminals");

                    b.Navigation("CriminalStatusHistories");
                });

            modelBuilder.Entity("Storage.Models.Employee.Employee", b =>
                {
                    b.Navigation("CrimeReports");

                    b.Navigation("CriminalCaseMovements");

                    b.Navigation("InspectionMaterialMovements");

                    b.Navigation("PositionHistories");

                    b.Navigation("PreventiveMeasureDecisions");

                    b.Navigation("RankHistories");
                });

            modelBuilder.Entity("Storage.Models.Employee.Position", b =>
                {
                    b.Navigation("EmployeePositionHistories");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Storage.Models.Employee.Rank", b =>
                {
                    b.Navigation("EmployeeRankHistories");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Storage.Models.InspectionMaterial", b =>
                {
                    b.Navigation("InspectionMaterialMovements");

                    b.Navigation("InspectionPeriodExtensions");
                });

            modelBuilder.Entity("Storage.Models.InspectionMaterialDecision", b =>
                {
                    b.Navigation("InspectionMaterialMovements");
                });

            modelBuilder.Entity("Storage.Models.PreventiveMeasure.PreventiveMeasure", b =>
                {
                    b.Navigation("PreventiveMeasureDecisions");
                });
#pragma warning restore 612, 618
        }
    }
}
