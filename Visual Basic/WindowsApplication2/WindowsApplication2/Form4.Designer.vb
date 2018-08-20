<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.cmbfood = New System.Windows.Forms.ComboBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Your Favourite Food"
        '
        'cmbfood
        '
        Me.cmbfood.FormattingEnabled = True
        Me.cmbfood.Items.AddRange(New Object() {"Pizza", "Pasta", "Ice Cream", "Soups", "Rice and Curry"})
        Me.cmbfood.Location = New System.Drawing.Point(300, 52)
        Me.cmbfood.Name = "cmbfood"
        Me.cmbfood.Size = New System.Drawing.Size(121, 21)
        Me.cmbfood.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(361, 94)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(93, 21)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 127)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.cmbfood)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbfood As ComboBox
    Friend WithEvents btnclose As Button
End Class
