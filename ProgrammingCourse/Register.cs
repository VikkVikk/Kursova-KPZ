using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace ProgrammingCourse
{
    static class Register
    {
        private static SubjectList subjectList = new SubjectList();
        private static ContractArchive archive = new ContractArchive();
        private static Calculator calc = new Calculator();
        private static DatabaseExecuter executer = new DatabaseExecuter();

        public static SubjectList GetSubjectList()
        {
            return subjectList;
        }

        public static ContractArchive GetContractArchive()
        {
            return archive;
        }

        public static Calculator GetCalculator()
        {
            return calc;
        }

        public static DatabaseExecuter GetDBExecuter()
        {
            return executer;
        }
    }
}
