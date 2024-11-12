using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Bank_Account_Management_System
{
    public class CheckingAccount : Account
    {
        public decimal OverdraftLimit {  get; set; }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public CheckingAccount(decimal overdraftLimit, string accountNumber, decimal balance, string owner) 
              : base(accountNumber, balance, owner)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if(amount <= Balance + OverdraftLimit)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("This amount exceeded");
            }
        }
        public override string ToString()
        {
            return $"Owner: {Owner}\n" +
                   $"Account Number: {AccountNumber}\n" +
                   $"Balance: {Balance}\n" +
                   $"OverdraftLimit: {OverdraftLimit}";
        }
    }
}
