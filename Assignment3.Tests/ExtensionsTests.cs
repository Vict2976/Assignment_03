using System;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Uri uriOne = new Uri("https://helloworld.com");
            
            //Act 
            bool uriOneBool = uriOne.IsSecure();

            //Assert
            Assert.Equal(true, uriOneBool);
        }
    }
}
