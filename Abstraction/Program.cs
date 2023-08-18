using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProduct interfaceProduct = new IProduct();
            //AbstractProduct abstractInstanceComputer = new AbstractProduct();
            
            IProduct iProduct = new Computer();
            AbstractProduct abstractComputer = new Computer();
            Computer computer = new Computer();

            iProduct.GetPrice();
            //iProduct.Sell();
            //iProduct.Repair();

            Console.WriteLine();

            //abstractComputer.GetPrice();
            abstractComputer.Sell();
            abstractComputer.Repair();
            
            Console.WriteLine();
            
            computer.GetPrice();
            computer.Sell();
            computer.Repair();

            Console.ReadKey();
        }
    }
}
