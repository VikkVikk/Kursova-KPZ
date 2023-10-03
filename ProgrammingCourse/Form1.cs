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
    public partial class Form1 : Form
    {
        private DatabaseExecuter executer = Register.GetDBExecuter();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContractCreation cntcrn = new ContractCreation();
            cntcrn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PayTheContract paycontr = new PayTheContract();
            paycontr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            executer.FeelSubjects();
            executer.FeelContract();
        }
    }
}
