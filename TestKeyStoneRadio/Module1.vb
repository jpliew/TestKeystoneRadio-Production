Module Module1

    Structure SYSTEMTIME
        Public Year As Short
        Public Month As Short
        Public DayOfWeek As Short
        Public Day As Short
        Public Hour As Short
        Public Minute As Short
        Public Second As Short
        Public Milliseconds As Short
    End Structure

    Declare Function SetLocalTime Lib "kernel32.dll" (ByRef lpSystemTime As SYSTEMTIME) As Boolean

#If DEBUG Then
    ' Point the DLL to the KeyStoneCOMM DLL Debug folder if you wish to debug both DLL and VB app at the same time.
    Declare Function CommVersion Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Int32
    Declare Function OpenRadioPort Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal port As String, ByVal usehardmute As Boolean) As Boolean
    Declare Function HardResetRadio Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function CloseRadioPort Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function PlayStream Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal channel As Int32) As Boolean
    Declare Function StopStream Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function SetVolume Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal volume As SByte) As Boolean
    Declare Function IsSysReady Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function VolumePlus Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function VolumeMinus Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Sub VolumeMute Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" ()
    Declare Function GetVolume Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function GetPlayMode Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function GetPlayStatus Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function GetTotalProgram Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Int32
    Declare Function NextStream Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function PrevStream Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function GetPlayIndex Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Int32
    Declare Function GetSignalStrength Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByRef biterror As Integer) As SByte
    Declare Function GetProgramType Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal dabIndex As Int32) As SByte
    Declare Unicode Function GetProgramText Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal programText As String) As SByte
    Declare Unicode Function GetProgramName Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal dabIndex As Int32, ByVal namemode As SByte, ByVal programName As String) As Boolean
    Declare Unicode Function GetPreset Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal presetindex As SByte) As Int32
    Declare Unicode Function SetPreset Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal presetindex As SByte, ByVal channel As Int32) As Boolean
    Declare Function DABAutoSearch Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal startindex As Byte, ByVal endindex As Byte) As Boolean
    Declare Function DABAutoSearchNoClear Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal startindex As Byte, ByVal endindex As Byte) As Boolean
    Declare Unicode Function GetEnsembleName Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal dabIndex As Int32, ByVal namemode As SByte, ByVal programName As String) As Boolean
    Declare Function GetDataRate Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Int16
    Declare Function SetStereoMode Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal mode As SByte) As Boolean
    Declare Function GetFrequency Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function GetStereoMode Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function GetStereo Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function ClearDatabase Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function SetBBEEQ Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal BBEOn As Byte, ByVal EQMode As Byte, ByVal BBELo As Byte, ByVal BBEHi As Byte, ByVal BBECFreq As Byte, ByVal BBEMachFreq As Byte, ByVal BBEMachGain As Byte, ByVal BBEMachQ As Byte, ByVal BBESurr As Byte, ByVal BBEMp As Byte, ByVal BBEHpF As Byte, ByVal BBEHiMode As Byte) As Boolean
    Declare Function GetBBEEQ Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByRef BBEOn As Byte, ByRef EQMode As Byte, ByRef BBELo As Byte, ByRef BBEHi As Byte, ByRef BBECFreq As Byte, ByRef BBEMachFreq As Byte, ByRef BBEMachGain As Byte, ByRef BBEMachQ As Byte, ByRef BBESurr As Byte, ByRef BBEMp As Byte, ByRef BBEHpF As Byte, ByRef BBEHiMode As Byte) As Boolean
    Declare Function SetHeadroom Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal headroom As SByte) As Boolean
    Declare Function GetHeadroom Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    'Declare Function MotQuery Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Unicode Sub GetImage Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal ImageFileName As String)
    Declare Function GetApplicationType Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal index As Int32) As Int16
    Declare Function GetApplicationData Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Boolean
    Declare Function SetApplicationType Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal index As UInt16) As Int16
    'Declare Sub MotReset Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal mode As SByte)
    Declare Function GetDABSignalQuality Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As SByte
    Declare Function GetProgramInfo Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal dabIndex As UInt32, ByRef ServiceComponentID As Byte, ByRef ServiceID As UInt32, ByRef EnsembleID As UInt16) As Boolean
    Declare Function GetServCompType Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal index As Int32) As SByte
    Declare Function SyncRTC Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByVal sync As Boolean) As Boolean
    Declare Function GetRTC Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" (ByRef sec As Byte, ByRef min As Byte, ByRef hour As Byte, ByRef day As Byte, ByRef month As Byte, ByRef year As Byte) As Boolean
    Declare Function GetSamplingRate Lib "C:\Users\JP\source\repos\keystonecomm\Debug\keystonecomm.dll" () As Int16

