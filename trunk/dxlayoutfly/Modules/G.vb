Module G
  Private Const SETTINGSFILENAME As String = "dxlayoutfly.settings"

  Dim mMainForm As frmMain
  Dim mSettings As SettingsDataset

  <STAThread()> _
  Sub Main()

    DevExpress.Skins.SkinManager.EnableFormSkins()

    G.LoadSettingsData()

    mMainForm = New frmMain
    mMainForm.Show()

    Application.Run(mMainForm)

    'Any Exit code here...
    G.SaveSettingsData()

  End Sub

  Public Sub LoadSettingsData()
    If mSettings Is Nothing Then mSettings = New SettingsDataset

    If IO.File.Exists(G.SettingsFile) Then
      Try
        mSettings.ReadXml(G.SettingsFile)
        G.DecryptSettings(mSettings)
      Catch ex As Exception
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error loading settings")
      End Try
    End If

  End Sub
  Public Sub SaveSettingsData()

    If mSettings Is Nothing Then Return

    Try
      G.EncryptSettings(mSettings)
      mSettings.WriteXml(G.SettingsFile)
      'decrypt so we can cont working with this
      G.DecryptSettings(mSettings)
    Catch ex As Exception
      DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error Saving settings")
    End Try

  End Sub

  Private Sub DecryptSettings(ByVal settingData As SettingsDataset)
    If settingData Is Nothing Then Return

    If mSettings.SavedLayouts.Rows.Count = 0 Then Return

    For Each dr As SettingsDataset.SavedLayoutsRow In mSettings.SavedLayouts.Rows
      'Connection Strings (as they are sensitive)
      If dr.ConnectionString <> "" Then
        dr.ConnectionString = SimpleEncryption.DeCryptString(dr.ConnectionString)
      End If
    Next

    mSettings.AcceptChanges()

  End Sub

  Private Sub EncryptSettings(ByVal settingData As SettingsDataset)
    If settingData Is Nothing Then Return

    If mSettings.SavedLayouts.Rows.Count = 0 Then Return

    For Each dr As SettingsDataset.SavedLayoutsRow In mSettings.SavedLayouts.Rows
      'Connection Strings (as they are sensitive)
      dr.BeginEdit()
      dr.ConnectionString = SimpleEncryption.EncryptString(dr.ConnectionString)
      dr.EndEdit()
    Next

    mSettings.AcceptChanges()

  End Sub


  Public ReadOnly Property SettingsFile() As String
    Get
      Return IO.Path.Combine(Application.StartupPath, SETTINGSFILENAME)
    End Get
  End Property

  Public ReadOnly Property SettingsData() As SettingsDataset
    Get
      Return mSettings
    End Get
  End Property

  Private Function ValidateSelectSql(ByVal sql As String) As Boolean
    Dim value As String = ""

    value = Trim(sql).ToLower

    If value = "" Then Return False
    If value.StartsWith("select") = False Then Return False
    If value.Contains("drop table") Then Return False
    If value.Contains("drop database") Then Return False
    If value.Contains("drop view") Then Return False
    If value.Contains("drop s") Then Return False
    If value.Contains(";") Then Return False 'DO NOT ALLOW MULTI STATEMENTS!!!
    'if value.Contains("exec sp_exectuesql etc.....")

    Return True
  End Function


End Module
