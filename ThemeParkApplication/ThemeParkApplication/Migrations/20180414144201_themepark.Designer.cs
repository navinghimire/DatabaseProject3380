﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ThemeParkApplication.Models;

namespace ThemeParkApplication.Migrations
{
    [DbContext(typeof(themeparkdbContext))]
    [Migration("20180414144201_themepark")]
    partial class themepark
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Attractions", b =>
                {
                    b.Property<string>("AttractionId")
                        .HasColumnName("Attraction_ID")
                        .HasColumnType("char(9)");

                    b.Property<int?>("AgeRequirement")
                        .HasColumnName("Age_Requirement");

                    b.Property<string>("AttractionName")
                        .IsRequired()
                        .HasColumnName("Attraction_Name")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("AttractionStatus")
                        .HasColumnName("Attraction_Status");

                    b.Property<int>("AttractionType")
                        .HasColumnName("Attraction_Type");

                    b.Property<int?>("HeightRequirement")
                        .HasColumnName("Height_Requirement");

                    b.Property<string>("ManagerId")
                        .IsRequired()
                        .HasColumnName("Manager_ID")
                        .HasColumnType("char(9)");

                    b.HasKey("AttractionId");

                    b.HasIndex("AttractionName")
                        .IsUnique()
                        .HasName("UQ__Attracti__7A367D64E2AF49C3");

                    b.HasIndex("AttractionStatus");

                    b.HasIndex("AttractionType");

                    b.HasIndex("ManagerId");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.AttractionStatusTable", b =>
                {
                    b.Property<int>("AttractionStatusIndex")
                        .HasColumnName("Attraction_Status_Index");

                    b.Property<string>("AttractionStatus")
                        .IsRequired()
                        .HasColumnName("Attraction_Status")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("AttractionStatusIndex");

                    b.HasIndex("AttractionStatusIndex")
                        .IsUnique()
                        .HasName("UQ__Attracti__609D8AA99022F52B");

                    b.ToTable("Attraction_Status_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.AttractionTypeTable", b =>
                {
                    b.Property<int>("AttractionTypeIndex")
                        .HasColumnName("Attraction_Type_Index");

                    b.Property<string>("AttractionType")
                        .IsRequired()
                        .HasColumnName("Attraction_Type")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("AttractionTypeIndex");

                    b.HasIndex("AttractionTypeIndex")
                        .IsUnique()
                        .HasName("UQ__Attracti__F658F5634A188E4D");

                    b.ToTable("Attraction_Type_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Closures", b =>
                {
                    b.Property<string>("ClosureId")
                        .HasColumnName("Closure_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("AttrId")
                        .HasColumnName("Attr_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("ConcId")
                        .HasColumnName("Conc_ID")
                        .HasColumnType("char(9)");

                    b.Property<DateTime>("DateClosure")
                        .HasColumnName("Date_Closure")
                        .HasColumnType("date");

                    b.Property<string>("DurationClosure")
                        .IsRequired()
                        .HasColumnName("Duration_Closure")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<int>("Reason");

                    b.HasKey("ClosureId");

                    b.HasIndex("AttrId");

                    b.HasIndex("ConcId");

                    b.HasIndex("Reason");

                    b.ToTable("Closures");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Concessions", b =>
                {
                    b.Property<string>("ConcessionId")
                        .HasColumnName("Concession_ID")
                        .HasColumnType("char(9)");

                    b.Property<TimeSpan>("ClosingTime")
                        .HasColumnName("Closing_Time");

                    b.Property<string>("ConcessionName")
                        .IsRequired()
                        .HasColumnName("Concession_Name")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("ConcessionStatus")
                        .HasColumnName("Concession_Status");

                    b.Property<string>("ManagerId")
                        .IsRequired()
                        .HasColumnName("Manager_ID")
                        .HasColumnType("char(9)");

                    b.Property<TimeSpan>("OpeningTime")
                        .HasColumnName("Opening_Time");

                    b.Property<int>("StoreType")
                        .HasColumnName("Store_Type");

                    b.HasKey("ConcessionId");

                    b.HasIndex("ConcessionStatus");

                    b.HasIndex("ManagerId");

                    b.HasIndex("StoreType");

                    b.ToTable("Concessions");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.ConcessionStatusTable", b =>
                {
                    b.Property<int>("ConcessionStatusIndex")
                        .HasColumnName("Concession_Status_Index");

                    b.Property<string>("ConcessionStatus")
                        .IsRequired()
                        .HasColumnName("Concession_Status")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("ConcessionStatusIndex");

                    b.HasIndex("ConcessionStatusIndex")
                        .IsUnique()
                        .HasName("UQ__Concessi__2DC995F4071A2B03");

                    b.ToTable("Concession_Status_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnName("Customer_ID");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnName("Customer_First_Name")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnName("Customer_Last_Name")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<DateTime?>("LastVisited")
                        .HasColumnName("Last_Visited")
                        .HasColumnType("date");

                    b.Property<int>("NumberVisits")
                        .HasColumnName("Number_Visits");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Employees", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnName("Employee_ID")
                        .HasColumnType("char(9)");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnName("Date_Birth")
                        .HasColumnType("date");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("End_Date")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("First_Name")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<int>("JobTitle")
                        .HasColumnName("Job_Title");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("Last_Name")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("Start_Date")
                        .HasColumnType("date");

                    b.Property<string>("SupervisorId")
                        .HasColumnName("Supervisor_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("WorksAtAttr")
                        .HasColumnName("Works_AT_Attr")
                        .HasColumnType("char(9)");

                    b.Property<string>("WorksAtConc")
                        .HasColumnName("Works_At_Conc")
                        .HasColumnType("char(9)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("JobTitle");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("WorksAtAttr");

                    b.HasIndex("WorksAtConc");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.ItemTypeTable", b =>
                {
                    b.Property<int>("ItemTypeIndex")
                        .HasColumnName("Item_Type_Index");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnName("Item_Type")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("ItemTypeIndex");

                    b.HasIndex("ItemTypeIndex")
                        .IsUnique()
                        .HasName("UQ__Item_Typ__AC3804268261A328");

                    b.ToTable("Item_Type_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.JobTitleTable", b =>
                {
                    b.Property<int>("JobTitleIndex")
                        .HasColumnName("Job_Title_Index");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnName("Job_Title")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("JobTitleIndex");

                    b.HasIndex("JobTitleIndex")
                        .IsUnique()
                        .HasName("UQ__Job_Titl__3C0DD398AEA324DE");

                    b.ToTable("Job_Title_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Maintenance", b =>
                {
                    b.Property<string>("WorkOrderId")
                        .HasColumnName("Work_Order_ID")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("AttrId")
                        .HasColumnName("Attr_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("ConcId")
                        .HasColumnName("Conc_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("MaintenanceEmployeeId")
                        .IsRequired()
                        .HasColumnName("Maintenance_Employee_ID")
                        .HasColumnType("char(9)");

                    b.Property<int>("OrderType")
                        .HasColumnName("Order_Type");

                    b.Property<DateTime?>("WorkFinishDate")
                        .HasColumnName("Work_Finish_Date")
                        .HasColumnType("date");

                    b.Property<DateTime>("WorkStartDate")
                        .HasColumnName("Work_Start_Date")
                        .HasColumnType("date");

                    b.Property<int>("WorkStatus")
                        .HasColumnName("Work_Status");

                    b.HasKey("WorkOrderId");

                    b.HasIndex("AttrId");

                    b.HasIndex("ConcId");

                    b.HasIndex("MaintenanceEmployeeId");

                    b.HasIndex("OrderType");

                    b.HasIndex("WorkStatus");

                    b.ToTable("Maintenance");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Merchandise", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnName("Item_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("AttrId")
                        .HasColumnName("Attr_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("ConcId")
                        .HasColumnName("Conc_ID")
                        .HasColumnType("char(9)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnName("Item_Name")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("ItemType")
                        .HasColumnName("Item_Type");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("ItemId");

                    b.HasIndex("AttrId");

                    b.HasIndex("ConcId");

                    b.HasIndex("ItemType");

                    b.ToTable("Merchandise");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.OrderTypeTable", b =>
                {
                    b.Property<int>("OrderTypeIndex")
                        .HasColumnName("Order_Type_Index");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnName("Order_Type")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("OrderTypeIndex");

                    b.ToTable("Order_Type_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Profile", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateCreation")
                        .HasColumnName("Date_Creation")
                        .HasColumnType("date");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnName("Employee_ID")
                        .HasColumnType("char(9)");

                    b.Property<DateTime?>("LastLoggedIn")
                        .HasColumnName("Last_Logged_In")
                        .HasColumnType("date");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(88)
                        .IsUnicode(false);

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("binary(64)");

                    b.Property<bool>("Status");

                    b.HasKey("Email");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.ReasonTable", b =>
                {
                    b.Property<int>("ReasonIndex")
                        .HasColumnName("Reason_Index");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("ReasonIndex");

                    b.HasIndex("ReasonIndex")
                        .IsUnique()
                        .HasName("UQ__Reason_T__53287D49C8EFC418");

                    b.ToTable("Reason_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.StoreTypeTable", b =>
                {
                    b.Property<int>("StoreTypeIndex")
                        .HasColumnName("Store_Type_Index");

                    b.Property<string>("StoreType")
                        .IsRequired()
                        .HasColumnName("Store_Type")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("StoreTypeIndex");

                    b.HasIndex("StoreTypeIndex")
                        .IsUnique()
                        .HasName("UQ__Store_Ty__1E2EF40273004534");

                    b.ToTable("Store_Type_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Transactions", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnName("Transaction_ID")
                        .HasColumnType("char(9)");

                    b.Property<DateTime>("DateOfSale")
                        .HasColumnName("Date_Of_Sale")
                        .HasColumnType("date");

                    b.Property<int>("GuestId")
                        .HasColumnName("Guest_ID");

                    b.Property<string>("MerchId")
                        .IsRequired()
                        .HasColumnName("Merch_ID")
                        .HasColumnType("char(9)");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("SaleAmount")
                        .HasColumnName("Sale_Amount")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("SellerEmployeeId")
                        .IsRequired()
                        .HasColumnName("Seller_Employee_ID")
                        .HasColumnType("char(9)");

                    b.HasKey("TransactionId", "DateOfSale");

                    b.HasIndex("GuestId");

                    b.HasIndex("MerchId");

                    b.HasIndex("SellerEmployeeId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.WorkStatusTable", b =>
                {
                    b.Property<int>("WorkStatusIndex")
                        .HasColumnName("Work_Status_Index");

                    b.Property<string>("WorkStatus")
                        .HasColumnName("Work_Status")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.HasKey("WorkStatusIndex");

                    b.ToTable("Work_Status_Table");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Attractions", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.AttractionStatusTable", "AttractionStatusNavigation")
                        .WithMany("Attractions")
                        .HasForeignKey("AttractionStatus")
                        .HasConstraintName("FK_Attractions_Attraction_Status_Table");

                    b.HasOne("ThemeParkApplication.Models.AttractionTypeTable", "AttractionTypeNavigation")
                        .WithMany("Attractions")
                        .HasForeignKey("AttractionType")
                        .HasConstraintName("FK_Attractions_Attraction_Type_Table");

                    b.HasOne("ThemeParkApplication.Models.Employees", "Manager")
                        .WithMany("Attractions")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK_Attractions_Employees");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Closures", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.Attractions", "Attr")
                        .WithMany("Closures")
                        .HasForeignKey("AttrId")
                        .HasConstraintName("FK_Closures_Attractions");

                    b.HasOne("ThemeParkApplication.Models.Concessions", "Conc")
                        .WithMany("Closures")
                        .HasForeignKey("ConcId")
                        .HasConstraintName("FK_Closures_Concessions");

                    b.HasOne("ThemeParkApplication.Models.ReasonTable", "ReasonNavigation")
                        .WithMany("Closures")
                        .HasForeignKey("Reason")
                        .HasConstraintName("FK_Closures_Reason_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Concessions", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ConcessionStatusTable", "ConcessionStatusNavigation")
                        .WithMany("Concessions")
                        .HasForeignKey("ConcessionStatus")
                        .HasConstraintName("FK_Concessions_Concession_Status_Table");

                    b.HasOne("ThemeParkApplication.Models.Employees", "Manager")
                        .WithMany("Concessions")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK_Concessions_Employees");

                    b.HasOne("ThemeParkApplication.Models.StoreTypeTable", "StoreTypeNavigation")
                        .WithMany("Concessions")
                        .HasForeignKey("StoreType")
                        .HasConstraintName("FK_Concessions_Store_Type_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Employees", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.JobTitleTable", "JobTitleNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("JobTitle")
                        .HasConstraintName("FK_Employee_Job_Title_Table");

                    b.HasOne("ThemeParkApplication.Models.Employees", "Supervisor")
                        .WithMany("InverseSupervisor")
                        .HasForeignKey("SupervisorId")
                        .HasConstraintName("FK_Employess_Employess");

                    b.HasOne("ThemeParkApplication.Models.Attractions", "WorksAtAttrNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("WorksAtAttr")
                        .HasConstraintName("FK_Employess_Attractions");

                    b.HasOne("ThemeParkApplication.Models.Concessions", "WorksAtConcNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("WorksAtConc")
                        .HasConstraintName("FK_Employess_Concessions");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Maintenance", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.Attractions", "Attr")
                        .WithMany("Maintenance")
                        .HasForeignKey("AttrId")
                        .HasConstraintName("FK_Maintenance_Attractions");

                    b.HasOne("ThemeParkApplication.Models.Concessions", "Conc")
                        .WithMany("Maintenance")
                        .HasForeignKey("ConcId")
                        .HasConstraintName("FK_Maintenance_Concessions");

                    b.HasOne("ThemeParkApplication.Models.Employees", "MaintenanceEmployee")
                        .WithMany("Maintenance")
                        .HasForeignKey("MaintenanceEmployeeId")
                        .HasConstraintName("FK_Maintenance_Employees");

                    b.HasOne("ThemeParkApplication.Models.OrderTypeTable", "OrderTypeNavigation")
                        .WithMany("Maintenance")
                        .HasForeignKey("OrderType")
                        .HasConstraintName("FK_Maintenance_Order_Type_Table");

                    b.HasOne("ThemeParkApplication.Models.WorkStatusTable", "WorkStatusNavigation")
                        .WithMany("Maintenance")
                        .HasForeignKey("WorkStatus")
                        .HasConstraintName("FK_Maintenance_Work_Status_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Merchandise", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.Attractions", "Attr")
                        .WithMany("Merchandise")
                        .HasForeignKey("AttrId")
                        .HasConstraintName("FK_Merchandise_Attractions");

                    b.HasOne("ThemeParkApplication.Models.Concessions", "Conc")
                        .WithMany("Merchandise")
                        .HasForeignKey("ConcId")
                        .HasConstraintName("FK_Merchandise_Concessions");

                    b.HasOne("ThemeParkApplication.Models.ItemTypeTable", "ItemTypeNavigation")
                        .WithMany("Merchandise")
                        .HasForeignKey("ItemType")
                        .HasConstraintName("FK_Merchadise_Item_Type_Table");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Profile", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.Employees", "Employee")
                        .WithMany("Profile")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_Profile_Employee");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Transactions", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.Customers", "Guest")
                        .WithMany("Transactions")
                        .HasForeignKey("GuestId")
                        .HasConstraintName("FK_Transactions_Customers");

                    b.HasOne("ThemeParkApplication.Models.Merchandise", "Merch")
                        .WithMany("Transactions")
                        .HasForeignKey("MerchId")
                        .HasConstraintName("FK_Transactions_Merchandise");

                    b.HasOne("ThemeParkApplication.Models.Employees", "SellerEmployee")
                        .WithMany("Transactions")
                        .HasForeignKey("SellerEmployeeId")
                        .HasConstraintName("FK_Transactions_Employees")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
