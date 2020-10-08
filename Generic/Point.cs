using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Point
    {
        public int Abscissa { get; set; }
        public int Ordinate { get; set; }

        public static Point operator +(Point first, Point second) => new Point { Abscissa = first.Abscissa, Ordinate = second.Ordinate };

    }


}
