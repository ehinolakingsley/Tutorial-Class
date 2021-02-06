
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
            this.SuspendLayout();
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(15, 15);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lbSubtotal.TabIndex = 0;
            this.lbSubtotal.Text = "Subtotal:";
            // 
            // lbDiscAmt
            // 
            this.lbDiscAmt.AutoSize = true;
            this.lbDiscAmt.Location = new System.Drawing.Point(15, 71);
            this.lbDiscAmt.Name = "lbDiscAmt";
            this.lbDiscAmt.Size = new System.Drawing.Size(91, 13);
            this.lbDiscAmt.TabIndex = 1;
            this.lbDiscAmt.Text = "Discount Amount:";
            // 
            // lbDiscPerc
            // 
            this.lbDiscPerc.AutoSize = true;
            this.lbDiscPerc.Location = new System.Drawing.Point(14, 45);
            this.lbDiscPerc.Name = "lbDiscPerc";
            this.lbDiscPerc.Size = new System.Drawing.Size(92, 13);
            this.lbDiscPerc.TabIndex = 2;
            this.lbDiscPerc.Text = "Discount Percent:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(15, 97);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(143, 12);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(146, 20);
            this.txtSubtotal.TabIndex = 1;
            // 
            // txtDiscPerc
            // 
            this.txtDiscPerc.Location = new System.Drawing.Point(143, 38);
            this.txtDiscPerc.Name = "txtDiscPerc";
            this.txtDiscPerc.ReadOnly = true;
            this.txtDiscPerc.Size = new System.Drawing.Size(146, 20);
            this.txtDiscPerc.TabIndex = 5;
            this.txtDiscPerc.TabStop = false;
            this.txtDiscPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscAmt
            // 
            this.txtDiscAmt.Location = new System.Drawing.Point(143, 64);
            this.txtDiscAmt.Name = "txtDiscAmt";
            this.txtDiscAmt.ReadOnly = true;
            this.txtDiscAmt.Size = new System.Drawing.Size(146, 20);
            this.txtDiscAmt.TabIndex = 6;
            this.txtDiscAmt.TabStop = false;
            this.txtDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(143, 90);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(146, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(94, 127);
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
            this.btnExit.Location = new System.Drawing.Point(175, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(317, 176);
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
    }
}

