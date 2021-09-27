using System;
using Xunit;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void IsSecure_given_http_returns_false()
        {
            // arrange
            var input = new Uri("http://www.google.com");

            // act
            var output = input.IsSecure();

            // assert
            Assert.False(output);
        }

                [Fact]
        public void IsSecure_given_https_returns_true()
        {
            // arrange
            var input = new Uri("https://www.yahoo.com");

            // act
            var output = input.IsSecure();

            // assert
            Assert.True(output);
        }
    }
}
