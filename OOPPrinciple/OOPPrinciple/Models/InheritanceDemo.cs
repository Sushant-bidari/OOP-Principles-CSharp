using System;

namespace OOPPrinciple
{
    // Inheritance
    public class InterestAmount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public decimal ServiceCharge { get; set; }

        public void AddInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interest Added: {interest}");
        }

        public void Charge()
        {
            Withdraw(ServiceCharge);
            Console.WriteLine($"Withdraw Amount: {ServiceCharge}");
        }
    }
}
