Public Class ControlBoxProperties

    Private ControlBFont As Font = New System.Drawing.Font("Calibri", 12, FontStyle.Regular)
    Private ControlForeColor As Color = Color.Black
    Private ControlBackColor As Color = Color.White

    Public Function Font()
        Return ControlBFont
    End Function

    Public Function ForeColor()
        Return ControlForeColor
    End Function

    Public Function BackColor()
        Return ControlBackColor
    End Function

End Class
