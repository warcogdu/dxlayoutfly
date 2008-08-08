<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavedLayouts
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.gridMain = New DevExpress.XtraGrid.GridControl
    Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
    Me.SettingsDataset1 = New dxlayoutfly.SettingsDataset
    Me.colLayoutID = New DevExpress.XtraGrid.Columns.GridColumn
    Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
    Me.colGridLayoutXML = New DevExpress.XtraGrid.Columns.GridColumn
    Me.colReportLayoutXML = New DevExpress.XtraGrid.Columns.GridColumn
    Me.colConnectionString = New DevExpress.XtraGrid.Columns.GridColumn
    Me.colSelectSql = New DevExpress.XtraGrid.Columns.GridColumn
    Me.colDateCreated = New DevExpress.XtraGrid.Columns.GridColumn
    Me.colDateModified = New DevExpress.XtraGrid.Columns.GridColumn
    CType(Me.gridMain, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SettingsDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gridMain
    '
    Me.gridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gridMain.DataMember = "SavedLayouts"
    Me.gridMain.DataSource = Me.SettingsDataset1
    Me.gridMain.EmbeddedNavigator.Buttons.Append.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.Edit.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.EndEdit.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.Remove.Visible = False
    Me.gridMain.EmbeddedNavigator.Name = ""
    Me.gridMain.Location = New System.Drawing.Point(12, 59)
    Me.gridMain.MainView = Me.gvMain
    Me.gridMain.Name = "gridMain"
    Me.gridMain.ShowOnlyPredefinedDetails = True
    Me.gridMain.Size = New System.Drawing.Size(562, 400)
    Me.gridMain.TabIndex = 0
    Me.gridMain.UseEmbeddedNavigator = True
    Me.gridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
    '
    'gvMain
    '
    Me.gvMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer))
    Me.gvMain.Appearance.FocusedRow.Options.UseBackColor = True
    Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLayoutID, Me.colName, Me.colGridLayoutXML, Me.colReportLayoutXML, Me.colConnectionString, Me.colSelectSql, Me.colDateCreated, Me.colDateModified})
    Me.gvMain.GridControl = Me.gridMain
    Me.gvMain.Name = "gvMain"
    Me.gvMain.OptionsView.ShowGroupPanel = False
    '
    'SettingsDataset1
    '
    Me.SettingsDataset1.DataSetName = "SettingsDataset"
    Me.SettingsDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'colLayoutID
    '
    Me.colLayoutID.Caption = "LayoutID"
    Me.colLayoutID.FieldName = "LayoutID"
    Me.colLayoutID.Name = "colLayoutID"
    '
    'colName
    '
    Me.colName.Caption = "Name"
    Me.colName.FieldName = "Name"
    Me.colName.Name = "colName"
    Me.colName.Visible = True
    Me.colName.VisibleIndex = 0
    '
    'colGridLayoutXML
    '
    Me.colGridLayoutXML.Caption = "GridLayoutXML"
    Me.colGridLayoutXML.FieldName = "GridLayoutXML"
    Me.colGridLayoutXML.Name = "colGridLayoutXML"
    '
    'colReportLayoutXML
    '
    Me.colReportLayoutXML.Caption = "ReportLayoutXML"
    Me.colReportLayoutXML.FieldName = "ReportLayoutXML"
    Me.colReportLayoutXML.Name = "colReportLayoutXML"
    '
    'colConnectionString
    '
    Me.colConnectionString.Caption = "ConnectionString"
    Me.colConnectionString.FieldName = "ConnectionString"
    Me.colConnectionString.Name = "colConnectionString"
    '
    'colSelectSql
    '
    Me.colSelectSql.Caption = "SelectSql"
    Me.colSelectSql.FieldName = "SelectSql"
    Me.colSelectSql.Name = "colSelectSql"
    Me.colSelectSql.Visible = True
    Me.colSelectSql.VisibleIndex = 1
    '
    'colDateCreated
    '
    Me.colDateCreated.Caption = "DateCreated"
    Me.colDateCreated.FieldName = "DateCreated"
    Me.colDateCreated.Name = "colDateCreated"
    Me.colDateCreated.Visible = True
    Me.colDateCreated.VisibleIndex = 2
    '
    'colDateModified
    '
    Me.colDateModified.Caption = "DateModified"
    Me.colDateModified.FieldName = "DateModified"
    Me.colDateModified.Name = "colDateModified"
    Me.colDateModified.Visible = True
    Me.colDateModified.VisibleIndex = 3
    '
    'frmSavedLayouts
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(586, 471)
    Me.Controls.Add(Me.gridMain)
    Me.Name = "frmSavedLayouts"
    Me.Text = "My Saved Layouts"
    CType(Me.gridMain, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SettingsDataset1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gridMain As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents SettingsDataset1 As dxlayoutfly.SettingsDataset
  Friend WithEvents colLayoutID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colGridLayoutXML As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colReportLayoutXML As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colConnectionString As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSelectSql As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDateCreated As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDateModified As DevExpress.XtraGrid.Columns.GridColumn
End Class
