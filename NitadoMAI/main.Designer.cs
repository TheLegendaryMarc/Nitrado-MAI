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
            this.labelusername = new System.Windows.Forms.Label();
            this.labelrealname = new System.Windows.Forms.Label();
            this.labeluserid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelcredit = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.labelregistered = new System.Windows.Forms.Label();
            this.picavatar = new System.Windows.Forms.PictureBox();
            this.listservices = new System.Windows.Forms.ListView();
            this.serviceiconlist = new System.Windows.Forms.ImageList(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainmenubutton = new System.Windows.Forms.ToolStripDropDownButton();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicetoolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.serviceBestellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLSERICESNAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.accessTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guthabenAufladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verschlüsselungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.supportCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeAufNitradonetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeFürMAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutbutton = new System.Windows.Forms.ToolStripButton();
            this.statusstrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picavatar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.labeluserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserid.Location = new System.Drawing.Point(173, 89);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(131, 16);
            this.labeluserid.TabIndex = 7;
            this.labeluserid.Text = "UserID: %USERID%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelcredit);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.labelregistered);
            this.groupBox1.Controls.Add(this.labelusername);
            this.groupBox1.Controls.Add(this.labeluserid);
            this.groupBox1.Controls.Add(this.picavatar);
            this.groupBox1.Controls.Add(this.labelrealname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // labelcredit
            // 
            this.labelcredit.AutoSize = true;
            this.labelcredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcredit.Location = new System.Drawing.Point(173, 102);
            this.labelcredit.Name = "labelcredit";
            this.labelcredit.Size = new System.Drawing.Size(82, 16);
            this.labelcredit.TabIndex = 10;
            this.labelcredit.Text = "%CREDIT%";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::NitadoMAI.Properties.Resources.refreshicon;
            this.btnrefresh.Location = new System.Drawing.Point(859, 137);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(37, 37);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
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
            this.listservices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.listservices.Location = new System.Drawing.Point(6, 28);
            this.listservices.Name = "listservices";
            this.listservices.Size = new System.Drawing.Size(890, 315);
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
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Nitrado MAI";
            this.notify.Visible = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listservices);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 349);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenubutton,
            this.servicetoolstrip,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.logoutbutton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(926, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mainmenubutton
            // 
            this.mainmenubutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.mainmenubutton.Image = global::NitadoMAI.Properties.Resources.nitrado;
            this.mainmenubutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainmenubutton.Name = "mainmenubutton";
            this.mainmenubutton.Size = new System.Drawing.Size(58, 22);
            this.mainmenubutton.Text = "MAI";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.Settingsicon;
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.exiticon;
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // servicetoolstrip
            // 
            this.servicetoolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceBestellenToolStripMenuItem,
            this.aLLSERICESNAToolStripMenuItem});
            this.servicetoolstrip.Image = global::NitadoMAI.Properties.Resources.servericon;
            this.servicetoolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.servicetoolstrip.Name = "servicetoolstrip";
            this.servicetoolstrip.Size = new System.Drawing.Size(73, 22);
            this.servicetoolstrip.Text = "Service";
            // 
            // serviceBestellenToolStripMenuItem
            // 
            this.serviceBestellenToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.webspaceicon;
            this.serviceBestellenToolStripMenuItem.Name = "serviceBestellenToolStripMenuItem";
            this.serviceBestellenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.serviceBestellenToolStripMenuItem.Text = "Service bestellen";
            this.serviceBestellenToolStripMenuItem.Click += new System.EventHandler(this.serviceBestellenToolStripMenuItem_Click);
            // 
            // aLLSERICESNAToolStripMenuItem
            // 
            this.aLLSERICESNAToolStripMenuItem.Name = "aLLSERICESNAToolStripMenuItem";
            this.aLLSERICESNAToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aLLSERICESNAToolStripMenuItem.Text = "ALL SERVICE N/A";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessTokenToolStripMenuItem,
            this.guthabenAufladenToolStripMenuItem,
            this.verschlüsselungToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::NitadoMAI.Properties.Resources.usericon;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton2.Text = "Account";
            // 
            // accessTokenToolStripMenuItem
            // 
            this.accessTokenToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.editing;
            this.accessTokenToolStripMenuItem.Name = "accessTokenToolStripMenuItem";
            this.accessTokenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.accessTokenToolStripMenuItem.Text = "AccessToken";
            this.accessTokenToolStripMenuItem.Click += new System.EventHandler(this.accessTokenToolStripMenuItem_Click);
            // 
            // guthabenAufladenToolStripMenuItem
            // 
            this.guthabenAufladenToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.moneyicon;
            this.guthabenAufladenToolStripMenuItem.Name = "guthabenAufladenToolStripMenuItem";
            this.guthabenAufladenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.guthabenAufladenToolStripMenuItem.Text = "Guthaben aufladen";
            this.guthabenAufladenToolStripMenuItem.Click += new System.EventHandler(this.guthabenAufladenToolStripMenuItem_Click);
            // 
            // verschlüsselungToolStripMenuItem
            // 
            this.verschlüsselungToolStripMenuItem.Enabled = false;
            this.verschlüsselungToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.lockicon;
            this.verschlüsselungToolStripMenuItem.Name = "verschlüsselungToolStripMenuItem";
            this.verschlüsselungToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verschlüsselungToolStripMenuItem.Text = "Verschlüsselung";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.usericon;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::NitadoMAI.Properties.Resources.logouticon;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportCenterToolStripMenuItem,
            this.hilfeAufNitradonetToolStripMenuItem,
            this.hilfeFürMAIToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.toolStripDropDownButton3.Image = global::NitadoMAI.Properties.Resources.questionfaq;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton3.Text = "Hilfe";
            // 
            // supportCenterToolStripMenuItem
            // 
            this.supportCenterToolStripMenuItem.Name = "supportCenterToolStripMenuItem";
            this.supportCenterToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.supportCenterToolStripMenuItem.Text = "Support Center";
            this.supportCenterToolStripMenuItem.Click += new System.EventHandler(this.supportCenterToolStripMenuItem_Click);
            // 
            // hilfeAufNitradonetToolStripMenuItem
            // 
            this.hilfeAufNitradonetToolStripMenuItem.Name = "hilfeAufNitradonetToolStripMenuItem";
            this.hilfeAufNitradonetToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.hilfeAufNitradonetToolStripMenuItem.Text = "Hilfe auf Nitrado.net";
            this.hilfeAufNitradonetToolStripMenuItem.Click += new System.EventHandler(this.hilfeAufNitradonetToolStripMenuItem_Click);
            // 
            // hilfeFürMAIToolStripMenuItem
            // 
            this.hilfeFürMAIToolStripMenuItem.Name = "hilfeFürMAIToolStripMenuItem";
            this.hilfeFürMAIToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.hilfeFürMAIToolStripMenuItem.Text = "Hilfe für MAI";
            this.hilfeFürMAIToolStripMenuItem.Click += new System.EventHandler(this.hilfeFürMAIToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutbutton.Image = global::NitadoMAI.Properties.Resources.logouticon;
            this.logoutbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(65, 22);
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(926, 588);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ListView listservices;
        private System.Windows.Forms.ImageList serviceiconlist;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mainmenubutton;
        private System.Windows.Forms.ToolStripDropDownButton servicetoolstrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripButton logoutbutton;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceBestellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verschlüsselungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeAufNitradonetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeFürMAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guthabenAufladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLSERICESNAToolStripMenuItem;
    }
}

