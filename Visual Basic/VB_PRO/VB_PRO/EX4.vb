Public Class EX4
    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        'Variable Declaration

        'Dim mark1, mark2, total As Integer

        Dim mark1 As Integer = 20
        Dim mark2 As Integer = 40
        Dim total As Integer = mark1 + mark2

        'mark1 = 40
        'mark2 = 20
        'total = mark1 + mark2

        'MessageBox.Show("Total : " & total, "Calculation")

        MessageBox.Show("Total : " & total, "Calculation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub
End Class