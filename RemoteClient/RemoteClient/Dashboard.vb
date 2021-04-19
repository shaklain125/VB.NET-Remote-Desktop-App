Imports System.ComponentModel
Imports System.IO

Public Class Dashboard

#Region "Form"

    Public Loaded As Boolean

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaded = False
        Control.CheckForIllegalCrossThreadCalls = False
        Me.WindowState = FormWindowState.Minimized
        Me.Hide()
        MySQLC.Connect()
        JobsPendingNotifier()
        ComputersNotifier()
        DashboardPanel1.ShowDashboard()
        BackgroundWorker1.RunWorkerAsync()
        Loaded = True
    End Sub

    Public Sub NormalWindow()
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub

#End Region

#Region "JobNotifier"

    Private MySQLC As New MySQLStaffConnection
    Public Shared C As Integer
    Public Shared JP As Integer

    Private Sub JobsPendingNotifier()
        JPNotify.Parent = JobsPending_btn
        JPNotify.BackColor = Color.Black
        JPNotify.ForeColor = Color.White
        JPNotify.Font = New Font("Calibri", 11)
        JPNotify.BringToFront()
        JPNotify.Text = 0
        JPNotify.Location = New Point(0, 0)
        JPNotify.Visible = True
        JPNotify.Enabled = True
    End Sub

    Private Sub ComputersNotifier()
        CNotify.Parent = Computers_btn
        CNotify.BackColor = Color.Black
        CNotify.ForeColor = Color.White
        CNotify.Text = 0
        CNotify.Font = New Font("Calibri", 11.25)
        CNotify.BringToFront()
        CNotify.Location = New Point(0, 0)
        CNotify.Visible = True
        CNotify.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending = False Then
            Do
                Try
                    C = 0
                    MySQLC.GetJobsApproved()

                    For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
                        C = C + 1
                    Next

                    If Computers_btn.Controls.Item("CNotify").Text = C.ToString Then
                        JP = 0
                        MySQLC.GetJobsPending()

                        For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
                            JP = JP + 1
                        Next

                        If JobsPending_btn.Controls.Item("JPNotify").Text = JP.ToString Then
                            Continue Do
                        Else
                            JobsPending_btn.Controls.Item("JPNotify").Text = JP
                            Continue Do
                        End If
                    Else
                        Computers_btn.Controls.Item("CNotify").Text = C
                        JP = 0
                        MySQLC.GetJobsPending()

                        For Each i As Object In MySQLC.SQLDS.Tables(0).Rows
                            JP = JP + 1
                        Next
                        If Convert.ToInt32(JobsPending_btn.Controls.Item("JPNotify").Text) = JP Then
                            Continue Do
                        Else
                            JobsPending_btn.Controls.Item("JPNotify").Text = JP
                            Continue Do
                        End If
                    End If
                Catch ex As Exception

                End Try
            Loop
        Else

        End If
    End Sub

#End Region

#Region "Menu"

    Private Sub Dashboard_btn_Click(sender As Object, e As EventArgs) Handles Dashboard_btn.Click
        JobsPending_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobsCompleted_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Computers_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Settings_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobDeclined_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Dashboard_btn.BackColor = Color.White
        ScreenRecord_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        DashboardPanel1.ShowDashboard()
    End Sub

    Private Sub JobsPending_btn_Click(sender As Object, e As EventArgs) Handles JobsPending_btn.Click
        JobsPending_btn.BackColor = Color.White
        JobsCompleted_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Computers_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Settings_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobDeclined_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Dashboard_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        ScreenRecord_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        DashboardPanel1.ShowJobsPending()
    End Sub

    Private Sub JobsCompleted_btn_Click(sender As Object, e As EventArgs) Handles JobsCompleted_btn.Click
        JobsPending_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobsCompleted_btn.BackColor = Color.White
        Computers_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Settings_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobDeclined_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Dashboard_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        ScreenRecord_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        DashboardPanel1.ShowJobsCompleted()
    End Sub

    Private Sub Settings_btn_Click(sender As Object, e As EventArgs) Handles Settings_btn.Click
        JobsPending_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobsCompleted_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Computers_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Settings_btn.BackColor = Color.White
        JobDeclined_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Dashboard_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        ScreenRecord_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        DashboardPanel1.ShowSettings()
    End Sub

    Private Sub ScreenRecord_btn_Click(sender As Object, e As EventArgs) Handles ScreenRecord_btn.Click
        JobsPending_btn.BackColor =Color.FromKnownColor(KnownColor.ActiveBorder)
        JobsCompleted_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Computers_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Settings_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobDeclined_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Dashboard_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        ScreenRecord_btn.BackColor = Color.White
        DashboardPanel1.ShowScreenRecords()
    End Sub

    Private Sub Computers_btn_Click(sender As Object, e As EventArgs) Handles Computers_btn.Click
        JobsPending_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobsCompleted_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Computers_btn.BackColor = Color.White
        Settings_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobDeclined_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Dashboard_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        ScreenRecord_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        DashboardPanel1.ShowComputers()
    End Sub

    Private Sub JobDeclined_btn_Click(sender As Object, e As EventArgs) Handles JobDeclined_btn.Click
        JobsPending_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobsCompleted_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Computers_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        Settings_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        JobDeclined_btn.BackColor = Color.White
        Dashboard_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        ScreenRecord_btn.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder)
        DashboardPanel1.ShowJobsDeclined()
    End Sub

#End Region

End Class