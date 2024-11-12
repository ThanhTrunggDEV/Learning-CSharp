using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Bank_Account_Management_System
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public Account(string AcountNumber, decimal Balance, string Owner)
        {
            this.AccountNumber = AcountNumber;
            this.Balance = Balance;
            this.Owner = Owner;
        }
        public Account() 
        {
            Owner = string.Empty;
            Balance = 0;
            AccountNumber = string.Empty;
        }
    }
}
