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
    [Migration("20240415171019_PromotionMigration")]
    partial class PromotionMigration
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

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

            modelBuilder.Entity("Core.Entities.Movement", b =>
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

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("TransferStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("TransferredDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id")
                        .HasName("Movement_pkey");

                    b.HasIndex("AccountId");

                    b.ToTable("Movements");
                });

            modelBuilder.Entity("Core.Entities.SavingAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("SavingType")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("SavingAccount_pkey");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("SavingAccounts");
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

            modelBuilder.Entity("Core.Entities.Movement", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithMany("Movements")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Core.Entities.SavingAccount", b =>
                {
                    b.HasOne("Core.Entities.Account", "Account")
                        .WithOne("SavingAccount")
                        .HasForeignKey("Core.Entities.SavingAccount", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Core.Entities.Account", b =>
                {
                    b.Navigation("CurrentAccount");

                    b.Navigation("Movements");

                    b.Navigation("SavingAccount");
                });

            modelBuilder.Entity("Core.Entities.Bank", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Core.Entities.Currency", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("CreditCards");
                });

            modelBuilder.Entity("Core.Entities.Customer", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("CreditCards");
                });
#pragma warning restore 612, 618
        }
    }
}
