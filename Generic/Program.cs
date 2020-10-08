namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumber = 10;
            float floatNumber = 10.5f;
            Point coordinate = new Point { Abscissa = 5, Ordinate = 3 };


            var intString = StringValue.convertString1(intNumber);
            var floatString = StringValue.convertString2(floatNumber);
            var coordinateString = StringValue.convertString3(coordinate);

            var intStringGeneric = StringValueGeneric.convertString(intNumber);
            var floatStringGeneric = StringValueGeneric.convertString(floatNumber);
            var coordinateStringGeneric = StringValueGeneric.convertString(coordinate);

            var sentenceCoordinate = coordinate.ToString();

        }
    }
}
