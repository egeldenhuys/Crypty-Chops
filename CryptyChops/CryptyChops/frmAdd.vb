Imports System.IO

Public Class frmAdd
    ' This form is used to add a CryptyFile to the list

    Private Sub frmAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Clear the items in the ListView that are used for reference in the designer
        lstInfo.Items.Clear()

    End Sub

    ''' <summary>
    ''' Entry point for this form. Display the information on the selected file.
    ''' </summary>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Public Sub ShowFileInfo(ByVal path As String)
        Me.Show()

        'TODO:
        ' Show file information

    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged
        ' TODO:
        ' Update the text in the ListView
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        ' Close Form
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
        'TODO:
        ' Create a cryptyFile object and add it the the CryptyList.
        ' Close Form
    End Sub
End Class