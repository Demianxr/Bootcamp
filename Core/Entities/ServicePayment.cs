﻿namespace Core.Entities;

public class ServicePayment
{
    public int Id { get; set; }

    public string DocumentNumber { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime DepositDateTime { get; set; }

    public decimal Amount { get; set; }

    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;

    public int AccountId { get; set; }
    public Account Account { get; set; } = null!;
}