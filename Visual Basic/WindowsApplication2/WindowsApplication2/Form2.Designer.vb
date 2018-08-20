<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.txtlbl = New System.Windows.Forms.Label()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter A Number :-"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(188, 57)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(206, 20)
        Me.txtnum.TabIndex = 1
        '
        'txtlbl
        '
        Me.txtlbl.AutoSize = True
        Me.txtlbl.BackColor = System.Drawing.Color.Yellow
        Me.txtlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlbl.Location = New System.Drawing.Point(33, 121)
        Me.txtlbl.Name = "txtlbl"
        Me.txtlbl.Size = New System.Drawing.Size(204, 13)
        Me.txtlbl.TabIndex = 2
        Me.txtlbl.Text = "Enter A Number Between 10 To 20"
        '
        'btncheck
        '
        Me.btncheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheck.Location = New System.Drawing.Point(132, 172)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(111, 26)
        Me.btncheck.TabIndex = 3
        Me.btncheck.Text = "Check"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 218)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.txtlbl)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents txtlbl As Label
    Friend WithEvents btncheck As Button
End Class
