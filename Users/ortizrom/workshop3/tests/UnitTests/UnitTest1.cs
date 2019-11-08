using System;
using System.Linq;
using MyApp.Controllers;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {

        private readonly ValuesController controller;

        public UnitTest1()
        {
            this.controller = new ValuesController();
        }

        [Fact]
        public void Test1()
        {
                Assert.True(true);
        }

        [Fact]
        public void Testname()
        {
                Assert.True(false, "you fucked up");
        }

        [Fact]
        public void ValuesControllerTests()
        {
            
        }

        [Fact]
        public void TestGet()
        {
            var values = this.controller.Get();

            Assert.True(values.Value.Count() == 2);
                
        }
    }

   
}
