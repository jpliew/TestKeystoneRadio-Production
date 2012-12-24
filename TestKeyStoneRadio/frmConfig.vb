Imports System.IO.Ports

Public Class frmConfig

    Private Sub UpdateEQ()
        If Form1.RadioCommand = 11 Or Form1.RadioCommand = 12 Then Exit Sub

        Button1.BackColor = Color.Gray
        Button3.BackColor = Color.Gray
        Button4.BackColor = Color.Gray
        Button5.BackColor = Color.Gray
        Button6.BackColor = Color.Gray
        Button9.BackColor = Color.Gray

        Select Case Form1.BBEOn
            Case 0
                Button2.BackColor = Color.Red

            Case 1
                Button2.BackColor = Color.Gray
                Button9.BackColor = Color.Green
                trkBBELo.Value = Form1.BBELo
                trkBBEHi.Value = Form1.BBEHi
                trkBBECFreq.Value = Form1.BBECFreq

                Select Case Form1.BBEMachFreq
                    Case 60
                        trkBBEMachFreq.Value = 0
                    Case 90
                        trkBBEMachFreq.Value = 1
                    Case 120
                        trkBBEMachFreq.Value = 2
                    Case 150
                        trkBBEMachFreq.Value = 3
                End Select

                Select Case Form1.BBEMachGain
                    Case 0
                        trkBBEMachGain.Value = 0
                    Case 4
                        trkBBEMachGain.Value = 1
                    Case 8
                        trkBBEMachGain.Value = 2
                    Case 12
                        trkBBEMachGain.Value = 3
                End Select

                Select Case Form1.BBEMachQ
                    Case 0
#If DEBUG Then
                        Console.WriteLine("MachQ=0")
