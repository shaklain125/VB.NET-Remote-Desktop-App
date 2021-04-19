Imports System.Threading

Public Class ClientScreen

#Region "keyboard Key presses"

    Public Sub theimage_KeyUp(sender As Object, e As KeyEventArgs) Handles theImage.KeyUp
        If Not Settings.SendKeysAndMouse OrElse Not Settings.Connected Then
            Return
        End If
        Try
            Dim keysToSend As [String] = ""
            If e.Shift Then
                keysToSend += "+"
            End If
            If e.Alt Then
                keysToSend += "%"
            End If
            If e.Control Then
                keysToSend += "^"
            End If
            If e.KeyCode.ToString.Equals("LWin") Then
                Server.SendWindowsStart(Nothing, Nothing)
            End If
            If e.KeyValue >= 65 AndAlso e.KeyValue <= 90 Then
                keysToSend += e.KeyCode.ToString().ToLower()
            ElseIf e.KeyCode.ToString().Equals("Back") Then
                keysToSend += "{BS}"
            ElseIf e.KeyCode.ToString().Equals("Pause") Then
                keysToSend += "{BREAK}"
            ElseIf e.KeyCode.ToString().Equals("Capital") Then
                keysToSend += "{CAPSLOCK}"
            ElseIf e.KeyValue = 144 Then
                keysToSend += "{NUMLOCK}"
            ElseIf e.KeyCode.ToString().Equals("Space") Then
                keysToSend += " "
            ElseIf e.KeyCode.ToString().Equals("Home") Then
                keysToSend += "{HOME}"
            ElseIf e.KeyCode.ToString().Equals("Return") Then
                keysToSend += "{ENTER}"
            ElseIf e.KeyCode.ToString().Equals("End") Then
                keysToSend += "{END}"
            ElseIf e.KeyCode.ToString().Equals("Tab") Then
                keysToSend += "{TAB}"
            ElseIf e.KeyCode.ToString().Equals("Escape") Then
                keysToSend += "{ESC}"
            ElseIf e.KeyCode.ToString().Equals("Insert") Then
                keysToSend += "{INS}"
            ElseIf e.KeyCode.ToString().Equals("Up") Then
                keysToSend += "{UP}"
            ElseIf e.KeyCode.ToString().Equals("Down") Then
                keysToSend += "{DOWN}"
            ElseIf e.KeyCode.ToString().Equals("Left") Then
                keysToSend += "{LEFT}"
            ElseIf e.KeyCode.ToString().Equals("Right") Then
                keysToSend += "{RIGHT}"
            ElseIf e.KeyCode.ToString().Equals("PageUp") Then
                keysToSend += "{PGUP}"
            ElseIf e.KeyCode.ToString().Equals("Next") Then
                keysToSend += "{PGDN}"
            ElseIf e.KeyCode.ToString().Equals("Tab") Then
                keysToSend += "{TAB}"
            ElseIf e.KeyCode.ToString().Equals("D1") Then
                keysToSend += "1"
            ElseIf e.KeyCode.ToString().Equals("D2") Then
                keysToSend += "2"
            ElseIf e.KeyCode.ToString().Equals("D3") Then
                keysToSend += "3"
            ElseIf e.KeyCode.ToString().Equals("D4") Then
                keysToSend += "4"
            ElseIf e.KeyCode.ToString().Equals("D5") Then
                keysToSend += "5"
            ElseIf e.KeyCode.ToString().Equals("D6") Then
                keysToSend += "6"
            ElseIf e.KeyCode.ToString().Equals("D7") Then
                keysToSend += "7"
            ElseIf e.KeyCode.ToString().Equals("D8") Then
                keysToSend += "8"
            ElseIf e.KeyCode.ToString().Equals("D9") Then
                keysToSend += "9"
            ElseIf e.KeyCode.ToString().Equals("D0") Then
                keysToSend += "0"
            ElseIf e.KeyCode.ToString().Equals("F1") Then
                keysToSend += "{F1}"
            ElseIf e.KeyCode.ToString().Equals("F2") Then
                keysToSend += "{F2}"
            ElseIf e.KeyCode.ToString().Equals("F3") Then
                keysToSend += "{F3}"
            ElseIf e.KeyCode.ToString().Equals("F4") Then
                keysToSend += "{F4}"
            ElseIf e.KeyCode.ToString().Equals("F5") Then
                keysToSend += "{F5}"
            ElseIf e.KeyCode.ToString().Equals("F6") Then
                keysToSend += "{F6}"
            ElseIf e.KeyCode.ToString().Equals("F7") Then
                keysToSend += "{F7}"
            ElseIf e.KeyCode.ToString().Equals("F8") Then
                keysToSend += "{F8}"
            ElseIf e.KeyCode.ToString().Equals("F9") Then
                keysToSend += "{F9}"
            ElseIf e.KeyCode.ToString().Equals("F10") Then
                keysToSend += "{F10}"
            ElseIf e.KeyCode.ToString().Equals("F11") Then
                keysToSend += "{F11}"
            ElseIf e.KeyCode.ToString().Equals("F12") Then
                keysToSend += "{F12}"
            ElseIf e.KeyValue = 186 Then
                keysToSend += "{;}"
            ElseIf e.KeyValue = 222 Then
                keysToSend += "'"
            ElseIf e.KeyValue = 191 Then
                keysToSend += "/"
            ElseIf e.KeyValue = 190 Then
                keysToSend += "."
            ElseIf e.KeyValue = 188 Then
                keysToSend += ","
            ElseIf e.KeyValue = 219 Then
                keysToSend += "{[}"
            ElseIf e.KeyValue = 221 Then
                keysToSend += "{]}"
            ElseIf e.KeyValue = 220 Then
                keysToSend += "\"
            ElseIf e.KeyValue = 187 Then
                keysToSend += "{=}"
            ElseIf e.KeyValue = 189 Then
                keysToSend += "{-}"
            ElseIf e.KeyCode.ToString().ToLower().StartsWith("numpad") Then
                keysToSend += e.KeyCode.ToString().Substring(6)
            ElseIf e.KeyCode = Keys.Divide Then
                keysToSend += "/"
            ElseIf e.KeyCode = Keys.[Decimal] Then
                keysToSend += "."
            ElseIf e.KeyCode = Keys.Subtract Then
                keysToSend += "-"
            ElseIf e.KeyCode = Keys.Add Then
                keysToSend += "+="
            ElseIf e.KeyCode = Keys.Multiply Then
                keysToSend += "*"
            ElseIf e.KeyCode = Keys.Delete Then
                keysToSend += "+{DEL}"
            Else
                e.SuppressKeyPress = True
                Return
            End If
            e.SuppressKeyPress = True
            Server.SendCommandOrData.SafeSendValue(keysToSend)

        Catch generatedExceptionName As Exception
        End Try
    End Sub

