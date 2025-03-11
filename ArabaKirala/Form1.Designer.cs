namespace ArabaKirala
{
    partial class Form1
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
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarToolStripMenuItem,
            this.arabalarToolStripMenuItem,
            this.rezervasyonToolStripMenuItem,
            this.kiralamaToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            this.kullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarToolStripMenuItem_Click);
            // 
            // arabalarToolStripMenuItem
            // 
            this.arabalarToolStripMenuItem.Name = "arabalarToolStripMenuItem";
            this.arabalarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arabalarToolStripMenuItem.Text = "Arabalar";
            this.arabalarToolStripMenuItem.Click += new System.EventHandler(this.arabalarToolStripMenuItem_Click);
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            // 
            // kiralamaToolStripMenuItem
            // 
            this.kiralamaToolStripMenuItem.Name = "kiralamaToolStripMenuItem";
            this.kiralamaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.kiralamaToolStripMenuItem.Text = "Kiralama";
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ana Menü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

