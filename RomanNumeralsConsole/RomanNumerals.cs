using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConsole
{
    public class RomanNumerals
    {
        public static int Translate (string romanNumber)
        {
            if (romanNumber.Length == 1)
            {
                if (romanNumber == "I")
                    return 1;
                else if (romanNumber == "V")
                    return 5;
                else if (romanNumber == "X")
                    return 10;
            }
            else
            {
                int result = 0;
                int iDigit = 0;
                while(iDigit < romanNumber.Length - 1 && romanNumber[iDigit] == romanNumber[iDigit + 1])
                {
                    result++;
                    iDigit++;
                }
                if (result > 0)
                    return result + 1;
                else if (romanNumber == "IV")
                    return 4;
            }

            return 0;
        }

    }
}
