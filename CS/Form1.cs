using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using DevExpress.XtraGrid.Views.Grid;

namespace LoadExternalImages {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private System.Windows.Forms.Label label1;
      private DevExpress.XtraGrid.Columns.GridColumn columnID;
      private DevExpress.XtraGrid.Columns.GridColumn columnName;
      private DevExpress.XtraGrid.Columns.GridColumn columnColor;
      private DevExpress.XtraGrid.Columns.GridColumn columnImage;
      private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
      private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
         InitData();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.columnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 23);
            this.gridControl1.LookAndFeel.SkinName = "The Asphalt World";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(527, 286);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnID,
            this.columnName,
            this.columnColor,
            this.columnImage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 33;
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // columnID
            // 
            this.columnID.Caption = "ID";
            this.columnID.FieldName = "ID";
            this.columnID.Name = "columnID";
            this.columnID.OptionsColumn.ReadOnly = true;
            this.columnID.Visible = true;
            this.columnID.VisibleIndex = 0;
            this.columnID.Width = 81;
            // 
            // columnName
            // 
            this.columnName.Caption = "Name";
            this.columnName.FieldName = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 1;
            this.columnName.Width = 132;
            // 
            // columnColor
            // 
            this.columnColor.Caption = "Color";
            this.columnColor.ColumnEdit = this.repositoryItemComboBox1;
            this.columnColor.FieldName = "Color";
            this.columnColor.Name = "columnColor";
            this.columnColor.Visible = true;
            this.columnColor.VisibleIndex = 2;
            this.columnColor.Width = 152;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Magenta",
            "Orange",
            "Pink",
            "Red",
            "White",
            "Yellow"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // columnImage
            // 
            this.columnImage.Caption = "Image (unbound)";
            this.columnImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.columnImage.FieldName = "Image";
            this.columnImage.Name = "columnImage";
            this.columnImage.OptionsColumn.AllowEdit = false;
            this.columnImage.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.columnImage.Visible = true;
            this.columnImage.VisibleIndex = 3;
            this.columnImage.Width = 118;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "What\'s your favorite color?";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(527, 309);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "db.mdb");
			if(DBFileName != "") {
				DataSet ds = new DataSet();
				string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
				System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM PeopleColors", con);
				oleDbDataAdapter.Fill(ds, "PeopleColors");
				gridControl1.DataSource = ds.Tables["PeopleColors"];
			}
		}

		string ImageDir = @"Images\";
		Hashtable Images = new Hashtable();

		string GetFileName(string color) {         
			if(color == null || color == string.Empty)
				return string.Empty;				
			return color + ".jpg";			
		}

		private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
			if(e.Column.FieldName == "Image" && e.IsGetData) {
				GridView view = sender as GridView;

				string colorName = (string)view.GetRowCellValue(e.RowHandle, "Color");
				string fileName = GetFileName(colorName).ToLower();
				if(!Images.ContainsKey(fileName)) {
					Image img = null;
					try {
						string filePath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, ImageDir + fileName, false);
						img = Image.FromFile(filePath);
					}
					catch {
					}
					Images.Add(fileName, img);
				}
				e.Value = Images[fileName];
			}
		}
	}
}
