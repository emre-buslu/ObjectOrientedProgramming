using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Breath();
            animal.Name = "Yellow Face";
            animal.Meet();
            
            Console.WriteLine();
            
            Dog dog = new Dog();
            dog.Breath();
            dog.Name = "Black Head";
            dog.Meet();
            dog.Age = 5;
            dog.GetAge();
            dog.Bark();
            
            Console.WriteLine();

            Beagle beagle = new Beagle();
            beagle.Breath();
            beagle.Name = "Hazelnut";
            beagle.Meet();
            beagle.Age = 3;
            beagle.GetAge();
            beagle.Bark();
            beagle.Play();
            beagle.Breathing();

        }
    }
}
