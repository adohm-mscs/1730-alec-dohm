using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            
            decimal amountDenmark = 100m;
            decimal rateDenmark = 0.13398653m;            
            decimal usdDenmark = amountDenmark * rateDenmark;
            txtUSDDenmark.Text = (
                Convert.ToDecimal(txtAmountDenmark.Text) * Convert.ToDecimal(txtRateDenmark.Text))
                .ToString("0.00");

            decimal amountGermany = 100m;
            decimal rateGermany = 0.99637475m;
            decimal usdGermany = amountGermany * rateGermany;
            txtUSDGermany.Text = (
            Convert.ToDecimal(txtAmountGermany.Text) * Convert.ToDecimal(txtRateGermany.Text))
                .ToString("0.00");

            decimal amountJapan = 0m;
            decimal rateJapan = 0.0071366308m;
            decimal usdJapan = amountJapan * rateJapan;
            txtUSDJapan.Text = (
            Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateJapan.Text))
                .ToString("0.00");

            decimal amountUK = 0m;
            decimal rateUK = 1.1513497m;
            decimal usdUK = amountUK * rateUK;
            txtUSDUK.Text = (
                Convert.ToDecimal(txtAmountUK.Text) * Convert.ToDecimal(txtRateDenmark.Text))
                .ToString("0.00");

            decimal usdTotal = usdDenmark + usdGermany + usdJapan + usdUK;
            txtUSDTotal.Text = (
            Convert.ToDecimal(txtUSDDenmark.Text) 
            + Convert.ToDecimal(txtRateGermany.Text) 
            + Convert.ToDecimal(txtAmountJapan.Text) 
            + Convert.ToDecimal(txtAmountUK.Text))
            .ToString("0.00");
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            txtAmountDenmark.Text = "0.00";
            txtAmountGermany.Text = "0.00";
            txtAmountJapan.Text = "0.00";
            txtAmountUK.Text = "0.00";
            txtUSDTotal.Text = "0.00";
            txtRateDenmark.Text = "0.13398653";
            txtRateGermany.Text = "0.99637475";
            txtRateJapan.Text = "0.0071366308";
            txtRateUK.Text = "1.1513497";
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
