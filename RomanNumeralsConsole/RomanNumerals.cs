using System.Collections.Generic;

namespace RomanNumeralsConsole
{
    public class RomanNumerals
    {
        static readonly Dictionary<string, int> RomanDigitDictionary = new Dictionary<string, int>()
        {
            {"I", 1},
            {"V", 5},
            {"X", 10}
        };

        public static int Translate(string romanNumber)
        {
            if (romanNumber.Length == 1)
            {
                //RomanDigitDictionary.TryGetValue(romanNumber, out int numberResult);

                return RomanDigitDictionary[romanNumber];
            }
            else
            {
                int result = 0;
                int iDigit = 0;
                while (iDigit < romanNumber.Length - 1 && romanNumber[iDigit] == romanNumber[iDigit + 1])
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
