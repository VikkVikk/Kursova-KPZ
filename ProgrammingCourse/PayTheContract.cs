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
    public partial class PayTheContract : Form
    {
        private ContractArchive archive = Register.GetContractArchive();

        public PayTheContract()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtSearchNumber.Text.Trim(), out int number))
            {
                if (archive.isContract(number))
                {
                    txtContractPIB.Text = archive.getContractStudentInfo();
                    txtContractNumber.Text = Convert.ToString(archive.getContractNumber());
                    txtContractDate.Text = Convert.ToString(archive.getContractDate());
                    txtContractSubjectName.Text = archive.getContractSubjectName();
                    txtContractStudyDuration.Text = $"{archive.getContractStudyDuration()} місяці(в)";
                    txtContractPrice.Text = $"{archive.getContractPrice()} гривень";

                    btnReset.Enabled = true;
                    btnClear.Enabled = true;

                    if (archive.getContractIsPayed())
                    {
                        txtContractIsPayed.Text = "Сплачений";
                        btnPay.Enabled = false;
                    }
                    else
                    {
                        txtContractIsPayed.Text = "Не сплачений";
                        btnPay.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Контракту з таким номером не існує.");
                }
            }
            else
            {
                MessageBox.Show("Помилка! Введений рядок не є набором цифр.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContractPIB.Clear();
            txtContractNumber.Clear();
            txtContractDate.Clear();
            txtContractSubjectName.Clear();
            txtContractStudyDuration.Clear();
            txtContractPrice.Clear();
            txtContractIsPayed.Clear();

            btnPay.Enabled = false;
            btnClear.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentWindow pwind = new PaymentWindow();
            pwind.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (archive.isContract(Convert.ToInt32(txtContractNumber.Text)))
            {
                if (archive.getContractIsPayed())
                {
                    txtContractIsPayed.Text = "Сплачений";
                    btnPay.Enabled = false;
                }
                else
                {
                    txtContractIsPayed.Text = "Не сплачений";
                    btnPay.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Неможливо оновити.");
            }
        }
    }
}