#End If
                    Case 1
                        trkBBEMachQ.Value = 0
                    Case 3
                        trkBBEMachQ.Value = 1
                End Select

                trkBBESurr.Value = Form1.BBESurr
                trkBBEMp.Value = Form1.BBEMp
                trkBBEHiMode.Value = Form1.BBEHiMode
                If Form1.BBEHpF >= 20 Then
                    trkBBEHpF.Value = Form1.BBEHpF
                End If

                trkHeadroom.Value = Form1.HeadRoom


            Case 2
                Button2.BackColor = Color.Gray
                Select Case Form1.EQMode
                    Case 0
                        Button1.BackColor = Color.Green
                    Case 1
                        Button3.BackColor = Color.Green
                    Case 2
                        Button4.BackColor = Color.Green
                    Case 3
                        Button5.BackColor = Color.Green
                    Case 4
                        Button6.BackColor = Color.Green

                End Select

        End Select

    End Sub

    Private Sub frmConfig_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        UpdateEQ()
        Form1.InConfigScreen = True
    End Sub

    Private Sub frmConfig_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.InConfigScreen = False
    End Sub

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ports As String() = SerialPort.GetPortNames
        Dim port As String

        Me.Left = Form1.Left
        Me.Top = Form1.Top

        Me.Text = "Version " & My.Application.Info.Version.ToString

        Timer1.Enabled = True
        'Form1.Timer2.Enabled = False
        'lblProgramText.Left = lblProgramName.Left
        'lblProgramName.Text = "CONFIG"
        'lblProgramText.Text = "Select Radio COM port...."

        ListBox1.Items.Clear()
        ListBox1.Refresh()

        For Each port In ports
            ListBox1.Items.Add(port)
        Next

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Form1.Show()
        Timer1.Enabled = False
        'Form1.InConfigScreen = False
        Me.Dispose()
        Form1.Refresh()
        Form1.Focus()
        If ListBox1.SelectedIndex > -1 Then
            If Len(Form1.strCOMPORT) > 0 And ListBox1.SelectedItem.ToString <> Form1.strCOMPORT Then
                CloseRadioPort()
            End If
            Form1.strCOMPORT = ListBox1.SelectedItem.ToString
            Form1.Button2_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.SetBBEOn = 0
        Form1.SetEQMode = 0
        Form1.RadioCommand = 11
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.SetBBEOn = 2
        Form1.SetEQMode = 0
        Form1.RadioCommand = 11
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.SetBBEOn = 2
        Form1.SetEQMode = 1
        Form1.RadioCommand = 11
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.SetBBEOn = 2
        Form1.SetEQMode = 2
        Form1.RadioCommand = 11
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.SetBBEOn = 2
        Form1.SetEQMode = 3
        Form1.RadioCommand = 11

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.SetBBEOn = 2
        Form1.SetEQMode = 4
        Form1.RadioCommand = 11

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form1.SetBBEOn = 1
        Form1.RadioCommand = 11
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UpdateEQ()
    End Sub

    Private Sub trkBBELo_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBELo.Scroll

        Form1.RadioCommand = 11
        Form1.SetBBEOn = 1
        Form1.SetBBELo = trkBBELo.Value

    End Sub

    Private Sub trkBBEHi_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBEHi.Scroll
        Form1.RadioCommand = 11
        Form1.SetBBEOn = 1
        Form1.SetBBEHi = trkBBEHi.Value

    End Sub

    Private Sub trkBBECFreq_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBECFreq.Scroll
        Form1.RadioCommand = 11
        Form1.SetBBEOn = 1
        Form1.SetBBECFreq = trkBBECFreq.Value
    End Sub


    Private Sub trkBBEMachFreq_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBEMachFreq.Scroll
        Form1.RadioCommand = 11
        Form1.SetBBEOn = 1
    End Sub

    Private Sub trkBBELo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBELo.ValueChanged
        lblBBELo.Text = trkBBELo.Value / 2 & "db"
    End Sub

    Private Sub trkBBEHi_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBEHi.ValueChanged
        lblBBEHi.Text = trkBBEHi.Value / 2 & "db"

    End Sub

    Private Sub trkBBECFreq_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBECFreq.ValueChanged
        If trkBBECFreq.Value = 0 Then
            lblBBECFreq.Text = "595Hz"
        End If

        If trkBBECFreq.Value = 1 Then
            lblBBECFreq.Text = "1Khz"
        End If
    End Sub

    Private Sub trkBBEMachFreq_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBEMachFreq.ValueChanged
        Select Case trkBBEMachFreq.Value
            Case 0
                Form1.SetBBEMachFreq = 60
                lblMachFreq.Text = "60Hz"
            Case 1
                Form1.SetBBEMachFreq = 90
                lblMachFreq.Text = "90Hz"
            Case 2
                Form1.SetBBEMachFreq = 120
                lblMachFreq.Text = "120Hz"
            Case 3
                Form1.SetBBEMachFreq = 150
                lblMachFreq.Text = "150Hz"
        End Select
    End Sub

    Private Sub trkBBEMachGain_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBEMachGain.Scroll
        Select Case trkBBEMachGain.Value
            Case 0
                Form1.SetBBEMachGain = 0
            Case 1
                Form1.SetBBEMachGain = 4
            Case 2
                Form1.SetBBEMachGain = 8
            Case 3
                Form1.SetBBEMachGain = 12
        End Select

        Form1.RadioCommand = 11
        Form1.SetBBEOn = 1
    End Sub

    Private Sub trkBBEMachQ_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBEMachQ.Scroll
        Form1.RadioCommand = 11
        Form1.SetBBEOn = 1
    End Sub

    Private Sub trkBBEMachQ_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBEMachQ.ValueChanged
        Select Case trkBBEMachQ.Value
            Case 0
                Form1.SetBBEMachQ = 1
                lblBBEMachQ.Text = "1"
            Case 1
                Form1.SetBBEMachQ = 3
                lblBBEMachQ.Text = "3"
        End Select
    End Sub

    Private Sub trkBBESurr_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBESurr.Scroll
        Form1.SetBBESurr = trkBBESurr.Value
        Form1.RadioCommand = 11
        Form1.SetBBEOn = 1
    End Sub

    Private Sub trkBBESurr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBESurr.ValueChanged
        lblBBESurr.Text = trkBBESurr.Value & "db"
    End Sub

    Private Sub trkBBEMp_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBEMp.Scroll
        Form1.SetBBEMp = trkBBEMp.Value
        Form1.SetBBEOn = 1
        Form1.RadioCommand = 11
    End Sub

    Private Sub trkBBEMp_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBEMp.ValueChanged
        lblBBEMp.Text = trkBBEMp.Value & "db"
    End Sub

    Private Sub trkBBEHiMode_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trkBBEHiMode.MouseUp

    End Sub

    Private Sub trkBBEHiMode_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBEHiMode.Scroll
        Form1.SetBBEHiMode = trkBBEHiMode.Value
        Form1.SetBBEOn = 1
        Form1.RadioCommand = 11
    End Sub

    Private Sub trkBBEHiMode_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBEHiMode.ValueChanged
        lblBBEHiMode.Text = trkBBEHiMode.Value & "db"
    End Sub

    Private Sub trkBBEMachGain_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBEMachGain.ValueChanged
        Select Case trkBBEMachGain.Value
            Case 0
                lblBBEMachGain.Text = 0 & "db"
            Case 1
                lblBBEMachGain.Text = 4 & "db"
            Case 2
                lblBBEMachGain.Text = 8 & "db"
            Case 3
                lblBBEMachGain.Text = 12 & "db"
        End Select
    End Sub

    Private Sub trkBBEHpF_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkBBEHpF.Scroll
        Form1.SetBBEHpF = trkBBEHpF.Value
        Form1.SetBBEOn = 1
        Form1.RadioCommand = 11

    End Sub

    Private Sub trkBBEHpF_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkBBEHpF.ValueChanged
        lblBBEHpF.Text = trkBBEHpF.Value
    End Sub

    Private Sub trkHeadroom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkHeadroom.Scroll
        Form1.SetHR = trkHeadroom.Value
        Form1.RadioCommand = 12

    End Sub

    Private Sub trkHeadroom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkHeadroom.ValueChanged
        lblHeadroom.Text = trkHeadroom.Value & "db"
    End Sub
End Class