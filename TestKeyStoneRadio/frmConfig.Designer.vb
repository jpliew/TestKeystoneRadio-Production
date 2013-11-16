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
        Me.trkBBEHiMode = New System.Windows.Forms.TrackBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblBBEHpF = New System.Windows.Forms.Label
        Me.trkBBEHpF = New System.Windows.Forms.TrackBar
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblBBEHiMode = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblBBEMp = New System.Windows.Forms.Label
        Me.trkBBEMp = New System.Windows.Forms.TrackBar
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblBBESurr = New System.Windows.Forms.Label
        Me.trkBBESurr = New System.Windows.Forms.TrackBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblBBEMachQ = New System.Windows.Forms.Label
        Me.trkBBEMachQ = New System.Windows.Forms.TrackBar
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblBBEMachGain = New System.Windows.Forms.Label
        Me.trkBBEMachGain = New System.Windows.Forms.TrackBar
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblMachFreq = New System.Windows.Forms.Label
        Me.trkBBEMachFreq = New System.Windows.Forms.TrackBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblBBECFreq = New System.Windows.Forms.Label
        Me.trkBBECFreq = New System.Windows.Forms.TrackBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblBBEHi = New System.Windows.Forms.Label
        Me.trkBBEHi = New System.Windows.Forms.TrackBar
        Me.lblBBELo = New System.Windows.Forms.Label
        Me.trkBBELo = New System.Windows.Forms.TrackBar
        Me.Button9 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.trkHeadroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBEHiMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBEHpF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBEMp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBESurr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBEMachQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBEMachGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBEMachFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBECFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBEHi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBBELo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.trkBBEHiMode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblBBEHpF)
        Me.GroupBox1.Controls.Add(Me.trkBBEHpF)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblBBEHiMode)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblBBEMp)
        Me.GroupBox1.Controls.Add(Me.trkBBEMp)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblBBESurr)
        Me.GroupBox1.Controls.Add(Me.trkBBESurr)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblBBEMachQ)
        Me.GroupBox1.Controls.Add(Me.trkBBEMachQ)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblBBEMachGain)
        Me.GroupBox1.Controls.Add(Me.trkBBEMachGain)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblMachFreq)
        Me.GroupBox1.Controls.Add(Me.trkBBEMachFreq)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblBBECFreq)
        Me.GroupBox1.Controls.Add(Me.trkBBECFreq)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblBBEHi)
        Me.GroupBox1.Controls.Add(Me.trkBBEHi)
        Me.GroupBox1.Controls.Add(Me.lblBBELo)
        Me.GroupBox1.Controls.Add(Me.trkBBELo)
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
        'trkBBEHiMode
        '
        Me.trkBBEHiMode.LargeChange = 1
        Me.trkBBEHiMode.Location = New System.Drawing.Point(366, 75)
        Me.trkBBEHiMode.Maximum = 12
        Me.trkBBEHiMode.Name = "trkBBEHiMode"
        Me.trkBBEHiMode.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBEHiMode.Size = New System.Drawing.Size(45, 350)
        Me.trkBBEHiMode.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(325, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 26)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "HP Filter"
        '
        'lblBBEHpF
        '
        Me.lblBBEHpF.AutoSize = True
        Me.lblBBEHpF.ForeColor = System.Drawing.Color.White
        Me.lblBBEHpF.Location = New System.Drawing.Point(327, 60)
        Me.lblBBEHpF.Name = "lblBBEHpF"
        Me.lblBBEHpF.Size = New System.Drawing.Size(25, 13)
        Me.lblBBEHpF.TabIndex = 75
        Me.lblBBEHpF.Text = "0db"
        '
        'trkBBEHpF
        '
        Me.trkBBEHpF.LargeChange = 10
        Me.trkBBEHpF.Location = New System.Drawing.Point(326, 75)
        Me.trkBBEHpF.Maximum = 250
        Me.trkBBEHpF.Minimum = 20
        Me.trkBBEHpF.Name = "trkBBEHpF"
        Me.trkBBEHpF.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBEHpF.Size = New System.Drawing.Size(45, 350)
        Me.trkBBEHpF.SmallChange = 10
        Me.trkBBEHpF.TabIndex = 74
        Me.trkBBEHpF.TickFrequency = 10
        Me.trkBBEHpF.Value = 20
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(367, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 26)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Hi Mode"
        '
        'lblBBEHiMode
        '
        Me.lblBBEHiMode.AutoSize = True
        Me.lblBBEHiMode.ForeColor = System.Drawing.Color.White
        Me.lblBBEHiMode.Location = New System.Drawing.Point(367, 60)
        Me.lblBBEHiMode.Name = "lblBBEHiMode"
        Me.lblBBEHiMode.Size = New System.Drawing.Size(25, 13)
        Me.lblBBEHiMode.TabIndex = 72
        Me.lblBBEHiMode.Text = "0db"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(288, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "MP"
        '
        'lblBBEMp
        '
        Me.lblBBEMp.AutoSize = True
        Me.lblBBEMp.ForeColor = System.Drawing.Color.White
        Me.lblBBEMp.Location = New System.Drawing.Point(287, 60)
        Me.lblBBEMp.Name = "lblBBEMp"
        Me.lblBBEMp.Size = New System.Drawing.Size(25, 13)
        Me.lblBBEMp.TabIndex = 69
        Me.lblBBEMp.Text = "0db"
        '
        'trkBBEMp
        '
        Me.trkBBEMp.LargeChange = 1
        Me.trkBBEMp.Location = New System.Drawing.Point(286, 75)
        Me.trkBBEMp.Name = "trkBBEMp"
        Me.trkBBEMp.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBEMp.Size = New System.Drawing.Size(45, 350)
        Me.trkBBEMp.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(248, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Surr"
        '
        'lblBBESurr
        '
        Me.lblBBESurr.AutoSize = True
        Me.lblBBESurr.ForeColor = System.Drawing.Color.White
        Me.lblBBESurr.Location = New System.Drawing.Point(247, 60)
        Me.lblBBESurr.Name = "lblBBESurr"
        Me.lblBBESurr.Size = New System.Drawing.Size(25, 13)
        Me.lblBBESurr.TabIndex = 66
        Me.lblBBESurr.Text = "0db"
        '
        'trkBBESurr
        '
        Me.trkBBESurr.LargeChange = 1
        Me.trkBBESurr.Location = New System.Drawing.Point(246, 75)
        Me.trkBBESurr.Name = "trkBBESurr"
        Me.trkBBESurr.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBESurr.Size = New System.Drawing.Size(45, 350)
        Me.trkBBESurr.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(208, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 31)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Mach Q"
        '
        'lblBBEMachQ
        '
        Me.lblBBEMachQ.AutoSize = True
        Me.lblBBEMachQ.ForeColor = System.Drawing.Color.White
        Me.lblBBEMachQ.Location = New System.Drawing.Point(212, 60)
        Me.lblBBEMachQ.Name = "lblBBEMachQ"
        Me.lblBBEMachQ.Size = New System.Drawing.Size(13, 13)
        Me.lblBBEMachQ.TabIndex = 63
        Me.lblBBEMachQ.Text = "1"
        '
        'trkBBEMachQ
        '
        Me.trkBBEMachQ.LargeChange = 1
        Me.trkBBEMachQ.Location = New System.Drawing.Point(206, 75)
        Me.trkBBEMachQ.Maximum = 1
        Me.trkBBEMachQ.Name = "trkBBEMachQ"
        Me.trkBBEMachQ.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBEMachQ.Size = New System.Drawing.Size(45, 350)
        Me.trkBBEMachQ.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(167, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 31)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Mach Gain"
        '
        'lblBBEMachGain
        '
        Me.lblBBEMachGain.AutoSize = True
        Me.lblBBEMachGain.ForeColor = System.Drawing.Color.White
        Me.lblBBEMachGain.Location = New System.Drawing.Point(168, 60)
        Me.lblBBEMachGain.Name = "lblBBEMachGain"
        Me.lblBBEMachGain.Size = New System.Drawing.Size(28, 13)
        Me.lblBBEMachGain.TabIndex = 60
        Me.lblBBEMachGain.Text = "0 db"
        '
        'trkBBEMachGain
        '
        Me.trkBBEMachGain.LargeChange = 1
        Me.trkBBEMachGain.Location = New System.Drawing.Point(166, 75)
        Me.trkBBEMachGain.Maximum = 3
        Me.trkBBEMachGain.Name = "trkBBEMachGain"
        Me.trkBBEMachGain.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBEMachGain.Size = New System.Drawing.Size(45, 350)
        Me.trkBBEMachGain.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(126, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 32)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Mach Freq"
        '
        'lblMachFreq
        '
        Me.lblMachFreq.AutoSize = True
        Me.lblMachFreq.ForeColor = System.Drawing.Color.White
        Me.lblMachFreq.Location = New System.Drawing.Point(126, 60)
        Me.lblMachFreq.Name = "lblMachFreq"
        Me.lblMachFreq.Size = New System.Drawing.Size(32, 13)
        Me.lblMachFreq.TabIndex = 57
        Me.lblMachFreq.Text = "60Hz"
        '
        'trkBBEMachFreq
        '
        Me.trkBBEMachFreq.LargeChange = 1
        Me.trkBBEMachFreq.Location = New System.Drawing.Point(126, 75)
        Me.trkBBEMachFreq.Maximum = 3
        Me.trkBBEMachFreq.Name = "trkBBEMachFreq"
        Me.trkBBEMachFreq.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBEMachFreq.Size = New System.Drawing.Size(45, 350)
        Me.trkBBEMachFreq.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(83, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 31)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Center Freq"
        '
        'lblBBECFreq
        '
        Me.lblBBECFreq.AutoSize = True
        Me.lblBBECFreq.ForeColor = System.Drawing.Color.White
        Me.lblBBECFreq.Location = New System.Drawing.Point(83, 60)
        Me.lblBBECFreq.Name = "lblBBECFreq"
        Me.lblBBECFreq.Size = New System.Drawing.Size(38, 13)
        Me.lblBBECFreq.TabIndex = 54
        Me.lblBBECFreq.Text = "595Hz"
        '
        'trkBBECFreq
        '
        Me.trkBBECFreq.LargeChange = 1
        Me.trkBBECFreq.Location = New System.Drawing.Point(86, 75)
        Me.trkBBECFreq.Maximum = 1
        Me.trkBBECFreq.Name = "trkBBECFreq"
        Me.trkBBECFreq.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBECFreq.Size = New System.Drawing.Size(45, 350)
        Me.trkBBECFreq.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Hi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Lo"
        '
        'lblBBEHi
        '
        Me.lblBBEHi.AutoSize = True
        Me.lblBBEHi.ForeColor = System.Drawing.Color.White
        Me.lblBBEHi.Location = New System.Drawing.Point(48, 60)
        Me.lblBBEHi.Name = "lblBBEHi"
        Me.lblBBEHi.Size = New System.Drawing.Size(25, 13)
        Me.lblBBEHi.TabIndex = 50
        Me.lblBBEHi.Text = "0db"
        '
        'trkBBEHi
        '
        Me.trkBBEHi.LargeChange = 1
        Me.trkBBEHi.Location = New System.Drawing.Point(46, 75)
        Me.trkBBEHi.Maximum = 24
        Me.trkBBEHi.Name = "trkBBEHi"
        Me.trkBBEHi.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBEHi.Size = New System.Drawing.Size(45, 350)
        Me.trkBBEHi.TabIndex = 49
        '
        'lblBBELo
        '
        Me.lblBBELo.AutoSize = True
        Me.lblBBELo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBBELo.ForeColor = System.Drawing.Color.White
        Me.lblBBELo.Location = New System.Drawing.Point(8, 60)
        Me.lblBBELo.Name = "lblBBELo"
        Me.lblBBELo.Size = New System.Drawing.Size(28, 15)
        Me.lblBBELo.TabIndex = 48
        Me.lblBBELo.Text = "0db"
        '
        'trkBBELo
        '
        Me.trkBBELo.LargeChange = 1
        Me.trkBBELo.Location = New System.Drawing.Point(6, 75)
        Me.trkBBELo.Maximum = 24
        Me.trkBBELo.Name = "trkBBELo"
        Me.trkBBELo.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBBELo.Size = New System.Drawing.Size(45, 350)
        Me.trkBBELo.TabIndex = 47
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button9.Location = New System.Drawing.Point(548, 266)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 56)
        Me.Button9.TabIndex = 49
        Me.Button9.Text = "BBE"
        Me.Button9.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.Button9)
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
        CType(Me.trkBBEHiMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBEHpF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBEMp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBESurr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBEMachQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBEMachGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBEMachFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBECFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBEHi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBBELo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblBBELo As System.Windows.Forms.Label
    Friend WithEvents trkBBELo As System.Windows.Forms.TrackBar
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblBBEHi As System.Windows.Forms.Label
    Friend WithEvents trkBBEHi As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMachFreq As System.Windows.Forms.Label
    Friend WithEvents trkBBEMachFreq As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblBBECFreq As System.Windows.Forms.Label
    Friend WithEvents trkBBECFreq As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBBEMachGain As System.Windows.Forms.Label
    Friend WithEvents trkBBEMachGain As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBBEMachQ As System.Windows.Forms.Label
    Friend WithEvents trkBBEMachQ As System.Windows.Forms.TrackBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblBBESurr As System.Windows.Forms.Label
    Friend WithEvents trkBBESurr As System.Windows.Forms.TrackBar
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblBBEHiMode As System.Windows.Forms.Label
    Friend WithEvents trkBBEHiMode As System.Windows.Forms.TrackBar
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblBBEMp As System.Windows.Forms.Label
    Friend WithEvents trkBBEMp As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblBBEHpF As System.Windows.Forms.Label
    Friend WithEvents trkBBEHpF As System.Windows.Forms.TrackBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblHeadroom As System.Windows.Forms.Label
    Friend WithEvents trkHeadroom As System.Windows.Forms.TrackBar
End Class
