<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EX2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click Me To Display"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.Location = New System.Drawing.Point(12, 32)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(104, 25)
        Me.lbltext.TabIndex = 1
        Me.lbltext.Text = "Test Label"
        '
        'EX2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 223)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EX2"
        Me.Text = "Click Me To Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lbltext As Label
End Class
