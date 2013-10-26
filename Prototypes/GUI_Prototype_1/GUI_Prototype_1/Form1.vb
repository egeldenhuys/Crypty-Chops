Imports System.IO

Public Class Form1

    Dim userFiles As New List(Of UserFile)


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        AddFile("Encryted", "Assignments", "C:/Porn.zip")
        AddFile("dfgdfg", "Assignmen233ts", "C:/Porn.z3ip")
        AddFile("Encryghjghjted", "Assig33nments", "C:/Po6rn.zip")
        AddFile("Encryt3ed", "Ass4ignments", "C:/P5orn.zip")


    End Sub

    ' Test sub for adding a new file to the list
    Private Sub AddFile(status As String, name As String, path As String)

        ' Create the userFile
        Dim tmpUserFile As New UserFile(status, name, path)

        ' Add it to the list
        userFiles.Add(tmpUserFile)


        ' Create the tmp listView item
        Dim tmpListItem As New ListViewItem

        tmpListItem.Text = tmpUserFile.status
        tmpListItem.SubItems.Add(tmpUserFile.name)
        tmpListItem.SubItems.Add(tmpUserFile.path)

        ' Add this item to the list view

        lstView1.Items.Add(tmpListItem)


    End Sub

    Private Sub RefreshListView()
        lstView1.Items.Clear()

        ' Loop through each userFile item in the list

        For i As Integer = 0 To userFiles.Count - 1
            ' Convert it to a ListViewItem
            lstView1.Items.Add(CListItem(userFiles(i)))
        Next

    End Sub

    Private Function CListItem(userFile As UserFile) As ListViewItem

        ' Create the tmp listView item
        Dim tmpListItem As New ListViewItem

        tmpListItem.Text = userFile.status
        tmpListItem.SubItems.Add(userFile.name)
        tmpListItem.SubItems.Add(userFile.path)

        Return tmpListItem

    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim rnd As New Random

        ' Change the name of each selected item to a random number.
        ' Example of how you would change the data...

        Dim selected As ListView.SelectedIndexCollection = lstView1.SelectedIndices

        For i As Integer = 0 To selected.Count - 1
            userFiles.Item(selected(i)).name = CStr(rnd.Next(10000000))
        Next

        RefreshListView()

    End Sub
End Class

''' <summary>
''' This class will be used to store information on the files the user adds
''' </summary>
''' <remarks></remarks>
Public Class UserFile

    Public status, name, path As String

    ''' <summary>
    ''' Create a new userFile object and populate paramaters
    ''' </summary>
    ''' <param name="fileStatus"></param>
    ''' <param name="fileName"></param>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Sub New(fileStatus As String, fileName As String, filePath As String)

        status = fileStatus
        name = fileName
        path = filePath


    End Sub


End Class
