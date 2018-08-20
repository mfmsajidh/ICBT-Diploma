Public Class Form3
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim subtotal As Decimal = CDec(txtsubtotal.Text)
        Dim discountPercent As Decimal

        If txtcus_type.Text = "R" Then
            If subtotal < 100 Then
                discountPercent = 0D
            ElseIf subtotal >= 100 And subtotal < 250 Then
                discountPercent = 0.1D
            ElseIf subtotal >= 250 Then
                discountPercent = 0.25D
            End If

        ElseIf txtcus_type.Text = "C" Then
            If subtotal < 250 Then
                discountPercent = 0.2D
            Else
                discountPercent = 0.3D
            End If

        Else
            discountPercent = 0.4D
        End If

        Dim discountAmount As Decimal = subtotal * discountPercent
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        txtpercent.Text = discountPercent
        txtamount.Text = discountAmount
        txttotal.Text = invoiceTotal

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class