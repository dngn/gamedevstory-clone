namespace gamedevstory
{
	partial class MainWindow
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStrip_file = new System.Windows.Forms.ToolStripMenuItem();
			this.lataaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip_game = new System.Windows.Forms.ToolStripMenuItem();
			this.nykyinenPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lopetaKehitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aloitaUusiProjektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yritysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.työntekijätToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_file,
            this.toolStrip_game,
            this.yritysToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(672, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// toolStrip_file
			// 
			this.toolStrip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lataaToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.poistuToolStripMenuItem});
			this.toolStrip_file.Name = "toolStrip_file";
			this.toolStrip_file.Size = new System.Drawing.Size(65, 20);
			this.toolStrip_file.Text = "Tiedosto";
			// 
			// lataaToolStripMenuItem
			// 
			this.lataaToolStripMenuItem.Name = "lataaToolStripMenuItem";
			this.lataaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.lataaToolStripMenuItem.Text = "Lataa";
			// 
			// tallennaToolStripMenuItem
			// 
			this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
			this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.tallennaToolStripMenuItem.Text = "Tallenna";
			// 
			// poistuToolStripMenuItem
			// 
			this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
			this.poistuToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.poistuToolStripMenuItem.Text = "Poistu";
			// 
			// toolStrip_game
			// 
			this.toolStrip_game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nykyinenPeliToolStripMenuItem,
            this.aloitaUusiProjektiToolStripMenuItem});
			this.toolStrip_game.Name = "toolStrip_game";
			this.toolStrip_game.Size = new System.Drawing.Size(59, 20);
			this.toolStrip_game.Text = "Projekti";
			// 
			// nykyinenPeliToolStripMenuItem
			// 
			this.nykyinenPeliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lopetaKehitysToolStripMenuItem});
			this.nykyinenPeliToolStripMenuItem.Name = "nykyinenPeliToolStripMenuItem";
			this.nykyinenPeliToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.nykyinenPeliToolStripMenuItem.Text = "Nykyinen projekti...";
			// 
			// lopetaKehitysToolStripMenuItem
			// 
			this.lopetaKehitysToolStripMenuItem.Name = "lopetaKehitysToolStripMenuItem";
			this.lopetaKehitysToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.lopetaKehitysToolStripMenuItem.Text = "Lopeta kehitys";
			// 
			// aloitaUusiProjektiToolStripMenuItem
			// 
			this.aloitaUusiProjektiToolStripMenuItem.Name = "aloitaUusiProjektiToolStripMenuItem";
			this.aloitaUusiProjektiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.aloitaUusiProjektiToolStripMenuItem.Text = "Aloita uusi projekti...";
			// 
			// yritysToolStripMenuItem
			// 
			this.yritysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.työntekijätToolStripMenuItem});
			this.yritysToolStripMenuItem.Name = "yritysToolStripMenuItem";
			this.yritysToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.yritysToolStripMenuItem.Text = "Yritys";
			// 
			// työntekijätToolStripMenuItem
			// 
			this.työntekijätToolStripMenuItem.Name = "työntekijätToolStripMenuItem";
			this.työntekijätToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.työntekijätToolStripMenuItem.Text = "Hallitse henkilöstöä...";
			this.työntekijätToolStripMenuItem.Click += new System.EventHandler(this.työntekijätToolStripMenuItem_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 27);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(648, 325);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 364);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.Text = "Pelistudion tarina";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStrip_file;
		private System.Windows.Forms.ToolStripMenuItem toolStrip_game;
		private System.Windows.Forms.ToolStripMenuItem nykyinenPeliToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lopetaKehitysToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aloitaUusiProjektiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yritysToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem työntekijätToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lataaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

