using System;

namespace OOPPrinciple
{
    // Polymorphism
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Sound: Woof Woof");
        }
    }
}
