
namespace CalculateInvestment
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbDiscAmt = new System.Windows.Forms.Label();
            this.lbDiscPerc = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscPerc = new System.Windows.Forms.TextBox();
            this.txtDiscAmt = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEnterSubTotal = new System.Windows.Forms.TextBox();
            this.lbEnterSubTotal = new System.Windows.Forms.Label();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.txtTotalInvoices = new System.Windows.Forms.TextBox();
            this.txtNumOfInvoices = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearTotal = new System.Windows.Forms.Button();
            this.txtLowestInvoice = new System.Windows.Forms.TextBox();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFutureValue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(11, 66);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lbSubtotal.TabIndex = 0;
            this.lbSubtotal.Text = "Subtotal:";
            // 
            // lbDiscAmt
            // 
            this.lbDiscAmt.AutoSize = true;
            this.lbDiscAmt.Location = new System.Drawing.Point(12, 118);
            this.lbDiscAmt.Name = "lbDiscAmt";
            this.lbDiscAmt.Size = new System.Drawing.Size(91, 13);
            this.lbDiscAmt.TabIndex = 1;
            this.lbDiscAmt.Text = "Discount Amount:";
            // 
            // lbDiscPerc
            // 
            this.lbDiscPerc.AutoSize = true;
            this.lbDiscPerc.Location = new System.Drawing.Point(11, 92);
            this.lbDiscPerc.Name = "lbDiscPerc";
            this.lbDiscPerc.Size = new System.Drawing.Size(92, 13);
            this.lbDiscPerc.TabIndex = 2;
            this.lbDiscPerc.Text = "Discount Percent:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(12, 144);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(113, 59);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(146, 20);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscPerc
            // 
            this.txtDiscPerc.Location = new System.Drawing.Point(113, 85);
            this.txtDiscPerc.Name = "txtDiscPerc";
            this.txtDiscPerc.ReadOnly = true;
            this.txtDiscPerc.Size = new System.Drawing.Size(146, 20);
            this.txtDiscPerc.TabIndex = 2;
            this.txtDiscPerc.TabStop = false;
            this.txtDiscPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscAmt
            // 
            this.txtDiscAmt.Location = new System.Drawing.Point(113, 111);
            this.txtDiscAmt.Name = "txtDiscAmt";
            this.txtDiscAmt.ReadOnly = true;
            this.txtDiscAmt.Size = new System.Drawing.Size(146, 20);
            this.txtDiscAmt.TabIndex = 6;
            this.txtDiscAmt.TabStop = false;
            this.txtDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(113, 137);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(146, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(172, 174);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(355, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtEnterSubTotal
            // 
            this.txtEnterSubTotal.Location = new System.Drawing.Point(113, 31);
            this.txtEnterSubTotal.Name = "txtEnterSubTotal";
            this.txtEnterSubTotal.Size = new System.Drawing.Size(146, 20);
            this.txtEnterSubTotal.TabIndex = 0;
            // 
            // lbEnterSubTotal
            // 
            this.lbEnterSubTotal.AutoSize = true;
            this.lbEnterSubTotal.Location = new System.Drawing.Point(12, 38);
            this.lbEnterSubTotal.Name = "lbEnterSubTotal";
            this.lbEnterSubTotal.Size = new System.Drawing.Size(77, 13);
            this.lbEnterSubTotal.TabIndex = 8;
            this.lbEnterSubTotal.Text = "Enter Subtotal:";
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(390, 83);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(146, 20);
            this.txtInvoiceAverage.TabIndex = 15;
            this.txtInvoiceAverage.TabStop = false;
            this.txtInvoiceAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalInvoices
            // 
            this.txtTotalInvoices.Location = new System.Drawing.Point(390, 57);
            this.txtTotalInvoices.Name = "txtTotalInvoices";
            this.txtTotalInvoices.ReadOnly = true;
            this.txtTotalInvoices.Size = new System.Drawing.Size(146, 20);
            this.txtTotalInvoices.TabIndex = 14;
            this.txtTotalInvoices.TabStop = false;
            this.txtTotalInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumOfInvoices
            // 
            this.txtNumOfInvoices.Location = new System.Drawing.Point(390, 31);
            this.txtNumOfInvoices.Name = "txtNumOfInvoices";
            this.txtNumOfInvoices.ReadOnly = true;
            this.txtNumOfInvoices.Size = new System.Drawing.Size(146, 20);
            this.txtNumOfInvoices.TabIndex = 11;
            this.txtNumOfInvoices.TabStop = false;
            this.txtNumOfInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total of Invoices:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Invoice Average:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Invoices:";
            // 
            // btnClearTotal
            // 
            this.btnClearTotal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearTotal.Location = new System.Drawing.Point(264, 174);
            this.btnClearTotal.Name = "btnClearTotal";
            this.btnClearTotal.Size = new System.Drawing.Size(75, 23);
            this.btnClearTotal.TabIndex = 3;
            this.btnClearTotal.Text = "Clear Total";
            this.btnClearTotal.UseVisualStyleBackColor = true;
            this.btnClearTotal.Click += new System.EventHandler(this.btnClearTotal_Click);
            // 
            // txtLowestInvoice
            // 
            this.txtLowestInvoice.Location = new System.Drawing.Point(390, 141);
            this.txtLowestInvoice.Name = "txtLowestInvoice";
            this.txtLowestInvoice.ReadOnly = true;
            this.txtLowestInvoice.Size = new System.Drawing.Size(146, 20);
            this.txtLowestInvoice.TabIndex = 19;
            this.txtLowestInvoice.TabStop = false;
            this.txtLowestInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Location = new System.Drawing.Point(390, 115);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(146, 20);
            this.txtLargestInvoice.TabIndex = 18;
            this.txtLargestInvoice.TabStop = false;
            this.txtLargestInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Largest Invoice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lowest Invoice:";
            // 
            // btnFutureValue
            // 
            this.btnFutureValue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFutureValue.Location = new System.Drawing.Point(6, 19);
            this.btnFutureValue.Name = "btnFutureValue";
            this.btnFutureValue.Size = new System.Drawing.Size(165, 23);
            this.btnFutureValue.TabIndex = 20;
            this.btnFutureValue.Text = "Calculate Future Value";
            this.btnFutureValue.UseVisualStyleBackColor = true;
            this.btnFutureValue.Click += new System.EventHandler(this.btnFutureValue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFutureValue);
            this.groupBox1.Location = new System.Drawing.Point(556, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 138);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLowestInvoice);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearTotal);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalInvoices);
            this.Controls.Add(this.txtNumOfInvoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnterSubTotal);
            this.Controls.Add(this.lbEnterSubTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscAmt);
            this.Controls.Add(this.txtDiscPerc);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDiscPerc);
            this.Controls.Add(this.lbDiscAmt);
            this.Controls.Add(this.lbSubtotal);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbDiscAmt;
        private System.Windows.Forms.Label lbDiscPerc;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscPerc;
        private System.Windows.Forms.TextBox txtDiscAmt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEnterSubTotal;
        private System.Windows.Forms.Label lbEnterSubTotal;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.TextBox txtTotalInvoices;
        private System.Windows.Forms.TextBox txtNumOfInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearTotal;
        private System.Windows.Forms.TextBox txtLowestInvoice;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFutureValue;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

