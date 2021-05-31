using System;
using System.Collections.Generic;
using System.Text;

namespace CalcConsole
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Age => 35;


        public string GetFullName(string firstName, string lastName) {
            return $"{firstName} {lastName}";
        }

        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("param name is empty or null");
            return 100;
        }

    }
    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }
        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 10;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customer();
            return new LoyalCustomer();
        }
    }

}