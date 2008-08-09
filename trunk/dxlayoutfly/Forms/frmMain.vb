Option Strict On

Public Class frmMain

  Dim mSavedLayoutsForm As frmSavedLayouts

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.InitBindings()
  End Sub

  Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    Me.LoadLookups()

    Me.ShowSavedlayouts()

  End Sub

  Private Sub ShowSavedlayouts()
    If mSavedLayoutsForm Is Nothing Then
      mSavedLayoutsForm = New frmSavedLayouts
      mSavedLayoutsForm.MdiParent = Me
    End If
    mSavedLayoutsForm.Show()

  End Sub

  Public Sub InitBindings()

  End Sub

  Public Sub LoadLookups()

    'skin
    riCboSkin.Items.Clear()
    Me.riCboSkin.BeginUpdate()
    For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
      Me.riCboSkin.Items.Add(skin.SkinName)
    Next
    Me.riCboSkin.EndUpdate()

  End Sub


  Private Sub beiSkin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beiSkin.EditValueChanged

    If Me.beiSkin.EditValue Is Nothing Then Return

    'change skin
    DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = CStr(Me.beiSkin.EditValue)

  End Sub

  Private Sub bbiNewLayout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNewLayout.ItemClick
    Dim f As New frmDxFlyLayout
    f.MdiParent = Me
    f.Show()
  End Sub

  Private Sub bbiShowSavedLayouts_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiShowSavedLayouts.ItemClick
    Me.ShowSavedlayouts()
  End Sub

End Class