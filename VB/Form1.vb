Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.OleDb

Namespace LoadExternalImages

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As GridView

        Private label1 As Label

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
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            gridControl1 = New DevExpress.XtraGrid.GridControl()
            gridView1 = New GridView()
            columnID = New DevExpress.XtraGrid.Columns.GridColumn()
            columnName = New DevExpress.XtraGrid.Columns.GridColumn()
            columnColor = New DevExpress.XtraGrid.Columns.GridColumn()
            repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            columnImage = New DevExpress.XtraGrid.Columns.GridColumn()
            repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            label1 = New Label()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = DockStyle.Fill
            gridControl1.EmbeddedNavigator.Name = ""
            gridControl1.Location = New System.Drawing.Point(0, 23)
            gridControl1.LookAndFeel.SkinName = "The Asphalt World"
            gridControl1.LookAndFeel.UseDefaultLookAndFeel = False
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {repositoryItemPictureEdit1, repositoryItemComboBox1})
            gridControl1.Size = New System.Drawing.Size(527, 286)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {columnID, columnName, columnColor, columnImage})
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            gridView1.OptionsView.ShowGroupPanel = False
            gridView1.RowHeight = 33
            AddHandler gridView1.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf gridView1_CustomUnboundColumnData)
            ' 
            ' columnID
            ' 
            columnID.Caption = "ID"
            columnID.FieldName = "ID"
            columnID.Name = "columnID"
            columnID.OptionsColumn.ReadOnly = True
            columnID.Visible = True
            columnID.VisibleIndex = 0
            columnID.Width = 81
            ' 
            ' columnName
            ' 
            columnName.Caption = "Name"
            columnName.FieldName = "Name"
            columnName.Name = "columnName"
            columnName.Visible = True
            columnName.VisibleIndex = 1
            columnName.Width = 132
            ' 
            ' columnColor
            ' 
            columnColor.Caption = "Color"
            columnColor.ColumnEdit = repositoryItemComboBox1
            columnColor.FieldName = "Color"
            columnColor.Name = "columnColor"
            columnColor.Visible = True
            columnColor.VisibleIndex = 2
            columnColor.Width = 152
            ' 
            ' repositoryItemComboBox1
            ' 
            repositoryItemComboBox1.AutoHeight = False
            repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemComboBox1.Items.AddRange(New Object() {"Black", "Blue", "Green", "Magenta", "Orange", "Pink", "Red", "White", "Yellow"})
            repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' columnImage
            ' 
            columnImage.Caption = "Image (unbound)"
            columnImage.ColumnEdit = repositoryItemPictureEdit1
            columnImage.FieldName = "Image"
            columnImage.Name = "columnImage"
            columnImage.OptionsColumn.AllowEdit = False
            columnImage.UnboundType = DevExpress.Data.UnboundColumnType.Object
            columnImage.Visible = True
            columnImage.VisibleIndex = 3
            columnImage.Width = 118
            ' 
            ' repositoryItemPictureEdit1
            ' 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            ' 
            ' label1
            ' 
            label1.Dock = DockStyle.Top
            label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            label1.Location = New System.Drawing.Point(0, 0)
            label1.Name = "label1"
            label1.Size = New System.Drawing.Size(527, 23)
            label1.TabIndex = 1
            label1.Text = "What's your favorite color?"
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(527, 309)
            Me.Controls.Add(gridControl1)
            Me.Controls.Add(label1)
            Name = "Form1"
            Text = "Form1"
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "db.mdb")
            If Not Equals(DBFileName, "") Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Using oleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM PeopleColors", con)
                    oleDbDataAdapter.Fill(ds, "PeopleColors")
                End Using

                gridControl1.DataSource = ds.Tables("PeopleColors")
            End If
        End Sub

        Private ImageDir As String = "Images\"

        Private Images As Hashtable = New Hashtable()

        Private Function GetFileName(ByVal color As String) As String
            If Equals(color, Nothing) OrElse Equals(color, String.Empty) Then Return String.Empty
            Return color & ".jpg"
        End Function

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
            If Equals(e.Column.FieldName, "Image") AndAlso e.IsGetData Then
                Dim view As GridView = TryCast(sender, GridView)
                Dim colorName As String = CStr(CType(e.Row, DataRowView)("Color"))
                Dim fileName As String = GetFileName(colorName).ToLower()
                If Not Images.ContainsKey(fileName) Then
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
