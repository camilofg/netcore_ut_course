using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcConsole.Tests
{
    public class NamesTest
    {
        [Fact]
        public void GetFullName_WithTwoGivenNames_ReturnsFullName() {
            var names = new Names();
            var result = names.GetFullName("Camilo", "Forero");
            Assert.Equal("Sr Camilo Forero", result);
            Assert.Contains("Sr", result);
            Assert.Equal("Sr camilo Forero", result, ignoreCase:true); //ignoreCase: StringComparison.InvariantCultureIgnoreCase
            Assert.StartsWith("Sr", result);
            Assert.EndsWith("Forero", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull() {
            var names = new Names();
            Assert.Null(names.NickName);
        }

        [Fact]
        public void NickName_MustBeNotNull()
        {
            var names = new Names();
            names.NickName = "Test";
            Assert.NotNull(names.NickName);
        }

        [Fact]
        public void GetFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.GetFullName("Camilo", "Forero");
            Assert.NotNull(result);
            Assert.True(!string.IsNullOrEmpty(result));
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
