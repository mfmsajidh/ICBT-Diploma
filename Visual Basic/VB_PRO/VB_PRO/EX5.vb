Public Class EX5
    Private Sub BtnClick_Click(sender As Object, e As EventArgs) Handles BtnClick.Click
        Dim dlg As New ColorDialog

        dlg.ShowDialog()

        'If dlg.ShowDialog = DialogResult.OK Then
        If DialogResult.OK Then
            Dim txt As String
            txt = dlg.Color.Name
            MsgBox(txt)
        End If
    End Sub
End Class