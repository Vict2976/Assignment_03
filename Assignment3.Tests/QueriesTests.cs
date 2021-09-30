using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void return_names_of_wizards_created_by_Rowling_linq_query()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;

            //Act
            var output = Queries.returnLinqInventedByRowling();

            //Assert
            Assert.Equal(new List<string>{"Harry Potter", "Ron Weasly", "Hermione granger"}, output);

        }

        [Fact]
        public void return_names_of_wizards_created_by_Rowling_lambda()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;

            //Act
            var output = Queries.returnLambdaInventedByRowling();

            //Assert
            Assert.Equal(new List<string>{"Harry Potter", "Ron Weasly", "Hermione granger"}, output);

        }

        [Fact]
        public void return_first_year_sith_lord_linq()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;

            //Act
            var output = Queries.returnLinqFirstSithLord().First();

            //Assert
            Assert.Equal("Obi-Wan Kenobi", output);
        }

        [Fact]
        public void return_first_year_sith_lord_lambsa()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;

            //Act
            var output = Queries.returnLambdaFirstSithLord().First();

            //Assert
            Assert.Equal("Obi-Wan Kenobi", output);
        }

    }
}



//The year the first sith lord was introduced. 
//Let's define a sith lord to be one named Darth something.