using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Bank_Account_Management_System
{
    public class SavingAccount : Account
    {
        public decimal InterestRate {  get; set; }
        public void AddInterest()
        {
            Balance += Balance * (InterestRate / 100);
        }
        public SavingAccount() : base()
        {
            InterestRate = 0;
        }
        public SavingAccount(decimal interestRate, string accountNumber, decimal balance, string owner) 
            : base(accountNumber, balance, owner) 
        {
            InterestRate = interestRate;
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if(amount > 10000000)
            {
                Console.WriteLine("This amount of money exceeds withdrawal limits");
            }
            else
                Balance -= amount;
        }
        public override string ToString()
        {
            return $"Owner: {Owner}\n" +
                   $"Account Number: {AccountNumber}\n" +
                   $"Balance: {Balance}\n" +
                   $"Interest Rate: {InterestRate}";
        }
    }
}
