using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingCourse;

namespace ProgrammingCoursesTest
{
    [TestClass]
    public class SubjectTests
    {
        [TestMethod]
        public void TestGetSubjectType_Negative1()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", -1, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Неможливо визначити...", result);
        }

        [TestMethod]
        public void TestGetSubjectType_0()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 0, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Неможливо визначити...", result);
        }

        [TestMethod]
        public void TestGetSubjectType_1()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 1, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Експрес-курс", result);
        }

        [TestMethod]
        public void TestGetSubjectType_5()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 5, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Експрес-курс", result);
        }

        [TestMethod]
        public void TestGetSubjectType_6()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 6, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Експрес-курс", result);
        }

        [TestMethod]
        public void TestGetSubjectType_7()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 7, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Загальний курс", result);
        }

        [TestMethod]
        public void TestGetSubjectType_11()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 11, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Загальний курс", result);
        }

        [TestMethod]
        public void TestGetSubjectType_12()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 12, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Загальний курс", result);
        }

        [TestMethod]
        public void TestGetSubjectType_13()
        {
            // Arrange
            Subject subject = new Subject("TestSubject", 13, 100);

            // Act
            string result = subject.getStudyType();

            // Assert
            Assert.AreEqual("Поглиблений курс", result);
        }
    }
}