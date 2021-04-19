Imports System.Collections.Generic
Imports System.Net
Imports System.Text
Imports System.Security.Principal
Imports System.IO
Imports System.Windows.Forms

Public Class Helper

    Public Shared Function XorString(Value As String, Shift As Integer, Outbound As Boolean) As String
        If Outbound Then
            Value = Value.Replace(" ", "#SS#")
        End If
        Dim Output As String = ""
        Dim Ch As Integer = 0


        For f As Integer = 0 To Value.Length - 1
            Ch = Convert.ToInt32(Value(f))
            If Outbound AndAlso Ch = 113 Then
                Ch = Convert.ToInt32("¬"c)
            ElseIf Not Outbound AndAlso Ch = 172 Then
                Ch = 113
            Else
                Ch = Ch Xor Shift
            End If
            Output += Char.ConvertFromUtf32(Ch)
        Next
        If Not Outbound Then
            Return Output.Replace("#SS#", " ")
        Else
            Return Output
        End If
    End Function

End Class