#Else
    Declare Function CommVersion Lib "keystonecomm.dll" () As Int32
    Declare Function OpenRadioPort Lib "keystonecomm.dll" (ByVal port As String, ByVal usehardmute As Boolean) As Boolean
    Declare Function HardResetRadio Lib "keystonecomm.dll" () As Boolean
    Declare Function CloseRadioPort Lib "keystonecomm.dll" () As Boolean
    Declare Function PlayStream Lib "keystonecomm.dll" (ByVal mode As SByte, ByVal channel As Int32) As Boolean
    Declare Function StopStream Lib "keystonecomm.dll" () As Boolean
    Declare Function SetVolume Lib "keystonecomm.dll" (ByVal volume As SByte) As Boolean
    Declare Function IsSysReady Lib "keystonecomm.dll" () As Boolean
    Declare Function VolumePlus Lib "keystonecomm.dll" () As SByte
    Declare Function VolumeMinus Lib "keystonecomm.dll" () As SByte
    Declare Sub VolumeMute Lib "keystonecomm.dll" ()
    Declare Function GetVolume Lib "keystonecomm.dll" () As SByte
    Declare Function GetPlayMode Lib "keystonecomm.dll" () As SByte
    Declare Function GetPlayStatus Lib "keystonecomm.dll" () As SByte
    Declare Function GetTotalProgram Lib "keystonecomm.dll" () As Int32
    Declare Function NextStream Lib "keystonecomm.dll" () As Boolean
    Declare Function PrevStream Lib "keystonecomm.dll" () As Boolean
    Declare Function GetPlayIndex Lib "keystonecomm.dll" () As Int32
    Declare Function GetSignalStrength Lib "keystonecomm.dll" (ByRef biterror As Integer) As SByte
    Declare Function GetProgramType Lib "keystonecomm.dll" (ByVal mode As SByte, ByVal dabIndex As Int32) As SByte
    Declare Unicode Function GetProgramText Lib "keystonecomm.dll" (ByVal programText As String) As SByte
    Declare Unicode Function GetProgramName Lib "keystonecomm.dll" (ByVal mode As SByte, ByVal dabIndex As Int32, ByVal namemode As SByte, ByVal programName As String) As Boolean
    Declare Unicode Function GetPreset Lib "keystonecomm.dll" (ByVal mode As SByte, ByVal presetindex As SByte) As Int32
    Declare Unicode Function SetPreset Lib "keystonecomm.dll" (ByVal mode As SByte, ByVal presetindex As SByte, ByVal channel As Int32) As Boolean
    Declare Function DABAutoSearch Lib "keystonecomm.dll" (ByVal startindex As Byte, ByVal endindex As Byte) As Boolean
    Declare Function DABAutoSearchNoClear Lib "keystonecomm.dll" (ByVal startindex As Byte, ByVal endindex As Byte) As Boolean
    Declare Unicode Function GetEnsembleName Lib "keystonecomm.dll" (ByVal dabIndex As Int32, ByVal namemode As SByte, ByVal programName As String) As Boolean
    Declare Function GetDataRate Lib "keystonecomm.dll" () As Int16
    Declare Function SetStereoMode Lib "keystonecomm.dll" (ByVal mode As SByte) As Boolean
    Declare Function GetFrequency Lib "keystonecomm.dll" () As SByte
    Declare Function GetStereoMode Lib "keystonecomm.dll" () As SByte
    Declare Function GetStereo Lib "keystonecomm.dll" () As SByte
    Declare Function ClearDatabase Lib "keystonecomm.dll" () As Boolean
    Declare Function SetBBEEQ Lib "keystonecomm.dll" (ByVal BBEOn As Byte, ByVal EQMode As Byte, ByVal BBELo As Byte, ByVal BBEHi As Byte, ByVal BBECFreq As Byte, ByVal BBEMachFreq As Byte, ByVal BBEMachGain As Byte, ByVal BBEMachQ As Byte, ByVal BBESurr As Byte, ByVal BBEMp As Byte, ByVal BBEHpF As Byte, ByVal BBEHiMode As Byte) As Boolean
    Declare Function GetBBEEQ Lib "keystonecomm.dll" (ByRef BBEOn As Byte, ByRef EQMode As Byte, ByRef BBELo As Byte, ByRef BBEHi As Byte, ByRef BBECFreq As Byte, ByRef BBEMachFreq As Byte, ByRef BBEMachGain As Byte, ByRef BBEMachQ As Byte, ByRef BBESurr As Byte, ByRef BBEMp As Byte, ByRef BBEHpF As Byte, ByRef BBEHiMode As Byte) As Boolean
    Declare Function SetHeadroom Lib "keystonecomm.dll" (ByVal headroom As SByte) As Boolean
    Declare Function GetHeadroom Lib "keystonecomm.dll" () As SByte
    'Declare Function MotQuery Lib "keystonecomm.dll" () As Boolean
    Declare Unicode Sub GetImage Lib "keystonecomm.dll" (ByVal ImageFileName As String)
    Declare Function GetApplicationType Lib "keystonecomm.dll" (ByVal index As Int32) As Int16
    Declare Function GetApplicationData Lib "keystonecomm.dll" () As Boolean
    Declare Function SetApplicationType Lib "keystonecomm.dll" (ByVal index As UInt16) As Int16
    'Declare Sub MotReset Lib "keystonecomm.dll" (ByVal mode As SByte)
    Declare Function GetDABSignalQuality Lib "keystonecomm.dll" () As SByte
    Declare Function GetProgramInfo Lib "keystonecomm.dll" (ByVal dabIndex As UInt32, ByRef ServiceComponentID As Byte, ByRef ServiceID As UInt32, ByRef EnsembleID As UInt16) As Boolean
    Declare Function GetServCompType Lib "keystonecomm.dll" (ByVal index As Int32) As SByte
    Declare Function SyncRTC Lib "keystonecomm.dll" (ByVal sync As Boolean) As Boolean
    Declare Function GetRTC Lib "keystonecomm.dll" (ByRef sec As Byte, ByRef min As Byte, ByRef hour As Byte, ByRef day As Byte, ByRef month As Byte, ByRef year As Byte) As Boolean
    Declare Function GetSamplingRate Lib "keystonecomm.dll" () As Int16

#End If

End Module
