using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingCourse;

namespace ProgrammingCoursesTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestGetRest_PositiveRest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.setCash(20000);
            calculator.setPrice(15000);

            // Act
            int rest = calculator.getRest();

            // Assert
            Assert.AreEqual(5000, rest);
        }

        [TestMethod]
        public void TestGetRest_ZeroRest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.setCash(10000);
            calculator.setPrice(10000);

            // Act
            int rest = calculator.getRest();

            // Assert
            Assert.AreEqual(0, rest);
        }

        [TestMethod]
        public void TestGetRest_NegativeRest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.setCash(5000);
            calculator.setPrice(10000);

            // Act
            int rest = calculator.getRest();

            // Assert
            Assert.AreEqual(-5000, rest);
        }
    }    
}
