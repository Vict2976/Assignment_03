using System;
using Xunit;

namespace Assignment3.Tests
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
            Assert.True(uriOneBool);
        }

        [Fact]
        public void Test_If_WordCount_Returns_5_Given_Array_Of_5_Words_And_One_Number() 
        {
            //Arrange
            string input = "Hello my name is number 42";

            //Act
            int output = input.WordCount();

            //Assert
            Assert.Equal(5, output);

        }
    }
}
