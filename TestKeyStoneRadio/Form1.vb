Imports System.Threading
Imports System.IO
Imports System.IO.Ports
Imports Microsoft.Win32

Public Class Form1

    Public Const PLAYNEXTSTREAM As SByte = 0
    Public Const PLAYPREVSTREAM As SByte = 1
    Public Const DABMODE As SByte = 2
    Public Const FMMODE As SByte = 3
    Public Const VOLPLUS As SByte = 4
    Public Const VOLMINUS As SByte = 5
    Public Const MUTE As SByte = 6
    Public Const PLAYINDEX As SByte = 7
    Public Const PLAYPRESET As SByte = 8
    Public Const STOREPRESET As SByte = 9
    Public Const TOGGLESTEREO As SByte = 10
    Public Const BBEEQ As Byte = 11
    Public Const HEADRM As Byte = 12
    Public Const SYNCRADIOCLOCK As Byte = 13

    Public Const MOT_HEADER_MODE As SByte = 0
    Public Const MOT_DIRECTORY_MODE As SByte = 1

    Public Const KSApplicationType_SLS = 0
    Public Const KSApplicationType_BWS = 1
    Public Const KSApplicationType_TPEG = 2
    Public Const KSApplicationType_DGPS = 3
    Public Const KSApplicationType_TMC = 4
    Public Const KSApplicationType_EPG = 5
    Public Const KSApplicationType_JAVA = 6     'DAB Java
    Public Const KSApplicationType_DMB = 7
    Public Const KSApplicationType_PUSH = 8     'Push Radio
    Public Const KSApplicationType_UNKNOWN = -1

    Public BBEOn As Byte   ' 0=off, 1=BBE, 2=EQ
    Public EQMode As Byte
    Public BBELo As Byte
    Public BBEHi As Byte
    Public BBECFreq As Byte
    Public BBEMachFreq As Byte
    Public BBEMachGain As Byte
    Public BBEMachQ As Byte
    Public BBESurr As Byte
    Public BBEMp As Byte
    Public BBEHpF As Byte
    Public BBEHiMode As Byte
    Public HeadRoom As SByte

    Public SetBBEOn As Byte   ' 0=off, 1=BBE, 2=EQ
    Public SetEQMode As Byte
    Public SetBBELo As Byte
    Public SetBBEHi As Byte
    Public SetBBECFreq As Byte
    Public SetBBEMachFreq As Byte
    Public SetBBEMachGain As Byte
    Public SetBBEMachQ As Byte
    Public SetBBESurr As Byte
    Public SetBBEMp As Byte
    Public SetBBEHpF As Byte
    Public SetBBEHiMode As Byte
    Public SetHR As SByte           ' Headroom
    Public InConfigScreen As Boolean = False

    Public strCOMPORT As String
    'Public serialPortName As String
    Public RadioCommand As SByte = -1

    Private statRet As Boolean

    Private currentAppType As SByte
    Private trd As Thread
    Private radiomode As SByte
    Private radiostatus As SByte
    Private signalbiterror As Integer
    Private programtype As SByte
    Private programTypeText As String
    Private programTextStatus As SByte
    Private programText As String
    Private programName As String
    Private ensembleName As String
    Private programNameText As String
    Private programRadioText As String

    Private ImageFilename As String

    Private channel As Integer
    Private strength As SByte
    Private volume As SByte

    Private MouseIsDown As Boolean = False
    Private StopThread As Boolean = False
    Private ThreadIsStopped As Boolean = False

    Private NeedEnsemble As Boolean = True
    Private NeedProgramType As Boolean = True
    Private NeedRadioMode As Boolean = True
    Private NeedSyncClock As Boolean = False


    Private DABLastPlayed As Long = 0
    Private FMLastPlayed As Long = 0
    Private FMPreset(10) As Long
    'Private DABPreset(10) As Long
    Private DABPresetName(10) As String
    Private DABList(100) As String     ' watch this DAB list might get more than 100
    Private PresetButtons(10) As Button
    Private totalDABProgram As Integer = 0
    Private firstOpen As Boolean = False
    Private NeedUpdateDABChannels As Boolean = False
    Private NeedUpdatePresets As Boolean = False
    Private ScrollStatic As Boolean = False
    Private LastMode As Integer = -1
    Private ScanDABChannels As Boolean = False
    Private ToNextStream As Boolean = False
    Private ToPrevStream As Boolean = False
    Private FoundNewSlideShow As Boolean = False
    Private DataRate As Int16
    Private intendedVolume As SByte = 0
    Private StereoStatus As SByte = -1
    'Private freqindex() As Double = _
    '{174.928, 176.64, 178.352, 180.064, 181.936, 183.648, 185.36, 187.072, 188.928, 190.64, 192.352, 194.064, 195.936, 197.648, 199.36, 201.072, 202.928, 204.64, 206.352, 208.064, _
    '209.936, 210.096, 211.648, 213.36, 215.072, 216.928, 217.088, 218.64, 220.352, 222.064, 223.936, 224.096, 225.648, 227.36, 229.072, 230.784, 232.496, 234.208, 235.776, 237.488, 239.2, _
    '168.16, 169.872, 171.584, 173.296, 175.008, 176.72, 178.432, 180.144, 181.856, 184.16, 185.872, 187.584, 189.296, 191.008, _
    '192.72, 194.432, 196.144, 197.856, 200.16, 201.872, 203.584, 205.296, 207.008, 208.72, 210.432, 212.144, 213.856, 216.432, 218.144, 219.856, 221.568}
    Private freqindex() As Double = _
    {174.928, 176.64, 178.352, 180.064, 181.936, 183.648, 185.36, 187.072, 188.928, 190.64, 192.352, 194.064, 195.936, 197.648, 199.36, 201.072, 202.928, 204.64, 206.352, 208.064, _
    209.936, 210.096, 211.648, 213.36, 215.072, 216.928, 217.088, 218.64, 220.352, 222.064, 223.936, 224.096, 225.648, 227.36, 229.072, 230.784, 232.496, 234.208, 235.776, 237.488, 239.2, _
    168.16, 169.872, 171.584, 173.296, 175.008, 176.72, 178.432, 180.144, 181.856, 184.16, 185.872, 187.584, 189.296, 191.008, _
    192.72, 194.432, 196.144, 197.856, 200.16, 201.872, 203.584, 205.296, 207.008, 208.72, 210.432, 212.144, 213.856, 216.432, 218.144, 219.856, 221.568, _
    1452.96, 1454.672, 1456.384, 1458.096, 1459.808, 1461.52, 1463.232, 1464.944, 1466.656, 1468.368, 1470.08, 1471.792, 1473.504, 1475.216, 1476.928, 1478.64, 1480.352, 1482.064, 1483.776, 1485.488, 1487.2, 1488.912, 1490.624}



    Private RadioCommandData As SByte = 0

    Private strDebug As String

    Private Sub ThreadTask()

        Dim presettemp As Integer
        Dim freq As SByte
        Dim presetchannel As Long
        'Dim doublefreq As Double
        Dim ServiceComponentID As Byte
        Dim ServiceID As UInt32
        Dim EnsembleID As UInt16
        Dim sec, min, hour, day, month, year As Byte

        Do
            If StopThread Then
                Try
                    ThreadIsStopped = True
                    Thread.Sleep(Timeout.Infinite)
                Catch ex As ThreadInterruptedException

                End Try
            End If

            ThreadIsStopped = False
            StopThread = False

            If (RadioCommand <> 11 Or RadioCommand <> 12) And InConfigScreen Then
                GetBBEEQ(BBEOn, EQMode, BBELo, BBEHi, BBECFreq, BBEMachFreq, BBEMachGain, BBEMachQ, BBESurr, BBEMp, BBEHpF, BBEHiMode)
                HeadRoom = 0 - GetHeadroom() ' Headroom is negative db
            End If

            If RadioCommand > -1 Then
                Select Case RadioCommand
                    Case 0
                        ImageFilename = ""
                        NeedEnsemble = True
                        NeedProgramType = True
                        DataRate = 0
                        currentAppType = KSApplicationType_UNKNOWN
                        NextStream()
                    Case 1
                        ImageFilename = ""
                        NeedEnsemble = True
                        NeedProgramType = True
                        DataRate = 0
                        currentAppType = KSApplicationType_UNKNOWN
                        PrevStream()
                    Case 2
                        ImageFilename = ""
                        NeedEnsemble = True
                        NeedRadioMode = True
                        NeedProgramType = True
                        DataRate = 0
                        currentAppType = KSApplicationType_UNKNOWN
                        Timer3.Enabled = True
                        PlayStream(0, DABLastPlayed)
                    Case 3
                        ImageFilename = ""
                        NeedEnsemble = True
                        NeedRadioMode = True
                        NeedProgramType = True
                        DataRate = 0
                        currentAppType = KSApplicationType_UNKNOWN
                        If FMLastPlayed = 0 Then
                            PlayStream(1, 94500)
                        Else
                            PlayStream(1, FMLastPlayed)
                        End If
                    Case 4
                        intendedVolume = intendedVolume + 1
                    Case 5
                        intendedVolume = intendedVolume - 1
                    Case 6
                        VolumeMute()
                        volume = GetVolume
                        intendedVolume = volume
                    Case 7
                        ImageFilename = ""
                        NeedEnsemble = True
                        NeedProgramType = True
                        NeedRadioMode = True
                        DataRate = 0
                        currentAppType = KSApplicationType_UNKNOWN
                        PlayStream(0, RadioCommandData)
                    Case 8
                        ImageFilename = ""
                        NeedEnsemble = True
                        NeedRadioMode = True
                        NeedProgramType = True
                        DataRate = 0
                        currentAppType = KSApplicationType_UNKNOWN
                        presetchannel = GetPreset(radiomode, RadioCommandData)
                        PlayStream(radiomode, presetchannel)
                    Case 9
                        SetPreset(radiomode, RadioCommandData, channel)
                    Case 10
                        If GetStereoMode() = 0 Then
                            SetStereoMode(1)
                        Else
                            SetStereoMode(0)
                        End If
                    Case 11
                        If SetBBEOn = 2 Then        ' This is EQ Mode, Bass Boost, Jazz, Live, Vocal, Acoustic
                            statRet = SetBBEEQ(SetBBEOn, SetEQMode, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                        ElseIf SetBBEOn = 1 Then    ' This is BBE Mode
                            If SetBBEMachQ = 0 Then SetBBEMachQ = 1 ' When setting MachQ must be only 1 or 3, 0 will cause weird behavior
                            If SetBBEMachFreq = 0 Then SetBBEMachFreq = &H3C ' Need to be more than &h3C or else it will cause weird behavior

                            statRet = SetBBEEQ(SetBBEOn, 0, SetBBELo, SetBBEHi, SetBBECFreq, SetBBEMachFreq, SetBBEMachGain, SetBBEMachQ, SetBBESurr, SetBBEMp, SetBBEHpF, SetBBEHiMode)
                            BBEOn = SetBBEOn
                            EQMode = SetEQMode
                            BBELo = SetBBELo
                            BBEHi = SetBBEHi
                            BBECFreq = SetBBECFreq
                            BBEMachFreq = SetBBEMachFreq
                            BBEMachGain = SetBBEMachGain
                            BBEMachQ = SetBBEMachQ
                            BBESurr = SetBBESurr
                            BBEMp = SetBBEMp
                            BBEHpF = SetBBEHpF
                            BBEHiMode = SetBBEHiMode
                        Else    ' Both EQ and BBE OFF
                            statRet = SetBBEEQ(0, 0, SetBBELo, SetBBEHi, SetBBECFreq, SetBBEMachFreq, SetBBEMachGain, SetBBEMachQ, SetBBESurr, SetBBEMp, SetBBEHpF, SetBBEHiMode)
                            'statRet = SetBBEEQ(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                        End If
                    Case 12
                        SetHeadroom(Math.Abs(SetHR))
                        HeadRoom = SetHR
                    Case 13
                        SyncRTC(True)
                        NeedSyncClock = True
                End Select

                RadioCommand = -1
            End If

            If ScanDABChannels = True Then
                ImageFilename = ""
                NeedEnsemble = True
                channel = -1
                NeedRadioMode = True
                NeedProgramType = True
                DataRate = 0
                currentAppType = KSApplicationType_UNKNOWN

                programNameText = "Please Wait"
                programRadioText = "Searching DAB channels..."
                ScrollStatic = True

                If DABAutoSearch(0, 40) = True Then
                    programNameText = "Please Wait"
                    programRadioText = "Searching DAB channels..."
                    programtype = 0
                    'ScrollStatic = True

                    radiostatus = GetPlayStatus
                    While radiostatus = 1
                        'Thread.Sleep(50)
                        radiostatus = GetPlayStatus
                        If radiostatus = 1 Then
                            freq = GetFrequency()
#If DEBUG Then
                            Debug.Print("Freq=" & freq)
#End If
                            If freq > -1 Then
                                programRadioText = "Searching DAB " & freqindex(freq).ToString & "Mhz"
                            End If
                        End If
                        totalDABProgram = GetTotalProgram
                        'Debug.Print(totalDABProgram)

                    End While

                    ScanDABChannels = False
                    ScrollStatic = False
                    programRadioText = ""

                    If totalDABProgram > 0 Then
                        SetVolume(5)
                        volume = GetVolume()
                        SetStereoMode(1) ' after a DABAutoSearch() the radio will be defaulted to Mono, so set it back to stereo
                        intendedVolume = volume
                        PlayStream(0, 0)
                        firstOpen = True
                    Else
                        programNameText = "No Channel!"
                    End If

                End If
            End If

            strength = GetSignalStrength(signalbiterror)
            StereoStatus = GetStereo()
            channel = GetPlayIndex()
            radiomode = GetPlayMode()
            programtype = GetProgramType(radiomode, channel)
            radiostatus = GetPlayStatus()

            If NeedSyncClock Then
                If GetRTC(sec, min, hour, day, month, year) Then

                    SyncRTC(False)
                    NeedSyncClock = False
                    Debug.Print(hour & ":" & min & ":" & sec & "   " & day & "/" & month & "/" & year)
                End If
            End If

            If firstOpen Then
                ' Get the status of BBE
                GetBBEEQ(BBEOn, EQMode, BBELo, BBEHi, BBECFreq, BBEMachFreq, BBEMachGain, BBEMachQ, BBESurr, BBEMp, BBEHpF, BBEHiMode)

                If radiostatus = 3 Then
                    volume = GetVolume
                    intendedVolume = volume

                    If volume = 0 Then
                        SetVolume(5)
                        volume = GetVolume()
                    End If

                    If LastMode = 0 Then
                        PlayStream(0, DABLastPlayed)
                    Else

                        If FMLastPlayed > 0 Then
                            PlayStream(1, FMLastPlayed)
                        Else
                            PlayStream(1, 94500)
                        End If

                    End If
                    radiostatus = GetPlayStatus
                End If
            End If

            If radiomode <> -1 And channel <> -1 Then
                If radiomode = 0 Then
                    DABLastPlayed = channel
                Else
                    If channel < 10900 Or channel > 0 Then
                        FMLastPlayed = channel
                    End If

                End If

            End If

            programName = Space(400)

            If GetProgramName(radiomode, channel, 1, programName) = True Then
                programNameText = Trim(programName)
            Else
                If radiomode = 1 Then
                    programNameText = channel / 1000 & "Mhz"
                Else
                    programName = ""
                End If
            End If

            If radiomode = 0 Then
                If NeedEnsemble Then
                    programName = Space(400)
                    If GetEnsembleName(channel, 0, programName) = True Then
                        ensembleName = Trim(programName)
                        NeedEnsemble = False
                    Else
                        ensembleName = ""
                    End If
                End If

#If DEBUG Then
                If NeedProgramType Then
                    Debug.Print("Service Comp Type=" & (GetServCompType(channel)))
                    NeedProgramType = False
                End If
#End If


                If DataRate < 1 Then
                    DataRate = GetDataRate()
#If DEBUG Then
                    Debug.Print("Datarate=" & DataRate)
#End If
                    If DataRate < 0 Then DataRate = 0
                End If
            Else
                ensembleName = ""
                NeedEnsemble = True
                DataRate = 0
            End If

            If firstOpen Then
                For i = 0 To 9
                    presettemp = GetPreset(1, i)
                    If presettemp > 0 Then
                        FMPreset(i) = presettemp
                    End If
                Next

                For i = 0 To 9
                    presettemp = GetPreset(0, i)
                    If presettemp > -1 Then
                        programName = Space(400)
                        If GetProgramName(0, presettemp, 0, programName) = True Then
#If DEBUG Then
                            Debug.Print(Trim(programName))
#End If
                            DABPresetName(i) = Trim(programName)
                        End If
                    End If
                Next

                NeedUpdatePresets = True
#If DEBUG Then
                Debug.Print("Radio Mode=" & radiomode)
#End If
                If radiomode = 0 Then
                    programName = Space(400)
                    If GetEnsembleName(channel, 0, programName) = True Then
                        ensembleName = Trim(programName)
                    Else
                        ensembleName = ""
                    End If

                    DataRate = GetDataRate()
                    If DataRate < 0 Then DataRate = 0

                Else
                    ensembleName = ""
                    DataRate = 0
                End If

                radiomode = GetPlayMode()
                radiostatus = GetPlayStatus()

                totalDABProgram = GetTotalProgram()

                If totalDABProgram > 0 Then
                    If ListBox1.Items.Count = 0 Then
                        programRadioText = "Reading channels..."
                        ScrollStatic = True
                        'Debug.Print(Now.Millisecond.ToString)

                        Dim objWriter As New System.IO.StreamWriter("stations.txt")
                        objWriter.WriteLine("ServiceComponentID, ServiceID, EnsembleID, StationName")
                        For i = 0 To totalDABProgram - 1
                            programName = Space(400)
                            If GetProgramName(0, i, 1, programName) = True Then
                                DABList(i) = Trim(programName)

                                If GetProgramInfo(i, ServiceComponentID, ServiceID, EnsembleID) Then
                                    objWriter.WriteLine(Hex(ServiceComponentID) & "," & Hex(ServiceID) & "," & Hex(EnsembleID) & "," & DABList(i))
                                Else
                                    objWriter.WriteLine("x,x,x," & DABList(i))
                                End If

                            End If
                        Next

                        objWriter.Close()

                        'Debug.Print(Now.Millisecond.ToString)


                        NeedUpdateDABChannels = True
                        programRadioText = ""
                        ScrollStatic = False
                    End If

                End If

                volume = GetVolume()
                intendedVolume = volume
                firstOpen = False
            Else
                programText = Space(400)
                programTextStatus = GetProgramText(programText)

                If programTextStatus = 0 Then
                    programRadioText = Trim(programText)
                    'Debug.Print(programRadioText)

                End If

                If programTextStatus = -1 Then
                    programRadioText = ""
                End If
            End If

            'volume = GetVolume()

            If intendedVolume <> volume Then
                If Not SetVolume(intendedVolume) Then
                    intendedVolume = volume
                Else
                    volume = intendedVolume
                End If

            End If

            If radiomode = 0 Then
                If (currentAppType = KSApplicationType_SLS) Then
                    If (MotQuery) Then
                        programText = Space(400)
                        GetImage(programText)
                        ImageFilename = Trim(programText)
                        FoundNewSlideShow = True
#If DEBUG Then
                        strDebug = Now.ToLongTimeString()
                        strDebug = strDebug & " " & ImageFilename & " -- " & programNameText
                        Debug.Print(strDebug)
#End If
                    End If
                ElseIf (currentAppType = KSApplicationType_EPG) Then
                    'EPG Support in the future


                Else
                    currentAppType = GetApplicationType(channel)
                    If (currentAppType = KSApplicationType_SLS) Then
                        MotReset(MOT_HEADER_MODE)
                    ElseIf (currentAppType = KSApplicationType_EPG) Then
                        MotReset(MOT_DIRECTORY_MODE)
                    End If
                End If

            End If

            If radiomode = 0 Then
                Thread.Sleep(3)
            Else
                Thread.Sleep(100)
            End If
        Loop
    End Sub

    Private Sub StatusUpdate()

        lblProgramName.Text = programNameText
        lblProgramText.Text = programRadioText
        'txtBottom.Text = programRadioText
        lblEnsemble.Text = ensembleName

        If radiostatus = 0 Then
            If DataRate > 0 Then
                lblDataRate.Text = DataRate & "kbps"
            Else
                lblDataRate.Text = ""
            End If


        Else
            lblDataRate.Text = ""
        End If

        If totalDABProgram > -1 Then
            lblDABChannels.Text = totalDABProgram
        End If


        Select Case currentAppType
            Case KSApplicationType_SLS
                lblSLS.Text = "SLS"
            Case KSApplicationType_BWS
                lblSLS.Text = "BWS"
            Case KSApplicationType_TPEG
                lblSLS.Text = "TPEG"
            Case KSApplicationType_DGPS
                lblSLS.Text = "DGPS"
            Case KSApplicationType_TMC
                lblSLS.Text = "TMC"
            Case KSApplicationType_EPG
                lblSLS.Text = "EPG"
            Case KSApplicationType_JAVA
                lblSLS.Text = "JAVA"
            Case KSApplicationType_DMB
                lblSLS.Text = "DMB"
            Case KSApplicationType_PUSH     'Push Radio
                lblSLS.Text = "PUSH"
            Case Else
                lblSLS.Text = ""
        End Select

        '        If currentAppType = KSApplicationType_SLS Then
        'lblSLS.Text = "SLS"
        'ElseIf currentAppType = KSApplicationType_EPG Then
        'lblSLS.Text = "EPG"
        'Else
        'lblSLS.Text = currentAppType.ToString
        'End If

        Select Case radiomode
            Case 0
                lblMode.Text = "DAB"
                LastMode = 0
            Case 1
                lblMode.Text = "FM"
                LastMode = 1
            Case 3
                lblMode.Text = ""
            Case 4
                lblMode.Text = ""
            Case Else
                lblMode.Text = "N/A"
        End Select

        Select Case radiostatus
            Case 0
                lblStatus.Text = "Playing"
            Case 1
                lblStatus.Text = "Searching"
            Case 2
                lblStatus.Text = "Tunning"
            Case 3
                lblStatus.Text = "Stop"
            Case 4
                lblStatus.Text = "Sorting"
            Case 5
                lblStatus.Text = "Reconfiguration"
            Case Else
                lblStatus.Text = "N/A"

        End Select

        Select Case programtype
            Case 0
                programTypeText = ""
            Case 1
                programTypeText = "News"
            Case 2
                programTypeText = "Current Affairs"
            Case 3
                programTypeText = "Information"
            Case 4
                programTypeText = "Sport"
            Case 5
                programTypeText = "Education"
            Case 6
                programTypeText = "Drama"
            Case 7
                programTypeText = "Arts"
            Case 8
                programTypeText = "Science"
            Case 9
                programTypeText = "Talk"
            Case 10
                programTypeText = "Pop Music"
            Case 11
                programTypeText = "Rock Music"
            Case 12
                programTypeText = "Easy Listening"
            Case 13
                programTypeText = "Light Classical"
            Case 14
                programTypeText = "Classical Music"
            Case 15
                programTypeText = "Other Music"
            Case 16
                programTypeText = "Weather"
            Case 17
                programTypeText = "Finance"
            Case 18
                programTypeText = "Children"
            Case 19
                programTypeText = "Factual"
            Case 20
                programTypeText = "Religion"
            Case 21
                programTypeText = "Phone In"
            Case 22
                programTypeText = "Travel"
            Case 23
                programTypeText = "Leisure"
            Case 24
                programTypeText = "Jazz and Blues"
            Case 25
                programTypeText = "Country Music"
            Case 26
                programTypeText = "National Music"
            Case 27
                programTypeText = "Oldies Music"
            Case 28
                programTypeText = "Folk Music"
            Case 29
                programTypeText = "Documentary"
            Case 30
                programTypeText = "Undefined"
            Case 31
                programTypeText = "Undefined"
            Case Else
                programTypeText = ""
        End Select

        lblProgramType.Text = programTypeText
        If strength > -1 Then
            lblSignal.Text = strength & "%"
        End If

        If (volume > -1) And (volume < 17) Then
            Dim volimage As Image
            Dim imagename As String

            imagename = "..\..\images\vol" & volume & ".png"
            If Not File.Exists(imagename) Then
                imagename = "..\..\images\vol" & volume - 1 & ".png"
            End If
            volimage = Image.FromFile(imagename)
            imgVolume.Image = volimage
        End If

        If StereoStatus > -1 Then
            Dim stereoimg As Image
            If StereoStatus = 0 Or StereoStatus = 1 Or StereoStatus = 2 Then
                stereoimg = Image.FromFile("..\..\images\stereo.png")
            Else
                stereoimg = Image.FromFile("..\..\images\mono.png")
            End If
            imgStereo.Image = stereoimg
        End If

        If FoundNewSlideShow Then
            If ImageFilename <> "" Then
                Try
                    ImageFilename = Path.GetFullPath(ImageFilename)
                    PictureBox1.Load(ImageFilename)
                    PictureBox1.Visible = True
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                End Try
                FoundNewSlideShow = False

            End If
        End If

        If ImageFilename = "" Then
            PictureBox1.Visible = False
        End If

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Microsoft.Win32.SystemEvents.PowerModeChanged, AddressOf SystemEvents_PowerModeChanged

        PresetButtons(0) = btnPreset0
        PresetButtons(1) = btnPreset1
        PresetButtons(2) = btnPreset2
        PresetButtons(3) = btnPreset3
        PresetButtons(4) = btnPreset4
        PresetButtons(5) = btnPreset5
        PresetButtons(6) = btnPreset6
        PresetButtons(7) = btnPreset7
        PresetButtons(8) = btnPreset8
        PresetButtons(9) = btnPreset9

        BBEOn = 0
        EQMode = 0
        BBEMachQ = 3
        HeadRoom = 0
        ImageFilename = ""
        NeedEnsemble = True
        channel = -1
        NeedRadioMode = True
        NeedProgramType = True
        DataRate = 0
        currentAppType = KSApplicationType_UNKNOWN
        lblMode.Text = ""
        lblStatus.Text = ""
        lblProgramName.Text = "6th Logic DAB+"
        lblProgramText.Text = "Radio off...."
        lblSignal.Text = strength & "%"
        trd = New Thread(AddressOf ThreadTask)
        trd.IsBackground = True
        StopThread = True
        trd.Start()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As Int32
        result = CommVersion()
        MsgBox(result)
    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Timer1.Enabled = False

        lblProgramName.Text = "RADIO Power"
        lblProgramText.Text = "Turning on radio..."
        lblProgramText.Left = lblProgramName.Left
        lblProgramText.Refresh()
        lblProgramName.Refresh()

        'strCOMPORT 

        StopThread = True
        While Not ThreadIsStopped
            System.Threading.Thread.Sleep(100)
        End While

        If (OpenRadioPort("\\.\" & strCOMPORT, True) = True) Then
            SetStereoMode(1)
            'btnSetting.Enabled = False
            trd.Interrupt()
            firstOpen = True
            Timer1.Enabled = True
            Timer2.Enabled = True
        Else
            CloseRadioPort()
            lblProgramText.Text = "Please select radio COM port...."
            'Button3_Click_1(sender, New System.EventArgs())
            frmConfig.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Enabled = False
        MsgBox(HardResetRadio())
        Timer1.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Enabled = False

        'For i = 1 To 10
        If StopStream() = True Then
            '    Exit For
        End If
        'Next

        lblProgramName.Text = "6th Logic DAB+"
        lblProgramText.Text = "Radio off...."
        lblMode.Text = ""
        lblStatus.Text = ""
        lblProgramType.Text = ""
        btnSetting.Enabled = True
        StopThread = True
        CloseRadioPort()
    End Sub
    Private Sub UpdateDABPresetButtons()
        Dim i As SByte

        For i = 0 To 9
            If DABPresetName(i) <> "" Then
                PresetButtons(i).Text = DABPresetName(i)
            Else
                PresetButtons(i).Text = ""
            End If
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        '        Timer3.Enabled = True
        '        PlayStream(0, DABLastPlayed)
        UpdateDABPresetButtons()
        RadioCommand = DABMODE

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        '        intendedVolume = intendedVolume + 1
        RadioCommand = VOLPLUS
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ' Dim volume As SByte
        'intendedVolume = intendedVolume - 1

        RadioCommand = VOLMINUS
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'NextStream()
        'ToNextStream = True
        RadioCommand = PLAYNEXTSTREAM

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'PrevStream()
        'ToPrevStream = True
        RadioCommand = PLAYPREVSTREAM

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(IsSysReady())
    End Sub

    Private Sub UpdateFMPresetButtons()
        Dim temp As Int32
        Dim i As SByte

        For i = 0 To 9
            temp = FMPreset(i)
            If temp > 0 Then
                PresetButtons(i).Text = (temp / 1000).ToString
            Else
                PresetButtons(i).Text = ""
            End If
        Next

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'If GetVolume() = 0 Then SetVolume(8)

        '        If FMLastPlayed = 0 Then
        'PlayStream(1, 94500)
        'Else
        'PlayStream(1, FMLastPlayed)
        'End If
        RadioCommand = FMMODE
        UpdateFMPresetButtons()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusUpdate()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If lblProgramName.Text = "CONFIG" Then
            strCOMPORT = ListBox1.SelectedItem.ToString
            ListBox1.Items.Clear()
            ListBox1.Refresh()
            Button2_Click(sender, New System.EventArgs())

        Else
            RadioCommandData = ListBox1.SelectedIndex
            RadioCommand = PLAYINDEX
            UpdateDABPresetButtons()
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ScrollStatic = True Then
            lblProgramText.Left = lblProgramName.Left
            Exit Sub
        Else
            lblProgramText.Left = lblProgramText.Left - 2
            If lblProgramText.Left < (0 - lblProgramText.Width) Then lblProgramText.Left = Panel1.Width

        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Need to bring this function to thread to avoid serial port race
        '        VolumeMute()
        '       volume = GetVolume
        '      intendedVolume = volume
        RadioCommand = MUTE

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        frmConfig.ShowDialog()

    End Sub

    Private Sub lblProgramName_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblProgramName.MouseDown
        MouseIsDown = True
    End Sub

    Private Sub lblProgramName_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblProgramName.MouseMove
        If MouseIsDown Then
            lblProgramName.DoDragDrop(lblProgramName.Text, DragDropEffects.Copy)
        End If
        MouseIsDown = False
    End Sub

    Private Sub btnPreset0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset0.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset0_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset0.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
#If DEBUG Then
                    Debug.Print(sender.text)
#End If
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If
    End Sub

    Private Sub btnPreset0_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset0.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub btnPreset1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset1.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset2.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset3.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset4.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset5.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset6.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset7.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset8.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset9.Click
        Dim presetindex As SByte

        presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        RadioCommandData = presetindex
        RadioCommand = PLAYPRESET

    End Sub

    Private Sub btnPreset1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset1.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If

    End Sub

    Private Sub btnPreset2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset2.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If


    End Sub

    Private Sub btnPreset3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset3.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If

    End Sub

    Private Sub btnPreset4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset4.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If

    End Sub

    Private Sub btnPreset5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset5.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If

    End Sub

    Private Sub btnPreset6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset6.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If


    End Sub

    Private Sub btnPreset7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset7.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If


    End Sub

    Private Sub btnPreset8_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset8.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If

    End Sub

    Private Sub btnPreset9_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset9.DragDrop
        Dim shortName As String = ""
        Dim presetindex As SByte

        If Len(e.Data.GetData(DataFormats.Text)) > 0 Then
            If radiostatus = 0 Then
                presetindex = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
                RadioCommandData = presetindex
                RadioCommand = STOREPRESET
                If radiomode = 0 Then
                    sender.text = lblProgramName.Text
                    DABPresetName(presetindex) = lblProgramName.Text
                Else
                    sender.text = (channel / 1000).ToString
                    FMPreset(presetindex) = channel
                End If
            End If
        End If

    End Sub

    Private Sub btnPreset1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset1.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub btnPreset2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset2.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub btnPreset3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset3.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub btnPreset4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset4.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub btnPreset5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset5.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub btnPreset6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset6.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub btnPreset7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset7.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub
    Private Sub btnPreset8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset8.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub btnPreset9_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles btnPreset9.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim i As SByte


        If NeedUpdatePresets = True Then
            If radiomode = 0 Then
                UpdateDABPresetButtons()
                NeedUpdatePresets = False
            ElseIf radiomode = 1 Then
                UpdateFMPresetButtons()
                NeedUpdatePresets = False
            End If

        End If

        If NeedUpdateDABChannels = True Then
            If totalDABProgram > 0 Then
                ListBox1.Items.Clear()
                For i = 0 To totalDABProgram - 1
                    If DABList(i) IsNot Nothing Then
                        ListBox1.Items.Add(DABList(i))
                        'Debug.Print(DABList(i))
                        ListBox1.TopIndex = ListBox1.Items.Count - 1
                        'ListBox1.Refresh()
                    End If
                Next
                NeedUpdateDABChannels = False
            End If
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub


    Private Sub Label2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.DoubleClick
        ListBox1.Items.Clear()
        ScanDABChannels = True
    End Sub

    Private Sub imgStereo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgStereo.Click
        RadioCommand = TOGGLESTEREO
    End Sub


    Private Sub SystemEvents_PowerModeChanged(ByVal sender As Object, ByVal e As PowerModeChangedEventArgs)

        Select Case e.Mode
            Case PowerModes.Resume
#If DEBUG Then
                Console.WriteLine("Resume")
#End If
                OpenRadioPort("\\.\" & strCOMPORT, True)
                SetStereoMode(1)
                SetVolume(volume)
                If radiostatus = 0 Then
                    If LastMode = 0 Then
                        PlayStream(LastMode, DABLastPlayed)
                    Else
                        PlayStream(LastMode, FMLastPlayed)
                    End If
                End If

                trd.Interrupt()
            Case PowerModes.StatusChange
#If DEBUG Then
                Console.WriteLine("StatusChange")
#End If
            Case PowerModes.Suspend
#If DEBUG Then
                Console.WriteLine("Suspend")
#End If
                StopThread = True
                While Not ThreadIsStopped
                    System.Threading.Thread.Sleep(100)
                End While
                programNameText = "Radio Suspending..."
                StopStream()
#If DEBUG Then
                Console.WriteLine("THREAD stopped.")
#End If


        End Select

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ImageFilename = ""
    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RadioCommand = SYNCRADIOCLOCK
    End Sub
End Class