using SonarCubePractice1.Controllers;
using System;
using Xunit;

namespace SonarCubePractice1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            Assert.True(true);

        }
        [Fact]
        public void Test3()
        {
            ValuesController valuesController = new ValuesController();
            var res= valuesController.Get();
            Assert.NotNull(res);
        }
    }
}
