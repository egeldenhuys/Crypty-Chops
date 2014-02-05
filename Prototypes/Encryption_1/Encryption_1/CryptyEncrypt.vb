Imports System.IO
Imports System.Text

Public Class CryptyEncrypt

    Const bufferSize = 1024

    ''' <summary>
    ''' Encrypt the file using the key given
    ''' </summary>
    ''' <param name="path">The path of the raw file</param>
    ''' <param name="outPath">Output path of the encrypted file</param>
    ''' <param name="key">Key to use for encryption</param>
    ''' <remarks></remarks>
    Public Sub ApplyAlgorithm(path As String, outPath As String, key As String)


        ' Convert the key to bytes
        Dim keyBytes As Byte() = New UTF8Encoding(True).GetBytes(key)

        Dim keyCount As Integer = 0 ' Which byte to use from the key when encrypting.

        ' Create filesteam and Buffer array
        Dim fs As New FileStream(path, FileMode.Open)
        Dim b(bufferSize - 1) As Byte ' Array to store the bytes read from the file

        Dim bytesLeft As Long = fs.Length ' How many bytes we still have to read

        ' Create filestream for writing the encrypted file
        Dim fsOut As New FileStream(outPath, FileMode.Create)

        Dim bOut(bufferSize -1) As Byte 'Array to use for storage of encrypted bytes

        Dim n As Integer = 0 ' Variable to store how many bytes was read

        ' Read blocks until all bytes have been read
        While (bytesLeft > 0)

            ' Read block of bytes and store how many was read in 'n'
            n = fs.Read(b, 0, b.Length)
            bytesLeft -= n

            ' If we read less bytes than the buffer size, resize the array to avoid empty bytes
            If n < b.Length Then
                ReDim bOut(n - 1)
            End If

            ' XOR each of the bytes in the block with a byte from they key.
            For i As Integer = 0 To n - 1

                ' Perform XOR
                bOut(i) = b(i) Xor keyBytes(keyCount)

                ' Check to see if we need to reset the keycount
                If keyCount = keyBytes.GetUpperBound(0) Then
                    keyCount = 0
                Else
                    keyCount += 1
                End If

            Next

            ' Write the encrypted bytes to the stream
            fsOut.Write(bOut, 0, bOut.Length)

        End While

        ' Close streams
        fs.Close()
        fsOut.Close()


    End Sub

End Class
