Public Class frmMain
    ' This is the main form of the program
    ' It is where all functions are initiated from

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        OpenFileDialog1.ShowDialog()

        Dim path As String = OpenFileDialog1.FileName

        If path <> "" Then
            frmAdd.ShowFileInfo(path)
        End If

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click
        frmEncrypt.Show()

    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click
        frmDecrypt.Show()

    End Sub
End Class
