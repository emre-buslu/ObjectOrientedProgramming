using System;

namespace Polymorphism
{
    public class Square : AbstractPolygon, IPolygon
    {
        public int Edge { get; set; }

        public int CalculateArea()
        {
            return Edge * Edge;
        }

        public override int CalculatePerimeter()
        {
            return Edge + Edge + Edge + Edge;
        }

        public override void CalculateVolume() 
        {
            Console.WriteLine("Squares don't have volume.");
        }
    }
}
