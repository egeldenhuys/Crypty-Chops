﻿Imports System.IO

Public Class frmAdd
    ' This form is used to add a CryptyFile to the list

    Dim tmpFileInfo As FileInfo

    Private Sub this_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.ShowButtons()
    End Sub

    Private Sub frmAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Entry point for this form. Display the information on the selected file.
    ''' </summary>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Public Sub ShowFileInfo(ByVal path As String)
        Me.Show()

        tmpFileInfo = New FileInfo(path)

        ' Name
        lstInfo.Items(0).SubItems.Add(tmpFileInfo.Name)

        ' Path
        lstInfo.Items(1).SubItems.Add(tmpFileInfo.FullName)

        ' Size
        lstInfo.Items(2).SubItems.Add(tmpFileInfo.Length.ToString)

        ' Populate Textbox
        txtName.Text = tmpFileInfo.Name


    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged

        lstInfo.Items(0).SubItems(1).Text = txtName.Text

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click
        ' TODO:
        ' Create a crypty File object and show the dialog for encrypting it.
        ' Close Form
    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click
        ' TODO:
        ' Create a crypty File object and show the dialog for Decrypting it.
        ' Close Form
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim tmpItem As New CryptyFile(tmpFileInfo.FullName)

        tmpItem.Name = txtName.Text

        frmMain.cryptyListObj.Add(tmpItem)

        Me.Close()

    End Sub
End Class