Module Module1
#If DEBUG Then
    ' Point the DLL to the KeyStoneCOMM DLL Debug folder if you wish to debug both DLL and VB app at the same time.
    Declare Function CommVersion Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Int32
    Declare Function OpenRadioPort Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal port As String, ByVal usehardmute As Boolean) As Boolean
    Declare Function HardResetRadio Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Function CloseRadioPort Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Function PlayStream Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal channel As Int32) As Boolean
    Declare Function StopStream Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Function SetVolume Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal volume As SByte) As Boolean
    Declare Function IsSysReady Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Function VolumePlus Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function VolumeMinus Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Sub VolumeMute Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" ()
    Declare Function GetVolume Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function GetPlayMode Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function GetPlayStatus Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function GetTotalProgram Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Int32
    Declare Function NextStream Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Function PrevStream Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Function GetPlayIndex Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Int32
    Declare Function GetSignalStrength Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByRef biterror As Integer) As SByte
    Declare Function GetProgramType Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal dabIndex As Int32) As SByte
    Declare Unicode Function GetProgramText Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal programText As String) As SByte
    Declare Unicode Function GetProgramName Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal dabIndex As Int32, ByVal namemode As SByte, ByVal programName As String) As Boolean
    Declare Unicode Function GetPreset Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal presetindex As SByte) As Int32
    Declare Unicode Function SetPreset Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal mode As SByte, ByVal presetindex As SByte, ByVal channel As Int32) As Boolean
    Declare Function DABAutoSearch Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal startindex As Byte, ByVal endindex As Byte) As Boolean
    Declare Unicode Function GetEnsembleName Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal dabIndex As Int32, ByVal namemode As SByte, ByVal programName As String) As Boolean
    Declare Function GetDataRate Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Int16
    Declare Function SetStereoMode Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal mode As SByte) As Boolean
    Declare Function GetFrequency Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function GetStereoMode Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function GetStereo Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function ClearDatabase Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Function SetBBEEQ Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal BBEOn As Byte, ByVal EQMode As Byte, ByVal BBELo As Byte, ByVal BBEHi As Byte, ByVal BBECFreq As Byte, ByVal BBEMachFreq As Byte, ByVal BBEMachGain As Byte, ByVal BBEMachQ As Byte, ByVal BBESurr As Byte, ByVal BBEMp As Byte, ByVal BBEHpF As Byte, ByVal BBEHiMode As Byte) As Boolean
    Declare Function GetBBEEQ Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByRef BBEOn As Byte, ByRef EQMode As Byte, ByRef BBELo As Byte, ByRef BBEHi As Byte, ByRef BBECFreq As Byte, ByRef BBEMachFreq As Byte, ByRef BBEMachGain As Byte, ByRef BBEMachQ As Byte, ByRef BBESurr As Byte, ByRef BBEMp As Byte, ByRef BBEHpF As Byte, ByRef BBEHiMode As Byte) As Boolean
    Declare Function SetHeadroom Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal headroom As SByte) As Boolean
    Declare Function GetHeadroom Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte
    Declare Function MotQuery Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As Boolean
    Declare Unicode Sub GetImage Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal ImageFileName As String)
    Declare Function GetApplicationType Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal index As Int32) As SByte
    Declare Sub MotReset Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" (ByVal mode As SByte)
    Declare Function GetDABSignalQuality Lib "C:\Documents and Settings\user\My Documents\Visual Studio 2008\Projects\KeyStoneCOMM\Debug\keystonecomm.dll" () As SByte

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
    Declare Function MotQuery Lib "keystonecomm.dll" () As Boolean
    Declare Unicode Sub GetImage Lib "keystonecomm.dll" (ByVal ImageFileName As String)
    Declare Function GetApplicationType Lib "keystonecomm.dll" (ByVal index As Int32) As SByte
    Declare Sub MotReset Lib "keystonecomm.dll" (ByVal mode As SByte)
    Declare Function GetDABSignalQuality Lib "keystonecomm.dll" () As SByte

#End If

End Module
