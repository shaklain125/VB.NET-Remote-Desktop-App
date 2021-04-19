Public Class ReturnColor
    Inherits Panel

    Public Shared HoverColor As Color
    Public Shared LeaveColor As Color

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
End Class
