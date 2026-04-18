using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)

        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [
            Test,
            TestCase("Asdasdgg", false),
            TestCase("ASDASD12", false),
            TestCase("asdasd12", false),
            TestCase("As1", false),
            TestCase("Asdasd1234", true)
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();
            // Act
            var actualResult = accountController.ValidatePassword(password);
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [
            Test,
            TestCase("irf@uni-corvinus.hu", "Abcd1234"),
            TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            // Arrange
            var accountController = new AccountController();
            // Act
            var actualResult = accountController.Register(email, password);
            // Assert
            Assert.That(actualResult.Email, Is.EqualTo(email));
            Assert.That(actualResult.Password, Is.EqualTo(password));
            Assert.That(actualResult.ID, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public void TestRegisterValidateException() 
        {
            //Arrange
            var accountController = new AccountController();
            //Act
            var actualResult = accountController.Register("irf.uni-corvinus.hu", "Abcd1234");
        }
    }
}