using BrightIdeasSoftware;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HireEmployee));
			this.employeeObjectListView = new BrightIdeasSoftware.ObjectListView();
			this.oNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oLevelColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oWageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oProgrammingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oWritingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oDesigningColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oSoundEngineeringColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oArtColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.oSpecialityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.employeeObjectListView)).BeginInit();
			this.SuspendLayout();
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
			this.employeeObjectListView.AllColumns.Add(this.oSpecialityColumn);
			this.employeeObjectListView.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.employeeObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oNameColumn,
            this.oLevelColumn,
            this.oWageColumn,
            this.oProgrammingColumn,
            this.oWritingColumn,
            this.oDesigningColumn,
            this.oSoundEngineeringColumn,
            this.oArtColumn,
            this.oSpecialityColumn});
			this.employeeObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
			this.employeeObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeObjectListView.HeaderUsesThemes = false;
			this.employeeObjectListView.Location = new System.Drawing.Point(0, 0);
			this.employeeObjectListView.Name = "employeeObjectListView";
			this.employeeObjectListView.RowHeight = 24;
			this.employeeObjectListView.ShowGroups = false;
			this.employeeObjectListView.ShowImagesOnSubItems = true;
			this.employeeObjectListView.Size = new System.Drawing.Size(699, 429);
			this.employeeObjectListView.SmallImageList = this.imageList;
			this.employeeObjectListView.TabIndex = 3;
			this.employeeObjectListView.UseAlternatingBackColors = true;
			this.employeeObjectListView.UseCompatibleStateImageBehavior = false;
			this.employeeObjectListView.UseHotItem = true;
			this.employeeObjectListView.UseTranslucentHotItem = true;
			this.employeeObjectListView.View = System.Windows.Forms.View.Details;
			this.employeeObjectListView.DoubleClick += new System.EventHandler(this.employeeObjectListView_DoubleClick);
			// 
			// oNameColumn
			// 
			this.oNameColumn.AspectName = "FullName";
			this.oNameColumn.Text = "Nimi";
			this.oNameColumn.Width = 120;
			// 
			// oLevelColumn
			// 
			this.oLevelColumn.AspectName = "Level";
			this.oLevelColumn.HeaderImageKey = "starIcon";
			this.oLevelColumn.ShowTextInHeader = false;
			this.oLevelColumn.Text = "";
			// 
			// oWageColumn
			// 
			this.oWageColumn.AspectName = "Wage";
			this.oWageColumn.AspectToStringFormat = "{0:C}";
			this.oWageColumn.HeaderImageKey = "dollarIcon";
			this.oWageColumn.ShowTextInHeader = false;
			this.oWageColumn.Width = 80;
			// 
			// oProgrammingColumn
			// 
			this.oProgrammingColumn.AspectName = "ProgrammingSkill";
			this.oProgrammingColumn.HeaderImageKey = "programmerIcon";
			this.oProgrammingColumn.ShowTextInHeader = false;
			this.oProgrammingColumn.Width = 55;
			// 
			// oWritingColumn
			// 
			this.oWritingColumn.AspectName = "WritingSkill";
			this.oWritingColumn.HeaderImageKey = "writerIcon";
			this.oWritingColumn.ShowTextInHeader = false;
			this.oWritingColumn.Width = 55;
			// 
			// oDesigningColumn
			// 
			this.oDesigningColumn.AspectName = "DesigningSkill";
			this.oDesigningColumn.HeaderImageKey = "designerIcon";
			this.oDesigningColumn.ShowTextInHeader = false;
			this.oDesigningColumn.Width = 55;
			// 
			// oSoundEngineeringColumn
			// 
			this.oSoundEngineeringColumn.AspectName = "SoundEngineeringSkill";
			this.oSoundEngineeringColumn.HeaderImageKey = "soundEngIcon";
			this.oSoundEngineeringColumn.ShowTextInHeader = false;
			this.oSoundEngineeringColumn.Width = 55;
			// 
			// oArtColumn
			// 
			this.oArtColumn.AspectName = "ArtSkill";
			this.oArtColumn.HeaderImageKey = "artistIcon";
			this.oArtColumn.ShowTextInHeader = false;
			this.oArtColumn.Width = 55;
			// 
			// oSpecialityColumn
			// 
			this.oSpecialityColumn.AspectName = "SpecialityLocalized";
			this.oSpecialityColumn.Text = "Erityisala";
			this.oSpecialityColumn.Width = 90;
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
			this.imageList.Images.SetKeyName(7, "skilllessIcon");
			// 
			// HireEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 429);
			this.Controls.Add(this.employeeObjectListView);
			this.Name = "HireEmployee";
			this.Text = "HireEmployee";
			this.Load += new System.EventHandler(this.HireEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeeObjectListView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView employeeObjectListView;
		private BrightIdeasSoftware.OLVColumn oNameColumn;
		private BrightIdeasSoftware.OLVColumn oLevelColumn;
		private BrightIdeasSoftware.OLVColumn oWageColumn;
		private BrightIdeasSoftware.OLVColumn oProgrammingColumn;
		private BrightIdeasSoftware.OLVColumn oWritingColumn;
		private BrightIdeasSoftware.OLVColumn oDesigningColumn;
		private BrightIdeasSoftware.OLVColumn oSoundEngineeringColumn;
		private BrightIdeasSoftware.OLVColumn oArtColumn;
		private System.Windows.Forms.ImageList imageList;
		private OLVColumn oSpecialityColumn;

	}
}