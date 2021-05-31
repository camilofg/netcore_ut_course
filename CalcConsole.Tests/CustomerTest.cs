using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcConsole.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void NameShouldNotBeNull() {
            var customer = new Customer("camilo");
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckForLegitDiscount() {
            var customer = new Customer();
            Assert.InRange(customer.Age, 20, 45);
        }

        [Fact]
        public void CheckNotForLegitDiscount()
        {
            var customer = new Customer();
            Assert.NotInRange(customer.Age, 20, 20);
        }

        [Fact]
        public void GetOrdersByName_GivenOneName_ShouldReturnValue() {
            var customer = new Customer();
            var result = customer.GetOrdersByName("Camilo");
            Assert.Equal(100, result);
        }

        [Fact]
        public void GetOrdersByName_WithoutGivenName_ShouldThrowException()
        {
            var customer = new Customer();
            //var result = customer.GetOrdersByName("");
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
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
