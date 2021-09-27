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

        [Fact]
        public void WordCount_given_7_unicode_words_returns_7()
        {
            // arrange
            var input = "?hello this, is a word (37) count method!!";

            // act
            var output = input.WordCount();

            // assert
            Assert.Equal(7, output);
        }
    }
}
