Imports System.IO

Public Class frmDelConfirm

    Private _cryptyObj As CryptyFile
    ' This form asks the user to confirm wether they want to delete the file from the disk

    Private Sub frmDelConfirm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    ''' <summary>
    ''' Entry point for this form
    ''' </summary>
    ''' <param name="cryptyObj"></param>
    ''' <remarks></remarks>
    Public Sub DeleteFile(cryptyObj As CryptyFile)
        Me.Show()

        _cryptyObj = cryptyObj

        Dim fileInfo As New FileInfo(cryptyObj.Path)


        ' Display the file information for the user

        ' Name
        lstInfo.Items(0).SubItems.Add(fileInfo.Name)

        ' Path
        lstInfo.Items(1).SubItems.Add(fileInfo.FullName)

        ' Size
        lstInfo.Items(2).SubItems.Add(fileInfo.Length.ToString)

        ' Status
        lstInfo.Items(3).SubItems.Add(cryptyObj.Status)

        ' Date Modified
        lstInfo.Items(4).SubItems.Add(fileInfo.LastWriteTime.ToString)


    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        My.Computer.FileSystem.DeleteFile(_cryptyObj.Path)

        ' Remove the object we have just deleted from the list.
        frmMain.cryptyListObj.Remove(frmMain.cryptyListObj.GetIndex(_cryptyObj.Name))

        Me.Close()

    End Sub
End Class