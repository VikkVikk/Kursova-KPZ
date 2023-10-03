using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingCourse
{
    public partial class ContractCreation : Form
    {
        private SubjectList subjectList = Register.GetSubjectList();
        private DatabaseExecuter executer = Register.GetDBExecuter();

        public ContractCreation()
        {
            InitializeComponent();
        }

        private void ContractCreation_Load(object sender, EventArgs e)
        {
            txtSubjectName.ReadOnly = true;
            txtStudyDuration.ReadOnly = true;
            txtStudyPrice.ReadOnly = true;
            txtClientPIB.ReadOnly = true;
            txtContract.ReadOnly = true;

            btnClear.Enabled = false;
            btnDrawUpContract.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubjectName.Clear();
            txtStudyDuration.Clear();
            txtStudyPrice.Clear();
            txtClientPIB.Clear();
            txtContract.Clear();

            txtClientPIB.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (subjectList.isSubject(txtSearchSubName.Text.Trim()))
            {
                txtSubjectName.Text = subjectList.getSubjectName();
                txtStudyDuration.Text = Convert.ToString(subjectList.getStudyDuration()) + " місяці(в)";
                txtStudyPrice.Text = Convert.ToString(subjectList.getPrice()) + " гривень";

                txtClientPIB.ReadOnly = false;
                btnClear.Enabled = true;
            }
            else
            {
                MessageBox.Show("Такого предмету не існує.");
            }
        }

        private void txtClientPIB_TextChanged(object sender, EventArgs e)
        {
            if (txtClientPIB.Text.Length > 0 && txtClientPIB.Text.Trim() != "")
            {
                btnDrawUpContract.Enabled = true;
            }
            else
            {
                btnDrawUpContract.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void btnDrawUpContract_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            int number = executer.getContractNumberFromDB();

            executer.CreateContract(txtClientPIB.Text.Trim(), number, time, subjectList.getSubjectName(),
                                    subjectList.getStudyDuration(), subjectList.getPrice());

            txtContract.Text = $"                                             Контракт №{number}                                   \n" +
                                "                                        надання освітніх послуг                                 \n" +
                                "                               курси з програмування CodeWave                              \n\n" +
                               $"                                                                                     {time} \n\n\n" +
                               $"       Замовнику {txtClientPIB.Text.Trim()} надається послуга навчання\n" +
                               $"  на курсі \"{subjectList.getSubjectName()}\" на термін {subjectList.getStudyDuration()} місяці(в).\n\n" +
                               $"  Вартість навчання: {subjectList.getPrice()} гривень.    \n\n\n" +
                                "  Підпис: ___________                                                ";

            btnDrawUpContract.Enabled = false;
            btnPrint.Enabled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtContract.Text, new Font("Times New Roman", 18), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
