Imports System.Text

'' Need error catching. If file is open in another program, it causes a crash.
'' -- Clicking Encrypt while no file is selected causes a crash (Unable to replicate)
'' ApplyAlgorithm spelt wrong

Public Class Cryptography
    ' This class will store the functions for encrypting and decrypting bytes

    Const BUFFER_SIZE As Integer = 1024

    Public Class Reverse

        Public Shared Sub ApplyAlgorithm(ByVal sourcePath As String, ByVal destPath As String)
            Array.Reverse(GetFileBytes(sourcePath))
        End Sub

    End Class

    Public Class AES

        Public Shared Sub Encrypt(ByVal sourcePath As String, ByVal destPath As String, ByVal key As String)
            EncryptString(GetFileBytes(sourcePath), key)

        End Sub

        Public Shared Sub Decrypt(ByVal sourcePath As String, ByVal destPath As String, ByVal key As String)
            DecryptString(GetFileBytes(sourcePath), key)
        End Sub

    End Class

    Public Class CryptyEncrypt

        Public Shared Sub ApplyAlgorithm(ByVal sourcePath As String, ByVal destPath As String, ByVal key() As Byte)

        End Sub

    End Class

    Public Shared Function GetFileBytes(ByVal path As String) As Byte()

        Dim fileBytes() As Byte = Nothing
        Dim reader As New FileReader(path, 1024)

        While reader.Finished = False
            fileBytes = reader.ReadBlock
        End While

        reader.Close()

        Return fileBytes

    End Function

    Public Shared Function EncryptString(ByVal fileBytes() As Byte, ByVal key As String) As String

        ' Hash the key
        Dim keyHash As String = EncryptSHA256Managed(key)

        Dim rawBytes() As Byte = fileBytes ' The cleartext bytes
        Dim keyBytes() As Byte = StringToBytes(keyHash) ' The hashed key bytes
        Dim encryptBytes(fileBytes.Length - 1) As Byte ' Array for encrypted bytes


        ' Encryption algortithm

        ' Xor raw bytes with key byte

        ' if using the first key byte add the last key byte to the encrypted byte
        ' else add the previous key byte

        ' Tick key counter

        ' if all key bytes used generate new key bytes
        ' keyBytes = Hash(encrypted block as a string + current key string)


        Dim keyCounter As Integer = 0 ' A counter for incrementing the key byte (ticker)
        Dim byteCount As Integer = 0 ' A counter for how many bytes have been encrypted (ticker)
        Dim rounds As Integer = 0 ' How many times a new hash has been generated

        For i As Integer = 0 To fileBytes.Length - 1

            ' XOR raw byte with key byte
            encryptBytes(i) = rawBytes(i) Xor keyBytes(keyCounter)


            ' Tick the key counter
            If keyCounter = keyBytes.GetUpperBound(0) Then
                keyCounter = 0
            Else
                keyCounter += 1
            End If

            ' when all bytes used in current key generate a new keyhash using the encrypted bytes and the previous key

            If byteCount = keyBytes.GetUpperBound(0) Then
                byteCount = 0
                rounds += 1

                ' Create array for storing new bytes
                Dim newKeyBytes(keyBytes.GetUpperBound(0)) As Byte

                ' Get the encrypted bytes to be hashed
                For j As Integer = 0 To keyBytes.GetUpperBound(0)

                    ' Get the new encrypted bytes that have not been used before
                    newKeyBytes(j) = encryptBytes(j * rounds)
                Next

                ' Convert the bytes to a string, add the current hash
                Dim newKeyHash As String = BytesToString(newKeyBytes)

                ' Add the current hash
                newKeyHash &= BytesToString(keyBytes)

                ' Hash the new key
                newKeyHash = EncryptSHA256Managed(newKeyHash)

                ' Convert the hashed key to bytes and set new array
                keyBytes = StringToBytes(newKeyHash)

            Else
                byteCount += 1
            End If

        Next

        ' Convert the encrypted bytes to a string again and return

        Return BytesToString(encryptBytes)

    End Function

    Public Shared Function DecryptString(ByVal fileBytes() As Byte, ByVal key As String) As String

        ' Hash the key
        Dim keyHash As String = EncryptSHA256Managed(key)

        Dim encryptBytes() As Byte = fileBytes ' The cleartext bytes
        Dim keyBytes() As Byte = StringToBytes(keyHash) ' The hashed key bytes
        Dim decryptBytes(fileBytes.Length - 1) As Byte ' Array for decrypted bytes

        ' Decryption Algorithm

        ' Xor encrypted byte with key byte

        ' if using the first key byte subtract the last key byte from the Xored  byte
        ' else subtract the previous key byte

        ' Tick key counter

        ' if all key bytes used generate new key bytes
        ' keyBytes = Hash(encrypted block as a string + current key string)

        Dim keyCounter As Integer = 0 ' A counter for incrementing the key byte (ticker)
        Dim byteCount As Integer = 0 ' A counter for how many bytes have been encrypted (ticker)
        Dim rounds As Integer = 0 ' How many times a new hash has been generated

        For i As Integer = 0 To fileBytes.Length - 1

            ' XOR raw byte with key byte
            decryptBytes(i) = encryptBytes(i) Xor keyBytes(keyCounter)


            ' To avoid repition appearing in encrypted bytes

            'If keyCounter > 0 Then
            'decryptBytes(i) += keyBytes(keyCounter - 1)
            ' Else
            'decryptBytes(i) += keyBytes(keyBytes.GetUpperBound(0))
            'End If


            ' Tick the key counter
            If keyCounter = keyBytes.GetUpperBound(0) Then
                keyCounter = 0
            Else
                keyCounter += 1
            End If

            ' when all bytes used in current key generate a new keyhash using the encrypted bytes and the previous key

            If byteCount = keyBytes.GetUpperBound(0) Then
                byteCount = 0
                rounds += 1

                ' Create array for storing new bytes
                Dim newKeyBytes(keyBytes.GetUpperBound(0)) As Byte

                ' Get the encrypted bytes to be hashed
                For j As Integer = 0 To keyBytes.GetUpperBound(0)

                    ' Get the new encrypted bytes that have not been used before
                    newKeyBytes(j) = encryptBytes(j * rounds)
                Next

                ' Convert the bytes to a string, add the current hash
                Dim newKeyHash As String = BytesToString(newKeyBytes)

                ' Add the current hash
                newKeyHash &= BytesToString(keyBytes)

                ' Hash the new key
                newKeyHash = EncryptSHA256Managed(newKeyHash)

                ' Convert the hashed key to bytes and set new array
                keyBytes = StringToBytes(newKeyHash)

            Else
                byteCount += 1
            End If

        Next

        ' Convert the encrypted bytes to a string again and return

        Return BytesToString(decryptBytes)


    End Function

    Public Shared Function StringToBytes(ByVal text As String) As Byte()

        Dim bytes(text.Length - 1) As Byte

        ' Convert each character to a byte
        For i As Integer = 0 To text.Length - 1
            bytes(i) = CByte(Asc(text(i)))
        Next

        Return bytes

    End Function

    Public Shared Function BytesToString(ByVal bytes() As Byte) As String

        Dim text As String = ""

        ' Convert each byte to a character
        For i As Integer = 0 To bytes.GetUpperBound(0)

            text &= ChrW(bytes(i))

        Next

        ' check for 3 bytes

        Return text

    End Function

    ' sample code by the ref: http://www.htmlforums.com/asp-and-aspnet/t-sha256-encryption-in-aspnet-20-83659.html
    Public Shared Function EncryptSHA256Managed(ByVal ClearString As String) As String
        Dim uEncode As New UnicodeEncoding()
        Dim bytClearString() As Byte = uEncode.GetBytes(ClearString)
        Dim sha As New System.Security.Cryptography.SHA256Managed()
        Dim hash() As Byte = sha.ComputeHash(bytClearString)
        Return Convert.ToBase64String(hash)
    End Function

End Class