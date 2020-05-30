using System;
using Xunit;
using simpleAPI;




namespace simpleAPI.test
{
    public class UnitTest1
    {
        SimpleAPI.Controllers.valuesController controller = new SimpleAPI.Controllers.valuesController();
        [Fact]
        public void getReturnMyName()
        {
            var retValue = controller.Get(1);
            Assert.Equal("SYN Test",retValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
