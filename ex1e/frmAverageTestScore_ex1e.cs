using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1e
{
    public partial class frmAverageTestScore_ex1e : Form
    {
        public frmAverageTestScore_ex1e()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalculate_Click(object sender, EventArgs e)
        {
            txtTest1Percent.Text = (
                Convert.ToDecimal(txtTest1Score1.Text) / Convert.ToDecimal(txtTest1Score2.Text) * 100
                ).ToString("00");
            txtTest2Percent.Text = (
                Convert.ToDecimal(txtTest2Score1.Text) / Convert.ToDecimal(txtTest2Score2.Text) * 100
                ).ToString("00");
            txtTest3Percent.Text = (
                Convert.ToDecimal(txtTest3Score1.Text) / Convert.ToDecimal(txtTest3Score2.Text) * 100
                ).ToString("00");
            txtTestAverage.Text = (
                (Convert.ToDecimal(txtTest1Percent.Text) + 
                Convert.ToDecimal(txtTest2Percent.Text) +
                Convert.ToDecimal(txtTest3Percent.Text)) / 3
                ).ToString("00");

            bntClear.Focus();
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtTest1Score1.Text = "";
            txtTest1Score2.Text = "";
            txtTest2Score1.Text = "";
            txtTest2Score2.Text = "";
            txtTest3Score1.Text = "";
            txtTest3Score2.Text = "";
            txtTest1Percent.Text = "";
            txtTest2Percent.Text = "";
            txtTest3Percent.Text = "";
            txtTestAverage.Text = "";

            txtTest1Score1.Focus();
        }
    }
}
