namespace Assignment_DmitrijKosmakov_Danske
{
    public abstract class AbstractShape
    {
        public AbstractShape(double posx, double posy)
        {
            X = posx;
            Y = posy;
        }
        public readonly double X;
        public readonly double Y;
        public string Type { get { return GetType().Name; } }
        public abstract double Area { get; }
        public override string ToString() => $"Type: {Type}, pos: (x:{X}, y:{Y})";
    }
}
