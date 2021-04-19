Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms

Public Class MaterialFlatButton

    Inherits Button

    Public Sub New()
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64)
        Me.FlatAppearance.MouseOverBackColor = Color.DimGray
        Me.FlatAppearance.BorderSize = 0
        Me.Font = New System.Drawing.Font("Calibri", 12, FontStyle.Regular)
        Me.Height = 34
        Me.Width = 150
    End Sub

    Protected Overrides ReadOnly Property ShowFocusCues As Boolean
        Get
            Return False
        End Get
    End Property

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        pe.Graphics.DrawRectangle(New Pen(BackColor), ClientRectangle)
    End Sub

    Public MouseDFColor As Color = Color.White
    Public Property MouseDownForeColor() As Color
        Get
            MouseDownForeColor = MouseDFColor
        End Get
        Set(value As Color)
            MouseDFColor = value
        End Set
    End Property

    Public MouseHFColor As Color = Color.DarkGray
    Public Property MouseHoverForeColor() As Color
        Get
            MouseHoverForeColor = MouseHFColor
        End Get
        Set(value As Color)
            MouseHFColor = value
        End Set
    End Property

    Public MouseLFColor As Color = Color.Black
    Public Property MouseLeaveForeColor() As Color
        Get
            MouseLeaveForeColor = MouseLFColor
        End Get
        Set(value As Color)
            MouseLFColor = value
        End Set
    End Property


    Private Sub MaterialFlatButton_Down(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        Me.ForeColor = MouseDFColor
    End Sub

    Private Sub MaterialFlatButton_Hover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.ForeColor = MouseHFColor
    End Sub

    Private Sub MaterialFlatButton_Leave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.ForeColor = MouseLFColor
    End Sub

End Class
