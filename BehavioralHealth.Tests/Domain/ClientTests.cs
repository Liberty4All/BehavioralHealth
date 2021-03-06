using BehavioralHealth.Domain;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BehavioralHealth.Tests
{
    [TestClass]
    public class ClientTests
    {
        int id = 0;
        string firstName;
        string lastName;
        DateTime birthDate;
        Gender gender;
        Race race;
        Ethnicity ethnicity;

        public void Initialize()
        {
            firstName = "Bob";
            lastName = "Tester";
            birthDate = DateTime.Now.Date.AddYears(-25);
            gender = new Gender(GenderType.Male);
            race = new Race(RaceType.White);
            ethnicity = new Ethnicity(EthnicityType.NotOfHispanicOrigin);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_FirstNameNull_MissingValueError()
        {
            // Arrange
            Initialize();
            firstName = "";

            // Act
            Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Missing value\nParameter name: First Name");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_LastNameNull_MissingValueError()
        {
            // Arrange
            Initialize();
            lastName = null;

            // Act
            Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Missing value\nParameter name: Last Name");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_BirthdateTooLongAgo_InvalidValueError()
        {
            // Arrange
            Initialize();
            birthDate = DateTime.Now.Date.AddYears(-121);

            // Act
            Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

            // Assert
            result.Should().Throw<ArgumentOutOfRangeException>()
               .WithMessage("More than 120 years ago\nParameter name: Date of Birth");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_EthnicityNull_InvalidValueError()
        {
            // Arrange
            Initialize();
            ethnicity = null;

            // Act
            Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Missing value\nParameter name: Ethnicity");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_GenderNull_InvalidValueError()
        {
            // Arrange
            Initialize();
            gender = null;

            // Act
            Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Missing value\nParameter name: Gender");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_RaceNull_InvalidValueError()
        {
            // Arrange
            Initialize();
            race = null;

            // Act
            Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Missing value\nParameter name: Race");
        }
    }
}
