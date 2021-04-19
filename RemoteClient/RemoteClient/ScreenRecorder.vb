Imports System.IO

Public Class ScreenRecorder

    Public ScreenRecordLocation As String = Application.StartupPath & "\Screen Records"
    Private VideoConverterZipFile As String = Application.StartupPath & "\Converter.zip"
    Private VideoConverterExtractPath As String = Application.StartupPath
    Private ffmpeg64bit As String = My.Application.Info.DirectoryPath & "\ffmpeg64.exe"
    Private ffmpeg32bit As String = My.Application.Info.DirectoryPath & "\ffmpeg32.exe"
    Public TempImagesLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Temp" & Computers.JobID

    Private Sub SaveScreenRecordAsVideo()
        If Not File.Exists(ScreenRecordLocation & "\" & Computers.JobID & ".mp4") Then
            Convert(True)
        Else
            Dim result As Integer = MessageBox.Show("Screen record of the same job already exists. Do you want to overwrite the previous version?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = MsgBoxResult.Yes Then
                File.Delete(ScreenRecordLocation & "\" & Computers.JobID & ".mp4")
                Convert(True)
            Else
                Dim result2 As Integer = MessageBox.Show("Discard new screen record?", "Keep or Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result2 = MsgBoxResult.No Then
                    Convert(False)
                End If
            End If
        End If
    End Sub

    Private Sub Convert(Overwrite As Boolean)
        Dim args As String
        If Overwrite Then
            args = "-framerate 9.8 -i " & TempImagesLocation & "\%01d.jpg -c:v libx264 -r 30 -pix_fmt yuv420p " & Chr(34) & ScreenRecordLocation & "\" & Computers.JobID & ".mp4" & Chr(34)
        Else
            args = "-framerate 9.8 -i " & TempImagesLocation & "\%01d.jpg -c:v libx264 -r 30 -pix_fmt yuv420p " & Chr(34) & ScreenRecordLocation & "\Copy of - " & Computers.JobID & ".mp4" & Chr(34)
        End If
        Dim proc As New Process
        Dim proci As New ProcessStartInfo
        If Environment.Is64BitOperatingSystem = True Then
            proci.FileName = ffmpeg64bit
        Else
            proci.FileName = ffmpeg32bit
        End If
        proci.Arguments = args
        proci.WindowStyle = ProcessWindowStyle.Hidden
        proci.CreateNoWindow = True
        proci.UseShellExecute = False
        proc.StartInfo = proci
        proc.Start()
        Dim servertxt As String = Server.Text
        Do Until proc.HasExited = True
            Server.Text = "Saving"
        Loop
        Server.Text = "Saved"
        Server.Text = servertxt
        IO.Directory.Delete(TempImagesLocation, True)
    End Sub

    Public Sub SaveVideo()
        If Not Directory.Exists(ScreenRecordLocation) Then
            Directory.CreateDirectory(ScreenRecordLocation)
            SaveScreenRecordAsVideo()
        Else
            SaveScreenRecordAsVideo()
        End If
    End Sub

End Class
