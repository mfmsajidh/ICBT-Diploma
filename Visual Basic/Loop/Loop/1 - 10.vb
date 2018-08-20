Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As Integer = 1
        Dim msg As String = ""

        Do While X <= 10
            msg = msg & X & vbNewLine
            txtcount.Text = msg
            X += 1
        Loop
    End Sub
End Class
