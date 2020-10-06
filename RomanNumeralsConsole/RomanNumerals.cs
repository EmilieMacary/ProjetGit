using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConsole
{
    public class RomanNumerals
    {
        public static int Translate (string romanNumber)
        {
            if (romanNumber == "I")
                return 1;
            else if (romanNumber == "V")
                return 5;
            else if (romanNumber == "X")
                return 10;
            else
                return 0;
        }

    }
}
