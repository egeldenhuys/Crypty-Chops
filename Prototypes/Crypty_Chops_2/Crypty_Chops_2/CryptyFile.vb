Imports Crypty_Chops_2.FormMain
Imports System.Text

Public Class CryptyFile

    Public path As String
    Public password As String
    Public algorithm As String
    Public compress As Boolean

    Public Sub Encrypt()

        ' Compress file
        If compress = True Then
            ConsoleWrite("Compressing file...")
            Compression.Compress(path)
        End If

        ' Determine encryption algorithm
        Select Case algorithm
            Case "Crypty-Encrypt"
                Dim cryptyObj As New Cryptography.CryptyEncrypt
                cryptyObj.key = System.Text.Encoding.ASCII.GetBytes(password)

                ConsoleWrite("Password (HEX): " & BitConverter.ToString(cryptyObj.key))

                Dim sha As New  _
        System.Security.Cryptography.SHA256Managed()
                Dim hash() As Byte = sha.ComputeHash(cryptyObj.key)
                ConsoleWrite(Convert.ToBase64String(hash))
                             

                Dim passHash As New StringBuilder

                For i As Integer = 0 To hash.Length - 1
                    If hash(i) < 10 Then
                        passHash.Append("0")
                    End If

                    passHash.Append(Conversion.Hex(hash(i)))
                    passHash.Append("")
                Next

                ConsoleWrite("PAssword hash (HEX):" & passHash.ToString)
            Case "AES"

            Case "Reverse"

            Case "No Password"

        End Select
    End Sub

    ' sample code by the ref: http://www.htmlforums.com/asp-and-aspnet/t-sha256-encryption-in-aspnet-20-83659.html
    Public Function EncryptSHA256Managed(ByVal ClearString As String) As String
        Dim uEncode As New UnicodeEncoding()
        Dim bytClearString() As Byte = uEncode.GetBytes(ClearString)
        Dim sha As New  _
        System.Security.Cryptography.SHA256Managed()
        Dim hash() As Byte = sha.ComputeHash(bytClearString)
        Return Convert.ToBase64String(hash)
    End Function

End Class
