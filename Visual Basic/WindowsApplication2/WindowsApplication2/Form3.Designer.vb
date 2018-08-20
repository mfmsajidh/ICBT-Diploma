<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcus_type = New System.Windows.Forms.TextBox()
        Me.txtpercent = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.btncal = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Discount Percent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Discount Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total"
        '
        'txtcus_type
        '
        Me.txtcus_type.Location = New System.Drawing.Point(273, 65)
        Me.txtcus_type.Name = "txtcus_type"
        Me.txtcus_type.Size = New System.Drawing.Size(100, 20)
        Me.txtcus_type.TabIndex = 1
        '
        'txtpercent
        '
        Me.txtpercent.Cursor = System.Windows.Forms.Cursors.No
        Me.txtpercent.Location = New System.Drawing.Point(273, 127)
        Me.txtpercent.Name = "txtpercent"
        Me.txtpercent.ReadOnly = True
        Me.txtpercent.Size = New System.Drawing.Size(100, 20)
        Me.txtpercent.TabIndex = 1
        '
        'txtamount
        '
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.No
        Me.txtamount.Location = New System.Drawing.Point(273, 165)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(100, 20)
        Me.txtamount.TabIndex = 1
        '
        'txttotal
        '
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.No
        Me.txttotal.Location = New System.Drawing.Point(273, 198)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 1
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(273, 98)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 2
        '
        'btncal
        '
        Me.btncal.Location = New System.Drawing.Point(97, 258)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(75, 23)
        Me.btncal.TabIndex = 3
        Me.btncal.Text = "Calculate"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(243, 258)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(73, 23)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 312)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtpercent)
        Me.Controls.Add(Me.txtcus_type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcus_type As TextBox
    Friend WithEvents txtpercent As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents btncal As Button
    Friend WithEvents btnexit As Button
End Class
