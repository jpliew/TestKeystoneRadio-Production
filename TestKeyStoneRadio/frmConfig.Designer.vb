<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.components = New System.ComponentModel.Container
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.lblProgramName = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblHeadroom = New System.Windows.Forms.Label
        Me.trkHeadroom = New System.Windows.Forms.TrackBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.trkHeadroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Score Board", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 30
        Me.ListBox1.Location = New System.Drawing.Point(492, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(163, 150)
        Me.ListBox1.TabIndex = 33
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.Font = New System.Drawing.Font("Ozone", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProgramName.Location = New System.Drawing.Point(486, 9)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(174, 35)
        Me.lblProgramName.TabIndex = 35
        Me.lblProgramName.Text = "COM Port"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(492, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 56)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Off"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(605, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 56)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Bass Boost"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(492, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 56)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Jazz"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(548, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 56)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Live"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(605, 328)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 56)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Vocal"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ozone", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(486, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 32)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "EQ Preset"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.Location = New System.Drawing.Point(492, 390)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 56)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Acoustic"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(548, 390)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 56)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "Ok"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblHeadroom)
        Me.GroupBox1.Controls.Add(Me.trkHeadroom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 431)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BBE Control"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(402, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 26)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Head Room"
        '
        'lblHeadroom
        '
        Me.lblHeadroom.AutoSize = True
        Me.lblHeadroom.ForeColor = System.Drawing.Color.White
        Me.lblHeadroom.Location = New System.Drawing.Point(402, 60)
        Me.lblHeadroom.Name = "lblHeadroom"
        Me.lblHeadroom.Size = New System.Drawing.Size(25, 13)
        Me.lblHeadroom.TabIndex = 78
        Me.lblHeadroom.Text = "0db"
        '
        'trkHeadroom
        '
        Me.trkHeadroom.LargeChange = 1
        Me.trkHeadroom.Location = New System.Drawing.Point(405, 75)
        Me.trkHeadroom.Maximum = 0
        Me.trkHeadroom.Minimum = -12
        Me.trkHeadroom.Name = "trkHeadroom"
        Me.trkHeadroom.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkHeadroom.Size = New System.Drawing.Size(45, 350)
        Me.trkHeadroom.TabIndex = 77
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(667, 464)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblProgramName)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trkHeadroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblProgramName As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblHeadroom As System.Windows.Forms.Label
    Friend WithEvents trkHeadroom As System.Windows.Forms.TrackBar
End Class
