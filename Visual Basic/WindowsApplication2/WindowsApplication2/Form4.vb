Public Class Form4
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cmbfood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfood.SelectedIndexChanged
        Dim food As String

        food = cmbfood.Text

        Select Case food
            Case "Pizza"
                MessageBox.Show("You've Selected Pizza", "Welcome To Food Store", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case "Pasta"
                MessageBox.Show("You've Selected Pasta", "Welcome To Food Store", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case "Soups"
                MessageBox.Show("You've Selected Soups", "Welcome To Food Store", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case "Ice Cream"
                MessageBox.Show("You've Selected Ice Ceream", "Welcome To Food Store", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case Else
                MessageBox.Show("You've Selected Rice & Curry", "Welcome To Food Store", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class