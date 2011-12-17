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
			this.employeeListView.Location = new System.Drawing.Point(12, 265);
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
			this.imageList.Images.SetKeyName(7, "add.png");
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
			this.employeeObjectListView.HeaderUsesThemes = false;
			this.employeeObjectListView.Location = new System.Drawing.Point(12, 12);
			this.employeeObjectListView.Name = "employeeObjectListView";
			this.employeeObjectListView.Size = new System.Drawing.Size(675, 237);
			this.employeeObjectListView.SmallImageList = this.imageList;
			this.employeeObjectListView.TabIndex = 3;
			this.employeeObjectListView.UseCompatibleStateImageBehavior = false;
			this.employeeObjectListView.View = System.Windows.Forms.View.Details;
			// 
			// oNameColumn
			// 
			this.oNameColumn.AspectName = "FullName";
			this.oNameColumn.Text = "Nimi";
			this.oNameColumn.Width = 67;
			// 
			// oLevelColumn
			// 
			this.oLevelColumn.AspectName = "Level";
			this.oLevelColumn.HeaderImageKey = "starIcon";
			this.oLevelColumn.ShowTextInHeader = false;
			this.oLevelColumn.Text = "";
			this.oLevelColumn.Width = 68;
			// 
			// oWageColumn
			// 
			this.oWageColumn.AspectName = "Wage";
			this.oWageColumn.AspectToStringFormat = "{0:C}";
			this.oWageColumn.HeaderImageKey = "dollarIcon";
			this.oWageColumn.ShowTextInHeader = false;
			this.oWageColumn.Width = 74;
			// 
			// oProgrammingColumn
			// 
			this.oProgrammingColumn.AspectName = "ProgrammingSkill";
			this.oProgrammingColumn.HeaderImageKey = "programmerIcon";
			this.oProgrammingColumn.ShowTextInHeader = false;
			// 
			// oWritingColumn
			// 
			this.oWritingColumn.AspectName = "WritingSkill";
			this.oWritingColumn.HeaderImageKey = "writerIcon";
			this.oWritingColumn.ShowTextInHeader = false;
			this.oWritingColumn.Width = 56;
			// 
			// oDesigningColumn
			// 
			this.oDesigningColumn.AspectName = "DesigningSkill";
			this.oDesigningColumn.HeaderImageKey = "designerIcon";
			this.oDesigningColumn.ShowTextInHeader = false;
			// 
			// oSoundEngineeringColumn
			// 
			this.oSoundEngineeringColumn.AspectName = "SoundEngineeringSkill";
			this.oSoundEngineeringColumn.HeaderImageKey = "soundEngIcon";
			this.oSoundEngineeringColumn.ShowTextInHeader = false;
			// 
			// oArtColumn
			// 
			this.oArtColumn.AspectName = "ArtSkill";
			this.oArtColumn.HeaderImageKey = "artistIcon";
			this.oArtColumn.ShowTextInHeader = false;
			this.oArtColumn.Text = "";
			// 
			// HireEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 429);
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