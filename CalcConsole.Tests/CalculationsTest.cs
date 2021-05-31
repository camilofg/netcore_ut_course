using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CalcConsole.Tests
{
    public class CalculationsFixture { 
        public Calculations calc => new Calculations();
    }
    public class CalculationsTest : IClassFixture<CalculationsFixture>, IDisposable
    {
        private readonly CalculationsFixture _calculationsFixture;
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryStream memoryStream;

        public CalculationsTest(CalculationsFixture calculationsFixture, ITestOutputHelper testOutputHelper)
        {
            _calculationsFixture = calculationsFixture;
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Constructor");
            memoryStream = new MemoryStream();
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = _calculationsFixture.calc;
            var result = calc.Add(3, 4);
            Assert.Equal(7, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = _calculationsFixture.calc;
            var result = calc.AddDouble(2.3, 4.2);
            Assert.Equal(6.5, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = _calculationsFixture.calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = _calculationsFixture.calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes4()
        {
            var calc = _calculationsFixture.calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckAllCollection() {
            _testOutputHelper.WriteLine($"Checking fibo collection. Test starting at {DateTime.Now}");
            var expextedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculationsFixture.calc;
            Assert.Equal(expextedCollection, calc.FiboNumbers);
        }

        public void Dispose()
        {
            memoryStream.Close();

        }
    }
}
