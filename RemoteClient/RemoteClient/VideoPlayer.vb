Public Class VideoPlayer


#Region "Form"

    Public Sub New(VideoFilePath As String)

        InitializeComponent()
        AxWindowsMediaPlayer1.URL = VideoFilePath
        Me.Show()
    End Sub

    Private Sub VideoPlayer_LostFocus(sender As Object, e As EventArgs) Handles MyBase.LostFocus
        Me.Focus()
    End Sub

    Private Sub VideoPlayer_keyup(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then
            Label4.Visible = True
            Label4.Text = TimeSpan.FromSeconds(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString("hh\:mm\:ss") & " - " & Format(CDec((AxWindowsMediaPlayer1.currentMedia.duration / 142)), "0.00") & "s"
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - Format(CDec((AxWindowsMediaPlayer1.currentMedia.duration / 142)), "0.00")
        End If
        If e.KeyCode = Keys.Right Then
            Label4.Visible = True
            Label4.Text = TimeSpan.FromSeconds(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString("hh\:mm\:ss") & " + " & Format(CDec((AxWindowsMediaPlayer1.currentMedia.duration / 142)), "0.00") & "s"
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + Format(CDec((AxWindowsMediaPlayer1.currentMedia.duration / 142)), "0.00")
        End If
        If e.KeyCode = Keys.Up Then
            If Not Volume.Value = 100 Then
                Label4.Visible = True
                AxWindowsMediaPlayer1.settings.volume = AxWindowsMediaPlayer1.settings.volume + 1
                Volume.Value = Volume.Value + 1
                Label4.Text = Volume.Value & "%"
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If Not Volume.Value = 0 Then
                Label4.Visible = True
                AxWindowsMediaPlayer1.settings.volume = AxWindowsMediaPlayer1.settings.volume - 1
                Volume.Value = Volume.Value - 1
                Label4.Text = Volume.Value & "%"
            End If
        End If
    End Sub

    Private Sub VideoPlayer_keydown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space OrElse e.KeyCode = Keys.Enter Then
            MaterialFlatButton2.PerformClick()
        End If
        If e.KeyCode = Keys.Escape Then
            MaterialFlatButton4.PerformClick()
        End If
    End Sub

    Private Sub VideoPlayer_sizechanged(sender As Object, e As EventArgs) Handles MyBase.Resize
        CentreMediaControls()
    End Sub

    Private Sub VideoPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.settings.setMode("Loop", True)
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub VideoPlayer_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub CentreMediaControls()
        Dim MediaControlsWidth As Integer = MaterialFlatButton1.Width + MaterialFlatButton2.Width + MaterialFlatButton3.Width + MaterialFlatButton4.Width
        Dim x As Integer = (Panel1.Width / 2) - (MediaControlsWidth / 2)
        Panel1.Padding = New Padding(x, 0, x, 0)
        'Label2.Location = New Point(Panel2.Location.X + MediaControlsWidth + 5, Me.Height - 61)
        'Label3.Location = New Point(Panel2.Location.X + MediaControlsWidth + Label2.Width, Panel2.Location.Y + 18)
    End Sub

#End Region

#Region "Media Controls"

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        If MaterialFlatButton2.Text = "❚❚" Then
            ToolTip1.SetToolTip(MaterialFlatButton2, "Play")
            MaterialFlatButton2.Text = "▶"
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            ToolTip1.SetToolTip(MaterialFlatButton2, "Pause")
            MaterialFlatButton2.Text = "❚❚"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Me.Close()
    End Sub

#End Region

#Region "Volume"

    Dim VolumeLabelAutoHide As Integer = 0

    Private Sub Volume_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll
        AxWindowsMediaPlayer1.settings.volume = Volume.Value
        Label4.Text = Volume.Value & "%"
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        VolumeLabelAutoHide += 1
        If VolumeLabelAutoHide = 2 Then
            Label4.Visible = False
            VolumeLabelAutoHide = 0
        End If
    End Sub

#End Region

#Region "Duration"

    Dim MaxValue As Double
    Dim Duration As Double
    Dim GetDurationFirstTick As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            GetDurationFirstTick = GetDurationFirstTick + 1
            Duration_trackb.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
            Duration_trackb.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
            Dim CurrentTimeValue As TimeSpan = TimeSpan.FromSeconds(Duration_trackb.Value)
            Label2.Text = CurrentTimeValue.ToString("hh\:mm\:ss")
            Dim diff As Integer = Duration - AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
            Dim TotalTimeValue As TimeSpan = TimeSpan.FromSeconds(diff)
            Label3.Text = TotalTimeValue.ToString("hh\:mm\:ss")
        Catch ex As Exception
            Timer1.Stop()
            Timer1.Start()
        End Try
    End Sub

    Private Sub Duration_trackb_Scroll(sender As Object, e As EventArgs) Handles Duration_trackb.Scroll
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Duration_trackb.Value
    End Sub

#End Region

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        Dim ScreenRecordSender As New DbxSaveDialogue
        ScreenRecordSender.Show()
    End Sub

End Class