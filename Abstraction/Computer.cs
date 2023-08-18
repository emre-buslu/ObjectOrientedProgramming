using System;

namespace Abstraction
{
    public class Computer : AbstractProduct, IProduct
    {
        public void GetPrice()
        {
            Console.WriteLine("Computer price 1000$");
        }
        public override void Repair()
        {
            Console.WriteLine("Computer is under repair");
        }
    }
}
