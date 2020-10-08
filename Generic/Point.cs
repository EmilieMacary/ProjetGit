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


        // exercice : redefinir la methode ToString() de Point de telle manière que le string retourné indique
        // "coordonnées : (x, y)"
        public override string ToString()
        {
            string setenceToReturn = $"coordonnes : ({Abscissa}, {Ordinate})";
            return setenceToReturn;
        }
    }


}
