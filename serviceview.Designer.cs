namespace NitadoMAI
{
    partial class serviceview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceview));
            this.servicestatusstrip = new System.Windows.Forms.StatusStrip();
            this.tabmaster = new System.Windows.Forms.TabControl();
            this.tabgameserver = new System.Windows.Forms.TabPage();
            this.tabcloudserver = new System.Windows.Forms.TabPage();
            this.tabvoiceserver = new System.Windows.Forms.TabPage();
            this.tabwebspace = new System.Windows.Forms.TabPage();
            this.tabbouncer = new System.Windows.Forms.TabPage();
            this.tabclanpage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelservice = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelservicetype = new System.Windows.Forms.Label();
            this.labelgameserver = new System.Windows.Forms.Label();
            this.labelgamestarttime = new System.Windows.Forms.Label();
            this.labelgamesuspendtime = new System.Windows.Forms.Label();
            this.labelservicestatus = new System.Windows.Forms.Label();
            this.labelip = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labellocation = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelgamestatus = new System.Windows.Forms.Label();
            this.serverimage = new System.Windows.Forms.PictureBox();
            this.labelworkerstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelnextupdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timermaschine = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btntimerstartstop = new System.Windows.Forms.ToolStripSplitButton();
            this.servicestatusstrip.SuspendLayout();
            this.tabmaster.SuspendLayout();
            this.tabgameserver.SuspendLayout();
            this.tabclanpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverimage)).BeginInit();
            this.SuspendLayout();
            // 
            // servicestatusstrip
            // 
            this.servicestatusstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelworkerstatus,
            this.toolStripStatusLabel1,
            this.labelnextupdate,
            this.toolStripStatusLabel2,
            this.btntimerstartstop});
            this.servicestatusstrip.Location = new System.Drawing.Point(0, 583);
            this.servicestatusstrip.Name = "servicestatusstrip";
            this.servicestatusstrip.Size = new System.Drawing.Size(1013, 22);
            this.servicestatusstrip.TabIndex = 0;
            this.servicestatusstrip.Text = "statusStrip1";
            // 
            // tabmaster
            // 
            this.tabmaster.Controls.Add(this.tabgameserver);
            this.tabmaster.Controls.Add(this.tabcloudserver);
            this.tabmaster.Controls.Add(this.tabvoiceserver);
            this.tabmaster.Controls.Add(this.tabwebspace);
            this.tabmaster.Controls.Add(this.tabbouncer);
            this.tabmaster.Controls.Add(this.tabclanpage);
            this.tabmaster.Location = new System.Drawing.Point(0, 26);
            this.tabmaster.Name = "tabmaster";
            this.tabmaster.SelectedIndex = 0;
            this.tabmaster.Size = new System.Drawing.Size(1013, 554);
            this.tabmaster.TabIndex = 1;
            this.tabmaster.SelectedIndexChanged += new System.EventHandler(this.tabmaster_SelectedIndexChanged);
            // 
            // tabgameserver
            // 
            this.tabgameserver.Controls.Add(this.labelgamestatus);
            this.tabgameserver.Controls.Add(this.label10);
            this.tabgameserver.Controls.Add(this.label9);
            this.tabgameserver.Controls.Add(this.label8);
            this.tabgameserver.Controls.Add(this.labellocation);
            this.tabgameserver.Controls.Add(this.label6);
            this.tabgameserver.Controls.Add(this.label5);
            this.tabgameserver.Controls.Add(this.labelip);
            this.tabgameserver.Controls.Add(this.labelservicestatus);
            this.tabgameserver.Controls.Add(this.labelgamesuspendtime);
            this.tabgameserver.Controls.Add(this.labelgamestarttime);
            this.tabgameserver.Controls.Add(this.labelgameserver);
            this.tabgameserver.Controls.Add(this.serverimage);
            this.tabgameserver.Location = new System.Drawing.Point(4, 22);
            this.tabgameserver.Name = "tabgameserver";
            this.tabgameserver.Padding = new System.Windows.Forms.Padding(3);
            this.tabgameserver.Size = new System.Drawing.Size(1005, 528);
            this.tabgameserver.TabIndex = 0;
            this.tabgameserver.Text = "Gameserver";
            this.tabgameserver.UseVisualStyleBackColor = true;
            // 
            // tabcloudserver
            // 
            this.tabcloudserver.Location = new System.Drawing.Point(4, 22);
            this.tabcloudserver.Name = "tabcloudserver";
            this.tabcloudserver.Size = new System.Drawing.Size(1005, 528);
            this.tabcloudserver.TabIndex = 5;
            this.tabcloudserver.Text = "Cloudserver";
            this.tabcloudserver.UseVisualStyleBackColor = true;
            // 
            // tabvoiceserver
            // 
            this.tabvoiceserver.Location = new System.Drawing.Point(4, 22);
            this.tabvoiceserver.Name = "tabvoiceserver";
            this.tabvoiceserver.Padding = new System.Windows.Forms.Padding(3);
            this.tabvoiceserver.Size = new System.Drawing.Size(1005, 528);
            this.tabvoiceserver.TabIndex = 1;
            this.tabvoiceserver.Text = "Voiceserver";
            this.tabvoiceserver.UseVisualStyleBackColor = true;
            // 
            // tabwebspace
            // 
            this.tabwebspace.Location = new System.Drawing.Point(4, 22);
            this.tabwebspace.Name = "tabwebspace";
            this.tabwebspace.Size = new System.Drawing.Size(1005, 528);
            this.tabwebspace.TabIndex = 2;
            this.tabwebspace.Text = "Webspace";
            this.tabwebspace.UseVisualStyleBackColor = true;
            // 
            // tabbouncer
            // 
            this.tabbouncer.Location = new System.Drawing.Point(4, 22);
            this.tabbouncer.Name = "tabbouncer";
            this.tabbouncer.Size = new System.Drawing.Size(1005, 528);
            this.tabbouncer.TabIndex = 3;
            this.tabbouncer.Text = "Bouncer";
            this.tabbouncer.UseVisualStyleBackColor = true;
            // 
            // tabclanpage
            // 
            this.tabclanpage.Controls.Add(this.label2);
            this.tabclanpage.Location = new System.Drawing.Point(4, 22);
            this.tabclanpage.Name = "tabclanpage";
            this.tabclanpage.Size = new System.Drawing.Size(1005, 528);
            this.tabclanpage.TabIndex = 4;
            this.tabclanpage.Text = "Clanpage";
            this.tabclanpage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clanpage steht noch nicht zur Verwaltung zur Verfügung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service:";
            // 
            // labelservice
            // 
            this.labelservice.AutoSize = true;
            this.labelservice.Location = new System.Drawing.Point(53, 9);
            this.labelservice.Name = "labelservice";
            this.labelservice.Size = new System.Drawing.Size(34, 13);
            this.labelservice.TabIndex = 3;
            this.labelservice.Text = "%ID%";
            // 
            // worker
            // 
            this.worker.WorkerSupportsCancellation = true;
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted_1);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(931, 4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Aktualisieren";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type:";
            // 
            // labelservicetype
            // 
            this.labelservicetype.AutoSize = true;
            this.labelservicetype.Location = new System.Drawing.Point(258, 9);
            this.labelservicetype.Name = "labelservicetype";
            this.labelservicetype.Size = new System.Drawing.Size(51, 13);
            this.labelservicetype.TabIndex = 6;
            this.labelservicetype.Text = "%TYPE%";
            // 
            // labelgameserver
            // 
            this.labelgameserver.AutoSize = true;
            this.labelgameserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgameserver.Location = new System.Drawing.Point(164, 6);
            this.labelgameserver.Name = "labelgameserver";
            this.labelgameserver.Size = new System.Drawing.Size(265, 31);
            this.labelgameserver.TabIndex = 1;
            this.labelgameserver.Text = "%GAMESERVER%";
            // 
            // labelgamestarttime
            // 
            this.labelgamestarttime.AutoSize = true;
            this.labelgamestarttime.Location = new System.Drawing.Point(820, 21);
            this.labelgamestarttime.Name = "labelgamestarttime";
            this.labelgamestarttime.Size = new System.Drawing.Size(73, 13);
            this.labelgamestarttime.TabIndex = 2;
            this.labelgamestarttime.Text = "%GEKAUFT%";
            // 
            // labelgamesuspendtime
            // 
            this.labelgamesuspendtime.AutoSize = true;
            this.labelgamesuspendtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgamesuspendtime.Location = new System.Drawing.Point(250, 103);
            this.labelgamesuspendtime.Name = "labelgamesuspendtime";
            this.labelgamesuspendtime.Size = new System.Drawing.Size(130, 16);
            this.labelgamesuspendtime.TabIndex = 3;
            this.labelgamesuspendtime.Text = "%SUSPENDTIME%";
            // 
            // labelservicestatus
            // 
            this.labelservicestatus.AutoSize = true;
            this.labelservicestatus.Location = new System.Drawing.Point(820, 3);
            this.labelservicestatus.Name = "labelservicestatus";
            this.labelservicestatus.Size = new System.Drawing.Size(112, 13);
            this.labelservicestatus.TabIndex = 5;
            this.labelservicestatus.Text = "%SERVICESTATUS%";
            // 
            // labelip
            // 
            this.labelip.AutoSize = true;
            this.labelip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelip.Location = new System.Drawing.Point(170, 41);
            this.labelip.Name = "labelip";
            this.labelip.Size = new System.Drawing.Size(82, 16);
            this.labelip.TabIndex = 6;
            this.labelip.Text = "%IP&PORT%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Servicestatus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gekauft:";
            // 
            // labellocation
            // 
            this.labellocation.AutoSize = true;
            this.labellocation.Location = new System.Drawing.Point(820, 41);
            this.labellocation.Name = "labellocation";
            this.labellocation.Size = new System.Drawing.Size(77, 13);
            this.labellocation.TabIndex = 9;
            this.labellocation.Text = "%LOCATION%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Standort:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Läuft ab am:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(170, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Status:";
            // 
            // labelgamestatus
            // 
            this.labelgamestatus.AutoSize = true;
            this.labelgamestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgamestatus.Location = new System.Drawing.Point(224, 57);
            this.labelgamestatus.Name = "labelgamestatus";
            this.labelgamestatus.Size = new System.Drawing.Size(87, 16);
            this.labelgamestatus.TabIndex = 14;
            this.labelgamestatus.Text = "%STATUS%";
            // 
            // serverimage
            // 
            this.serverimage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("serverimage.ErrorImage")));
            this.serverimage.InitialImage = global::NitadoMAI.Properties.Resources.squaresloading;
            this.serverimage.Location = new System.Drawing.Point(8, 6);
            this.serverimage.Name = "serverimage";
            this.serverimage.Size = new System.Drawing.Size(150, 150);
            this.serverimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serverimage.TabIndex = 0;
            this.serverimage.TabStop = false;
            // 
            // labelworkerstatus
            // 
            this.labelworkerstatus.Image = global::NitadoMAI.Properties.Resources.deleteicon;
            this.labelworkerstatus.Name = "labelworkerstatus";
            this.labelworkerstatus.Size = new System.Drawing.Size(131, 17);
            this.labelworkerstatus.Text = "Kein Service geladen";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel1.Text = " - ";
            // 
            // labelnextupdate
            // 
            this.labelnextupdate.Name = "labelnextupdate";
            this.labelnextupdate.Size = new System.Drawing.Size(19, 17);
            this.labelnextupdate.Text = "60";
            // 
            // timermaschine
            // 
            this.timermaschine.Interval = 1000;
            this.timermaschine.Tag = "stopped";
            this.timermaschine.Tick += new System.EventHandler(this.timermaschine_Tick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(175, 17);
            this.toolStripStatusLabel2.Text = "Sekunden bis zur Aktualisierung";
            // 
            // btntimerstartstop
            // 
            this.btntimerstartstop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btntimerstartstop.Image = ((System.Drawing.Image)(resources.GetObject("btntimerstartstop.Image")));
            this.btntimerstartstop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntimerstartstop.Name = "btntimerstartstop";
            this.btntimerstartstop.Size = new System.Drawing.Size(208, 20);
            this.btntimerstartstop.Text = "Automatische Aktualisierung - OFF";
            this.btntimerstartstop.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // serviceview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 605);
            this.Controls.Add(this.labelservicetype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.labelservice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabmaster);
            this.Controls.Add(this.servicestatusstrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "serviceview";
            this.Text = "Service - Nitrado MAI";
            this.Load += new System.EventHandler(this.serviceview_Load);
            this.servicestatusstrip.ResumeLayout(false);
            this.servicestatusstrip.PerformLayout();
            this.tabmaster.ResumeLayout(false);
            this.tabgameserver.ResumeLayout(false);
            this.tabgameserver.PerformLayout();
            this.tabclanpage.ResumeLayout(false);
            this.tabclanpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip servicestatusstrip;
        private System.Windows.Forms.ToolStripStatusLabel labelworkerstatus;
        private System.Windows.Forms.TabControl tabmaster;
        private System.Windows.Forms.TabPage tabgameserver;
        private System.Windows.Forms.TabPage tabcloudserver;
        private System.Windows.Forms.TabPage tabvoiceserver;
        private System.Windows.Forms.TabPage tabwebspace;
        private System.Windows.Forms.TabPage tabbouncer;
        private System.Windows.Forms.TabPage tabclanpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelservice;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelservicetype;
        private System.Windows.Forms.Label labelgamesuspendtime;
        private System.Windows.Forms.Label labelgamestarttime;
        private System.Windows.Forms.Label labelgameserver;
        private System.Windows.Forms.PictureBox serverimage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labellocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelip;
        private System.Windows.Forms.Label labelservicestatus;
        private System.Windows.Forms.Label labelgamestatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelnextupdate;
        private System.Windows.Forms.Timer timermaschine;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton btntimerstartstop;
    }
}