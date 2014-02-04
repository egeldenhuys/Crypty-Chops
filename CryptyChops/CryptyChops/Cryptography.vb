Imports System.IO
Public Class Cryptography
    ' This class will store the functions for encrypting and decrypting bytes

    Const BUFFER_SIZE As Integer = 1024


    Public Class Reverse

        Public Shared Sub ApplyAlgortihm(ByVal bytes() As Byte, ByVal destPath As String)
            Dim fReader As New FileReader(destPath, BUFFER_SIZE)
            ''Dim fsDest As New FileStream(destPath, FileMode.Create)
            ''Dim bytes() As Byte

            ' read all blocks until no bytes left
            ''While readerSource.Finished = False
            ''bytes = readerSource.ReadBlock()

            Array.Reverse(bytes)

            fReader.CreateFile(destPath, bytes)
            fReader.Close()

            ''readerSource.ReplaceFile(destPath)
            ''fsDest.Write(bytes, 0, 1024)
            ''End While

            ''readerSource.Close()

        End Sub

    End Class

    Public Class AES

        Public Shared Sub Encrypt(ByVal rawBytes() As Byte, ByVal key() As Byte, ByVal destPath As String)
            Dim fReader As New FileReader(destPath, BUFFER_SIZE)

            '' Doesn't prevent reptition

            Dim keyCounter As Integer = 0

            ''While reader.Finished = False
            ''rawBytes = reader.ReadBlock()

            Dim encryptedBytes(rawBytes.Length - 1) As Byte

            For i As Integer = 0 To encryptedBytes.Length
                encryptedBytes(i) = rawBytes(i) Xor key(keyCounter)
                keyCounter += 1

                If keyCounter > key.Length Then
                    keyCounter = 0
                End If
            Next

            fReader.CreateFile(destPath, encryptedBytes)
            fReader.Close()

            ''End While

            ''reader.ReplaceFile(destPath)

            ''reader.Close()

        End Sub

        Public Shared Sub Decrypt(ByVal encryptedBytes() As Byte, ByVal key() As Byte, ByVal destPath As String) '' ByVal sourcePath As String, ByVal destPath As String, ByVal key() As Byte)

            Dim fReader As New FileReader(destPath, BUFFER_SIZE)

            ''Dim reader As New FileReader(sourcePath, 1024)
            Dim keyCounter As Integer = 0

            ''While reader.Finished = False
            ''encryptedBytes = reader.ReadBlock()

            Dim decryptedBytes(encryptedBytes.Length - 1) As Byte

            For i As Integer = 0 To encryptedBytes.Length - 1
                decryptedBytes(i) = encryptedBytes(i) Xor key(keyCounter)
                keyCounter += 1

                If keyCounter > key.Length Then
                    keyCounter = 0
                End If
            Next

            fReader.CreateFile(destPath, decryptedBytes)
            fReader.Close()

            ''End While

            ''reader.ReplaceFile(destPath)

            ''reader.Close()

        End Sub

    End Class

    Public Class CryptyEncrypt

        Public Shared Function ApplyAlgortihm(ByVal rawBytes() As Byte, ByVal key() As Byte, ByVal destPath As String) As Byte()

            Dim fReader As New FileReader(destPath, BUFFER_SIZE)

            ''Dim reader As New FileReader(sourcePath, 1024)
            ''Dim rawBytes() As Byte
            Dim keyCounter As Integer = 0

            ''While reader.Finished = False
            ''rawBytes = reader.ReadBlock()
            ''End While

            Dim encryptedBytes(rawBytes.Length - 1) As Byte

            For i As Integer = 0 To rawBytes.Length - 1
                encryptedBytes(i) = rawBytes(i) Xor key(keyCounter)
                keyCounter += 1

                If keyCounter > key.Length Then
                    keyCounter = 0
                End If
            Next

            fReader.CreateFile(destPath, encryptedBytes)
            fReader.Close()

            ''reader.ReplaceFile(destPath)

            ''reader.Close()

        End Function

    End Class
End Class