using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1f
{
    public partial class frmCurrencyConverterV2ex1f : Form
    {
        public frmCurrencyConverterV2ex1f()
        {
            InitializeComponent();
        }

        private void frmCurrencyConverterV2ex1f_Load(object sender, EventArgs e)
        {
            btnDenmark.BackgroundImage = picDenmark.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtUSAmount.Text = "0.00";
            txtTotal.Text = "0.00";
            txtRate.Text = "0.13398653";
            txtAmount.Focus();
        }

        private void btnDenmark_Click(object sender, EventArgs e)
        {
            btnDenmark.BackgroundImage = picDenmark.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.DimGray;
            label3.ForeColor = Color.DimGray;
            label4.ForeColor = Color.DimGray;

            label5.Text = "Danish Krone:";
            txtAmount.Text = "0.00";
            txtRate.Text = "0.13398653";
            txtAmount.Focus();
        }

        private void bntGermany_Click(object sender, EventArgs e)
        {
            btnGermany.BackgroundImage = picGermany.Image;
            btnDenmark.BackgroundImage = picDenmarkDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;

            label2.ForeColor = Color.Black;
            label1.ForeColor = Color.DimGray;
            label3.ForeColor = Color.DimGray;
            label4.ForeColor = Color.DimGray;

            label5.Text = "Euro:";
            txtAmount.Text = "0.00";
            txtRate.Text = "0.99637475";
            txtAmount.Focus();
        }

        private void btnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnDenmark.BackgroundImage = picDenmarkDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;

            label3.ForeColor = Color.Black;
            label1.ForeColor = Color.DimGray;
            label2.ForeColor = Color.DimGray;
            label4.ForeColor = Color.DimGray;

            label5.Text = "Yen:";
            txtAmount.Text = "0.00";
            txtRate.Text = "0.0071366308";
            txtAmount.Focus();
        }

        private void btnUK_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUK.Image;
            btnDenmark.BackgroundImage = picDenmarkDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;

            label4.ForeColor = Color.Black;
            label1.ForeColor = Color.DimGray;
            label3.ForeColor = Color.DimGray;
            label2.ForeColor = Color.DimGray;

            label5.Text = "Sterling Pound:";
            txtAmount.Text = "0.00";
            txtRate.Text = "1.1513497";
            txtAmount.Focus();
        }

        private void currencyTextChange(object sender, EventArgs e)
        {
            txtUSAmount.Text = (
            Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text)
            ).ToString("0.00");
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            txtAmount.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtUSAmount.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + "  +" + txtUSAmount.Text;



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnDenmark.BackgroundImage = picDenmark.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            label5.Text = "Danish Krone";
            txtAmount.Text = "0.00";
            txtUSAmount.Text = "0.00";
            txtTotal.Text = "0.00";
            txtRate.Text = "0.13398653";
            lblEquation.Text = "";
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.DimGray;
            label3.ForeColor = Color.DimGray;
            label4.ForeColor = Color.DimGray;
            txtAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
