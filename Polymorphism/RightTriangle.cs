namespace Polymorphism
{
    public class RightTriangle : AbstractPolygon, IPolygon
    {
        public int Edge1 { get; set; }
        public int Edge2 { get; set; }
        public int Hypotenuse { get; set; }

        public int CalculateArea()
        {
            return Edge1 * Edge2 / 2;
        }

        public override int CalculatePerimeter()
        {
            return Edge1 + Edge2 + Hypotenuse;
        }
    }
}
