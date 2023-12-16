namespace InvoiceTotal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtDicountPercent = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnterSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount Percent:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(223, 60);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(169, 20);
            this.txtSubtotal.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(223, 176);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(169, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(223, 140);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(169, 20);
            this.txtDiscountAmount.TabIndex = 7;
            // 
            // txtDicountPercent
            // 
            this.txtDicountPercent.Location = new System.Drawing.Point(223, 104);
            this.txtDicountPercent.Name = "txtDicountPercent";
            this.txtDicountPercent.ReadOnly = true;
            this.txtDicountPercent.Size = new System.Drawing.Size(169, 20);
            this.txtDicountPercent.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(673, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(385, 253);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter SubTotal:";
            // 
            // txtEnterSubTotal
            // 
            this.txtEnterSubTotal.Location = new System.Drawing.Point(223, 20);
            this.txtEnterSubTotal.Name = "txtEnterSubTotal";
            this.txtEnterSubTotal.Size = new System.Drawing.Size(169, 20);
            this.txtEnterSubTotal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total of invoice:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of invoices:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Invoice Average:";
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(592, 64);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(169, 20);
            this.txtNumberOfInvoices.TabIndex = 14;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(592, 104);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(169, 20);
            this.txtTotalOfInvoices.TabIndex = 15;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(592, 147);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(169, 20);
            this.txtInvoiceAverage.TabIndex = 16;
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(532, 253);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(114, 23);
            this.btnClearTotals.TabIndex = 17;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 361);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEnterSubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDicountPercent);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtDicountPercent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnterSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Button btnClearTotals;
    }
}

