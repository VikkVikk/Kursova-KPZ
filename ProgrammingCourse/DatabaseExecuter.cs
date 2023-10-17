using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingCourse
{
    public class DatabaseExecuter
    {
        private Database database = new Database();
        private SubjectList subjectList = Register.GetSubjectList();
        private ContractArchive archive = Register.GetContractArchive();

        public void FeelSubjects()
        {
            string subjectName;
            byte studyDuration;
            int price;

            using (SqlCommand sqlCommand = new SqlCommand("MakeSubjects", database.getConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    database.openConnection();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            subjectName = row["subjectName"].ToString();
                            studyDuration = Convert.ToByte(row["studyDuration"]);
                            price = Convert.ToInt32(row["price"]);

                            Subject subject = new Subject(subjectName, studyDuration, price);
                            subjectList.AddSubject(subject);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Помилка при роботі з базою даних.");
                }
                finally
                {
                    database.closeConnection();
                }
            }
        }

        public void FeelContract()
        {
            string studentInfo;
            int number;
            DateTime date;
            string subjectName;
            byte studyDuration;
            int price;
            bool isPayed;

            using (SqlCommand sqlCommand = new SqlCommand("MakeContracts", database.getConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    database.openConnection();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            studentInfo = row["studentInfo"].ToString();
                            number = Convert.ToInt32(row["number"]);
                            date = Convert.ToDateTime(row["date"]);
                            subjectName = row["subjectName"].ToString();
                            studyDuration = Convert.ToByte(row["studyDuration"]);
                            price = Convert.ToInt32(row["price"]);
                            isPayed = Convert.ToBoolean(row["isPayed"]);

                            Contract contract = new Contract(studentInfo, number, date, subjectName, studyDuration, price, isPayed);
                            archive.AddContract(contract);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Помилка при роботі з базою даних.");
                }
                finally
                {
                    database.closeConnection();
                }
            }
        }

        public int getContractNumberFromDB()
        {
            int number = 0;

            using (SqlCommand sqlCommand = new SqlCommand("GetContractNumber", database.getConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    database.openConnection();

                    number = (int)sqlCommand.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("Помилка при роботі з базою даних.");
                }
                finally
                {
                    database.closeConnection();
                }
            }

            return number;
        }

        public void CreateContract(string studentInfo, int number, DateTime date, string subjectName, byte studyDuration, int price)
        {
            bool isPayed = false;

            using (SqlCommand sqlCommand = new SqlCommand("CreateContract", database.getConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@studentInfo", SqlDbType.NVarChar, -1));
                sqlCommand.Parameters["@studentInfo"].Value = studentInfo;

                sqlCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.Int));
                sqlCommand.Parameters["@number"].Value = number;

                sqlCommand.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime));
                sqlCommand.Parameters["@date"].Value = date;

                sqlCommand.Parameters.Add(new SqlParameter("@subjectName", SqlDbType.NVarChar, 50));
                sqlCommand.Parameters["@subjectName"].Value = subjectName;

                sqlCommand.Parameters.Add(new SqlParameter("@studyDuration", SqlDbType.TinyInt));
                sqlCommand.Parameters["@studyDuration"].Value = studyDuration;

                sqlCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Int));
                sqlCommand.Parameters["@price"].Value = price;

                try
                {
                    database.openConnection();
                    sqlCommand.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("Помилка при роботі з базою даних.");
                }
                finally
                {
                    database.closeConnection();
                }
            }

            Contract contract = new Contract(studentInfo, number, date, subjectName, studyDuration, price, isPayed);
            archive.AddContract(contract);
        }

        public void UpdateContractPaymentStatus(bool isPayed, int number)
        {
            using (SqlCommand sqlCommand = new SqlCommand("UpdatePaymentStatusByNumber", database.getConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@contractNumber", SqlDbType.Int));
                sqlCommand.Parameters["@contractNumber"].Value = number;

                try
                {
                    database.openConnection();
                    sqlCommand.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("Помилка при роботі з базою даних.");
                }
                finally
                {
                    database.closeConnection();
                }
            }

            archive.setIsPayed(isPayed);
        }
    }
}
