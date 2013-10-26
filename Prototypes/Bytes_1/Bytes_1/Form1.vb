Imports System.IO

Public Class Form1

    ' The aim of this program is to demonstrate how to get and display the bytes of a file

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click

        ' Get byte array
        Dim bytes() As Byte = GetBytes("C:\users\Evert\Desktop\Byte Me.txt")

        Dim tmpNum As String

        ' Print the bytes as decimals
        For i As Integer = 0 To bytes.GetUpperBound(0)

            tmpNum = CStr(Conversion.Hex(bytes(i)))

            txtBytes.AppendText(tmpNum & " ")
        Next

        txtBytes.AppendText(vbNewLine & "-------------------" & vbNewLine)

        ' Get char array from bytes by encoding text
        Dim chars() As Char = System.Text.UnicodeEncoding.Default.GetChars(bytes)

        For i As Integer = 0 To chars.GetUpperBound(0)
            txtBytes.AppendText(chars(i))
        Next


    End Sub

    Private Function GetBytes(ByVal path As String) As Byte()
        ' Specify a file to read from and to create. 

        Dim fsSource As FileStream = New FileStream(path, _
            FileMode.Open, FileAccess.Read)
        ' Read the source file into a byte array. 
        Dim bytes() As Byte = New Byte(CInt((fsSource.Length) - 1)) {}
        Dim numBytesToRead As Integer = CType(fsSource.Length, Integer)
        Dim numBytesRead As Integer = 0

        While (numBytesToRead > 0)
            ' Read may return anything from 0 to numBytesToRead. 
            Dim n As Integer = fsSource.Read(bytes, numBytesRead, _
                numBytesToRead)
            ' Break when the end of the file is reached. 
            If (n = 0) Then
                Exit While
            End If
            numBytesRead = (numBytesRead + n)
            numBytesToRead = (numBytesToRead - n)

        End While
        numBytesToRead = bytes.Length

        Return bytes

    End Function


End Class
