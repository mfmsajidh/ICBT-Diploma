<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EX3
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
        Me.BtnRed = New System.Windows.Forms.Button()
        Me.BtnBlue = New System.Windows.Forms.Button()
        Me.BtnGreen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRed
        '
        Me.BtnRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRed.Location = New System.Drawing.Point(40, 92)
        Me.BtnRed.Name = "BtnRed"
        Me.BtnRed.Size = New System.Drawing.Size(93, 44)
        Me.BtnRed.TabIndex = 0
        Me.BtnRed.Text = "Red"
        Me.BtnRed.UseVisualStyleBackColor = True
        '
        'BtnBlue
        '
        Me.BtnBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBlue.Location = New System.Drawing.Point(172, 92)
        Me.BtnBlue.Name = "BtnBlue"
        Me.BtnBlue.Size = New System.Drawing.Size(93, 44)
        Me.BtnBlue.TabIndex = 0
        Me.BtnBlue.Text = "Blue"
        Me.BtnBlue.UseVisualStyleBackColor = True
        '
        'BtnGreen
        '
        Me.BtnGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGreen.Location = New System.Drawing.Point(306, 92)
        Me.BtnGreen.Name = "BtnGreen"
        Me.BtnGreen.Size = New System.Drawing.Size(93, 44)
        Me.BtnGreen.TabIndex = 0
        Me.BtnGreen.Text = "Green"
        Me.BtnGreen.UseVisualStyleBackColor = True
        '
        'EX3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 388)
        Me.Controls.Add(Me.BtnGreen)
        Me.Controls.Add(Me.BtnBlue)
        Me.Controls.Add(Me.BtnRed)
        Me.Name = "EX3"
        Me.Text = "BackGround Colour Change"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRed As Button
    Friend WithEvents BtnBlue As Button
    Friend WithEvents BtnGreen As Button
End Class
