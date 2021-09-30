using Xunit;

namespace Assignment3.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_12_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Luke Skywalker","Star Wars",1977,"George Lucas")]
        [InlineData("Yoda","Star Wars",1977,"George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Gandalf", "The Hobbit",1937, "J.R.R. Tolkien")]
        [InlineData("Harry Potter","Harry Potter",1997,"J.K. Rowling")]
        [InlineData("Ron Weasly","Harry Potter",1998,"J.K. Rowling")]
        [InlineData("Hermione Granger","Harry Potter",1998,"J.K. Rowling")]
        [InlineData("Albus Dumbledore","Harry Potter",1997,"J.K. Rowling")]
        [InlineData("Newt Scamander","Fantastic Beasts",2016,"J.K. Rowling")]
        [InlineData("Merlin","Merlin",2008,"Julian Jones")]
        [InlineData("Dr. Strange","Strange Tales", 1963,"Stan Lee")]
        
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

