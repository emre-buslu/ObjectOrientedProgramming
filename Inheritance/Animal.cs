using System;

namespace Inheritance
{
    public class Animal
    {
        public string Name;
        public void Breath()
        {
            Console.WriteLine("Breathing..");
        }

        public virtual void Meet()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
