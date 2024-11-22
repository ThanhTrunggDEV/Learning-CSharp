using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Bank_Account_Management_System
{
    public class Bank
    {
        private List<Account> listBanks;
        public List<Account> ListBanks { get { return listBanks; } set { listBanks = value; }}
        public Bank()
        {
            ListBanks = new List<Account>();
        }
        public Bank(List<Account> listBanks)
        {
            this.listBanks = listBanks;
        }
        public void AddAccount(Account bank)
        {
            listBanks.Add(bank);
        }
        public void FindAccount(string accountNumber)
        {
            foreach (Account bank in listBanks)
            {
                if(accountNumber == bank.AccountNumber)
                {
                    Console.WriteLine(bank);
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
        public void Deposit(string accountNumber, decimal amount)
        {
            foreach(Account bank in listBanks)
            {
                if(bank.AccountNumber == accountNumber)
                {
                    bank.Deposit(amount);
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
        public void Withdraw(string accountNumber, decimal amount)
        {
            for(int i = 0; i < listBanks.Count; i++)
            {
                if(accountNumber ==  listBanks[i].AccountNumber)
                {
                    listBanks[i].Withdraw(amount);
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
        public void Transfer(string destinationAccount, string senderAccount, decimal amount)
        {
            Console.WriteLine("This function is testing");
        }
        public void ListBankAccounts()
        {
            foreach(Account bank in listBanks)
            {
                Console.WriteLine(bank);
            }
        }
    }
}
