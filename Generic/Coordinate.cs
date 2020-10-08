using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Coordinate
    {
        public int Abscissa { get; set; }
        public int Ordinate { get; set; }

        public static Coordinate operator +(Coordinate first, Coordinate second) => new Coordinate { Abscissa = first.Abscissa, Ordinate = second.Ordinate };

    }


}
