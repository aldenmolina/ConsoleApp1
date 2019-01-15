using System;
using Xunit;

namespace ConsoleApp1.tests
{
    public class ProgramTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello", "Hello");
        }
    }
}
