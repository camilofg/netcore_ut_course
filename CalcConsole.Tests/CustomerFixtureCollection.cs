using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcConsole.Tests
{
    [CollectionDefinition("Customer")]
    public class CustomerFixtureCollection : IClassFixture<CustomerFixture>
    {
    }
}
