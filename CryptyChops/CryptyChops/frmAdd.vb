Imports System.IO

Public Class frmAdd
    ' This form is used to add files to the ListView

    Private Sub frmAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstInfo.Items.Clear()

    End Sub

    Public Sub ShowFileInfo(ByVal path As String)
        Me.Show()

        Dim fileInfo As New FileInfo(path)

        Dim lstMan As New ListViewManager(lstInfo)

        ' Display the file properties in the ListView
        lstMan.AddItem("name", {"Name", fileInfo.Name})
        lstMan.AddItem("path", {"Path", fileInfo.FullName})
        lstMan.AddItem("size", {"Size (bytes)", fileInfo.Length.ToString})

        ' Used for editing the name of the file
        txtName.Text = fileInfo.Name

    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged

        lstInfo.Items("name").SubItems(1).Text = txtName.Text

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class