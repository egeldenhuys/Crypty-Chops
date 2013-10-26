Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

        txtOut.Clear()

        Dim encrypted() As Integer = EncryptData(txtIn.Text, txtKey.Text)

        For i As Integer = 0 To encrypted.Length - 1

            txtOut.Text &= ChrW(encrypted(i))
        Next

    End Sub

    Private Function EncryptData(data As String, key As String) As Integer()

        ' Equation

        ' D - Data value
        ' K - Key value
        ' E - Encrypted char value
        ' i - Data counter

        '  E = D + K + (E - 1) - i + (D - 1)

        Dim result(data.Length - 1) As Integer

        Dim keyTicker As Integer = 0

        ' Get value of data
        ' Get value of key
        ' Add value of data and key
        ' Add result to array
        ' Repeat for each data


        ' Loop through each data character and and the value of a char in the key to it
        For i As Integer = 0 To data.Length - 1

            If i = 0 Then

                ' We cant use the previous results as they do not exist yet
                result(i) = AscW(data(i)) + AscW(key(keyTicker))
            Else

                ' Apply the equation
                result(i) = CInt(AscW(data(i)) + AscW(key(keyTicker)) + result(i - 1) - i + AscW(data(i - 1)))
            End If


            If keyTicker = key.Length - 1 Then
                keyTicker = 0
            Else
                keyTicker += 1
            End If

        Next

        Return result

    End Function

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click

        txtOut.Clear()

        Dim decrypted() As Integer = DecryptData(txtIn.Text, txtKey.Text)

        For i As Integer = 0 To decrypted.Length - 1

            txtOut.Text &= ChrW(decrypted(i))
        Next

    End Sub

    Private Function DecryptData(data As String, key As String) As Integer()

        Dim result(data.Length - 1) As Integer

        Dim keyTicker As Integer = 0

        ' Loop through each data char
        For i As Integer = 0 To data.Length - 1

            If i = 0 Then

                ' We cant use the previous results as they do not exist yet
                result(i) = AscW(data(i)) - AscW(key(keyTicker))
            Else

                ' Apply the decryption equation
                result(i) = CInt(AscW(data(i)) - AscW(key(keyTicker)) - AscW(data(i - 1)) + i - result(i - 1))
            End If

            If keyTicker = key.Length - 1 Then
                keyTicker = 0
            Else
                keyTicker += 1
            End If

        Next


        Return result
    End Function

End Class