#End Region

#Region "Mouse commands"

    Public Sub theImage_MouseMove(sender As Object, e As MouseEventArgs) Handles theImage.MouseMove
        'Keep sending our mouse X,Y to the server 
        If Not Settings.SendKeysAndMouse Then
            Return
        End If

        Try

            'We are not full screen so scale the mouse X,Y to suite the current size 
            Dim correctX As Single = CSng(Settings.ScreenClientX) * (CSng(e.Location.X) / (theImage.Width - theImage.Padding.Left - theImage.Padding.Right))
            Dim correctY As Single = CSng(Settings.ScreenClientY) * (CSng(e.Location.Y) / (theImage.Height - theImage.Padding.Top))
            correctX = CInt(correctX)
            correctY = CInt(correctY)
            Server.SendCommandOrData.SafeSendValue("M" & correctX & " " & correctY)

        Catch generatedExceptionName As Exception

        End Try

    End Sub

    Public Sub theImage_MouseClick(sender As Object, e As MouseEventArgs) Handles theImage.MouseClick
        If Not Settings.SendKeysAndMouse Then
            Return
        End If
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Server.SendCommandOrData.SafeSendValue("LCLICK")
        ElseIf e.Button = System.Windows.Forms.MouseButtons.Right Then
            Server.SendCommandOrData.SafeSendValue("RCLICK")
        End If
    End Sub

    Public Sub theImage_MouseDown(sender As Object, e As MouseEventArgs) Handles theImage.MouseDown
        If Settings.Connected Then
            FindForm.Invoke(DirectCast(Sub()

                                       End Sub, MethodInvoker))
        End If
        If Not Settings.SendKeysAndMouse Then
            Return
        End If
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Server.SendCommandOrData.SafeSendValue("LDOWN")
        ElseIf e.Button = System.Windows.Forms.MouseButtons.Right Then
            Server.SendCommandOrData.SafeSendValue("RDOWN")
        End If
    End Sub

    Public Sub theImage_MouseUp(sender As Object, e As MouseEventArgs) Handles theImage.MouseUp
        If Not Settings.SendKeysAndMouse Then
            Return
        End If
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Server.SendCommandOrData.SafeSendValue("LUP")
        ElseIf e.Button = System.Windows.Forms.MouseButtons.Right Then
            Server.SendCommandOrData.SafeSendValue("RUP")
        End If
    End Sub

#End Region

#Region "Screen Status"

    Public Sub ChatEnvironmentImg(Change As Boolean)
        If Change = True Then
            theImage.Image = My.Resources.ResourceManager.GetObject("ChatMsgpb")
        End If
    End Sub

#End Region

#Region "Screen Size"

    Public AspectRatio As Double

    Public Sub MaintainAspectRatio(Img As Image)
        theImage.Image = Img
        theImage.SizeMode = PictureBoxSizeMode.StretchImage
        AspectRatio = Img.Height / Img.Width
        Server.ClientSize = New System.Drawing.Size(Img.Width, Img.Height)
    End Sub

    Public Sub ServerResize(sender As Object, e As EventArgs)
        Server.ClientSize = New System.Drawing.Size(theImage.Height / AspectRatio, Server.ClientSize.Height)
    End Sub

#End Region

    Public Sub FocusCmd(focus As Boolean)
        If focus = True Then
            theImage.Focus()
        End If
    End Sub

    Public Sub NewImage(img As Bitmap)
        theImage.Image = DirectCast(img, Image)
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Server.Desktop_pb.Padding = New Padding(50, 0, 50, 0)
        Server.AllButtonsContainer.Show()
        Server.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Server.WindowState = FormWindowState.Normal
    End Sub

End Class
