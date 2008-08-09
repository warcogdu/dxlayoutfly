Public Class ReportDesignerForm

  Public Sub EditReport(ByVal report As DevExpress.XtraReports.UI.XtraReport, ByVal title As String)
    Me.XrDesignPanel1.OpenReport(report)
    Me.RibbonControl.ApplicationDocumentCaption = title
  End Sub

End Class