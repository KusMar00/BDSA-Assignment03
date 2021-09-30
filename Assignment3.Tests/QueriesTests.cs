using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
        [Theory]
        [InlineData("Harry Potter")]
        [InlineData("Ron Weasly")]
        [InlineData("Hermione Granger")]
        [InlineData("Albus Dumbledore")]
        [InlineData("Newt Scamander")]
        public void GetRowlingWizards_Returns_Name_of_5_Wizards(string name)
        {
            // arrange

            // act
            var query = Queries.GetRowlingWizards();

            // assert
            Assert.Contains(query, n => n == name);
        }
        [Theory]
        [InlineData("Harry Potter")]
        [InlineData("Ron Weasly")]
        [InlineData("Hermione Granger")]
        [InlineData("Albus Dumbledore")]
        [InlineData("Newt Scamander")]
        public void GetRowlingWizardsExtension_Returns_Name_of_5_Wizards(string name)
        {
            // arrange

            // act
            var query = Queries.GetRowlingWizardsExtension();

            // assert
            Assert.Contains(query, n => n == name);
        }
        [Fact]
        public void GetYearOfFirstSith_Returns_1977()
        {
            // arrange

            // act
            var query = Queries.GetYearOfFirstSith();

            // assert
            Assert.Equal(1977, query);
            
        }
        [Fact]
        public void GetYearOfFirstSithExtension_Returns_1977()
        {
            // arrange

            // act
            var query = Queries.GetYearOfFirstSithExtension();

            // assert
            Assert.Equal(1977, query);
            
        }

        [Fact]
        public void GetWizardsFromHP_Returns_4_Tuples()
        {
            // arrange
            IEnumerable<(string, int?)> expected = new List<(string, int?)>{("Harry Potter", 1997),("Ron Weasly",1998),("Hermione Granger",1998),("Albus Dumbledore",1997)};
            // act
            var query = Queries.GetWizardsFromHP();

            // assert
            Assert.Equal(expected, query);
        }

        [Fact]
        public void GetWizardsFromHPExtension_Returns_4_Tuples()
        {
            // arrange
            IEnumerable<(string, int?)> expected = new List<(string, int?)>{("Harry Potter", 1997),("Ron Weasly",1998),("Hermione Granger",1998),("Albus Dumbledore",1997)};
            // act
            var query = Queries.GetWizardsFromHPExtension();

            // assert
            Assert.Equal(expected, query);
        }

        [Fact]
        public void GetWizardNamesSortedByCreator()
        {
            // arrange
            IEnumerable<string> expected = new List<string>{"Dr. Strange","Merlin", "Gandalf", "Sauron",
                                                            "Albus Dumbledore", "Harry Potter",
                                                            "Hermione Granger", "Newt Scamander",
                                                            "Ron Weasly", "Darth Vader",
                                                            "Luke Skywalker", "Yoda"};
            // act
            var query = Queries.GetWizardNamesSortedByCreator();

            // assert
            Assert.Equal(expected, query);
        }

        [Fact]
        public void GetWizardNamesSortedByCreatorExtension()
        {
            // arrange
            IEnumerable<string> expected = new List<string>{"Dr. Strange","Merlin", "Gandalf", "Sauron",
                                                            "Albus Dumbledore", "Harry Potter",
                                                            "Hermione Granger", "Newt Scamander",
                                                            "Ron Weasly", "Darth Vader",
                                                            "Luke Skywalker", "Yoda"};
            // act
            var query = Queries.GetWizardNamesSortedByCreatorExtension();

            // assert
            Assert.Equal(expected, query);
        }
    }
}
