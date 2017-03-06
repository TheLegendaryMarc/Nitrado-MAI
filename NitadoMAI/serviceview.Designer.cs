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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelnextupdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabmaster = new System.Windows.Forms.TabControl();
            this.tabgameserver = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.labelgame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelgamestatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labellocation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelip = new System.Windows.Forms.Label();
            this.labelservicestatus = new System.Windows.Forms.Label();
            this.labelgamesuspendtime = new System.Windows.Forms.Label();
            this.labelgamestarttime = new System.Windows.Forms.Label();
            this.labelgameserver = new System.Windows.Forms.Label();
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
            this.timermaschine = new System.Windows.Forms.Timer(this.components);
            this.serverimage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelworkerstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btntimerstartstop = new System.Windows.Forms.ToolStripSplitButton();
            this.minutenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekundenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sekundenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sekundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekundenunstableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.servicestatusstrip.SuspendLayout();
            this.tabmaster.SuspendLayout();
            this.tabgameserver.SuspendLayout();
            this.tabcloudserver.SuspendLayout();
            this.tabwebspace.SuspendLayout();
            this.tabbouncer.SuspendLayout();
            this.tabclanpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(175, 17);
            this.toolStripStatusLabel2.Text = "Sekunden bis zur Aktualisierung";
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
            this.tabgameserver.Controls.Add(this.label7);
            this.tabgameserver.Controls.Add(this.labelgame);
            this.tabgameserver.Controls.Add(this.label4);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "IP:";
            // 
            // labelgame
            // 
            this.labelgame.AutoSize = true;
            this.labelgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgame.Location = new System.Drawing.Point(224, 77);
            this.labelgame.Name = "labelgame";
            this.labelgame.Size = new System.Drawing.Size(71, 16);
            this.labelgame.TabIndex = 16;
            this.labelgame.Text = "%GAME%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Game:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(170, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Läuft ab am:";
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
            // labellocation
            // 
            this.labellocation.AutoSize = true;
            this.labellocation.Location = new System.Drawing.Point(820, 41);
            this.labellocation.Name = "labellocation";
            this.labellocation.Size = new System.Drawing.Size(77, 13);
            this.labellocation.TabIndex = 9;
            this.labellocation.Text = "%LOCATION%";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Servicestatus:";
            // 
            // labelip
            // 
            this.labelip.AutoSize = true;
            this.labelip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelip.Location = new System.Drawing.Point(224, 37);
            this.labelip.Name = "labelip";
            this.labelip.Size = new System.Drawing.Size(82, 16);
            this.labelip.TabIndex = 6;
            this.labelip.Text = "%IP&PORT%";
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
            // labelgamesuspendtime
            // 
            this.labelgamesuspendtime.AutoSize = true;
            this.labelgamesuspendtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgamesuspendtime.Location = new System.Drawing.Point(256, 128);
            this.labelgamesuspendtime.Name = "labelgamesuspendtime";
            this.labelgamesuspendtime.Size = new System.Drawing.Size(130, 16);
            this.labelgamesuspendtime.TabIndex = 3;
            this.labelgamesuspendtime.Text = "%SUSPENDTIME%";
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
            // tabcloudserver
            // 
            this.tabcloudserver.BackColor = System.Drawing.Color.Black;
            this.tabcloudserver.Controls.Add(this.pictureBox4);
            this.tabcloudserver.Controls.Add(this.label13);
            this.tabcloudserver.Location = new System.Drawing.Point(4, 22);
            this.tabcloudserver.Name = "tabcloudserver";
            this.tabcloudserver.Size = new System.Drawing.Size(1005, 528);
            this.tabcloudserver.TabIndex = 5;
            this.tabcloudserver.Text = "Cloudserver";
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
            this.tabwebspace.BackColor = System.Drawing.Color.Black;
            this.tabwebspace.Controls.Add(this.pictureBox3);
            this.tabwebspace.Controls.Add(this.label12);
            this.tabwebspace.Location = new System.Drawing.Point(4, 22);
            this.tabwebspace.Name = "tabwebspace";
            this.tabwebspace.Size = new System.Drawing.Size(1005, 528);
            this.tabwebspace.TabIndex = 2;
            this.tabwebspace.Text = "Webspace";
            // 
            // tabbouncer
            // 
            this.tabbouncer.BackColor = System.Drawing.Color.Black;
            this.tabbouncer.Controls.Add(this.pictureBox2);
            this.tabbouncer.Controls.Add(this.label11);
            this.tabbouncer.Location = new System.Drawing.Point(4, 22);
            this.tabbouncer.Name = "tabbouncer";
            this.tabbouncer.Size = new System.Drawing.Size(1005, 528);
            this.tabbouncer.TabIndex = 3;
            this.tabbouncer.Text = "Bouncer";
            // 
            // tabclanpage
            // 
            this.tabclanpage.BackColor = System.Drawing.Color.Black;
            this.tabclanpage.Controls.Add(this.pictureBox1);
            this.tabclanpage.Controls.Add(this.label2);
            this.tabclanpage.Location = new System.Drawing.Point(4, 22);
            this.tabclanpage.Name = "tabclanpage";
            this.tabclanpage.Size = new System.Drawing.Size(1005, 528);
            this.tabclanpage.TabIndex = 4;
            this.tabclanpage.Text = "Clanpage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 18);
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
            // timermaschine
            // 
            this.timermaschine.Interval = 1000;
            this.timermaschine.Tag = "stopped";
            this.timermaschine.Tick += new System.EventHandler(this.timermaschine_Tick);
            // 
            // serverimage
            // 
            this.serverimage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("serverimage.ErrorImage")));
            this.serverimage.InitialImage = global::NitadoMAI.Properties.Resources.squares;
            this.serverimage.Location = new System.Drawing.Point(8, 6);
            this.serverimage.Name = "serverimage";
            this.serverimage.Size = new System.Drawing.Size(150, 150);
            this.serverimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serverimage.TabIndex = 0;
            this.serverimage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NitadoMAI.Properties.Resources.notfound;
            this.pictureBox1.Location = new System.Drawing.Point(3, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelworkerstatus
            // 
            this.labelworkerstatus.Image = global::NitadoMAI.Properties.Resources.deleteicon;
            this.labelworkerstatus.Name = "labelworkerstatus";
            this.labelworkerstatus.Size = new System.Drawing.Size(131, 16);
            this.labelworkerstatus.Text = "Kein Service geladen";
            // 
            // btntimerstartstop
            // 
            this.btntimerstartstop.BackColor = System.Drawing.Color.Blue;
            this.btntimerstartstop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btntimerstartstop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minutenToolStripMenuItem1,
            this.minutenToolStripMenuItem,
            this.sekundenToolStripMenuItem2,
            this.sekundenToolStripMenuItem1,
            this.sekundenToolStripMenuItem,
            this.sekundenunstableToolStripMenuItem});
            this.btntimerstartstop.Image = ((System.Drawing.Image)(resources.GetObject("btntimerstartstop.Image")));
            this.btntimerstartstop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntimerstartstop.Name = "btntimerstartstop";
            this.btntimerstartstop.Size = new System.Drawing.Size(208, 20);
            this.btntimerstartstop.Tag = "60";
            this.btntimerstartstop.Text = "Automatische Aktualisierung - OFF";
            this.btntimerstartstop.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // minutenToolStripMenuItem1
            // 
            this.minutenToolStripMenuItem1.Name = "minutenToolStripMenuItem1";
            this.minutenToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.minutenToolStripMenuItem1.Text = "5 Minuten";
            this.minutenToolStripMenuItem1.Click += new System.EventHandler(this.minutenToolStripMenuItem1_Click);
            // 
            // minutenToolStripMenuItem
            // 
            this.minutenToolStripMenuItem.Name = "minutenToolStripMenuItem";
            this.minutenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.minutenToolStripMenuItem.Text = "2 Minuten";
            this.minutenToolStripMenuItem.Click += new System.EventHandler(this.minutenToolStripMenuItem_Click);
            // 
            // sekundenToolStripMenuItem2
            // 
            this.sekundenToolStripMenuItem2.Name = "sekundenToolStripMenuItem2";
            this.sekundenToolStripMenuItem2.Size = new System.Drawing.Size(197, 22);
            this.sekundenToolStripMenuItem2.Text = "90 Sekunden";
            this.sekundenToolStripMenuItem2.Click += new System.EventHandler(this.sekundenToolStripMenuItem2_Click);
            // 
            // sekundenToolStripMenuItem1
            // 
            this.sekundenToolStripMenuItem1.Name = "sekundenToolStripMenuItem1";
            this.sekundenToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.sekundenToolStripMenuItem1.Text = "60 Sekunden";
            this.sekundenToolStripMenuItem1.Click += new System.EventHandler(this.sekundenToolStripMenuItem1_Click);
            // 
            // sekundenToolStripMenuItem
            // 
            this.sekundenToolStripMenuItem.Name = "sekundenToolStripMenuItem";
            this.sekundenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sekundenToolStripMenuItem.Text = "30 Sekunden";
            this.sekundenToolStripMenuItem.Click += new System.EventHandler(this.sekundenToolStripMenuItem_Click);
            // 
            // sekundenunstableToolStripMenuItem
            // 
            this.sekundenunstableToolStripMenuItem.Name = "sekundenunstableToolStripMenuItem";
            this.sekundenunstableToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sekundenunstableToolStripMenuItem.Text = "10 Sekunden (unstable)";
            this.sekundenunstableToolStripMenuItem.Click += new System.EventHandler(this.sekundenunstableToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(97, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(780, 33);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bouncer steht noch nicht zur Verwaltung zur Verfügung";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(98, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(810, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "Webspace steht noch nicht zur Verwaltung zur Verfügung";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(75, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(834, 33);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cloudserver steht noch nicht zur Verwaltung zur Verfügung";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NitadoMAI.Properties.Resources.notfound;
            this.pictureBox2.Location = new System.Drawing.Point(176, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(630, 352);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NitadoMAI.Properties.Resources.notfound;
            this.pictureBox3.Location = new System.Drawing.Point(183, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(630, 352);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::NitadoMAI.Properties.Resources.notfound;
            this.pictureBox4.Location = new System.Drawing.Point(183, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(630, 352);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
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
            this.tabcloudserver.ResumeLayout(false);
            this.tabcloudserver.PerformLayout();
            this.tabwebspace.ResumeLayout(false);
            this.tabwebspace.PerformLayout();
            this.tabbouncer.ResumeLayout(false);
            this.tabbouncer.PerformLayout();
            this.tabclanpage.ResumeLayout(false);
            this.tabclanpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label labelgame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem minutenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekundenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sekundenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sekundenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekundenunstableToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
    }
}