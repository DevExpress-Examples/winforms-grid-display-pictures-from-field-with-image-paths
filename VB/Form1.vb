Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports DevExpress.XtraGrid.Views.Grid

Namespace LoadExternalImages
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
	  Private gridControl1 As DevExpress.XtraGrid.GridControl
	  Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	  Private label1 As System.Windows.Forms.Label
	  Private columnID As DevExpress.XtraGrid.Columns.GridColumn
	  Private columnName As DevExpress.XtraGrid.Columns.GridColumn
	  Private columnColor As DevExpress.XtraGrid.Columns.GridColumn
	  Private columnImage As DevExpress.XtraGrid.Columns.GridColumn
	  Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
	  Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		 InitData()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.columnID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.columnName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.columnColor = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.columnImage = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 23)
			Me.gridControl1.LookAndFeel.SkinName = "The Asphalt World"
			Me.gridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemComboBox1})
			Me.gridControl1.Size = New System.Drawing.Size(527, 286)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.columnID, Me.columnName, Me.columnColor, Me.columnImage})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.RowHeight = 33
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
			' 
			' columnID
			' 
			Me.columnID.Caption = "ID"
			Me.columnID.FieldName = "ID"
			Me.columnID.Name = "columnID"
			Me.columnID.OptionsColumn.ReadOnly = True
			Me.columnID.Visible = True
			Me.columnID.VisibleIndex = 0
			Me.columnID.Width = 81
			' 
			' columnName
			' 
			Me.columnName.Caption = "Name"
			Me.columnName.FieldName = "Name"
			Me.columnName.Name = "columnName"
			Me.columnName.Visible = True
			Me.columnName.VisibleIndex = 1
			Me.columnName.Width = 132
			' 
			' columnColor
			' 
			Me.columnColor.Caption = "Color"
			Me.columnColor.ColumnEdit = Me.repositoryItemComboBox1
			Me.columnColor.FieldName = "Color"
			Me.columnColor.Name = "columnColor"
			Me.columnColor.Visible = True
			Me.columnColor.VisibleIndex = 2
			Me.columnColor.Width = 152
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "Black", "Blue", "Green", "Magenta", "Orange", "Pink", "Red", "White", "Yellow"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' columnImage
			' 
			Me.columnImage.Caption = "Image (unbound)"
			Me.columnImage.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.columnImage.FieldName = "Image"
			Me.columnImage.Name = "columnImage"
			Me.columnImage.OptionsColumn.AllowEdit = False
			Me.columnImage.UnboundType = DevExpress.Data.UnboundColumnType.Object
			Me.columnImage.Visible = True
			Me.columnImage.VisibleIndex = 3
			Me.columnImage.Width = 118
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Top
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(527, 23)
			Me.label1.TabIndex = 1
			Me.label1.Text = "What's your favorite color?"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(527, 309)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.label1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "db.mdb")
			If DBFileName <> "" Then
				Dim ds As New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM PeopleColors", con)
				oleDbDataAdapter.Fill(ds, "PeopleColors")
				gridControl1.DataSource = ds.Tables("PeopleColors")
			End If
		End Sub

		Private ImageDir As String = "Images\"
		Private Images As New Hashtable()

		Private Function GetFileName(ByVal color As String) As String
			If color Is Nothing OrElse color = String.Empty Then
				Return String.Empty
			End If
			Return color & ".jpg"
		End Function

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.Column.FieldName = "Image" AndAlso e.IsGetData Then
				Dim view As GridView = TryCast(sender, GridView)

				Dim colorName As String = CStr((CType(e.Row, DataRowView))("Color"))
				Dim fileName As String = GetFileName(colorName).ToLower()
				If (Not Images.ContainsKey(fileName)) Then
					Dim img As Image = Nothing
					Try
						Dim filePath As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, ImageDir & fileName, False)
						img = Image.FromFile(filePath)
					Catch
					End Try
					Images.Add(fileName, img)
				End If
				e.Value = Images(fileName)
			End If
		End Sub
	End Class
End Namespace
