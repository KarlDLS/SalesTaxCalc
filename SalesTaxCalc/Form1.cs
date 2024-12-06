using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CalculateTax_Click(object sender, EventArgs e)
        {
            double subtotal = Double.Parse(txtbox_Subtotal.Text);
            double total = CalculateSalesTax(subtotal);
            txtbox_DisplayCostAfterTax.Text = total.ToString();
        }

        /// <summary>
        /// This method assumes that the sales tax is 13% like in Ontario
        /// </summary>
        /// <param name="subtotal">The amount of money before sales tax.</param>
        /// <returns></returns>
        private double CalculateSalesTax(double subtotal)
        {
            return (subtotal * 0.13) + subtotal;
        }
    }
}
