using System;

namespace OOPPrinciple
{
    public class BankAccount
    {
        // Encapsulation
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return;
            }
            _balance += amount;
            Console.WriteLine($"Deposit: {amount} , New Balance: {_balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be greater than 0");
                return;
            }
            if (amount > _balance)
            {
                Console.WriteLine("No Sufficient Balance to Withdraw");
                return;
            }
            _balance -= amount;
            Console.WriteLine($"Withdraw: {amount} , New Balance: {_balance}");
        }
    }
}
