Imports System.IO

Public Class ScreenRecords

    Private ScreenRecordsContainerTL As TableLayoutPanel
    Dim ScreenRecordDirectory As New DirectoryInfo(Application.StartupPath & "\Screen Records")
    Dim ScreenRecordFiles As FileInfo()
    Private Count As Integer
    Private ScreenRecordPlayer As VideoPlayer

    Private Sub ScreenRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(Application.StartupPath & "\Screen Records") Then
            Directory.CreateDirectory(Application.StartupPath & "\Screen Records")
        End If
        CreateTable()
        ScreenRecordFiles = ScreenRecordDirectory.GetFiles()
        For Each ScreenRecordVideo As FileInfo In ScreenRecordFiles
            If ScreenRecordVideo.FullName.EndsWith(".mp4") Then
                DisplayScreenRecords(Path.GetFileNameWithoutExtension(ScreenRecordVideo.FullName))
            End If
        Next
    End Sub

    Private Sub CreateTable()
        ScreenRecordsContainerTL = New TableLayoutPanel
        With ScreenRecordsContainerTL
            .CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            .Name = "tableLayout"
            .Padding = New Padding(8, 8, 8, 0)
            .Margin = New Padding(0, 0, 0, 0)
            .ColumnCount = 5
            .RowCount = 1
            .Height = 100
            For x = 1 To .ColumnCount
                .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100%))
            Next
            For y = 1 To .RowCount
                .RowStyles.Add(New RowStyle(SizeType.Percent, 100%))
            Next
            .Dock = DockStyle.Top
        End With
        Me.Controls.Add(ScreenRecordsContainerTL)
    End Sub

    Private Sub DisplayScreenRecords(Filename As String)
        Count = Count + 1
        If Count = ScreenRecordsContainerTL.ColumnCount * ScreenRecordsContainerTL.RowCount Then
            ScreenRecordsContainerTL.RowCount = ScreenRecordsContainerTL.RowCount + 1
            For y = 1 To ScreenRecordsContainerTL.RowCount
                ScreenRecordsContainerTL.RowStyles.Add(New RowStyle(SizeType.Percent, 100%))
            Next
            ScreenRecordsContainerTL.Height = ScreenRecordsContainerTL.Height + 100
        End If
        Dim ScreenR As New MaterialFlatButton
        Dim ScreenRID_lbl As New Label
        AddHandler ScreenR.Click, AddressOf ScreenR_Click
        With ScreenR
            .Dock = DockStyle.Fill
            .MouseHoverForeColor = Color.Empty
            .MouseLeaveForeColor = Color.Empty
            .MouseDownForeColor = Color.Empty
            .FlatAppearance.MouseDownBackColor = Color.Empty
            .FlatAppearance.MouseOverBackColor = Color.Empty
            .FlatStyle = FlatStyle.Popup
            .BackgroundImage = My.Resources.ScreenRBG
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        With ScreenRID_lbl
            .Parent = ScreenR
            .BackColor = Color.Transparent
            .ForeColor = Color.White
            .Font = New Font("Calibri", 9)
            .BringToFront()
            .Text = Filename
            .AutoSize = True
            .Location = New Point(1, 1)
            .Visible = True
            .Enabled = True
        End With
        ScreenRecordsContainerTL.Controls.Add(ScreenR)
        ScreenR.Controls.Add(ScreenRID_lbl)
    End Sub

    Public Shared ScreenRLocation As String

    Private Sub ScreenR_Click(sender As Object, e As EventArgs)
        Dim C As MaterialFlatButton
        C = CType(sender, MaterialFlatButton)
        Dim ScreenID As String = C.Controls.Item(0).Text
        For Each screenrfile As FileInfo In ScreenRecordFiles
            If Path.GetFileNameWithoutExtension(screenrfile.FullName) = ScreenID Then
                ScreenRLocation = screenrfile.FullName
                ScreenRecordPlayer = New VideoPlayer(screenrfile.FullName)
                ScreenRecordPlayer.Text = ScreenID
                Exit For
            End If
        Next
    End Sub

End Class
