namespace NitadoMAI
{
    partial class gameswitcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameswitcher));
            this.listgames = new System.Windows.Forms.ListView();
            this.gameicons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listgames
            // 
            this.listgames.LargeImageList = this.gameicons;
            this.listgames.Location = new System.Drawing.Point(12, 12);
            this.listgames.Name = "listgames";
            this.listgames.Size = new System.Drawing.Size(691, 454);
            this.listgames.TabIndex = 0;
            this.listgames.UseCompatibleStateImageBehavior = false;
            this.listgames.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listgames_MouseDoubleClick);
            // 
            // gameicons
            // 
            this.gameicons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.gameicons.ImageSize = new System.Drawing.Size(120, 120);
            this.gameicons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gameswitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 478);
            this.Controls.Add(this.listgames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "gameswitcher";
            this.Text = "Gamedatenbank - Nitrado MAI";
            this.Load += new System.EventHandler(this.gameswitcher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listgames;
        private System.Windows.Forms.ImageList gameicons;
    }
}