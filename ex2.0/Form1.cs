using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotDogSubtotal.Text = (
            //    2.5m * Convert.ToDecimal(txtHotDogs.Text)
            //    ).ToString("0.00");
            int hotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal hotDogPrice = 2.5m;
            decimal hotDogSubtotal = hotDogs * hotDogPrice;
            txtHotDogSubtotal.Text = hotDogSubtotal.ToString("0.00");

            //txtBurgerSubtotal.Text = (
            //    3.0m * Convert.ToDecimal(txtBurgers.Text)
            //    ).ToString("0.00");
            int hamBurgers = Convert.ToInt32(txtBurgers.Text);
            decimal hamBurgerPrice = 3.0m;
            decimal hamBurgerSubtotal = hamBurgers * hamBurgerPrice;
            txtBurgerSubtotal.Text = hamBurgerSubtotal.ToString("0.00");
            //txtPretaxTotal.Text = (
            //    Convert.ToDecimal(txtHotDogSubtotal.Text) + Convert.ToDecimal(txtBurgerSubtotal.Text)
            //    ).ToString("0.00");
            decimal preTaxTotal = hotDogSubtotal + hamBurgerSubtotal;
            txtPretaxTotal.Text = preTaxTotal.ToString("0.00");
            //txtTax.Text = (
            //    0.06875m * Convert.ToDecimal(txtPretaxTotal.Text)
            //    ).ToString("0.00");
            decimal taxTotal = preTaxTotal * 0.06875m;
            txtTax.Text = taxTotal.ToString("0.00");
            //txtTotal.Text = (
            //    Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //    ).ToString("0.00");
            decimal subTotal = preTaxTotal + taxTotal;
            txtTotal.Text = subTotal.ToString("0.00");

            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtBurgers.Text = "0";
            txtHotDogSubtotal.Text = "";
            txtBurgerSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtHotDogs.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
