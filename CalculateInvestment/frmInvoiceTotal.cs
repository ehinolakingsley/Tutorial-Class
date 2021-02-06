using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateInvestment
{
    public partial class frmInvoiceTotal :Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this. Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            decimal subTotal = decimal.Parse(txtSubtotal.Text);

            decimal discountPercent = 0m;

            if(subTotal >= 500)
            {
                discountPercent = 0.2m;
            }
            else if(subTotal >= 250 && subTotal < 500)
            {
                discountPercent = 0.15m;
            }
            else if (subTotal >= 100 && subTotal < 250)
            {
                discountPercent = 0.1m;
            }

            decimal discountAmt = subTotal * discountPercent;
            decimal invoiceTotal = subTotal - discountAmt;

            txtDiscPerc.Text = discountPercent.ToString("p1");
            txtDiscAmt.Text = discountAmt.ToString("c2");
            txtTotal.Text = invoiceTotal.ToString("c2");

            txtSubtotal.Focus();
            //txtSubtotal.Text = subTotal.ToString("c2");
        }



    }
}
