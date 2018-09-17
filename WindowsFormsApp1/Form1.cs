using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            string letterGrade = "";

            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade < 88)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade < 80)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade < 68)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;

            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
