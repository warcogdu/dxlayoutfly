<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDxFlyLayout
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
    Me.components = New System.ComponentModel.Container
    Me.gridMain = New DevExpress.XtraGrid.GridControl
    Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
    Me.txtSelect = New DevExpress.XtraEditors.MemoEdit
    Me.txtName = New DevExpress.XtraEditors.TextEdit
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar
    Me.bbiSaveLayout = New DevExpress.XtraBars.BarButtonItem
    Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
    CType(Me.gridMain, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gridMain
    '
    Me.gridMain.EmbeddedNavigator.Buttons.Append.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.Edit.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.EndEdit.Visible = False
    Me.gridMain.EmbeddedNavigator.Buttons.Remove.Visible = False
    Me.gridMain.EmbeddedNavigator.Name = ""
    Me.gridMain.Location = New System.Drawing.Point(107, 88)
    Me.gridMain.MainView = Me.gvMain
    Me.gridMain.Name = "gridMain"
    Me.gridMain.Size = New System.Drawing.Size(400, 200)
    Me.gridMain.TabIndex = 0
    Me.gridMain.UseEmbeddedNavigator = True
    Me.gridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
    '
    'gvMain
    '
    Me.gvMain.GridControl = Me.gridMain
    Me.gvMain.Name = "gvMain"
    '
    'txtSelect
    '
    Me.txtSelect.Location = New System.Drawing.Point(260, 309)
    Me.txtSelect.Name = "txtSelect"
    Me.txtSelect.Size = New System.Drawing.Size(207, 86)
    Me.txtSelect.TabIndex = 1
    '
    'txtName
    '
    Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtName.Location = New System.Drawing.Point(88, 50)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(529, 20)
    Me.txtName.TabIndex = 2
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(12, 53)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
    Me.LabelControl1.TabIndex = 3
    Me.LabelControl1.Text = "Layout Name :"
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSaveLayout})
    Me.BarManager1.MaxItemId = 1
    '
    'Bar1
    '
    Me.Bar1.BarName = "Layout Menu"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
    Me.Bar1.FloatLocation = New System.Drawing.Point(72, 172)
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiSaveLayout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.Bar1.Offset = 13
    Me.Bar1.OptionsBar.AllowRename = True
    Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl1
    Me.Bar1.Text = "Layout Menu"
    '
    'bbiSaveLayout
    '
    Me.bbiSaveLayout.Caption = "Save Fly Layout"
    Me.bbiSaveLayout.Glyph = Global.dxlayoutfly.My.Resources.Resources.MenuBar_Save
    Me.bbiSaveLayout.Id = 0
    Me.bbiSaveLayout.Name = "bbiSaveLayout"
    '
    'StandaloneBarDockControl1
    '
    Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
    Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
    Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
    Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(629, 23)
    Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
    '
    'frmDxFlyLayout
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(629, 472)
    Me.Controls.Add(Me.StandaloneBarDockControl1)
    Me.Controls.Add(Me.LabelControl1)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.txtSelect)
    Me.Controls.Add(Me.gridMain)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmDxFlyLayout"
    Me.Text = "Layout Designer"
    CType(Me.gridMain, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents gridMain As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtSelect As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents bbiSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
