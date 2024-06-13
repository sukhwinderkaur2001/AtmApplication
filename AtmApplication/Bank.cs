using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApplication
{
    public class Bank
    {
        private List<Account> Accounts;

        public Bank()
        {
            Accounts = new List<Account>();
            for (int i = 100; i < 110; i++)
            {
                Accounts.Add(new Account(i, 100, 3, $"Holder {i}"));
            }
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public Account RetrieveAccount(int accountNumber)
        {
            return Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }

        public void DisplayAllAccounts()
        {
            foreach (var account in Accounts)
            {
                Console.WriteLine(account);
            }
        }
    }

}
