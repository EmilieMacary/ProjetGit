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

        [Fact]
        public void ReturnIIwhen2()
        {
            Assert.Equal(2, RomanNumerals.Translate("II"));
        }

        [Fact]
        public void ReturnIIIwhen3()
        {
            Assert.Equal(3, RomanNumerals.Translate("III"));
        }

        [Fact]
        public void ReturnIVwhen4()
        {
            Assert.Equal(4, RomanNumerals.Translate("IV"));
        }
    }
}
