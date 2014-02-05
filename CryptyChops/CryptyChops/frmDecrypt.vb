Public Class frmDecrypt
    ' This form is used to collect the information for decrypting the file

    Dim _cryptyFile As CryptyFile
    Private _algorithm As String = "crypty encrypt"


    Private Sub frmDecrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
    ''' The entry point for this form
    ''' </summary>
    ''' <param name="cryptyFile">The CryptyFile to set decrypt properties</param>
    ''' <remarks></remarks>
    Public Sub DecryptFile(ByVal cryptyFile As CryptyFile)
        Me.Show()

        _cryptyFile = cryptyFile

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click

        ' Set the properties for the cryptyFile to be used by the decryption algortihm
        _cryptyFile.Key = txtPass.Text

        If _algorithm = "" Then
            _algorithm = "crypty encrypt"
        End If

        _cryptyFile.algorithm = _algorithm

        _cryptyFile.Decrypt()

        If _cryptyFile.Status.ToLower = "error" Then
            MsgBox("You fool")
        Else
            frmMain.cryptyListObj.Refresh()
        End If


        Me.Close()

    End Sub

    Private Sub rbtnReverse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnReverse.CheckedChanged, rbtnNoPass.CheckedChanged, rbtnCrypty.CheckedChanged, rbtnAes.CheckedChanged
        Dim rbtn As RadioButton = CType(sender, RadioButton)

        If rbtn.Checked = True Then
            _algorithm = rbtn.Text
        End If

    End Sub

End Class