namespace NitadoMAI
{
    partial class order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelpriceworkerstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelservicetype = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelguthaben = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listlocations = new System.Windows.Forms.CheckedListBox();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.labellocation = new System.Windows.Forms.Label();
            this.groupserver = new System.Windows.Forms.GroupBox();
            this.listservertype = new System.Windows.Forms.CheckedListBox();
            this.taborder = new System.Windows.Forms.TabControl();
            this.tabgameserver = new System.Windows.Forms.TabPage();
            this.Laufzeit = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tracklaufzeit = new System.Windows.Forms.TrackBar();
            this.groupramupgrade = new System.Windows.Forms.GroupBox();
            this.labelserverram = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackupgrade = new System.Windows.Forms.TrackBar();
            this.groupslots = new System.Windows.Forms.GroupBox();
            this.labelmaxslots = new System.Windows.Forms.Label();
            this.labelminslots = new System.Windows.Forms.Label();
            this.labelservertype = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelslots = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackslots = new System.Windows.Forms.TrackBar();
            this.tabvoiceserver = new System.Windows.Forms.TabPage();
            this.tabwebspace = new System.Windows.Forms.TabPage();
            this.tabmusicbot = new System.Windows.Forms.TabPage();
            this.tabventrillo = new System.Windows.Forms.TabPage();
            this.tabmumble = new System.Windows.Forms.TabPage();
            this.tabbouncer = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelinstallgame = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listlocationts = new System.Windows.Forms.CheckedListBox();
            this.groupslotsts = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelslotsts = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tracktsslots = new System.Windows.Forms.TrackBar();
            this.btnorderts = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tracklaufzeitts = new System.Windows.Forms.TrackBar();
            this.label21 = new System.Windows.Forms.Label();
            this.labeltsprice = new System.Windows.Forms.Label();
            this.labeltslocation = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupserver.SuspendLayout();
            this.taborder.SuspendLayout();
            this.tabgameserver.SuspendLayout();
            this.Laufzeit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklaufzeit)).BeginInit();
            this.groupramupgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackupgrade)).BeginInit();
            this.groupslots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackslots)).BeginInit();
            this.tabvoiceserver.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupslotsts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktsslots)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklaufzeitts)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelpriceworkerstatus,
            this.toolStripStatusLabel1,
            this.labelservicetype,
            this.toolStripStatusLabel2,
            this.labelguthaben});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelpriceworkerstatus
            // 
            this.labelpriceworkerstatus.Image = global::NitadoMAI.Properties.Resources.deleteicon;
            this.labelpriceworkerstatus.Name = "labelpriceworkerstatus";
            this.labelpriceworkerstatus.Size = new System.Drawing.Size(209, 17);
            this.labelpriceworkerstatus.Text = "Preisdatenbank noch nicht geladen";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "ServiceType:";
            // 
            // labelservicetype
            // 
            this.labelservicetype.Name = "labelservicetype";
            this.labelservicetype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelservicetype.Size = new System.Drawing.Size(69, 17);
            this.labelservicetype.Tag = "gameserver";
            this.labelservicetype.Text = "Gameserver";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel2.Text = "Guthaben:";
            // 
            // labelguthaben
            // 
            this.labelguthaben.Name = "labelguthaben";
            this.labelguthaben.Size = new System.Drawing.Size(89, 17);
            this.labelguthaben.Text = "%GUTHABEN%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listlocations);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location:";
            // 
            // listlocations
            // 
            this.listlocations.CheckOnClick = true;
            this.listlocations.FormattingEnabled = true;
            this.listlocations.Location = new System.Drawing.Point(11, 19);
            this.listlocations.MultiColumn = true;
            this.listlocations.Name = "listlocations";
            this.listlocations.Size = new System.Drawing.Size(707, 49);
            this.listlocations.TabIndex = 0;
            this.listlocations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // labellocation
            // 
            this.labellocation.AutoSize = true;
            this.labellocation.Location = new System.Drawing.Point(67, 14);
            this.labellocation.Name = "labellocation";
            this.labellocation.Size = new System.Drawing.Size(64, 13);
            this.labellocation.TabIndex = 3;
            this.labellocation.Text = "%Location%";
            // 
            // groupserver
            // 
            this.groupserver.Controls.Add(this.listservertype);
            this.groupserver.Controls.Add(this.labellocation);
            this.groupserver.Controls.Add(this.label1);
            this.groupserver.Enabled = false;
            this.groupserver.Location = new System.Drawing.Point(3, 87);
            this.groupserver.Name = "groupserver";
            this.groupserver.Size = new System.Drawing.Size(724, 102);
            this.groupserver.TabIndex = 4;
            this.groupserver.TabStop = false;
            this.groupserver.Text = "Server:";
            // 
            // listservertype
            // 
            this.listservertype.CheckOnClick = true;
            this.listservertype.ColumnWidth = 200;
            this.listservertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listservertype.FormattingEnabled = true;
            this.listservertype.Items.AddRange(new object[] {
            "Publicserver Basic",
            "Publicserver",
            "EPS Publicserver"});
            this.listservertype.Location = new System.Drawing.Point(11, 30);
            this.listservertype.MultiColumn = true;
            this.listservertype.Name = "listservertype";
            this.listservertype.Size = new System.Drawing.Size(707, 52);
            this.listservertype.TabIndex = 4;
            this.listservertype.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listservertype_ItemCheck);
            // 
            // taborder
            // 
            this.taborder.Controls.Add(this.tabgameserver);
            this.taborder.Controls.Add(this.tabvoiceserver);
            this.taborder.Controls.Add(this.tabwebspace);
            this.taborder.Controls.Add(this.tabmusicbot);
            this.taborder.Controls.Add(this.tabventrillo);
            this.taborder.Controls.Add(this.tabmumble);
            this.taborder.Controls.Add(this.tabbouncer);
            this.taborder.Location = new System.Drawing.Point(12, 12);
            this.taborder.Name = "taborder";
            this.taborder.SelectedIndex = 0;
            this.taborder.Size = new System.Drawing.Size(741, 525);
            this.taborder.TabIndex = 5;
            this.taborder.Tag = "";
            this.taborder.SelectedIndexChanged += new System.EventHandler(this.taborder_SelectedIndexChanged);
            // 
            // tabgameserver
            // 
            this.tabgameserver.Controls.Add(this.btnorder);
            this.tabgameserver.Controls.Add(this.Laufzeit);
            this.tabgameserver.Controls.Add(this.labelprice);
            this.tabgameserver.Controls.Add(this.groupramupgrade);
            this.tabgameserver.Controls.Add(this.label15);
            this.tabgameserver.Controls.Add(this.groupslots);
            this.tabgameserver.Controls.Add(this.labelinstallgame);
            this.tabgameserver.Controls.Add(this.groupBox1);
            this.tabgameserver.Controls.Add(this.label13);
            this.tabgameserver.Controls.Add(this.groupserver);
            this.tabgameserver.Controls.Add(this.button1);
            this.tabgameserver.Location = new System.Drawing.Point(4, 22);
            this.tabgameserver.Name = "tabgameserver";
            this.tabgameserver.Padding = new System.Windows.Forms.Padding(3);
            this.tabgameserver.Size = new System.Drawing.Size(733, 499);
            this.tabgameserver.TabIndex = 0;
            this.tabgameserver.Tag = "gameserver";
            this.tabgameserver.Text = "Gameserver";
            this.tabgameserver.UseVisualStyleBackColor = true;
            // 
            // Laufzeit
            // 
            this.Laufzeit.Controls.Add(this.label12);
            this.Laufzeit.Controls.Add(this.label11);
            this.Laufzeit.Controls.Add(this.label10);
            this.Laufzeit.Controls.Add(this.label9);
            this.Laufzeit.Controls.Add(this.tracklaufzeit);
            this.Laufzeit.Enabled = false;
            this.Laufzeit.Location = new System.Drawing.Point(3, 394);
            this.Laufzeit.Name = "Laufzeit";
            this.Laufzeit.Size = new System.Drawing.Size(724, 63);
            this.Laufzeit.TabIndex = 7;
            this.Laufzeit.TabStop = false;
            this.Laufzeit.Text = "Laufzeit:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(673, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "365 Tage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "90 Tage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "30 Tage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "3 Tage";
            // 
            // tracklaufzeit
            // 
            this.tracklaufzeit.Location = new System.Drawing.Point(9, 12);
            this.tracklaufzeit.Maximum = 3;
            this.tracklaufzeit.Name = "tracklaufzeit";
            this.tracklaufzeit.Size = new System.Drawing.Size(699, 45);
            this.tracklaufzeit.TabIndex = 0;
            this.tracklaufzeit.Scroll += new System.EventHandler(this.tracklaufzeit_Scroll);
            // 
            // groupramupgrade
            // 
            this.groupramupgrade.Controls.Add(this.labelserverram);
            this.groupramupgrade.Controls.Add(this.label8);
            this.groupramupgrade.Controls.Add(this.label7);
            this.groupramupgrade.Controls.Add(this.label6);
            this.groupramupgrade.Controls.Add(this.label5);
            this.groupramupgrade.Controls.Add(this.label3);
            this.groupramupgrade.Controls.Add(this.trackupgrade);
            this.groupramupgrade.Enabled = false;
            this.groupramupgrade.Location = new System.Drawing.Point(3, 301);
            this.groupramupgrade.Name = "groupramupgrade";
            this.groupramupgrade.Size = new System.Drawing.Size(724, 87);
            this.groupramupgrade.TabIndex = 6;
            this.groupramupgrade.TabStop = false;
            this.groupramupgrade.Text = "RAM Upgrade (Nur Publicserver)";
            // 
            // labelserverram
            // 
            this.labelserverram.AutoSize = true;
            this.labelserverram.Location = new System.Drawing.Point(39, 64);
            this.labelserverram.Name = "labelserverram";
            this.labelserverram.Size = new System.Drawing.Size(50, 13);
            this.labelserverram.TabIndex = 6;
            this.labelserverram.Tag = "1024";
            this.labelserverram.Text = "1024 MB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ram:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ultimate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Professional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Advanced";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Tag = "";
            this.label3.Text = "Standart";
            // 
            // trackupgrade
            // 
            this.trackupgrade.Location = new System.Drawing.Point(10, 15);
            this.trackupgrade.Maximum = 3;
            this.trackupgrade.Name = "trackupgrade";
            this.trackupgrade.Size = new System.Drawing.Size(699, 45);
            this.trackupgrade.TabIndex = 0;
            this.trackupgrade.Scroll += new System.EventHandler(this.trackupgrade_Scroll);
            // 
            // groupslots
            // 
            this.groupslots.Controls.Add(this.labelmaxslots);
            this.groupslots.Controls.Add(this.labelminslots);
            this.groupslots.Controls.Add(this.labelservertype);
            this.groupslots.Controls.Add(this.label4);
            this.groupslots.Controls.Add(this.labelslots);
            this.groupslots.Controls.Add(this.label2);
            this.groupslots.Controls.Add(this.trackslots);
            this.groupslots.Enabled = false;
            this.groupslots.Location = new System.Drawing.Point(3, 195);
            this.groupslots.Name = "groupslots";
            this.groupslots.Size = new System.Drawing.Size(724, 100);
            this.groupslots.TabIndex = 5;
            this.groupslots.TabStop = false;
            this.groupslots.Text = "Slots:";
            // 
            // labelmaxslots
            // 
            this.labelmaxslots.AutoSize = true;
            this.labelmaxslots.Location = new System.Drawing.Point(683, 61);
            this.labelmaxslots.Name = "labelmaxslots";
            this.labelmaxslots.Size = new System.Drawing.Size(25, 13);
            this.labelmaxslots.TabIndex = 6;
            this.labelmaxslots.Text = "100";
            // 
            // labelminslots
            // 
            this.labelminslots.AutoSize = true;
            this.labelminslots.Location = new System.Drawing.Point(17, 61);
            this.labelminslots.Name = "labelminslots";
            this.labelminslots.Size = new System.Drawing.Size(13, 13);
            this.labelminslots.TabIndex = 5;
            this.labelminslots.Text = "4";
            // 
            // labelservertype
            // 
            this.labelservertype.AutoSize = true;
            this.labelservertype.Location = new System.Drawing.Point(47, 16);
            this.labelservertype.Name = "labelservertype";
            this.labelservertype.Size = new System.Drawing.Size(65, 13);
            this.labelservertype.TabIndex = 4;
            this.labelservertype.Tag = "publicserver";
            this.labelservertype.Text = "Publicserver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Server:";
            // 
            // labelslots
            // 
            this.labelslots.AutoSize = true;
            this.labelslots.Location = new System.Drawing.Point(47, 81);
            this.labelslots.Name = "labelslots";
            this.labelslots.Size = new System.Drawing.Size(13, 13);
            this.labelslots.TabIndex = 2;
            this.labelslots.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slots:";
            // 
            // trackslots
            // 
            this.trackslots.Location = new System.Drawing.Point(10, 29);
            this.trackslots.Maximum = 50;
            this.trackslots.Minimum = 4;
            this.trackslots.Name = "trackslots";
            this.trackslots.Size = new System.Drawing.Size(699, 45);
            this.trackslots.TabIndex = 0;
            this.trackslots.TickFrequency = 2;
            this.trackslots.Value = 4;
            this.trackslots.Scroll += new System.EventHandler(this.trackslots_Scroll);
            // 
            // tabvoiceserver
            // 
            this.tabvoiceserver.Controls.Add(this.labeltsprice);
            this.tabvoiceserver.Controls.Add(this.label21);
            this.tabvoiceserver.Controls.Add(this.groupBox3);
            this.tabvoiceserver.Controls.Add(this.btnorderts);
            this.tabvoiceserver.Controls.Add(this.groupslotsts);
            this.tabvoiceserver.Controls.Add(this.groupBox2);
            this.tabvoiceserver.Location = new System.Drawing.Point(4, 22);
            this.tabvoiceserver.Name = "tabvoiceserver";
            this.tabvoiceserver.Padding = new System.Windows.Forms.Padding(3);
            this.tabvoiceserver.Size = new System.Drawing.Size(733, 499);
            this.tabvoiceserver.TabIndex = 1;
            this.tabvoiceserver.Tag = "voiceserver";
            this.tabvoiceserver.Text = "Voiceserver";
            this.tabvoiceserver.UseVisualStyleBackColor = true;
            // 
            // tabwebspace
            // 
            this.tabwebspace.Location = new System.Drawing.Point(4, 22);
            this.tabwebspace.Name = "tabwebspace";
            this.tabwebspace.Size = new System.Drawing.Size(733, 463);
            this.tabwebspace.TabIndex = 2;
            this.tabwebspace.Tag = "webspace";
            this.tabwebspace.Text = "Webspace";
            this.tabwebspace.UseVisualStyleBackColor = true;
            // 
            // tabmusicbot
            // 
            this.tabmusicbot.Location = new System.Drawing.Point(4, 22);
            this.tabmusicbot.Name = "tabmusicbot";
            this.tabmusicbot.Size = new System.Drawing.Size(733, 463);
            this.tabmusicbot.TabIndex = 3;
            this.tabmusicbot.Tag = "musicbot";
            this.tabmusicbot.Text = "MusicBot";
            this.tabmusicbot.UseVisualStyleBackColor = true;
            // 
            // tabventrillo
            // 
            this.tabventrillo.Location = new System.Drawing.Point(4, 22);
            this.tabventrillo.Name = "tabventrillo";
            this.tabventrillo.Size = new System.Drawing.Size(733, 463);
            this.tabventrillo.TabIndex = 4;
            this.tabventrillo.Tag = "ventrillo";
            this.tabventrillo.Text = "Ventrillo";
            this.tabventrillo.UseVisualStyleBackColor = true;
            // 
            // tabmumble
            // 
            this.tabmumble.Location = new System.Drawing.Point(4, 22);
            this.tabmumble.Name = "tabmumble";
            this.tabmumble.Size = new System.Drawing.Size(733, 463);
            this.tabmumble.TabIndex = 5;
            this.tabmumble.Tag = "mumble";
            this.tabmumble.Text = "Mumble";
            this.tabmumble.UseVisualStyleBackColor = true;
            // 
            // tabbouncer
            // 
            this.tabbouncer.Location = new System.Drawing.Point(4, 22);
            this.tabbouncer.Name = "tabbouncer";
            this.tabbouncer.Size = new System.Drawing.Size(733, 463);
            this.tabbouncer.TabIndex = 6;
            this.tabbouncer.Tag = "bouncer";
            this.tabbouncer.Text = "Bouncer";
            this.tabbouncer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(10, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spiel wählen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(107, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Game:";
            // 
            // labelinstallgame
            // 
            this.labelinstallgame.AutoSize = true;
            this.labelinstallgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinstallgame.Location = new System.Drawing.Point(153, 470);
            this.labelinstallgame.Name = "labelinstallgame";
            this.labelinstallgame.Size = new System.Drawing.Size(139, 16);
            this.labelinstallgame.TabIndex = 8;
            this.labelinstallgame.Text = "Kein Spiel ausgewählt";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(338, 464);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Preis:";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(407, 464);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(66, 24);
            this.labelprice.TabIndex = 10;
            this.labelprice.Text = "0,00 €";
            // 
            // btnorder
            // 
            this.btnorder.Enabled = false;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(605, 464);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(116, 29);
            this.btnorder.TabIndex = 11;
            this.btnorder.Text = "Bestellen";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listlocationts);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location:";
            // 
            // listlocationts
            // 
            this.listlocationts.CheckOnClick = true;
            this.listlocationts.FormattingEnabled = true;
            this.listlocationts.Location = new System.Drawing.Point(11, 19);
            this.listlocationts.MultiColumn = true;
            this.listlocationts.Name = "listlocationts";
            this.listlocationts.Size = new System.Drawing.Size(707, 49);
            this.listlocationts.TabIndex = 0;
            this.listlocationts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listlocationts_ItemCheck);
            // 
            // groupslotsts
            // 
            this.groupslotsts.Controls.Add(this.labeltslocation);
            this.groupslotsts.Controls.Add(this.label14);
            this.groupslotsts.Controls.Add(this.label16);
            this.groupslotsts.Controls.Add(this.labelslotsts);
            this.groupslotsts.Controls.Add(this.label20);
            this.groupslotsts.Controls.Add(this.tracktsslots);
            this.groupslotsts.Enabled = false;
            this.groupslotsts.Location = new System.Drawing.Point(3, 90);
            this.groupslotsts.Name = "groupslotsts";
            this.groupslotsts.Size = new System.Drawing.Size(724, 100);
            this.groupslotsts.TabIndex = 6;
            this.groupslotsts.TabStop = false;
            this.groupslotsts.Text = "Slots:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(683, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "256";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "4";
            // 
            // labelslotsts
            // 
            this.labelslotsts.AutoSize = true;
            this.labelslotsts.Location = new System.Drawing.Point(47, 81);
            this.labelslotsts.Name = "labelslotsts";
            this.labelslotsts.Size = new System.Drawing.Size(13, 13);
            this.labelslotsts.TabIndex = 2;
            this.labelslotsts.Text = "4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Slots:";
            // 
            // tracktsslots
            // 
            this.tracktsslots.Location = new System.Drawing.Point(10, 29);
            this.tracktsslots.Maximum = 256;
            this.tracktsslots.Minimum = 4;
            this.tracktsslots.Name = "tracktsslots";
            this.tracktsslots.Size = new System.Drawing.Size(699, 45);
            this.tracktsslots.TabIndex = 0;
            this.tracktsslots.TickFrequency = 2;
            this.tracktsslots.Value = 4;
            this.tracktsslots.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnorderts
            // 
            this.btnorderts.Enabled = false;
            this.btnorderts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderts.Location = new System.Drawing.Point(592, 449);
            this.btnorderts.Name = "btnorderts";
            this.btnorderts.Size = new System.Drawing.Size(129, 44);
            this.btnorderts.TabIndex = 7;
            this.btnorderts.Text = "Bestellen";
            this.btnorderts.UseVisualStyleBackColor = true;
            this.btnorderts.Click += new System.EventHandler(this.btnorderts_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.tracklaufzeitts);
            this.groupBox3.Location = new System.Drawing.Point(3, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 63);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laufzeit:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(673, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "365 Tage";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(336, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "90 Tage";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "30 Tage";
            // 
            // tracklaufzeitts
            // 
            this.tracklaufzeitts.Location = new System.Drawing.Point(9, 12);
            this.tracklaufzeitts.Maximum = 2;
            this.tracklaufzeitts.Name = "tracklaufzeitts";
            this.tracklaufzeitts.Size = new System.Drawing.Size(699, 45);
            this.tracklaufzeitts.TabIndex = 0;
            this.tracklaufzeitts.Scroll += new System.EventHandler(this.tracklaufzeitts_Scroll);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(201, 460);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 24);
            this.label21.TabIndex = 9;
            this.label21.Text = "Preis:";
            // 
            // labeltsprice
            // 
            this.labeltsprice.AutoSize = true;
            this.labeltsprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltsprice.Location = new System.Drawing.Point(264, 460);
            this.labeltsprice.Name = "labeltsprice";
            this.labeltsprice.Size = new System.Drawing.Size(60, 24);
            this.labeltsprice.TabIndex = 10;
            this.labeltsprice.Text = "0,00 €";
            // 
            // labeltslocation
            // 
            this.labeltslocation.AutoSize = true;
            this.labeltslocation.Location = new System.Drawing.Point(8, 16);
            this.labeltslocation.Name = "labeltslocation";
            this.labeltslocation.Size = new System.Drawing.Size(22, 13);
            this.labeltslocation.TabIndex = 7;
            this.labeltslocation.Text = "DE";
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 562);
            this.Controls.Add(this.taborder);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "order";
            this.Text = "Server bestellen - Nitrado MAI";
            this.Load += new System.EventHandler(this.order_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupserver.ResumeLayout(false);
            this.groupserver.PerformLayout();
            this.taborder.ResumeLayout(false);
            this.tabgameserver.ResumeLayout(false);
            this.tabgameserver.PerformLayout();
            this.Laufzeit.ResumeLayout(false);
            this.Laufzeit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklaufzeit)).EndInit();
            this.groupramupgrade.ResumeLayout(false);
            this.groupramupgrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackupgrade)).EndInit();
            this.groupslots.ResumeLayout(false);
            this.groupslots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackslots)).EndInit();
            this.tabvoiceserver.ResumeLayout(false);
            this.tabvoiceserver.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupslotsts.ResumeLayout(false);
            this.groupslotsts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktsslots)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklaufzeitts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelpriceworkerstatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox listlocations;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labellocation;
        private System.Windows.Forms.GroupBox groupserver;
        private System.Windows.Forms.CheckedListBox listservertype;
        private System.Windows.Forms.TabControl taborder;
        private System.Windows.Forms.TabPage tabgameserver;
        private System.Windows.Forms.TabPage tabvoiceserver;
        private System.Windows.Forms.TabPage tabwebspace;
        private System.Windows.Forms.TabPage tabmusicbot;
        private System.Windows.Forms.TabPage tabventrillo;
        private System.Windows.Forms.TabPage tabmumble;
        private System.Windows.Forms.TabPage tabbouncer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelservicetype;
        private System.Windows.Forms.GroupBox groupslots;
        private System.Windows.Forms.TrackBar trackslots;
        private System.Windows.Forms.Label labelservertype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelslots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelmaxslots;
        private System.Windows.Forms.Label labelminslots;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labelguthaben;
        private System.Windows.Forms.GroupBox Laufzeit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tracklaufzeit;
        private System.Windows.Forms.GroupBox groupramupgrade;
        private System.Windows.Forms.Label labelserverram;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackupgrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelinstallgame;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox listlocationts;
        private System.Windows.Forms.GroupBox groupslotsts;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelslotsts;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar tracktsslots;
        private System.Windows.Forms.Label labeltsprice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar tracklaufzeitts;
        private System.Windows.Forms.Button btnorderts;
        private System.Windows.Forms.Label labeltslocation;
    }
}