Public Class frmEncrypt

    Private Sub frmEncrypt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chbFile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbFile.CheckedChanged

        If chbFile.Checked = True Then
            grpFilepath.Enabled = True
            txtPass.Enabled = False

        Else
            grpFilepath.Enabled = False
            txtPass.Enabled = True
        End If

    End Sub
    
End Class