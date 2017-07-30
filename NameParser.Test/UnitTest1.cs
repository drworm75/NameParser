using System;
using NameParser.App;
using Xunit;

namespace NameParser.Test
{
    public class WhenParsingNameINformation
    {
        [Fact]
        public void OneNameIsEnteredFirstNameIsPopulated()
        {
            // Testing in 3 steps
            // 1 Arrange
            var name = "Zendaya";
            var nameParser = new Parser();
            // 2 Act (What were Testing)
            var result = nameParser.ParseName(name);
            // 3 Assert
            Assert.Equal(result.FirstName, "Zendaya");
        }

            [Fact]
            public void TwoNamesAreEnteredFirstAndLastNameArePopulated()
            {
                // 1 Arrange
                var name = "Steve Jones";
                var nameParser = new Parser();
                // 2 Act (What were Testing)
                var result = nameParser.ParseName(name);
                // 3 Assert
                Assert.Equal(result.FirstName, "Steve");
                Assert.Equal(result.LastName, "Jones");

            }
           [Fact]
            public void TwoNamesWithDoubleBarreledLastNameAreEnteredFirstAndLastNameArePopulated()
            {
                // 1 Arrange
                var name = "Mary Barnes-Jones";
                var nameParser = new Parser();
                // 2 Act (What were Testing)
                var result = nameParser.ParseName(name);
                // 3 Assert
                Assert.Equal(result.FirstName, "Mary");
                Assert.Equal(result.LastName, "Barnes-Jones");

            }    

           [Fact]
            public void TwoNamesPlusMiddleInitialEnteredFirstNameMiddleInitialLastNamePopulated()
            {
                // 1 Arrange
                var name = "Steve L. Jones";
                var nameParser = new Parser();
                // 2 Act (What were Testing)
                var result = nameParser.ParseName(name);
                // 3 Assert
                Assert.Equal(result.FirstName, "Steve");
                Assert.Equal(result.MiddleInitial, "L");
                Assert.Equal(result.LastName, "Jones");

            }  

           [Fact]
            public void TwoNamesPlusSuffixEnteredFirstNameLastNameSuffixPopulated()
            {
                // 1 Arrange
                var name = "Bob Marley Jr.";
                var nameParser = new Parser();
                // 2 Act (What were Testing)
                var result = nameParser.ParseName(name);
                // 3 Assert
                Assert.Equal(result.FirstName, "Bob");
                Assert.Equal(result.LastName, "Marley");
                Assert.Equal(result.Honorific, "Jr.");
            } 

           [Fact]
            public void TwoNamesPlusPrefixOfLength3EnteredFirstNameLastNamePrefixPopulated()
            {
                // 1 Arrange
                var name = "Mr. Bob Michaels";
                var nameParser = new Parser();
                // 2 Act (What were Testing)
                var result = nameParser.ParseName(name);
                // 3 Assert
                Assert.Equal(result.FirstName, "Bob");
                Assert.Equal(result.LastName, "Michaels");
                Assert.Equal(result.Honorific, "Mr.");
            } 

           [Fact]
            public void TwoNamesPlusPrefixOfLength4EnteredFirstNameLastNamePrefixPopulated()
            {
                // 1 Arrange
                var name = "Mrs. Aunt Jemima";
                var nameParser = new Parser();
                // 2 Act (What were Testing)
                var result = nameParser.ParseName(name);
                // 3 Assert
                Assert.Equal(result.FirstName, "Aunt");
                Assert.Equal(result.LastName, "Jemima");
                Assert.Equal(result.Honorific, "Mrs.");
            } 

        // [Theory]
        // [InlineData("Steve Jones","Steve","Jones")]
        // [InlineData("Mary Barnes-Jones","Mary","Barnes-Jones")]
        // [InlineData("Nathan Barnes-Jones","Nathan","Barnes-Jones")]
        // public void TwoNamesAreEnteredFirstAndLastNameArePopulated(string nameToTest, string expectedFirstName,string expectedLastName) 
        // {
        //     //Arrange
        //     var nameParser = new Parser();
        //     //Act
        //     var result = nameParser.ParseName(nameToTest);
        //     //Assert
        //     Assert.Equal(result.FirstName, expectedFirstName);
        //     Assert.Equal(result.LastName, expectedLastName);
        // }


        }
    }


