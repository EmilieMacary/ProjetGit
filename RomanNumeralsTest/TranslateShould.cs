using RomanNumeralsConsole;
using System.Collections.Generic;
using Xunit;

namespace RomanNumeralsTest
{
    public class TranslateShould
    {
        [Fact]
        public void ReturnIwhen1()
        {
            Assert.Equal(1, RomanNumerals.Translate("I"));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        //[InlineData("VI", 5)]
        //[InlineData("VII", 5)]
        //[InlineData("VII", 5)]
        //[InlineData("IX", 9)]
        [InlineData("X", 10)]

        public void ReturnResultwhenRomanNumber(string romanNumber, int result)
        {
            Assert.Equal(result, RomanNumerals.Translate(romanNumber));
        }

        [Fact]
        public void Return()
        {
            Assert.Throws<KeyNotFoundException>(() => RomanNumerals.Translate("G"));
        }
    }
}
