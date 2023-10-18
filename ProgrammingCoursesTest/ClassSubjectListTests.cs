using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingCourse;

namespace ProgrammingCoursesTest
{
    [TestClass]
    public class IsSubjectTests
    {
        [TestMethod]
        public void isSubject_SubjectExists()
        {
            // Arrange
            var subjectList = new SubjectList();
            var existingSubject = new Subject("Algorithms", 8, 10000);
            subjectList.AddSubject(existingSubject);

            // Act
            bool result = subjectList.isSubject("Algorithms");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isSubject_SubjectNotExists()
        {
            // Arrange
            var subjectList = new SubjectList();
            var existingSubject = new Subject("Algorithms", 8, 10000);
            subjectList.AddSubject(existingSubject);

            // Act
            bool result = subjectList.isSubject("Databases");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void isSubject_SubjectListIsEmpty()
        {
            // Arrange
            var subjectList = new SubjectList();

            // Act
            bool result = subjectList.isSubject("Algorithms");

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(subjectList.getSubjectName());
        }
    }
}
