﻿using Core.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public partial class BootcampContext : DbContext
{

    public BootcampContext()
    {
    }

    public BootcampContext(DbContextOptions<BootcampContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bank> Banks { get; set; }
    public virtual DbSet<SavingAccount> SavingAccounts { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Currency> Currency { get; set; }
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<CurrentAccount> CurrentAccounts { get; set; }
    public virtual DbSet<Movement> Movements { get; set; }
    public virtual DbSet<CreditCard> CreditCards { get; set; }
    public virtual DbSet<Promotion> Promotions { get; set; }
    public virtual DbSet<Enterprise> Enterprises { get; set; }
    public virtual DbSet<PromotionEnterprise> PromotionEnterprises { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Request> Requests { get; set; }
    public virtual DbSet<Withdrawal> Withdrawals { get; set; }
    public virtual DbSet<ServicePayment> ServicePayments { get; set; }
    public virtual DbSet<Deposit> Deposits { get; set; }
    public virtual DbSet<Transfer> Transfers { get; set; }
    public virtual DbSet<Service> Services { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new BankConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new MovementConfiguration());
        modelBuilder.ApplyConfiguration(new SavingAccountConfiguration());
        modelBuilder.ApplyConfiguration(new CreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new PromotionConfiguration());
        modelBuilder.ApplyConfiguration(new EnterpriseConfiguration());
        modelBuilder.ApplyConfiguration(new PromotionEnterpriseConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new RequestConfiguration());
        modelBuilder.ApplyConfiguration(new WithdrawalConfiguration());
        modelBuilder.ApplyConfiguration(new ServicePaymentConfiguration());
        modelBuilder.ApplyConfiguration(new DepositConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceConfiguration());



        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
