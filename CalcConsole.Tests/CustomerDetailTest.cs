using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcConsole.Tests
{
    [Collection("Customer")]
    public class CustomerDetailTest
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenTwoNames_ReturnsFullName() {
            Assert.Equal("Camilo Forero", _customerFixture.Cust.GetFullName("Camilo", "Forero"));
        }
    }
}
