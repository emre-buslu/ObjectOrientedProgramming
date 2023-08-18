using System;

namespace Inheritance
{
    public class Dog : Animal
    {
        public int Age { get; set; }
        public void Bark()
        {
            Console.WriteLine("Hav hav !");
        }
        public void GetAge()
        {
            Console.WriteLine($"My age is {Age}");
        }

        public override sealed void Meet()
        {
            Console.WriteLine($"My name is {base.Name} and i'm a dog !");
        }
    }
}
