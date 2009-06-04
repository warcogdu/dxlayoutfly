Public Class DynamicReport

  Private mLayout As String

  Public Event ReportSaved(ByVal sender As Object, ByVal newLayoutString As String)

  Private Sub DynamicReport_DesignerLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs) Handles Me.DesignerLoaded

    Dim ms As System.ComponentModel.Design.IMenuCommandService = CType(e.DesignerHost.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)


    Dim fileSaveAsCommand As System.ComponentModel.Design.MenuCommand = ms.FindCommand(DevExpress.XtraReports.UserDesigner.Native.UICommands.SaveFileAs)
    ms.RemoveCommand(fileSaveAsCommand)
    'don't want to add a save as button.
    'ms.AddCommand(New System.ComponentModel.Design.MenuCommand(New EventHandler(AddressOf OnSaveFileAs), DevExpress.XtraReports.UserDesigner.Native.UICommands.SaveFileAs))

    Dim fileSaveCommand As System.ComponentModel.Design.MenuCommand = ms.FindCommand(DevExpress.XtraReports.UserDesigner.Native.UICommands.SaveFile)
    ms.RemoveCommand(fileSaveCommand)
    ms.AddCommand(New System.ComponentModel.Design.MenuCommand(New EventHandler(AddressOf OnReportDesignerSaveFile), DevExpress.XtraReports.UserDesigner.Native.UICommands.SaveFile))

    'Hide data fields box
    Dim df As DevExpress.XtraReports.UserDesigner.XRDesignFormEx = CType(Me.Site.GetService(GetType(DevExpress.XtraReports.UserDesigner.XRDesignFormEx)), DevExpress.XtraReports.UserDesigner.XRDesignFormEx)

    If Not df Is Nothing Then df.SetWindowVisibility(DevExpress.XtraReports.UserDesigner.DesignDockPanelType.FieldList, False)
    'If Not Me.DesignFormEx Is Nothing Then Me.DesignFormEx.SetWindowVisibility(DevExpress.XtraReports.UserDesigner.DesignDockPanelType.FieldList, False)

  End Sub

  'Public Sub SetLayoutRecord(ByVal record As DAL.DynamicReportDefinition)
  '  mRecord = record

  '  If record IsNot Nothing Then
  '    If record.ReportLayout <> "" Then
  '      Me.LoadLayoutFromString(record.ReportLayout)
  '    End If

  '  End If

  'End Sub

  Public Function LoadLayoutFromString(ByVal layoutString As String) As Boolean
    If layoutString Is Nothing Then Return True
    If layoutString.Trim = "" Then Return True

    Dim loResult As Boolean = True
    Dim loSw As IO.StreamWriter = New IO.StreamWriter(New IO.MemoryStream)

    Try
      loSw.Write(layoutString)
      loSw.Flush()

      Me.LoadLayout(loSw.BaseStream)
    Catch
      loResult = False
    Finally
      loSw.Close()
      loSw.Dispose()
      loSw = Nothing
    End Try

    Return loResult

  End Function


  Sub OnReportDesignerSaveFile(ByVal sender As Object, ByVal e As EventArgs)
    ' Write your custom processing for the SaveFile command here.

    Try

      'ToDo Save layout to db!!!
      'need to know
      '1. report type
      '2. report name we are editing (user defined)
      '3. ?
      '=========================================================
      Dim ms As New IO.MemoryStream

      Me.SaveLayout(ms)

      ms.Position = 0

      Dim sr As IO.StreamReader = New IO.StreamReader(ms)

      'save to output
      mLayout = sr.ReadToEnd

      sr.Close()
      sr.Dispose()
      sr = Nothing

      ms.Dispose()
      ms = Nothing

      ' Also, use this code to prevent the "Report has been changed" dialog from being shown.
      Dim designPanel As DevExpress.XtraReports.UserDesigner.XRDesignPanel = CType(Me.Site.GetService(GetType(DevExpress.XtraReports.UserDesigner.XRDesignPanel)), DevExpress.XtraReports.UserDesigner.XRDesignPanel)
      designPanel.ReportState = DevExpress.XtraReports.UserDesigner.ReportState.Saved


      'RaiseEvent CustomSaveLayout(Me, _SavedLayoutString)

      'NOW SAVE TO DATABASE
      'If mRecord IsNot Nothing Then
      '  mRecord.ReportLayout = mLayout
      'End If

      RaiseEvent ReportSaved(Me, mLayout)

      DevExpress.XtraEditors.XtraMessageBox.Show("Report Layout Saved", "Save Report Layout", MessageBoxButtons.OK, MessageBoxIcon.Information)

      'This closes the report file but leaves the designer open.
      'designPanel.CloseReport()

    Catch ex As Exception
      DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error saving Report Layout", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub


End Class