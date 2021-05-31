using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcConsole.Tests
{
    [Collection("Customer")]
    public class CustomerTest
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void NameShouldNotBeNull() {
            var customer = new Customer("camilo");
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckForLegitDiscount() {
            Assert.InRange(_customerFixture.Cust.Age, 20, 45);
        }

        [Fact]
        public void CheckNotForLegitDiscount()
        {
            Assert.NotInRange(_customerFixture.Cust.Age, 20, 20);
        }

        [Fact]
        public void GetOrdersByName_GivenOneName_ShouldReturnValue() {
            var result = _customerFixture.Cust.GetOrdersByName("Camilo");
            Assert.Equal(100, result);
        }

        [Fact]
        public void GetOrdersByName_WithoutGivenName_ShouldThrowException()
        {
            //var result = customer.GetOrdersByName("");
            var exceptionDetails = Assert.Throws<ArgumentException>(() => _customerFixture.Cust.GetOrdersByName(null));
            Assert.Equal("param name is empty or null", exceptionDetails.Message);
        }

        [Fact]
        public void CreateCustomer_ReturnLoyalForOrderG100() {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            //Assert.IsType<LoyalCustomer>(customer);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
