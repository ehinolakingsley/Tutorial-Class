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
        int numberOfInvoices = 0;
        decimal totalInvoices = 0m;

        decimal lowestInvoice = 0m, highestInvoice = 0m;
        bool isFirstRan = true;

        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {

                decimal subTotal = decimal.Parse(txtEnterSubTotal.Text);

                decimal discountPercent = 0m;

                if (subTotal >= 500)
                {
                    discountPercent = 0.2m;
                }
                else if (subTotal >= 250 && subTotal < 500)
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
                txtSubtotal.Text = subTotal.ToString("c2");

                txtEnterSubTotal.Focus();

                numberOfInvoices++;
                totalInvoices = totalInvoices + invoiceTotal;


                txtNumOfInvoices.Text = numberOfInvoices.ToString();
                txtTotalInvoices.Text = totalInvoices.ToString("c2");
                txtInvoiceAverage.Text = (totalInvoices / numberOfInvoices).ToString("c2");

                lowestInvoice = Math.Min(invoiceTotal, lowestInvoice);
                highestInvoice = Math.Max(invoiceTotal, highestInvoice);

                if (isFirstRan == true)
                {
                    lowestInvoice = highestInvoice;
                    isFirstRan = false;
                }

                txtLargestInvoice.Text = highestInvoice.ToString("c2");
                txtLowestInvoice.Text = lowestInvoice.ToString("c2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message!");
            }


        }

        private void btnClearTotal_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalInvoices = 0m;
            lowestInvoice = 0m;
            highestInvoice = 0m;
            isFirstRan = true;

            txtLowestInvoice.Text = "";
            txtLargestInvoice.Text = "";
            txtEnterSubTotal.Text = "";
            txtSubtotal.Text = "";
            txtDiscPerc.Text = "";
            txtDiscAmt.Text = "";
            txtTotal.Text = "";
            txtNumOfInvoices.Text = "";
            txtTotalInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtEnterSubTotal.Focus();
        }

        private void btnFutureValue_Click(object sender, EventArgs e)
        {
            FutureValueFrm futureValueFrm = new FutureValueFrm();
            futureValueFrm.ShowDialog();
        }

    }
}
