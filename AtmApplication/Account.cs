using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApplication
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public double InterestRate { get; private set; }
        public string AccountHolderName { get; private set; }
        private List<string> Transactions;

        public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            InterestRate = interestRate;
            AccountHolderName = accountHolderName;
            Transactions = new List<string>();
            Transactions.Add($"Account created with initial balance {initialBalance}");
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"Deposited: {amount}");
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transactions.Add($"Withdrew: {amount}");
                return true;
            }
            else
            {
                Transactions.Add($"Failed withdrawal attempt: {amount}");
                return false;
            }
        }

        public void DisplayTransactions()
        {
            Console.WriteLine("\n\n---------------------------------");
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
            Console.WriteLine("\n\n---------------------------------");
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Holder: {AccountHolderName}, Balance: {Balance}, Interest Rate: {InterestRate}%";
        }
    }

}
