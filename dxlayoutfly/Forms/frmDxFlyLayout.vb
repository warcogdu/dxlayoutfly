Public Class frmDxFlyLayout 

  Private Sub txtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.EditValueChanged
    Me.Text = Me.txtName.Text
  End Sub

End Class