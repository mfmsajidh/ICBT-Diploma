<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EX4
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
        Me.BtnCal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCal
        '
        Me.BtnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCal.Location = New System.Drawing.Point(68, 98)
        Me.BtnCal.Name = "BtnCal"
        Me.BtnCal.Size = New System.Drawing.Size(161, 62)
        Me.BtnCal.TabIndex = 0
        Me.BtnCal.Text = "Calculate"
        Me.BtnCal.UseVisualStyleBackColor = True
        '
        'EX4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BtnCal)
        Me.Name = "EX4"
        Me.Text = "EX4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCal As Button
End Class
