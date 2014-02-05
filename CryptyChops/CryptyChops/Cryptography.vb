Imports System.IO
Public Class Cryptography
    ' This class will store the functions for encrypting and decrypting bytes

    Const BUFFER_SIZE As Integer = 1024


    Public Class Reverse

        Public Function ApplyAlgorithm(ByVal rawBytes() As Byte) As Byte()

            Array.Reverse(rawBytes)

            Return rawBytes

        End Function

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

            ' fReader.CreateFile(destPath, encryptedBytes)
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

            'fReader.CreateFile(destPath, decryptedBytes)
            fReader.Close()

            ''End While

            ''reader.ReplaceFile(destPath)

            ''reader.Close()

        End Sub

    End Class

    Public Class CryptyEncrypt

        Public key() As Byte
        Public keyIndex As Integer = 0

        Public Function ApplyAlgorithm(ByVal rawBytes() As Byte) As Byte()

            Dim cryptBytes(rawBytes.Length - 1) As Byte ' Array to store the encrypted bytes

            Dim bytesLeft As Long = rawBytes.Length ' How many bytes we still have to read

            ' XOR each of the bytes in the block with a byte from they key.
            For i As Integer = 0 To rawBytes.Length - 1

                ' Perform XOR
                cryptBytes(i) = rawBytes(i) Xor key(keyIndex)

                ' Check to see if we need to reset the keycount
                If keyIndex = key.GetUpperBound(0) Then
                    keyIndex = 0

                    Dim hasher As New System.Security.Cryptography.SHA1Managed
                    key = hasher.ComputeHash(key)
                Else
                    keyIndex += 1
                End If

            Next

            Return cryptBytes
        End Function


    End Class
End Class