<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtmrk = New System.Windows.Forms.TextBox()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Marks"
        '
        'txtmrk
        '
        Me.txtmrk.Location = New System.Drawing.Point(124, 87)
        Me.txtmrk.Name = "txtmrk"
        Me.txtmrk.Size = New System.Drawing.Size(135, 20)
        Me.txtmrk.TabIndex = 1
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Location = New System.Drawing.Point(44, 126)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(67, 13)
        Me.lblinfo.TabIndex = 2
        Me.lblinfo.Text = "Your Grade :"
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(88, 178)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(106, 25)
        Me.btndisplay.TabIndex = 3
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.txtmrk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmrk As TextBox
    Friend WithEvents lblinfo As Label
    Friend WithEvents btndisplay As Button
End Class
