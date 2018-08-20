Public Class Form1

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim a As Integer
        Dim b As Integer
        Dim ans As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        ans = a + b
        TextBoxAns.Text = ans


    End Sub

    Private Sub btnmult_Click(sender As Object, e As EventArgs) Handles btnmult.Click
        Dim a As Integer
        Dim b As Integer
        Dim ans As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        ans = a * b
        TextBoxAns.Text = ans
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Dim a As Integer
        Dim b As Integer
        Dim ans As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        ans = a / b
        TextBoxAns.Text = ans
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBoxAns.Text = ""
        TextBox1.Focus()

    End Sub

End Class
