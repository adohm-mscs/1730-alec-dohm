using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1d1
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            txtAmountDenmark.Text = "0.00";
            txtAmountGermany.Text = "0.00";
            txtAmountJapan.Text = "0.00";
            txtAmountUK.Text = "0.00";
            txtRateDenmark.Text = "0.13398653";
            txtRateGermany.Text = "0.99637475";
            txtRateJapan.Text = "0.0071366308";
            txtRateUK.Text = "1.1513497";

            txtAmountDenmark.Focus();
        }

        private void denmarkTextChange(object sender, EventArgs e)
        {
            txtUSDDenmark.Text = (
                Convert.ToDecimal(txtAmountDenmark.Text) * Convert.ToDecimal(txtRateDenmark.Text)
                ).ToString("0.00");
        }

        private void germanyTextChange(object sender, EventArgs e)
        {
            txtUSDGermany.Text = (
                Convert.ToDecimal(txtAmountGermany.Text) * Convert.ToDecimal(txtRateGermany.Text)
                ).ToString("0.00");
        }

        private void japanTextChange(object sender, EventArgs e)
        {
            txtUSDJapan.Text = (
                Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateJapan.Text)
                ).ToString("0.00");
        }

        private void ukTextChange(object sender, EventArgs e)
        {
            txtUSDUK.Text = (
                Convert.ToDecimal(txtAmountUK.Text) * Convert.ToDecimal(txtRateUK.Text)
                ).ToString("0.00");
        }

        private void usaTextChange(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDDenmark.Text) + Convert.ToDecimal(txtUSDGermany.Text) +
                Convert.ToDecimal(txtUSDJapan.Text) + Convert.ToDecimal(txtUSDUK.Text)
                ).ToString("0.00");
        }
    }
}
