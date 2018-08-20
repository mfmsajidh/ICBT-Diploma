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
        Me.cmbMovie = New System.Windows.Forms.ComboBox()
        Me.BtnChk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbMovie
        '
        Me.cmbMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMovie.FormattingEnabled = True
        Me.cmbMovie.Items.AddRange(New Object() {"Harry Potter", "Fast & Furious", "Mission Impossible", "Thor", "Hulk"})
        Me.cmbMovie.Location = New System.Drawing.Point(30, 38)
        Me.cmbMovie.Name = "cmbMovie"
        Me.cmbMovie.Size = New System.Drawing.Size(265, 24)
        Me.cmbMovie.TabIndex = 0
        Me.cmbMovie.Text = "Select The Movies You Watched"
        '
        'BtnChk
        '
        Me.BtnChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChk.Location = New System.Drawing.Point(236, 119)
        Me.BtnChk.Name = "BtnChk"
        Me.BtnChk.Size = New System.Drawing.Size(81, 37)
        Me.BtnChk.TabIndex = 1
        Me.BtnChk.Text = "CHECK"
        Me.BtnChk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 168)
        Me.Controls.Add(Me.BtnChk)
        Me.Controls.Add(Me.cmbMovie)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbMovie As ComboBox
    Friend WithEvents BtnChk As Button
End Class
