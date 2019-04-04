Imports System.IO.Ports

Public Class frmConfig

    Private Sub UpdateEQ()
        If Form1.RadioCommand = 11 Or Form1.RadioCommand = 12 Then Exit Sub

        Button1.BackColor = Color.Gray
        Button3.BackColor = Color.Gray
        Button4.BackColor = Color.Gray
        Button5.BackColor = Color.Gray
        Button6.BackColor = Color.Gray

        Select Case Form1.BBEOn
            Case 0
                Button2.BackColor = Color.Red
            Case 1
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

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.SetBBEOn = 1
        Form1.RadioCommand = 11
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UpdateEQ()
    End Sub

    Private Sub trkHeadroom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkHeadroom.Scroll
        Form1.SetHR = trkHeadroom.Value
        Form1.RadioCommand = 12

    End Sub

    Private Sub trkHeadroom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkHeadroom.ValueChanged
        lblHeadroom.Text = trkHeadroom.Value & "db"
    End Sub
End Class