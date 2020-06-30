using System;
using System.Collections.Generic;
using System.Text;
using Assignment_DmitrijKosmakov_Danske;

namespace Assignment_DmitrijKosmakov_Danske
{
    public static class Rectangle_Extensions
    {
        public static string TallOrFlat(this Rectangle rect)
        {
            const string SQUARE = "square";
            const string TALL = "tall";
            const string FLAT = "flat";

            if (rect.Width == rect.Height)
                return SQUARE;
            else if (rect.Width < rect.Height)
                return TALL;
            else
                return FLAT;
        }
    }
}
