using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using ProgrammingCourse;

namespace ProgrammingCoursesTest
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void TestOpenConnection()
        {
            // Arrange
            Database database = new Database();

            // Act
            database.openConnection();

            // Assert
            Assert.AreEqual(System.Data.ConnectionState.Open, database.getConnection().State);
        }

        [TestMethod]
        public void TestCloseConnection()
        {
            // Arrange
            Database database = new Database();

            // Act
            database.closeConnection();

            // Assert
            Assert.AreEqual(System.Data.ConnectionState.Closed, database.getConnection().State);
        }

        [TestMethod]
        public void TestGetConnection()
        {
            // Arrange
            Database database = new Database();

            // Act
            SqlConnection connection = database.getConnection();

            // Assert
            Assert.IsNotNull(connection);
            Assert.AreEqual(@"Data Source=DESKTOP-UH3DL2B\SQLEXPRESS;Initial Catalog=OnlineCourcesDB;Integrated Security=True", connection.ConnectionString);
        }
    }
}