using System;

namespace Polymorphism
{
    public abstract class AbstractPolygon
    {
        public void Hello()
        {
            Console.WriteLine("Hi, i'm a polygon !");
        }

        public virtual void CalculateVolume()
        {
            Console.WriteLine("Polygons don't have volume.");
        }

        public abstract int CalculatePerimeter();
    }
}
