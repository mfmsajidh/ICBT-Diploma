Public Class Form1
    Private Sub BtnChk_Click(sender As Object, e As EventArgs) Handles BtnChk.Click
        Dim Movie As String = cmbMovie.Text

        Select Case Movie
            Case "Harry Potter"
                MessageBox.Show("You have watched Harry Potter")
        End Select
    End Sub
End Class
