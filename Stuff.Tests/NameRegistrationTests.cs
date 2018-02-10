using NUnit.Framework;
using Stuff.App;

namespace Stuff.Tests
{
    [TestFixture]
    public class NameRegistrationTests
    {
        [Test]
        public void Entering_one_name_results_in_the_first_name_being_filled_out()
        {
            //Arrange
            var name = "Cher";
            var nameParser = new NameParser();

            //Act
            var result = nameParser.Parse(name);

            //Assert
            Assert.AreEqual("Cher", result.FirstName);
            Assert.IsNull(result.MiddleName);
            Assert.IsNull(result.LastName);
        }

        [Test]
        public void Entering_two_names_results_in_the_first_name_and_the_last_name_being_filled_out()
        {
            //Arrange
            var name = "John Doe";
            var nameParser = new NameParser();

            //Act
            var result = nameParser.Parse(name);

            //Assert
            Assert.AreEqual("John", result.FirstName);
            Assert.IsNull(result.MiddleName);
            Assert.AreEqual("Doe", result.LastName);
        }

    }
}
