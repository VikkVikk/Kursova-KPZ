using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProgrammingCourse
{
    public class Database
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UH3DL2B\SQLEXPRESS;Initial Catalog=OnlineCourcesDB;Integrated Security=True");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
