namespace gamedevstory
{
	partial class NewGame
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.genreTab = new System.Windows.Forms.TabPage();
			this.modifiersTab = new System.Windows.Forms.TabPage();
			this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
			this.tabControl.SuspendLayout();
			this.genreTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.genreTab);
			this.tabControl.Controls.Add(this.modifiersTab);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(630, 308);
			this.tabControl.TabIndex = 0;
			// 
			// genreTab
			// 
			this.genreTab.Controls.Add(this.objectListView1);
			this.genreTab.Location = new System.Drawing.Point(4, 22);
			this.genreTab.Name = "genreTab";
			this.genreTab.Padding = new System.Windows.Forms.Padding(3);
			this.genreTab.Size = new System.Drawing.Size(622, 282);
			this.genreTab.TabIndex = 0;
			this.genreTab.Text = "Genre";
			this.genreTab.UseVisualStyleBackColor = true;
			// 
			// modifiersTab
			// 
			this.modifiersTab.Location = new System.Drawing.Point(4, 22);
			this.modifiersTab.Name = "modifiersTab";
			this.modifiersTab.Padding = new System.Windows.Forms.Padding(3);
			this.modifiersTab.Size = new System.Drawing.Size(622, 282);
			this.modifiersTab.TabIndex = 1;
			this.modifiersTab.Text = "Modifiers";
			this.modifiersTab.UseVisualStyleBackColor = true;
			// 
			// objectListView1
			// 
			this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objectListView1.Location = new System.Drawing.Point(3, 3);
			this.objectListView1.Name = "objectListView1";
			this.objectListView1.Size = new System.Drawing.Size(616, 276);
			this.objectListView1.TabIndex = 0;
			this.objectListView1.UseCompatibleStateImageBehavior = false;
			this.objectListView1.View = System.Windows.Forms.View.Details;
			// 
			// NewGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 308);
			this.Controls.Add(this.tabControl);
			this.Name = "NewGame";
			this.Text = "New game";
			this.tabControl.ResumeLayout(false);
			this.genreTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage genreTab;
		private System.Windows.Forms.TabPage modifiersTab;
		private BrightIdeasSoftware.ObjectListView objectListView1;
	}
}