Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        Dim num As Integer
        'Dim Result As String

        num = txtnum.Text

        'If num >= 10 Then
        'If num <= 20 Then
        'Result = "Within Range"
        'Else
        'Result = "Out of Range"
        'End If
        ' Else
        'Result = "Out of Range"
        'End If

        'txtlbl.Text = Result

        If num >= 10 And num <= 20 Then
            MessageBox.Show("Number Entered Was: " & num)
            txtnum.Text = ""
            txtnum.Focus()
        Else
            MessageBox.Show("Number Entered wasn't Between 10 and 20")
            txtnum.Text = ""
            txtnum.Focus()
        End If

    End Sub
End Class