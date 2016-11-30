namespace NitadoMAI
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.tardis = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelrealname = new System.Windows.Forms.Label();
            this.labeluserid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelregistered = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.picavatar = new System.Windows.Forms.PictureBox();
            this.labelworker = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picavatar)).BeginInit();
            this.SuspendLayout();
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelworker});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(926, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 543);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(778, 540);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(136, 23);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Aktualisieren";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(169, 16);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(306, 42);
            this.labelusername.TabIndex = 5;
            this.labelusername.Text = "%USERNAME%";
            // 
            // labelrealname
            // 
            this.labelrealname.AutoSize = true;
            this.labelrealname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrealname.Location = new System.Drawing.Point(172, 58);
            this.labelrealname.Name = "labelrealname";
            this.labelrealname.Size = new System.Drawing.Size(126, 20);
            this.labelrealname.TabIndex = 6;
            this.labelrealname.Text = "%REALNAME%";
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Location = new System.Drawing.Point(173, 78);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(103, 13);
            this.labeluserid.TabIndex = 7;
            this.labeluserid.Text = "UserID: %USERID%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlogout);
            this.groupBox1.Controls.Add(this.labelregistered);
            this.groupBox1.Controls.Add(this.labelusername);
            this.groupBox1.Controls.Add(this.labeluserid);
            this.groupBox1.Controls.Add(this.picavatar);
            this.groupBox1.Controls.Add(this.labelrealname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // labelregistered
            // 
            this.labelregistered.AutoSize = true;
            this.labelregistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregistered.Location = new System.Drawing.Point(173, 150);
            this.labelregistered.Name = "labelregistered";
            this.labelregistered.Size = new System.Drawing.Size(120, 16);
            this.labelregistered.TabIndex = 8;
            this.labelregistered.Text = "%REGISTERED%";
            // 
            // btnlogout
            // 
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(650, 151);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Logout";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // picavatar
            // 
            this.picavatar.ErrorImage = global::NitadoMAI.Properties.Resources.unknownuser;
            this.picavatar.InitialImage = global::NitadoMAI.Properties.Resources.squares;
            this.picavatar.Location = new System.Drawing.Point(13, 16);
            this.picavatar.Name = "picavatar";
            this.picavatar.Size = new System.Drawing.Size(150, 150);
            this.picavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picavatar.TabIndex = 4;
            this.picavatar.TabStop = false;
            // 
            // labelworker
            // 
            this.labelworker.Image = global::NitadoMAI.Properties.Resources.successicon;
            this.labelworker.Name = "labelworker";
            this.labelworker.Size = new System.Drawing.Size(208, 16);
            this.labelworker.Text = "%STATUSBACKGROUNDWORKER%";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(926, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Nitrado MAI";
            this.Load += new System.EventHandler(this.main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picavatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Timer tardis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelworker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.PictureBox picavatar;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelrealname;
        private System.Windows.Forms.Label labeluserid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelregistered;
        private System.Windows.Forms.Button btnlogout;
    }
}

