namespace MYSQL___ADO
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quittezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quittezToolStripMenuItem,
            this.basesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quittezToolStripMenuItem
            // 
            this.quittezToolStripMenuItem.Name = "quittezToolStripMenuItem";
            this.quittezToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.quittezToolStripMenuItem.Text = "Quittez";
            this.quittezToolStripMenuItem.Click += new System.EventHandler(this.quittezToolStripMenuItem_Click);
            // 
            // basesToolStripMenuItem
            // 
            this.basesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auteursToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.adhérentsToolStripMenuItem,
            this.livresToolStripMenuItem});
            this.basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            this.basesToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.basesToolStripMenuItem.Text = "Bases";
            // 
            // auteursToolStripMenuItem
            // 
            this.auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            this.auteursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.auteursToolStripMenuItem.Text = "Auteurs";
            this.auteursToolStripMenuItem.Click += new System.EventHandler(this.auteursToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.genresToolStripMenuItem.Text = "Genres";
            // 
            // adhérentsToolStripMenuItem
            // 
            this.adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            // 
            // livresToolStripMenuItem
            // 
            this.livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            this.livresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.livresToolStripMenuItem.Text = "Livres";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quittezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;
    }
}