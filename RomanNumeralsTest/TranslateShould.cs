using System;
using Xunit;
using RomanNumeralsConsole;

namespace RomanNumeralsTest
{
    public class TranslateShould
    {
        [Fact]
        public void ReturnIwhen1()
        {
            Assert.Equal(1, RomanNumerals.Translate("I"));
        }

        [Fact]
        public void ReturnVwhen5()
        {
            Assert.Equal(5, RomanNumerals.Translate("V"));
        }

        [Fact]
        public void ReturnXwhen10()
        {
            Assert.Equal(10, RomanNumerals.Translate("X"));
        }
    }
}
