﻿using Core.Constants;

namespace Core.Models
{
    public class AccountDTO
    {
        public int Id { get; set; }

        public string Holder { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public AccountType AccountType { get; set; } = AccountType.Current;

        public decimal Balance { get; set; }

        public AccountStatus AccountStatus { get; set; } = AccountStatus.Active;
        public IsDeleteStatus IsDelete { get; set; } = IsDeleteStatus.False;

        public CurrencyDTO Currency { get; set; } = null;

        public CustomerDTO Customer { get; set; } = null;
    }
}

