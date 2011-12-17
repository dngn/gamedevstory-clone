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
			System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Ohjelmoija", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Graafikko", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Säveltäjä", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Kirjoittaja", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Suunnittelija", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Epäpätevä", System.Windows.Forms.HorizontalAlignment.Left);
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
			this.employeeObjectListView = new BrightIdeasSoftware.ObjectListView();
			this.oNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oLevelColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oWageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oProgrammingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oWritingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oDesigningColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oSoundEngineeringColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oArtColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			((System.ComponentModel.ISupportInitialize)(this.employeeObjectListView)).BeginInit();
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
			listViewGroup7.Header = "Ohjelmoija";
			listViewGroup7.Name = "programmer";
			listViewGroup8.Header = "Graafikko";
			listViewGroup8.Name = "artist";
			listViewGroup9.Header = "Säveltäjä";
			listViewGroup9.Name = "soundEngineer";
			listViewGroup10.Header = "Kirjoittaja";
			listViewGroup10.Name = "writer";
			listViewGroup11.Header = "Suunnittelija";
			listViewGroup11.Name = "designer";
			listViewGroup12.Header = "Epäpätevä";
			listViewGroup12.Name = "nothing";
			this.employeeListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
			this.employeeListView.Location = new System.Drawing.Point(12, 183);
			this.employeeListView.MultiSelect = false;
			this.employeeListView.Name = "employeeListView";
			this.employeeListView.Size = new System.Drawing.Size(502, 152);
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
			this.programmingColumn.Width = 59;
			// 
			// writingColumn
			// 
			this.writingColumn.Width = 62;
			// 
			// designingColumn
			// 
			this.designingColumn.Width = 48;
			// 
			// soundEngineeringColumn
			// 
			this.soundEngineeringColumn.Width = 46;
			// 
			// artColumn
			// 
			this.artColumn.Width = 52;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "starIcon");
			this.imageList.Images.SetKeyName(1, "dollarIcon");
			this.imageList.Images.SetKeyName(2, "artistIcon");
			this.imageList.Images.SetKeyName(3, "programmerIcon");
			this.imageList.Images.SetKeyName(4, "writerIcon");
			this.imageList.Images.SetKeyName(5, "soundEngIcon");
			this.imageList.Images.SetKeyName(6, "designerIcon");
			// 
			// employeeObjectListView
			// 
			this.employeeObjectListView.AllColumns.Add(this.oNameColumn);
			this.employeeObjectListView.AllColumns.Add(this.oLevelColumn);
			this.employeeObjectListView.AllColumns.Add(this.oWageColumn);
			this.employeeObjectListView.AllColumns.Add(this.oProgrammingColumn);
			this.employeeObjectListView.AllColumns.Add(this.oWritingColumn);
			this.employeeObjectListView.AllColumns.Add(this.oDesigningColumn);
			this.employeeObjectListView.AllColumns.Add(this.oSoundEngineeringColumn);
			this.employeeObjectListView.AllColumns.Add(this.oArtColumn);
			this.employeeObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oNameColumn,
            this.oLevelColumn,
            this.oWageColumn,
            this.oProgrammingColumn,
            this.oWritingColumn,
            this.oDesigningColumn,
            this.oSoundEngineeringColumn,
            this.oArtColumn});
			this.employeeObjectListView.Location = new System.Drawing.Point(12, 12);
			this.employeeObjectListView.Name = "employeeObjectListView";
			this.employeeObjectListView.Size = new System.Drawing.Size(502, 165);
			this.employeeObjectListView.SmallImageList = this.imageList;
			this.employeeObjectListView.TabIndex = 3;
			this.employeeObjectListView.UseCompatibleStateImageBehavior = false;
			this.employeeObjectListView.View = System.Windows.Forms.View.Details;
			// 
			// oNameColumn
			// 
			this.oNameColumn.AspectName = "FullName";
			this.oNameColumn.Text = "Nimi";
			// 
			// oLevelColumn
			// 
			this.oLevelColumn.AspectName = "Level";
			this.oLevelColumn.Text = "";
			this.oLevelColumn.Width = 68;
			// 
			// oWageColumn
			// 
			this.oWageColumn.AspectName = "Wage";
			this.oWageColumn.Width = 41;
			// 
			// oProgrammingColumn
			// 
			this.oProgrammingColumn.AspectName = "ProgrammingSkill";
			// 
			// oWritingColumn
			// 
			this.oWritingColumn.AspectName = "WritingSkill";
			this.oWritingColumn.Width = 56;
			// 
			// oDesigningColumn
			// 
			this.oDesigningColumn.AspectName = "DesigningSkill";
			// 
			// oSoundEngineeringColumn
			// 
			this.oSoundEngineeringColumn.AspectName = "SoundEngineeringSkill";
			// 
			// oArtColumn
			// 
			this.oArtColumn.AspectName = "ArtSkill";
			this.oArtColumn.Text = "";
			// 
			// HireEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 347);
			this.Controls.Add(this.employeeObjectListView);
			this.Controls.Add(this.employeeListView);
			this.Name = "HireEmployee";
			this.Text = "HireEmployee";
			this.Load += new System.EventHandler(this.HireEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeeObjectListView)).EndInit();
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
		private BrightIdeasSoftware.ObjectListView employeeObjectListView;
		private BrightIdeasSoftware.OLVColumn oNameColumn;
		private BrightIdeasSoftware.OLVColumn oLevelColumn;
		private BrightIdeasSoftware.OLVColumn oWageColumn;
		private BrightIdeasSoftware.OLVColumn oProgrammingColumn;
		private BrightIdeasSoftware.OLVColumn oWritingColumn;
		private BrightIdeasSoftware.OLVColumn oDesigningColumn;
		private BrightIdeasSoftware.OLVColumn oSoundEngineeringColumn;
		private BrightIdeasSoftware.OLVColumn oArtColumn;

	}
}