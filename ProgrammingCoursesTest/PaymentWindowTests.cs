using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingCourse;

namespace ProgrammingCoursesTest
{
    [TestClass]
    public class PaymentWindowTests
    {
        [TestMethod]
        public void IsValidCash_ValidPositiveInput_ShouldReturnTrue()
        {
            // Arrange
            string validInput = "10000";
            int cash;

            // Act
            bool isValid = Register.IsValidCash(validInput, out cash);

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(10000, cash);
        }

        [TestMethod]
        public void IsValidCash_InvalidNegativeInput_ShouldReturnFalse()
        {
            // Arrange
            string invalidInput = "-1000";
            int cash;

            // Act
            bool isValid = Register.IsValidCash(invalidInput, out cash);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(-1000, cash);
        }

        [TestMethod]
        public void IsValidCash_InvalidLetterInput_ShouldReturnFalse()
        {
            // Arrange
            string invalidInput = "aBcD";
            int cash;

            // Act
            bool isValid = Register.IsValidCash(invalidInput, out cash);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(0, cash);
        }

        [TestMethod]
        public void IsValidCash_InvalidSymbolInput_ShouldReturnFalse()
        {
            // Arrange
            string invalidInput = "%@*";
            int cash;

            // Act
            bool isValid = Register.IsValidCash(invalidInput, out cash);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(0, cash);
        }

        [TestMethod]
        public void getRestMessage_PositiveRest_ShouldReturnRestAsString()
        {
            // Arrange
            int positiveRest = 50;

            // Act
            string message = Register.getRestMessage(positiveRest);

            // Assert
            Assert.AreEqual("50", message);
        }

        [TestMethod]
        public void getRestMessage_NegativeRest_ShouldReturnErrorMessage()
        {
            // Arrange
            int negativeRest = -30;

            // Act
            string message = Register.getRestMessage(negativeRest);

            // Assert
            Assert.AreEqual("Не вистачає: 30", message);
        }
    }
}
