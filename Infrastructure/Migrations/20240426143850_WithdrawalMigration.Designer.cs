﻿// <auto-generated />
using System;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(BootcampContext))]
    [Migration("20240426143850_WithdrawalMigration")]
    partial class WithdrawalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountStatus")
                        .HasColumnType("integer");

                    b.Property<int>("AccountType")
                        .HasColumnType("integer");

                    b.Property<decimal>("Balance")
                        .HasPrecision(20, 5)
                        .HasColumnType("numeric(20,5)");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("Holder")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("integer");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id")
                        .HasName("Account_pkey");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Core.Entities.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("OperationalLimit")
                        .HasColumnType("numeric");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id")
                        .HasName("Bank_pkey");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Core.Entities.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Availablecredit")
                        .HasPrecision(20, 5)
                        .HasColumnType("numeric(20,5)");

                    b.Property<int>("CVV")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<int>("CreditCardStatus")
                        .HasMaxLength(100)
                        .HasColumnType("integer");

                    b.Property<decimal>("CreditLimit")
                        .HasMaxLength(100)
                        .HasColumnType("numeric");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Currentdebt")
                        .HasPrecision(20, 5)
                        .HasColumnType("numeric(20,5)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("ExpirationDate")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("InterestRate")
                        .HasPrecision(20, 5)
                        .HasColumnType("numeric(20,5)");

                    b.Property<DateTime?>("IssueDate")
                        .HasMaxLength(100)
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id")
                        .HasName("CreditCard_pkey");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("Core.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BuyValue")
                        .HasMaxLength(100)
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("SellValue")
                        .HasMaxLength(100)
                        .HasColumnType("numeric");

                    b.HasKey("Id")
                        .HasName("Currency_pkey");

                    b.ToTable("Currencies", (string)null);
                });

            modelBuilder.Entity("Core.Entities.CurrentAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Interest")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("MonthAverage")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("OperationalLimit")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("CurrentAccounts");
                });

            modelBuilder.Entity("Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("BankId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CustomerStatus")
                        .HasMaxLength(100)
                        .HasColumnType("integer");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Lastname")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Mail")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id")
                        .HasName("Customer_pkey");

                    b.HasIndex("BankId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Core.Entities.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Amount")
                        .HasPrecision(20, 5)
                        .HasColumnType("numeric(20,5)");

                    b.Property<DateTime>("DepositDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("Deposit_pkey");

                    b.HasIndex("AccountId");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("Core.Entities.Enterprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Enterprises");
                });

            modelBuilder.Entity("Core.Entities.Movement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountDestinationId")
                        .HasColumnType("integer");

                    b.Property<int>("AccountSourceId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Amount")
                        .HasPrecision(20, 5)
                        .HasColumnType("numeric(20,5)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<int>("MovementType")
                        .HasColumnType("integer");

                    b.Property<int>("TransferStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TransferredDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id")
                        .HasName("Movement_pkey");

                    b.HasIndex("AccountSourceId");

                    b.ToTable("Movements");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<decimal>("InitialDeposit")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Term")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Discount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("Core.Entities.PromotionEnterprise", b =>
                {
                    b.Property<int>("PromotionId")
                        .HasColumnType("integer");

                    b.Property<int>("EnterpriseId")
                        .HasColumnType("integer");

                    b.HasKey("PromotionId", "EnterpriseId");

                    b.HasIndex("EnterpriseId");

                    b.ToTable("PromotionEnterprises");
                });

            modelBuilder.Entity("Core.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("Request_pkey");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Core.Entities.SavingAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<decimal>("DesiredAmount")
                        .HasColumnType("numeric");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("PreferredTerm")
                        .HasColumnType("integer");

                    b.Property<int>("SavingType")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("SavingAccount_pkey");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("CurrencyId");

                    b.ToTable("SavingAccounts");
                });

            modelBuilder.Entity("Core.Entities.ServicePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("DebitAccountId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("ServicePayments");
                });

            modelBuilder.Entity("Core.Entities.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("DestinationAccountId")
                        .HasColumnType("integer");

                    b.Property<int>("OriginAccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("Core.Entities.Withdrawal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Amount")
                        .HasPrecision(20, 5)
                        .HasColumnType("numeric(20,5)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("WithdrawalDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id")
                        .HasName("Withdrawal_pkey");

                    b.HasIndex("AccountId");

                    b.ToTable("Withdrawals");
                });

            modelBuilder.Entity("Core.Entities.Account", b =>
                {
                    b.HasOne("Core.Entities.Currency", "Currency")
                        .WithMany("Accounts")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Customer", "Customer")
                        .WithMany("Accounts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Core.Entities.CreditCard", b =>
                {
                    b.HasOne("Core.Entities.Currency", null)
                        .WithMany("CreditCards")
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Core.Entities.Customer", null)
                        .WithMany("CreditCards")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Core.Entities.CurrentAccount", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithOne("CurrentAccount")
                        .HasForeignKey("Core.Entities.CurrentAccount", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Core.Entities.Customer", b =>
                {
                    b.HasOne("Core.Entities.Bank", "Bank")
                        .WithMany("Customers")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Core.Entities.Deposit", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithMany("Deposits")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Core.Entities.Movement", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithMany("Movements")
                        .HasForeignKey("AccountSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Core.Entities.PromotionEnterprise", b =>
                {
                    b.HasOne("Core.Entities.Enterprise", "Enterprise")
                        .WithMany("PromotionsEnterprises")
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Promotion", "Promotion")
                        .WithMany("PromotionsEnterprises")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enterprise");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("Core.Entities.Request", b =>
                {
                    b.HasOne("Core.Entities.Currency", "Currency")
                        .WithMany("Requests")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Customer", "Customer")
                        .WithMany("Requests")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Product", "Product")
                        .WithMany("Requests")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Entities.SavingAccount", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithOne("SavingAccount")
                        .HasForeignKey("Core.Entities.SavingAccount", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("Core.Entities.ServicePayment", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithMany("Payments")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Core.Entities.Withdrawal", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithMany("Withdrawals")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Core.Entities.Account", b =>
                {
                    b.Navigation("CurrentAccount");

                    b.Navigation("Deposits");

                    b.Navigation("Movements");

                    b.Navigation("Payments");

                    b.Navigation("SavingAccount");

                    b.Navigation("Withdrawals");
                });

            modelBuilder.Entity("Core.Entities.Bank", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Core.Entities.Currency", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("CreditCards");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Core.Entities.Customer", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("CreditCards");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Core.Entities.Enterprise", b =>
                {
                    b.Navigation("PromotionsEnterprises");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Core.Entities.Promotion", b =>
                {
                    b.Navigation("PromotionsEnterprises");
                });
#pragma warning restore 612, 618
        }
    }
}
