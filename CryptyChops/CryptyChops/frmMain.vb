Imports System.IO

Public Class frmMain
    ' This is the main form of the program
    ' It is where all functions are initiated from

    ' TODO: 
    ' Managing the ListView and CryptyFiles
    ' Tooltip
    ' Status Strip
    ' Pass the selected CryptyFile object to the function form

    Public cryptyListObj As CryptyList

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cryptyListObj = New CryptyList(lstFiles)

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        ' Collect the path
        OpenFileDialog1.ShowDialog()

        Dim path As String = OpenFileDialog1.FileName

        'If the user does not select a file do not display the next window
        If path <> "" Then
            frmAdd.ShowFileInfo(path)
        End If

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

        ' TODO:
        ' Implement Encryption

        ' False Encryption for each selected file

        ' Get all the selected items
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)
        Dim index As Integer = 0

        ' Encrypt all the selected items
        For i As Integer = 0 To selItems.Count - 1
            index = cryptyListObj.GetIndex(selItems.Item(i).Name)

            cryptyListObj.FileList.Item(index).Encrypt()
            cryptyListObj.FileList.Item(index).RefreshInfo()
        Next

        cryptyListObj.refresh()

        lstFiles.Focus()
        lstFiles.Items(0).Selected = True


    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click

        ' TODO:
        ' Implement Deryption

        ' Get all the selected items
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)
        Dim index As Integer = 0

        ' Decrypt all the selected items
        For i As Integer = 0 To selItems.Count - 1
            index = cryptyListObj.GetIndex(selItems.Item(i).Name)

            cryptyListObj.FileList.Item(index).Decrypt()
            cryptyListObj.FileList.Item(index).RefreshInfo()

        Next

        cryptyListObj.Refresh()

        lstFiles.Focus()
        lstFiles.Items(0).Selected = True


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        frmDelConfirm.Show()

    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

        ' Get the name of the selected item
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

        ' Remove all selected items
        For i As Integer = 0 To selItems.Count - 1
            cryptyListObj.Remove(selItems(i).Name)
        Next

    End Sub

    Private Sub btnOpenLoc_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenLoc.Click

        ' Get all selected items
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

        ' Open the folder of each selected item
        For i As Integer = 0 To selItems.Count - 1

            ' Get file info
            Dim tmpFileInfo As New FileInfo(selItems(i).SubItems(4).Text)

            ' Pass the Directory path of the file to explorer
            Process.Start("explorer.exe", tmpFileInfo.DirectoryName)

        Next

    End Sub
End Class
