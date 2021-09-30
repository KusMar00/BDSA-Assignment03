using System;
using Xunit;
using System.IO;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
            // reverse a string
            Action<string> ReverseString = s => {
                var arr = s.ToCharArray();
                Array.Reverse(arr);
                foreach(var c in arr)
                {
                    Console.Write(c);
                }
            };

            // return product of two decimal numbers
            Func<double,double,double> Product = (a,b) => a*b;

            // check numerical value of string
            Func<string, int, bool> n = (s, i) => {
                try 
                {
                    return Int32.Parse(s) == i;
                }
                catch (Exception)
                {
                    return false;
                }
            };
    

        [Fact]
        public void ReverseString_reverses_string()
        {
            // arrange
            var expected = "gnirts a si siht";

            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // act
            ReverseString("this is a string");
            var output = writer.GetStringBuilder().ToString().Trim();
            
            // assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Product_given_two_decimals_returns_product()
        {
            // arrange
            var expected = 7.0;
            
            // act
            var actual = Product(2.0, 3.5);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void n_given_string_0041_and_int_41_returns_true()
        {
            // arrange

            // act
            var actual = n(" 0041 ", 41);

            // assert
            Assert.True(actual);
        }

        [Fact]
        public void n_given_string_V76T_and_int_76_returns_false()
        {
            // arrange

            // act
            var actual = n("V76T", 76);

            // assert
            Assert.False(actual);
        }
    }
}
