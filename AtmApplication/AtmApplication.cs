using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApplication
{
    public class AtmApplication
    {
        private Bank bank;

        public AtmApplication()
        {
            bank = new Bank();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n\n==============Welcome to the ATM Applications==============");
                Console.WriteLine("Choose the following options by the number associated with the option");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Select Account");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();
                if (choice == "3")
                {
                    Console.WriteLine("Do you want to exit [y/n].");
                    var ch = Console.ReadLine();
                    if (ch == "y")
                        return;
                }
                switch (choice)
                {
                    case "1":
                        CreateAccount();
                        break;
                    case "2":
                        SelectAccount();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void CreateAccount()
        {
            Console.WriteLine("\n\n==============Welcome Create Account Menu==============");

            Console.Write("Enter Account Holder Name: ");
            string accountHolderName = Console.ReadLine();

            Console.Write("Enter Account Number(Account Number must be between 100 and 1000): ");
            
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            Console.Write("Enter Interest Rate(less than 3%): ");
            double interestRate = double.Parse(Console.ReadLine());

            

            Account account = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
            bank.AddAccount(account);
            Console.WriteLine("\n\n---------------------------------");

            Console.WriteLine("Account created successfully!");

            Console.WriteLine("\n\n---------------------------------");
            /*
            while (true)
            {
                Console.WriteLine("\n\n---------------------------------");
                Console.WriteLine("\n\nWelcome " + accountHolderName);
                Console.WriteLine("\n\n---------------------------------");
                Console.WriteLine("\n\nAccount Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Transactions");
                Console.WriteLine("5. Exit Account");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n\n---------------------------------");
                        Console.WriteLine($"Balance: {account.Balance}");
                        Console.WriteLine("\n\n---------------------------------");
                        break;
                    case "2":
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        Console.WriteLine("\n\n---------------------------------");
                        Console.WriteLine("Deposit successful!");
                        Console.WriteLine("\n\n---------------------------------");
                        break;
                    case "3":
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (account.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine("\n\n---------------------------------");
                            Console.WriteLine("Withdrawal successful!");
                            Console.WriteLine("\n\n---------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("\n\n---------------------------------");
                            Console.WriteLine("Insufficient funds.");
                            Console.WriteLine("\n\n---------------------------------");
                        }
                        break;
                    case "4":
                        account.DisplayTransactions();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("\n\n---------------------------------");
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("\n\n---------------------------------");
                        break;
                }
            }*/
        }

        private void SelectAccount()
        {

            Console.Write("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Account account = bank.RetrieveAccount(accountNumber);
            if (account != null)
            {
                while (true)
                {
                    Console.WriteLine("\n\n---------------------------------");
                    Console.WriteLine("\nWelcome " + account.AccountHolderName);
                    Console.WriteLine("\n\n---------------------------------");
                    Console.WriteLine("Account Menu:\n");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Display Transactions");
                    Console.WriteLine("5. Exit Account");
                    Console.Write("Choose an option: ");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("\n\n---------------------------------");
                            Console.WriteLine($"Balance: {account.Balance}");
                            Console.WriteLine("\n\n---------------------------------");
                            break;
                        case "2":
                            Console.Write("Enter amount to deposit: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                            Console.WriteLine("\n\n---------------------------------");
                            Console.WriteLine("Deposit successful!");
                            Console.WriteLine("\n\n---------------------------------");
                            break;
                        case "3":
                            Console.Write("Enter amount to withdraw: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            if (account.Withdraw(withdrawAmount))
                            {
                                Console.WriteLine("\n\n---------------------------------");
                                Console.WriteLine("Withdrawal successful!");
                                Console.WriteLine("\n\n---------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("\n\n---------------------------------");
                                Console.WriteLine("Insufficient funds.");
                                Console.WriteLine("\n\n---------------------------------");
                            }
                            break;
                        case "4":
                            account.DisplayTransactions();
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("\n\n---------------------------------");
                            Console.WriteLine("Invalid choice. Please try again.");
                            Console.WriteLine("\n\n---------------------------------");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\n---------------------------------");
                Console.WriteLine("Account not found.");
                Console.WriteLine("\n\n---------------------------------");
            }
        }
    }

}