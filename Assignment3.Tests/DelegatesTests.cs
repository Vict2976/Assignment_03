using Xunit;
using System;
using System.IO;
using System.Linq;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
        
        [Fact]
        public void stringreverse_prints_olleH_when_given_Hello()
        {
            //Arrange
            Action<string> printReverseString = (line) => Console.WriteLine(Reverse(line));
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            printReverseString("Hello");
            
            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("olleH", output);
        }
        
        [Fact]
        public void product_returns_8_given_2_and_4()
        {
            //Arrange
            Func<int, int, int> Product = (x, y) => x * y;
            
            //Act
            var output = Product(2, 4);

            //Assert
            Assert.Equal(8, output);
        }

        [Fact]
        public void equal_returns_true_when_given_int_42_and_string_0042()
        {
            //Arrange
            Func<int, string, bool> equal = (x, stringX) => x == Int32.Parse(stringX);
            
            //Act
            bool output = equal(42, "0042");

            //Assert
            Assert.True(output);
        }
        
    }
}
