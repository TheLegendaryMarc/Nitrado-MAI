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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceview));
            this.servicestatusstrip = new System.Windows.Forms.StatusStrip();
            this.labelworkerstatus = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.servicestatusstrip.SuspendLayout();
            this.tabmaster.SuspendLayout();
            this.tabclanpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicestatusstrip
            // 
            this.servicestatusstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelworkerstatus});
            this.servicestatusstrip.Location = new System.Drawing.Point(0, 583);
            this.servicestatusstrip.Name = "servicestatusstrip";
            this.servicestatusstrip.Size = new System.Drawing.Size(1013, 22);
            this.servicestatusstrip.TabIndex = 0;
            this.servicestatusstrip.Text = "statusStrip1";
            // 
            // labelworkerstatus
            // 
            this.labelworkerstatus.Image = global::NitadoMAI.Properties.Resources.deleteicon;
            this.labelworkerstatus.Name = "labelworkerstatus";
            this.labelworkerstatus.Size = new System.Drawing.Size(131, 17);
            this.labelworkerstatus.Text = "Kein Service geladen";
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
            this.tabclanpage.ResumeLayout(false);
            this.tabclanpage.PerformLayout();
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
    }
}