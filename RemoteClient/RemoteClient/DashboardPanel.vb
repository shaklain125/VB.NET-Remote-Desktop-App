Public Class DashboardPanel

    Inherits Panel

    Public Sub ShowDashboard()
        Me.Controls.Clear()
        Dim DashB As New DashboardPage
        With DashB
            DashB.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(DashB)
    End Sub

    Public Sub ShowJobsPending()
        Me.Controls.Clear()
        Dim JP As New JobsPending
        With JP
            JP.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(JP)
    End Sub

    Public Sub ShowJobsDeclined()
        Me.Controls.Clear()
        Dim JD As New JobsDeclined
        With JD
            JD.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(JD)
    End Sub

    Public Sub ShowJobsCompleted()
        Me.Controls.Clear()
        Dim JC As New JobsCompleted
        With JC
            JC.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(JC)
    End Sub

    Public Sub ShowComputers()
        Me.Controls.Clear()
        Dim C As New Computers
        With C
            C.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(C)
    End Sub

    Public Sub ShowScreenRecords()
        Me.Controls.Clear()
        Dim ScreenR As New ScreenRecords
        With ScreenR
            ScreenR.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(ScreenR)
    End Sub

    Public Sub ShowSettings()
        Me.Controls.Clear()
        Dim S As New TechSettings
        With S
            S.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(S)
    End Sub

End Class
