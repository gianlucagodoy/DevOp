using System;
using Xunit;
using SimpleOne.Controllers;

namespace SimpleOne.test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]//Basically a test 

        public void GetReturnsMyName(){
            Console.WriteLine($"\n\n\nQUalquer vcalor apsdjfejc\n\n");
            int i = 2;
            var returnValue = controller.Get(i);
            Assert.Equal("Casa "+i, returnValue.Value);

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
