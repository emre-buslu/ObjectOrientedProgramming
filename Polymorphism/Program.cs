using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.Edge2 = 3;
            rightTriangle.Edge1 = 4;
            rightTriangle.Hypotenuse = 5;

            rightTriangle.Hello();
            rightTriangle.CalculateVolume();
            int triangleArea = rightTriangle.CalculateArea();
            int trianglePerimeter = rightTriangle.CalculatePerimeter();

            Console.WriteLine("Right Triangle's area : {0}", triangleArea);
            Console.WriteLine("Right Triangle's perimeter : {0}", trianglePerimeter);

            Console.WriteLine();

            Square square = new Square();
            square.Edge = 4;

            square.Hello();
            square.CalculateVolume();
            int squareArea = square.CalculateArea();
            int squarePerimeter = square.CalculatePerimeter();

            Console.WriteLine("Square's area : {0}", squareArea);
            Console.WriteLine("Square's perimeter : {0}", squarePerimeter);

            Console.ReadKey();

        }
    }
}