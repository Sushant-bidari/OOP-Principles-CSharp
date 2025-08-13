using System;

namespace OOPPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Encapsulation----");
            BankAccount account = new BankAccount();
            account.Balance = 200;
            account.Deposit(1000);
            account.Withdraw(600);

            Console.WriteLine("\n----Inheritance----");
            InterestAmount amount = new InterestAmount();
            amount.InterestRate = 5;
            amount.ServiceCharge = 500;
            amount.Deposit(1000);
            amount.AddInterest();
            amount.Charge();

            Console.WriteLine("\n----Abstraction----");
            Shape circle = new Circle(5);
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");

            Console.WriteLine("\n----Polymorphism----");
            Animal animal = new Animal();
            animal.MakeSound();
            Dog dog = new Dog();
            dog.MakeSound();
        }
    }
}
