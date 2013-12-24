Public Class frmMain
    ' This is the main form of the program
    ' It is where all functions are initiated from

    ' TODO: 
    ' Managing the ListView and CryptyFiles
    ' Tooltip
    ' Status Strip
    ' Pass the selected CryptyFile object to the function form

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        ' Collect the path
        OpenFileDialog1.ShowDialog()

        Dim path As String = OpenFileDialog1.FileName

        'If the user does not select a file do not display the next window
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

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        frmDelConfirm.Show()

    End Sub
End Class
