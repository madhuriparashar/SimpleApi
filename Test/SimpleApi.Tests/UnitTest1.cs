using System;
using Xunit;
using SimpleApi;


namespace SimpleApi.Tests
{
    
    public class UnitTest1
    {
        ValuesController valuesController = new ValuesController();
        [Fact]
        public void Test1()
        {
      var result =   valuesController.Get(1);
        Assert.Equal("Unit Test Message  - faile",result);

        }
    }
}
