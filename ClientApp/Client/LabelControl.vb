Public Class LabelControl
    Inherits Label

    Private Properties As New ControlBoxProperties
    Public Label As String

    Public Sub ForRestore()
        Me.ForeColor = Properties.ForeColor()
        Me.BackColor = Properties.BackColor()
        Me.Font = New System.Drawing.Font("Calibri", 15, FontStyle.Regular)
        Me.AutoSize = False
        Me.Size = New Size(50, 9)
        Me.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Public Sub ForXAndMin()
        Me.ForeColor = Properties.ForeColor()
        Me.BackColor = Properties.BackColor()
        Me.Font = Properties.Font()
        Me.AutoSize = False
        Me.Size = New Size(50, 9)
        Me.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = Label
        End Set
    End Property

    Public HoverColor As Color = Color.Gray
    Public LeaveColor As Color = Color.Black

    Public Property MouseHoverColor() As Color
        Get
            MouseHoverColor = HoverColor
        End Get
        Set(value As Color)
            HoverColor = value
        End Set
    End Property

    Public Property MouseLeaveColor() As Color
        Get
            MouseLeaveColor = LeaveColor
        End Get
        Set(value As Color)
            LeaveColor = value
        End Set
    End Property

    Public Sub CloseMouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.Cursor = Cursors.Hand
        Me.ForeColor = MouseHoverColor
    End Sub

    Public Sub CloseMouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.Cursor = Cursors.Arrow
        Me.ForeColor = MouseLeaveColor
    End Sub


End Class