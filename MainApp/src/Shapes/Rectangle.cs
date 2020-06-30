using System;

namespace Assignment_DmitrijKosmakov_Danske
{
    public class Rectangle : AbstractShape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            if (width < 0)
                throw new ArgumentOutOfRangeException("Rectangle width can't be less than 0");
            if (height < 0)
                throw new ArgumentOutOfRangeException("Rectangle height can't be less than 0");

            Width = width;
            Height = height;
        }
        public override double Area => Width * Height;
        public override string ToString() => $"{Type}:{X},{Y},{Width},{Height}";
    }
}
