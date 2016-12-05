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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Gameserver", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Voiceserver", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Webspace", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Domain", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("CMS", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Bouncer", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Clanpage", System.Windows.Forms.HorizontalAlignment.Left);
            this.mainworker = new System.ComponentModel.BackgroundWorker();
            this.tardis = new System.Windows.Forms.Timer(this.components);
            this.statusstrip = new System.Windows.Forms.StatusStrip();
            this.labelworker = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelrealname = new System.Windows.Forms.Label();
            this.labeluserid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsettings = new System.Windows.Forms.Button();
            this.labelcredit = new System.Windows.Forms.Label();
            this.labelregistered = new System.Windows.Forms.Label();
            this.picavatar = new System.Windows.Forms.PictureBox();
            this.listservices = new System.Windows.Forms.ListView();
            this.serviceiconlist = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusstrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picavatar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainworker
            // 
            this.mainworker.WorkerSupportsCancellation = true;
            this.mainworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // statusstrip
            // 
            this.statusstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelworker});
            this.statusstrip.Location = new System.Drawing.Point(0, 566);
            this.statusstrip.Name = "statusstrip";
            this.statusstrip.Size = new System.Drawing.Size(926, 22);
            this.statusstrip.TabIndex = 0;
            this.statusstrip.Text = "statusStrip1";
            // 
            // labelworker
            // 
            this.labelworker.Name = "labelworker";
            this.labelworker.Size = new System.Drawing.Size(192, 17);
            this.labelworker.Text = "%STATUSBACKGROUNDWORKER%";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(821, 151);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
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
            this.labelrealname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrealname.Location = new System.Drawing.Point(172, 58);
            this.labelrealname.Name = "labelrealname";
            this.labelrealname.Size = new System.Drawing.Size(166, 25);
            this.labelrealname.TabIndex = 6;
            this.labelrealname.Text = "%REALNAME%";
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Location = new System.Drawing.Point(173, 89);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(103, 13);
            this.labeluserid.TabIndex = 7;
            this.labeluserid.Text = "UserID: %USERID%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsettings);
            this.groupBox1.Controls.Add(this.labelcredit);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.labelregistered);
            this.groupBox1.Controls.Add(this.labelusername);
            this.groupBox1.Controls.Add(this.labeluserid);
            this.groupBox1.Controls.Add(this.picavatar);
            this.groupBox1.Controls.Add(this.labelrealname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // btnsettings
            // 
            this.btnsettings.Location = new System.Drawing.Point(808, 16);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(88, 23);
            this.btnsettings.TabIndex = 11;
            this.btnsettings.Text = "Einstellungen";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // labelcredit
            // 
            this.labelcredit.AutoSize = true;
            this.labelcredit.Location = new System.Drawing.Point(173, 102);
            this.labelcredit.Name = "labelcredit";
            this.labelcredit.Size = new System.Drawing.Size(63, 13);
            this.labelcredit.TabIndex = 10;
            this.labelcredit.Text = "%CREDIT%";
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
            // picavatar
            // 
            this.picavatar.ErrorImage = global::NitadoMAI.Properties.Resources.unknownuser;
            this.picavatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picavatar.InitialImage")));
            this.picavatar.Location = new System.Drawing.Point(13, 16);
            this.picavatar.Name = "picavatar";
            this.picavatar.Size = new System.Drawing.Size(150, 150);
            this.picavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picavatar.TabIndex = 4;
            this.picavatar.TabStop = false;
            // 
            // listservices
            // 
            listViewGroup1.Header = "Gameserver";
            listViewGroup1.Name = "gameserver";
            listViewGroup2.Header = "Voiceserver";
            listViewGroup2.Name = "voiceserver";
            listViewGroup3.Header = "Webspace";
            listViewGroup3.Name = "webspace";
            listViewGroup4.Header = "Domain";
            listViewGroup4.Name = "domain";
            listViewGroup5.Header = "CMS";
            listViewGroup5.Name = "cms";
            listViewGroup6.Header = "Bouncer";
            listViewGroup6.Name = "bouncer";
            listViewGroup7.Header = "Clanpage";
            listViewGroup7.Name = "clanpage";
            this.listservices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7});
            this.listservices.LargeImageList = this.serviceiconlist;
            this.listservices.Location = new System.Drawing.Point(12, 223);
            this.listservices.Name = "listservices";
            this.listservices.Size = new System.Drawing.Size(896, 340);
            this.listservices.TabIndex = 9;
            this.listservices.UseCompatibleStateImageBehavior = false;
            this.listservices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listservices_MouseDoubleClick);
            // 
            // serviceiconlist
            // 
            this.serviceiconlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("serviceiconlist.ImageStream")));
            this.serviceiconlist.TransparentColor = System.Drawing.Color.Transparent;
            this.serviceiconlist.Images.SetKeyName(0, "servericon.png");
            this.serviceiconlist.Images.SetKeyName(1, "teamspeakicon.png");
            this.serviceiconlist.Images.SetKeyName(2, "webspaceicon.png");
            this.serviceiconlist.Images.SetKeyName(3, "clanpageicon.png");
            this.serviceiconlist.Images.SetKeyName(4, "domainicon.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Services";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(926, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listservices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusstrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Nitrado MAI";
            this.Load += new System.EventHandler(this.main_Load);
            this.statusstrip.ResumeLayout(false);
            this.statusstrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picavatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker mainworker;
        private System.Windows.Forms.Timer tardis;
        private System.Windows.Forms.StatusStrip statusstrip;
        private System.Windows.Forms.ToolStripStatusLabel labelworker;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.PictureBox picavatar;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelrealname;
        private System.Windows.Forms.Label labeluserid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelregistered;
        private System.Windows.Forms.Label labelcredit;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.ListView listservices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList serviceiconlist;
    }
}

