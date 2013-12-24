Imports System.IO

Public Class frmAdd
    ' This form is used to add a CryptyFile to the list

    ' TODO:
    ' Display file information
    ' Ability to edit file name

    Private Sub frmAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstInfo.Items.Clear()

    End Sub

    Public Sub ShowFileInfo(ByVal path As String)
        Me.Show()


    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged


    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Me.Close()

    End Sub
End Class