Public Class Form1
    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Dim mrk As Integer

        mrk = Val(txtmrk.Text)

        If mrk >= 50 Then
            lblinfo.Text = "Pass"
        Else
            lblinfo.Text = "Fail"
        End If

    End Sub
End Class
