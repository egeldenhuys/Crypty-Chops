Imports System.IO

Public Class frmEncrypt

    ' This form is used to collect information for encrypting a file

    Dim _cryptyFile As CryptyFile

    Private Sub frmEncrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub this_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmMain.ShowButtons()

    End Sub

    Private Sub chbFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFile.CheckedChanged

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
    ''' <param name="cryptyFile">The cryptyFile to set properties on</param>
    ''' <remarks></remarks>
    Public Sub EncryptFile(ByVal cryptyFile As CryptyFile)

        Me.Show()

        _cryptyFile = cryptyFile


    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click

        ' Set the properties for the cryptyFile to be used by the encryption class

        _cryptyFile.Key = txtPass.Text

        If chkCompress.Checked = True Then
            _cryptyFile.Compress = True
        Else
            _cryptyFile.Compress = False
        End If

        '' Which encryption method to use
        Dim method As String
        If rbtnAes.Checked = True Then
            method = "AES"
        ElseIf rbtnCrypty.Checked = True Then
            method = "Crypty"
        ElseIf rbtnNoPass.Checked = True Then
            method = "No Pass"
        ElseIf rbtnReverse.Checked = True Then
            method = "Reverse"
        Else
            method = "None"
        End If

        ' The status is set by the object when encrypted
        _cryptyFile.Encrypt(method)

        ' Show the user that the file has been compressed
        If _cryptyFile.Status = "Encrypted" Then
            If _cryptyFile.Compress = True Then
                _cryptyFile.Status = "Encrypted (C)"
            End If
        End If

        frmMain.cryptyListObj.Refresh()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

        frmMain.ShowButtons()
    End Sub
End Class