using System;
using Xunit;

namespace CalcConsole.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(3, 4);
            Assert.Equal(7, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble() {
            var calc = new Calculator();
            var result = calc.AddDouble(2.3, 4.2);
            Assert.Equal(6.5, result);
        }
    }
}
