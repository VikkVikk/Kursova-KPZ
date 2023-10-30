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
    public partial class PaymentWindow : Form
    {
        private int rest;
        private Calculator calculator = Register.GetCalculator();
        private ContractArchive archive = Register.GetContractArchive();
        private DatabaseExecuter executer = Register.GetDBExecuter();

        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void PaymentWindow_Load(object sender, EventArgs e)
        {
            int contractPrice = archive.getContractPrice();

            calculator.setPrice(contractPrice);
            txtPrice.Text = Convert.ToString(contractPrice);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(Register.IsValidCash(txtCash.Text, out int cash))
            {
                calculator.setCash(cash);
                rest = calculator.getRest();
                txtRest.Text = Register.getRestMessage(rest);
            }
            else
            {
                if (txtCash.Text != "")
                {
                    MessageBox.Show("Введений рядок не є числом");
                    txtCash.Clear();
                    txtRest.Clear();
                }
            }
        }

        private void txtRest_TextChanged(object sender, EventArgs e)
        {
            if (rest >= 0)
            {
                btnPay.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            executer.UpdateContractPaymentStatus(true, archive.getContractNumber());
            this.Close();
        }
    }
}
