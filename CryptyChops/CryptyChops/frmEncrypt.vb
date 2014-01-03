Imports System.IO

Public Class frmEncrypt

    Dim _cryptyFile As CryptyFile

    Private Sub this_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.ShowButtons()
    End Sub

    ' This form is used to cllect information for encrypting a file
    Private Sub frmEncrypt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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
    ''' Entry point for this form
    ''' </summary>
    ''' <param name="cryptyFile"></param>
    ''' <remarks></remarks>
    Public Sub EncryptFile(cryptyFile As CryptyFile)
        Me.Show()

        _cryptyFile = cryptyFile


    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

        ' Set the properties for the cryptyFile to be used by the encryption class

        _cryptyFile.Key = txtPass.Text

        If chkCompress.Checked = True Then
            _cryptyFile.Compress = True
        Else
            _cryptyFile.Compress = False
        End If

        ' The status is set by the object when encrypted
        _cryptyFile.Encrypt()

        ' Show the user thath the file ahs been compressed
        If _cryptyFile.Status = "Encrypted" Then
            If _cryptyFile.Compress = True Then
                _cryptyFile.Status = "Encrypted (C)"
            End If
        End If

        frmMain.cryptyListObj.Refresh()
        Me.Close()

    End Sub
End Class