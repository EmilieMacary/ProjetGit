using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class StringValue
    {
        public static string ToString(int number1)
        {
            return number1.ToString();
        }

        public static string ToString(float number1)
        {
            return number1.ToString();
        }

        public static string ToString(Coordinate c)
        {
            return c.ToString();
        }
    }
}
