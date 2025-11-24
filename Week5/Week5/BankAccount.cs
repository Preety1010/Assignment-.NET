using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        //constructor to initialize account number and balance
        public BankAccount(string accNumber, double initialBalance)
        {
            accountNumber = accNumber;
            if (initialBalance <= 0)
            {
                throw new ArgumentException("Initial balance must be greater than 0.");
            }
            balance = initialBalance;

        }   
        public string AccountNumber
        {
            get { return accountNumber; }
        }
        //public property for balance 
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Balance cannot be zero or negative");
                }
                balance = value;
            }
        }

            public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. Remaining balance: {balance:C}");
        }
    }

}

