using System;

namespace Assignment_DmitrijKosmakov_Danske
{
    public class Ellipse : AbstractShape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public Ellipse(double posx, double posy, double width, double height) : base(posx, posy)
        {
            if (width < 0)
                throw new ArgumentOutOfRangeException("Ellipse width can't be less than 0");
            if (height < 0)
                throw new ArgumentOutOfRangeException("Ellipse height can't be less than 0");

            Width = width;
            Height = height;
        }
        public override double Area => Width/2.0 * Height/2.0 * Math.PI;
        public override string ToString() => $"{Type} [x:{X},y:{Y},w:{Width},h:{Height}]";
    }
}
