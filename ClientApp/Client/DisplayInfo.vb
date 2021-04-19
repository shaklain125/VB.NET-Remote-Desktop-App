Public Class DisplayInfo

    Inherits Panel

    Public Sub ShowOverview()
        Me.Controls.Clear()
        Dim Ov As New Overview
        With Ov
            Ov.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(Ov)
    End Sub

    Public Sub ShowChangeEmail()
        Me.Controls.Clear()
        Dim Em As New ChangeEmail
        With Em
            Em.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(Em)
    End Sub

    Public Sub ShowChangePass()
        Me.Controls.Clear()
        Dim Pw As New ChangePass
        With Pw
            Pw.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(Pw)
    End Sub

    Public Sub ShowChangeName()
        Me.Controls.Clear()
        Dim Name As New ChangeName
        With Name
            Name.Dock = DockStyle.Fill
        End With
        Me.Controls.Add(Name)
    End Sub

End Class
