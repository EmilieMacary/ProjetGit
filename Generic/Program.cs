using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumber = 10;
            float floatNumber = 10.5f;
            Point coordinate = new Point { Abscissa = 5, Ordinate = 3 };


            var intString = StringValue.ToString(intNumber);
            var floatString = StringValue.ToString(floatNumber);
            var coordinateString = StringValue.ToString(coordinate);
                   
            var intStringGeneric = StringValueGeneric.ToString(intNumber);
            var floatStringGeneric = StringValueGeneric.ToString(floatNumber);
            var coordinateStringGeneric = StringValueGeneric.ToString(coordinate);

        }
    }
}
