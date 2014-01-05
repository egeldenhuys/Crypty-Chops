Public Class frmDecrypt
    ' This form is used to collect the information for decrypting the file

    Dim _cryptyFile As CryptyFile

    Private Sub frmDecrypt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub this_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.ShowButtons()
    End Sub

    Private Sub chbFile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbFile.CheckedChanged

        ' If 'Use File as Key' is checked, disable the password text box and enable the file browser
        If chbFile.Checked = True Then
            grpFilepath.Enabled = True
            txtPass.Enabled = False

        Else
            grpFilepath.Enabled = False
            txtPass.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' The entry point for this form
    ''' </summary>
    ''' <param name="cryptyFile">The CryptyFile to set decrypt properties</param>
    ''' <remarks></remarks>
    Public Sub DecryptFile(cryptyFile As CryptyFile)
        Me.Show()

        _cryptyFile = cryptyFile

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click

        ' Set the properties for the cryptyFile to be used by the decryption algortihm
        _cryptyFile.Key = txtPass.Text

        _cryptyFile.Decrypt()

        frmMain.cryptyListObj.Refresh()
        Me.Close()

    End Sub
End Class