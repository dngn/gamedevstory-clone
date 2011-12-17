namespace gamedevstory
{
	partial class HireEmployee
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Ohjelmoija", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Graafikko", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Säveltäjä", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Kirjoittaja", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Suunnittelija", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Epäpätevä", System.Windows.Forms.HorizontalAlignment.Left);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HireEmployee));
			this.employeeListView = new System.Windows.Forms.ListView();
			this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.levelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.wageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.programmingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.writingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.designingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.soundEngineeringColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.artColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// employeeListView
			// 
			this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.levelColumn,
            this.wageColumn,
            this.programmingColumn,
            this.writingColumn,
            this.designingColumn,
            this.soundEngineeringColumn,
            this.artColumn});
			this.employeeListView.Dock = System.Windows.Forms.DockStyle.Fill;
			listViewGroup1.Header = "Ohjelmoija";
			listViewGroup1.Name = "programmer";
			listViewGroup2.Header = "Graafikko";
			listViewGroup2.Name = "artist";
			listViewGroup3.Header = "Säveltäjä";
			listViewGroup3.Name = "soundEngineer";
			listViewGroup4.Header = "Kirjoittaja";
			listViewGroup4.Name = "writer";
			listViewGroup5.Header = "Suunnittelija";
			listViewGroup5.Name = "designer";
			listViewGroup6.Header = "Epäpätevä";
			listViewGroup6.Name = "nothing";
			this.employeeListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
			this.employeeListView.Location = new System.Drawing.Point(0, 0);
			this.employeeListView.MultiSelect = false;
			this.employeeListView.Name = "employeeListView";
			this.employeeListView.Size = new System.Drawing.Size(526, 347);
			this.employeeListView.SmallImageList = this.imageList;
			this.employeeListView.TabIndex = 2;
			this.employeeListView.UseCompatibleStateImageBehavior = false;
			this.employeeListView.View = System.Windows.Forms.View.Details;
			this.employeeListView.DoubleClick += new System.EventHandler(this.employeeListView_DoubleClick);
			// 
			// nameColumn
			// 
			this.nameColumn.Text = "Nimi";
			this.nameColumn.Width = 108;
			// 
			// levelColumn
			// 
			this.levelColumn.Text = "Taitotaso";
			// 
			// wageColumn
			// 
			this.wageColumn.Text = "Palkkatoive";
			this.wageColumn.Width = 84;
			// 
			// programmingColumn
			// 
			this.programmingColumn.Text = "";
			this.programmingColumn.Width = 59;
			// 
			// writingColumn
			// 
			this.writingColumn.Text = "";
			this.writingColumn.Width = 62;
			// 
			// designingColumn
			// 
			this.designingColumn.Text = "";
			this.designingColumn.Width = 48;
			// 
			// soundEngineeringColumn
			// 
			this.soundEngineeringColumn.Text = "";
			this.soundEngineeringColumn.Width = 46;
			// 
			// artColumn
			// 
			this.artColumn.Text = "";
			this.artColumn.Width = 52;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "artistIcon");
			this.imageList.Images.SetKeyName(1, "programmerIcon");
			this.imageList.Images.SetKeyName(2, "writerIcon");
			this.imageList.Images.SetKeyName(3, "soundEngIcon");
			this.imageList.Images.SetKeyName(4, "designerIcon");
			// 
			// HireEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 347);
			this.Controls.Add(this.employeeListView);
			this.Name = "HireEmployee";
			this.Text = "HireEmployee";
			this.Load += new System.EventHandler(this.HireEmployee_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView employeeListView;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader wageColumn;
		private System.Windows.Forms.ColumnHeader programmingColumn;
		private System.Windows.Forms.ColumnHeader levelColumn;
		private System.Windows.Forms.ColumnHeader writingColumn;
		private System.Windows.Forms.ColumnHeader designingColumn;
		private System.Windows.Forms.ColumnHeader soundEngineeringColumn;
		private System.Windows.Forms.ColumnHeader artColumn;
		private System.Windows.Forms.ImageList imageList;

	}
}