namespace NitadoMAI
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listpaymentbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelguthaben = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelpayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(204, 22);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(143, 62);
            this.txtamount.TabIndex = 2;
            this.txtamount.Text = "5,00";
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "€";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(535, 71);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "Weiter";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelpayment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelguthaben);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listpaymentbox);
            this.groupBox1.Controls.Add(this.btnnext);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guthaben:";
            // 
            // listpaymentbox
            // 
            this.listpaymentbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listpaymentbox.FormattingEnabled = true;
            this.listpaymentbox.Items.AddRange(new object[] {
            "PayPal",
            "Visa",
            "American Express",
            "Banküberweisung",
            "Visa Debit",
            "Mastercard Debit",
            "Mastercard",
            "GiroPay",
            "Skrill / Moneybookers",
            "Paysafecard",
            "Sofortüberweisung",
            "Barzahlen",
            "Telefon (Festnetz)",
            "Telefon (Mobil)",
            "Gutscheincode",
            "iDeal"});
            this.listpaymentbox.Location = new System.Drawing.Point(6, 35);
            this.listpaymentbox.Name = "listpaymentbox";
            this.listpaymentbox.Size = new System.Drawing.Size(192, 28);
            this.listpaymentbox.TabIndex = 5;
            this.listpaymentbox.Text = "PayPal";
            this.listpaymentbox.SelectedIndexChanged += new System.EventHandler(this.listpaymentbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wollen sie ";
            // 
            // labelguthaben
            // 
            this.labelguthaben.AutoSize = true;
            this.labelguthaben.Location = new System.Drawing.Point(475, 16);
            this.labelguthaben.Name = "labelguthaben";
            this.labelguthaben.Size = new System.Drawing.Size(28, 13);
            this.labelguthaben.TabIndex = 7;
            this.labelguthaben.Text = "5,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Euro mit";
            // 
            // labelpayment
            // 
            this.labelpayment.AutoSize = true;
            this.labelpayment.Location = new System.Drawing.Point(410, 35);
            this.labelpayment.Name = "labelpayment";
            this.labelpayment.Size = new System.Drawing.Size(40, 13);
            this.labelpayment.TabIndex = 9;
            this.labelpayment.Text = "PayPal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "aufladen ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zahlungsmethode:";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 120);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guthaben aufladen - Nitrado MAI";
            this.Load += new System.EventHandler(this.payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listpaymentbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelpayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelguthaben;
        private System.Windows.Forms.Label label3;
    }
}