﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealCashMs.Data;

#nullable disable

namespace RealCashMs.Migrations
{
    [DbContext(typeof(CashMsDbContext))]
    [Migration("20221118220348_ForeignKeyCreation")]
    partial class ForeignKeyCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerReviews", b =>
                {
                    b.Property<string>("CustomerClassEmailAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("reviewsClassratedEmployeeIdentifier")
                        .HasColumnType("int");

                    b.HasKey("CustomerClassEmailAddress", "reviewsClassratedEmployeeIdentifier");

                    b.HasIndex("reviewsClassratedEmployeeIdentifier");

                    b.ToTable("CustomerReviews");
                });

            modelBuilder.Entity("RealCashMs.Models.AccountMpesaDetails", b =>
                {
                    b.Property<string>("mpesaConfirmationCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("amountPaid")
                        .HasColumnType("int");

                    b.Property<int>("currentAccountBalance")
                        .HasColumnType("int");

                    b.Property<int>("initialAccountBalance")
                        .HasColumnType("int");

                    b.Property<int?>("profitDayOfTheYear")
                        .HasColumnType("int");

                    b.Property<string>("secondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mpesaConfirmationCode");

                    b.HasIndex("profitDayOfTheYear");

                    b.ToTable("mpesaDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.CasualWorker", b =>
                {
                    b.Property<string>("CasualWorkerNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("OnDuty")
                        .HasColumnType("bit");

                    b.Property<string>("dayOfTheYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mealsOfTheDaydayOfTheYear")
                        .HasColumnType("int");

                    b.HasKey("CasualWorkerNo");

                    b.HasIndex("EmployeeNo")
                        .IsUnique()
                        .HasFilter("[EmployeeNo] IS NOT NULL");

                    b.HasIndex("mealsOfTheDaydayOfTheYear");

                    b.ToTable("casualWorkersTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Cook", b =>
                {
                    b.Property<string>("CookNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("dayOfTheYear")
                        .HasColumnType("int");

                    b.Property<int>("mealCookeddayOfTheYear")
                        .HasColumnType("int");

                    b.Property<bool>("onDuty")
                        .HasColumnType("bit");

                    b.HasKey("CookNo");

                    b.HasIndex("EmployeeNo")
                        .IsUnique();

                    b.HasIndex("mealCookeddayOfTheYear");

                    b.ToTable("cooksTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Customer", b =>
                {
                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("orderNo")
                        .HasColumnType("int");

                    b.Property<int>("starsReviews")
                        .HasColumnType("int");

                    b.HasKey("EmailAddress");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("RealCashMs.Models.CustomerAlert", b =>
                {
                    b.Property<string>("AlertEmailAddres")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerDetailsEmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("quantityState")
                        .HasColumnType("int");

                    b.HasKey("AlertEmailAddres");

                    b.HasIndex("customerDetailsEmailAddress");

                    b.ToTable("cAlertDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Department", b =>
                {
                    b.Property<int>("departmentCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("departmentCode"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departmentCode");

                    b.ToTable("departmentDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalID")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departmentCode")
                        .HasColumnType("int");

                    b.Property<int>("departmentWorkingdepartmentCode")
                        .HasColumnType("int");

                    b.Property<int?>("jobGroup")
                        .HasColumnType("int");

                    b.Property<int>("salaryClassjobGroup")
                        .HasColumnType("int");

                    b.HasKey("EmployeeNo");

                    b.HasIndex("departmentWorkingdepartmentCode");

                    b.HasIndex("salaryClassjobGroup");

                    b.ToTable("employeeDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.EmployeeAlert", b =>
                {
                    b.Property<string>("EmployeeAlertNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("complaint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employeeAlertType")
                        .HasColumnType("int");

                    b.Property<string>("employeeInAlertEmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeAlertNo");

                    b.HasIndex("employeeInAlertEmployeeNo");

                    b.ToTable("eAlertDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Meal", b =>
                {
                    b.Property<int>("mealName")
                        .HasColumnType("int");

                    b.Property<string>("customerInstanceEmailAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("dayOfTheYear")
                        .HasColumnType("int");

                    b.Property<int>("mealPrice")
                        .HasColumnType("int");

                    b.Property<int>("mealsOftheDaydayOfTheYear")
                        .HasColumnType("int");

                    b.Property<int>("quantityRemaining")
                        .HasColumnType("int");

                    b.Property<string>("receiptNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mealName");

                    b.HasIndex("customerInstanceEmailAddress");

                    b.HasIndex("mealsOftheDaydayOfTheYear");

                    b.ToTable("meals");
                });

            modelBuilder.Entity("RealCashMs.Models.MealsADay", b =>
                {
                    b.Property<int>("dayOfTheYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dayOfTheYear"));

                    b.Property<string>("nameOfTheDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dayOfTheYear");

                    b.ToTable("mealsOfTheDay");
                });

            modelBuilder.Entity("RealCashMs.Models.OrderIssue", b =>
                {
                    b.Property<int>("orderNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderNo"));

                    b.Property<string>("paymentDetailsreceiptNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("receiptNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("orderNo");

                    b.HasIndex("paymentDetailsreceiptNo");

                    b.ToTable("OrdersIssued");
                });

            modelBuilder.Entity("RealCashMs.Models.PaymentDetails", b =>
                {
                    b.Property<string>("receiptNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerDetailsEmailAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("mpesaConfirmationCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("timeOfTheDay")
                        .HasColumnType("datetime2");

                    b.HasKey("receiptNo");

                    b.HasIndex("customerDetailsEmailAddress");

                    b.HasIndex("mpesaConfirmationCode")
                        .IsUnique()
                        .HasFilter("[mpesaConfirmationCode] IS NOT NULL");

                    b.ToTable("paymentDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Profit", b =>
                {
                    b.Property<int>("profitDayOfTheYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("profitDayOfTheYear"));

                    b.Property<int>("Capital")
                        .HasColumnType("int");

                    b.Property<bool>("loss")
                        .HasColumnType("bit");

                    b.Property<bool>("profit")
                        .HasColumnType("bit");

                    b.Property<int>("profitMade")
                        .HasColumnType("int");

                    b.Property<int>("returnsMade")
                        .HasColumnType("int");

                    b.HasKey("profitDayOfTheYear");

                    b.ToTable("profitDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Reviews", b =>
                {
                    b.Property<int>("ratedEmployeeIdentifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ratedEmployeeIdentifier"));

                    b.Property<string>("EmployeeNo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ratedEmployeeIdentifier");

                    b.HasIndex("EmployeeNo")
                        .IsUnique()
                        .HasFilter("[EmployeeNo] IS NOT NULL");

                    b.ToTable("reviewsDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Salary", b =>
                {
                    b.Property<int>("jobGroup")
                        .HasColumnType("int");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("jobGroup");

                    b.ToTable("salaryDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Stock", b =>
                {
                    b.Property<int>("stocksIdentifier")
                        .HasColumnType("int");

                    b.Property<int>("QuantityRemainingKg")
                        .HasColumnType("int");

                    b.Property<int>("QuantitySack")
                        .HasColumnType("int");

                    b.Property<int>("rateOfConsumptionPercentage")
                        .HasColumnType("int");

                    b.Property<int>("stockAlertPercentage")
                        .HasColumnType("int");

                    b.HasKey("stocksIdentifier");

                    b.ToTable("stockDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.StockAlert", b =>
                {
                    b.Property<int>("stockAlertCode")
                        .HasColumnType("int");

                    b.Property<int>("stockLevel")
                        .HasColumnType("int");

                    b.HasKey("stockAlertCode");

                    b.ToTable("StocksAlertTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Supervisor", b =>
                {
                    b.Property<int>("supervisorNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("supervisorNo"));

                    b.Property<int>("dayMealsdayOfTheYear")
                        .HasColumnType("int");

                    b.Property<int>("dayOfTheYear")
                        .HasColumnType("int");

                    b.Property<bool>("onDuty")
                        .HasColumnType("bit");

                    b.HasKey("supervisorNo");

                    b.HasIndex("dayMealsdayOfTheYear");

                    b.ToTable("supervisorDetailsTable");
                });

            modelBuilder.Entity("RealCashMs.Models.Suppliers", b =>
                {
                    b.Property<int>("companyCode")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pricing")
                        .HasColumnType("int");

                    b.Property<int>("stockClassstocksIdentifier")
                        .HasColumnType("int");

                    b.Property<int>("stocksIdentifier")
                        .HasColumnType("int");

                    b.HasKey("companyCode");

                    b.HasIndex("stockClassstocksIdentifier");

                    b.ToTable("supplierDetailsTable");
                });

            modelBuilder.Entity("CustomerReviews", b =>
                {
                    b.HasOne("RealCashMs.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerClassEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealCashMs.Models.Reviews", null)
                        .WithMany()
                        .HasForeignKey("reviewsClassratedEmployeeIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealCashMs.Models.AccountMpesaDetails", b =>
                {
                    b.HasOne("RealCashMs.Models.Profit", null)
                        .WithMany("mpesaDetailsCollection")
                        .HasForeignKey("profitDayOfTheYear");
                });

            modelBuilder.Entity("RealCashMs.Models.CasualWorker", b =>
                {
                    b.HasOne("RealCashMs.Models.Employee", "employees")
                        .WithOne("casualWorker")
                        .HasForeignKey("RealCashMs.Models.CasualWorker", "EmployeeNo");

                    b.HasOne("RealCashMs.Models.MealsADay", "mealsOfTheDay")
                        .WithMany("casualWorker")
                        .HasForeignKey("mealsOfTheDaydayOfTheYear")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employees");

                    b.Navigation("mealsOfTheDay");
                });

            modelBuilder.Entity("RealCashMs.Models.Cook", b =>
                {
                    b.HasOne("RealCashMs.Models.Employee", "employeesTable")
                        .WithOne("cookClass")
                        .HasForeignKey("RealCashMs.Models.Cook", "EmployeeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealCashMs.Models.MealsADay", "mealCooked")
                        .WithMany("cooksForTheDay")
                        .HasForeignKey("mealCookeddayOfTheYear")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeesTable");

                    b.Navigation("mealCooked");
                });

            modelBuilder.Entity("RealCashMs.Models.CustomerAlert", b =>
                {
                    b.HasOne("RealCashMs.Models.Customer", "customerDetails")
                        .WithMany()
                        .HasForeignKey("customerDetailsEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customerDetails");
                });

            modelBuilder.Entity("RealCashMs.Models.Employee", b =>
                {
                    b.HasOne("RealCashMs.Models.Department", "departmentWorking")
                        .WithMany("Employees")
                        .HasForeignKey("departmentWorkingdepartmentCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealCashMs.Models.Salary", "salaryClass")
                        .WithMany("employeesInJobGroup")
                        .HasForeignKey("salaryClassjobGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("departmentWorking");

                    b.Navigation("salaryClass");
                });

            modelBuilder.Entity("RealCashMs.Models.EmployeeAlert", b =>
                {
                    b.HasOne("RealCashMs.Models.Employee", "employeeInAlert")
                        .WithMany("empAlert")
                        .HasForeignKey("employeeInAlertEmployeeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeeInAlert");
                });

            modelBuilder.Entity("RealCashMs.Models.Meal", b =>
                {
                    b.HasOne("RealCashMs.Models.Customer", "customerInstance")
                        .WithMany("mealsOrdered")
                        .HasForeignKey("customerInstanceEmailAddress");

                    b.HasOne("RealCashMs.Models.MealsADay", "mealsOftheDay")
                        .WithMany("mealsOffered")
                        .HasForeignKey("mealsOftheDaydayOfTheYear")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customerInstance");

                    b.Navigation("mealsOftheDay");
                });

            modelBuilder.Entity("RealCashMs.Models.OrderIssue", b =>
                {
                    b.HasOne("RealCashMs.Models.PaymentDetails", "paymentDetails")
                        .WithMany()
                        .HasForeignKey("paymentDetailsreceiptNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paymentDetails");
                });

            modelBuilder.Entity("RealCashMs.Models.PaymentDetails", b =>
                {
                    b.HasOne("RealCashMs.Models.Customer", "customerDetails")
                        .WithMany("paymentDetails")
                        .HasForeignKey("customerDetailsEmailAddress");

                    b.HasOne("RealCashMs.Models.AccountMpesaDetails", "accountDetails")
                        .WithOne("PaymentDetails")
                        .HasForeignKey("RealCashMs.Models.PaymentDetails", "mpesaConfirmationCode");

                    b.Navigation("accountDetails");

                    b.Navigation("customerDetails");
                });

            modelBuilder.Entity("RealCashMs.Models.Reviews", b =>
                {
                    b.HasOne("RealCashMs.Models.Employee", "employeesClass")
                        .WithOne("reviewClass")
                        .HasForeignKey("RealCashMs.Models.Reviews", "EmployeeNo");

                    b.Navigation("employeesClass");
                });

            modelBuilder.Entity("RealCashMs.Models.Supervisor", b =>
                {
                    b.HasOne("RealCashMs.Models.MealsADay", "dayMeals")
                        .WithMany("supervisorsOfTheDay")
                        .HasForeignKey("dayMealsdayOfTheYear")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dayMeals");
                });

            modelBuilder.Entity("RealCashMs.Models.Suppliers", b =>
                {
                    b.HasOne("RealCashMs.Models.Stock", "stockClass")
                        .WithMany("supplierClass")
                        .HasForeignKey("stockClassstocksIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("stockClass");
                });

            modelBuilder.Entity("RealCashMs.Models.AccountMpesaDetails", b =>
                {
                    b.Navigation("PaymentDetails");
                });

            modelBuilder.Entity("RealCashMs.Models.Customer", b =>
                {
                    b.Navigation("mealsOrdered");

                    b.Navigation("paymentDetails");
                });

            modelBuilder.Entity("RealCashMs.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("RealCashMs.Models.Employee", b =>
                {
                    b.Navigation("casualWorker")
                        .IsRequired();

                    b.Navigation("cookClass")
                        .IsRequired();

                    b.Navigation("empAlert");

                    b.Navigation("reviewClass")
                        .IsRequired();
                });

            modelBuilder.Entity("RealCashMs.Models.MealsADay", b =>
                {
                    b.Navigation("casualWorker");

                    b.Navigation("cooksForTheDay");

                    b.Navigation("mealsOffered");

                    b.Navigation("supervisorsOfTheDay");
                });

            modelBuilder.Entity("RealCashMs.Models.Profit", b =>
                {
                    b.Navigation("mpesaDetailsCollection");
                });

            modelBuilder.Entity("RealCashMs.Models.Salary", b =>
                {
                    b.Navigation("employeesInJobGroup");
                });

            modelBuilder.Entity("RealCashMs.Models.Stock", b =>
                {
                    b.Navigation("supplierClass");
                });
#pragma warning restore 612, 618
        }
    }
}
