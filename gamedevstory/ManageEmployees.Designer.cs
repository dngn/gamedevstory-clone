namespace gamedevstory
{
	partial class ManageEmployees
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
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Ohjelmoija", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Graafikko", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Säveltäjä", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Keijo Kemppainen");
			this.hireEmployeesButton = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// hireEmployeesButton
			// 
			this.hireEmployeesButton.Location = new System.Drawing.Point(13, 214);
			this.hireEmployeesButton.Name = "hireEmployeesButton";
			this.hireEmployeesButton.Size = new System.Drawing.Size(130, 23);
			this.hireEmployeesButton.TabIndex = 0;
			this.hireEmployeesButton.Text = "Palkkaa työntekijöitä...";
			this.hireEmployeesButton.UseVisualStyleBackColor = true;
			this.hireEmployeesButton.Click += new System.EventHandler(this.hireEmployeesButton_Click);
			// 
			// listView1
			// 
			listViewGroup4.Header = "Ohjelmoija";
			listViewGroup4.Name = "programmersGroup";
			listViewGroup5.Header = "Graafikko";
			listViewGroup5.Name = "artistGroup";
			listViewGroup6.Header = "Säveltäjä";
			listViewGroup6.Name = "composersGroup";
			this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
			listViewItem2.Group = listViewGroup4;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
			this.listView1.Location = new System.Drawing.Point(13, 13);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(497, 195);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Tile;
			// 
			// ManageEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 249);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.hireEmployeesButton);
			this.Name = "ManageEmployees";
			this.Text = "ManageEmployees";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button hireEmployeesButton;
		private System.Windows.Forms.ListView listView1;
	}
}