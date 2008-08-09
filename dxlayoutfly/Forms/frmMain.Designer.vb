<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar2 = New DevExpress.XtraBars.Bar
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
    Me.bbiNewLayout = New DevExpress.XtraBars.BarButtonItem
    Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem
    Me.bbiShowSavedLayouts = New DevExpress.XtraBars.BarButtonItem
    Me.beiSkin = New DevExpress.XtraBars.BarEditItem
    Me.riCboSkin = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem
    Me.bbiAbout = New DevExpress.XtraBars.BarButtonItem
    Me.Bar3 = New DevExpress.XtraBars.Bar
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
    Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem
    Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
    Me.BarMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.riCboSkin, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.bbiNewLayout, Me.BarSubItem3, Me.bbiAbout, Me.BarSubItem4, Me.beiSkin, Me.bbiShowSavedLayouts, Me.BarMdiChildrenListItem1})
    Me.BarManager1.MainMenu = Me.Bar2
    Me.BarManager1.MaxItemId = 9
    Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riCboSkin})
    Me.BarManager1.StatusBar = Me.Bar3
    '
    'Bar2
    '
    Me.Bar2.BarName = "Main menu"
    Me.Bar2.DockCol = 0
    Me.Bar2.DockRow = 0
    Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarMdiChildrenListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3)})
    Me.Bar2.OptionsBar.AllowQuickCustomization = False
    Me.Bar2.OptionsBar.DrawDragBorder = False
    Me.Bar2.OptionsBar.MultiLine = True
    Me.Bar2.OptionsBar.UseWholeRow = True
    Me.Bar2.Text = "Main menu"
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "&File"
    Me.BarSubItem1.Id = 0
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNewLayout)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'bbiNewLayout
    '
    Me.bbiNewLayout.Caption = "New Fly Layout"
    Me.bbiNewLayout.Id = 2
    Me.bbiNewLayout.Name = "bbiNewLayout"
    '
    'BarSubItem4
    '
    Me.BarSubItem4.Caption = "&View"
    Me.BarSubItem4.Id = 5
    Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowSavedLayouts), New DevExpress.XtraBars.LinkPersistInfo(Me.beiSkin)})
    Me.BarSubItem4.Name = "BarSubItem4"
    '
    'bbiShowSavedLayouts
    '
    Me.bbiShowSavedLayouts.Caption = "Saved Layouts"
    Me.bbiShowSavedLayouts.Id = 7
    Me.bbiShowSavedLayouts.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
    Me.bbiShowSavedLayouts.Name = "bbiShowSavedLayouts"
    '
    'beiSkin
    '
    Me.beiSkin.Caption = "SKin"
    Me.beiSkin.Edit = Me.riCboSkin
    Me.beiSkin.Id = 6
    Me.beiSkin.Name = "beiSkin"
    Me.beiSkin.Width = 150
    '
    'riCboSkin
    '
    Me.riCboSkin.AutoHeight = False
    Me.riCboSkin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.riCboSkin.ImmediatePopup = True
    Me.riCboSkin.Name = "riCboSkin"
    Me.riCboSkin.PopupSizeable = True
    Me.riCboSkin.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'BarSubItem3
    '
    Me.BarSubItem3.Caption = "&Help"
    Me.BarSubItem3.Id = 3
    Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAbout)})
    Me.BarSubItem3.Name = "BarSubItem3"
    '
    'bbiAbout
    '
    Me.bbiAbout.Caption = "About"
    Me.bbiAbout.Id = 4
    Me.bbiAbout.Name = "bbiAbout"
    '
    'Bar3
    '
    Me.Bar3.BarName = "Status bar"
    Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.Bar3.DockCol = 0
    Me.Bar3.DockRow = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.Bar3.OptionsBar.AllowQuickCustomization = False
    Me.Bar3.OptionsBar.DrawDragBorder = False
    Me.Bar3.OptionsBar.DrawSizeGrip = True
    Me.Bar3.OptionsBar.UseWholeRow = True
    Me.Bar3.Text = "Status bar"
    '
    'BarSubItem2
    '
    Me.BarSubItem2.Caption = "New"
    Me.BarSubItem2.Id = 1
    Me.BarSubItem2.Name = "BarSubItem2"
    '
    'XtraTabbedMdiManager1
    '
    Me.XtraTabbedMdiManager1.MdiParent = Me
    '
    'BarMdiChildrenListItem1
    '
    Me.BarMdiChildrenListItem1.Caption = "Window"
    Me.BarMdiChildrenListItem1.Id = 8
    Me.BarMdiChildrenListItem1.Name = "BarMdiChildrenListItem1"
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(757, 543)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.IsMdiContainer = True
    Me.Name = "frmMain"
    Me.Text = "DxLayoutFly"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.riCboSkin, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
  Friend WithEvents bbiNewLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents bbiAbout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents beiSkin As DevExpress.XtraBars.BarEditItem
  Friend WithEvents riCboSkin As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents bbiShowSavedLayouts As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
End Class
