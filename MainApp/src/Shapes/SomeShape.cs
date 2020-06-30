using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_DmitrijKosmakov_Danske
{
    public class SomeShape : AbstractShape
    {
        public SomeShape(double posx, double posy) : base(posx, posy)
        {}
        public override double Area => 0;
        public override string ToString() => $"{Type}:{X},{Y}";
    }
}
