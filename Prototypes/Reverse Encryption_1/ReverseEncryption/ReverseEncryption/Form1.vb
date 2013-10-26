Imports System.IO
Public Class Form1

    ' The basic idea is that it reverses the byte array in every position then goes through again and reverses it in random positions.
    ' Decrypting is done in the opposite order encrypting is.

    Dim bytes() As Byte ' Holds the bytes of the file
    Dim reverseIndexes(9) As Integer ' Holds the indexes 
    Dim random As New Random ' Used to generate indexes

    Private Sub btnLoadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFile.Click

        ofd.ShowDialog() ' Show the OpenFileDialog

        Try
            bytes = File.ReadAllBytes(ofd.FileName) ' Get all the bytes from the selected file
        Catch ex As Exception
            MsgBox("Couldn't read bytes")
        End Try


    End Sub

    Private Sub btnGenerateIndexes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateIndexes.Click

        ' This gets random numbers, puts them into an array and displays them in the textbox
        ' The numbers are used as indexes to select points in the array of bytes to reverse from

        txtReverseIndexes.Clear()

        For i = 0 To 9
            reverseIndexes(i) = random.Next(0, bytes.GetUpperBound(0))

            txtReverseIndexes.Text &= reverseIndexes(i) & " "
        Next

    End Sub

    Private Sub btnEncryptFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncryptFile.Click

        ' Loop through the array and reverse from every position
        For i = 0 To bytes.GetUpperBound(0) Step 1

            Array.Reverse(bytes, i, bytes.GetUpperBound(0) - i) ' Loop through the array and reverse it at every position

        Next

        ' Reverse at random points
        For i = 0 To 9
            Array.Reverse(bytes, reverseIndexes(i), bytes.GetUpperBound(0) - reverseIndexes(i)) ' Loop through the array 10 times and each time use a different index to reverse from
        Next


        File.WriteAllBytes(ofd.FileName, bytes) ' Write all the bytes back to the opened file

        MsgBox("File Encrypted")

    End Sub

    Private Sub btnDecryptFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecryptFile.Click
        ' We need to decrypt in the opposite order we encrypted. Reverse at random points first then reverse from each point.


        'Reverse the array of the random indexes so it can unencrypt it.
        Array.Reverse(reverseIndexes)

        ' Then un-reverse it at those points
        For i = 0 To 9
            Array.Reverse(bytes, reverseIndexes(i), bytes.GetUpperBound(0) - reverseIndexes(i)) ' Loop through the array 10 times and each time use a different index to reverse from
        Next


        'Loop backwards through the array of bytes to un-reverse it
        For i = bytes.GetUpperBound(0) To 0 Step -1

            Array.Reverse(bytes, i, bytes.GetUpperBound(0) - i) ' Loop through the array backwards to unencrypt it

        Next


        File.WriteAllBytes(ofd.FileName, bytes) ' Write all the bytes back to the opened file

        MsgBox("File Decrypted")

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
