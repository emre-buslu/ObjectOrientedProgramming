using System;

namespace Abstraction
{
    abstract public class AbstractProduct
    {
        public void Sell()
        {
            Console.WriteLine("Product was sold.");
        }
        abstract public void Repair();
    }
}
