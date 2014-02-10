Imports System.Text
Imports System.IO

Public Class CryptyList
    ' This class stores a List of CryptyFiles and manages a ListView control

    Private _listView As ListView
    Private _fileList As New List(Of CryptyFile) ' The list of CryptyFiles that are displayed in the ListView

    ''' <summary>
    ''' Create a new CryptyList object
    ''' </summary>
    ''' <param name="ownerList">The ListView control this object is responsible to manage</param>
    ''' <remarks></remarks>
    Sub New(ByVal ownerList As ListView)
        _listView = ownerList

    End Sub

    ''' <summary>
    ''' Returns the CryptyFile with the given name
    ''' </summary>
    ''' <param name="name">The name of the cryptyFile object to return</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetObjByName(ByVal name As String) As CryptyFile

        Return _fileList.Item(GetIndex(name))

    End Function

    ''' <summary>
    ''' Returns the index of the CryptyFile with the given name
    ''' </summary>
    ''' <param name="name">The name of the item to find</param>
    ''' <returns></returns>
    ''' <remarks>Returns -1 if the item was not found</remarks>
    Public Function GetIndex(ByVal name As String) As Integer

        For i As Integer = 0 To _fileList.Count - 1
            If _fileList.Item(i).Name = name Then
                Return i
            End If
        Next

        Return -1
    End Function

    ''' <summary>
    ''' Adds the given object to the list
    ''' </summary>
    ''' <param name="item">The CryptyFile object to add to the list</param>
    ''' <remarks></remarks>
    Public Sub Add(ByVal item As CryptyFile)

        ' Add the item to the list
        _fileList.Add(item)

        ' Add all items from the fileList to the ListView
        Refresh()

    End Sub

    ''' <summary>
    ''' Removes the specified object from the list
    ''' </summary>
    ''' <param name="itemName">The name (identifier) of the item to remove</param>
    ''' <remarks></remarks>
    Public Sub Remove(ByVal itemName As String)

        ' Remove the item from the List
        For i As Integer = 0 To _fileList.Count - 1
            If _fileList.Item(i).Name = itemName Then
                _fileList.RemoveAt(i)

                ' Exit the loop, as the number of indices in _fileList has now changed.
                Exit For
            End If
        Next

        Refresh()

    End Sub

    ''' <summary>
    ''' Removes the specified object from the list
    ''' </summary>
    ''' <param name="index">The index of the item in the list to remove</param>
    ''' <remarks></remarks>
    Public Sub Remove(ByVal index As Integer)

        ' Remove the item from the List
        _fileList.RemoveAt(index)

        ' Add all items from the fileList to the ListView
        Refresh()

    End Sub

    ''' <summary>
    ''' Refreshes the ListView control, with the items from the FileList
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Refresh()

        ' Remove all items from the ListView
        _listView.Items.Clear()

        ' Add all items from the _fileList
        For i As Integer = 0 To _fileList.Count - 1
            Dim tmpItem As New ListViewItem

            ' Identifier
            tmpItem.Name = _fileList.Item(i).Name

            ' File Name
            tmpItem.Text = _fileList.Item(i).Name

            ' Status
            tmpItem.SubItems.Add(_fileList.Item(i).Status)

            ' Size
            tmpItem.SubItems.Add(_fileList.Item(i).FileInfo.Length.ToString)

            ' Date Modified
            tmpItem.SubItems.Add(_fileList.Item(i).FileInfo.LastWriteTime.ToString)

            ' Path
            tmpItem.SubItems.Add(_fileList.Item(i).FileInfo.FullName)

            ' Add the item to the ListView
            _listView.Items.Add(tmpItem)
        Next

    End Sub

    ''' <summary>
    ''' Saves the listView items to a file which is then encrypted
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveList()
        '' CCFL = Crypty Chops File List
        
        If IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypty-Chops") = False Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypty-Chops")
        End If
        
        FileOpen(1, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypty-Chops\FileList.ccfl", OpenMode.Output)

        If _listView.Items.Count > 0 Then
            For i As Integer = 0 To _listView.Items.Count - 1 '' Iterate through the file list and print each path to a textfile.
                PrintLine(1, _fileList.Item(i).Path)
            Next
        End If

        FileClose(1)

    End Sub

    Public Sub LoadList()

        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypty-Chops\FileList.ccfl") Then

            FileOpen(1, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypty-Chops\FileList.ccfl", OpenMode.Input)

            While Not EOF(1)
                Try
                    Dim item As New CryptyFile(LineInput(1))

                    frmMain.cryptyListObj.Add(item)
                Catch ex As Exception
                    MsgBox("Couldn't load file list")
                End Try
            End While

            FileClose(1)

            Refresh()

        End If

    End Sub

#Region "Properties"
    ''' <summary>
    ''' Returns the List(of CryptyFile)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FileList() As List(Of CryptyFile)
        Get
            Return _fileList
        End Get
        Set(ByVal value As List(Of CryptyFile))
            _fileList = value
        End Set
    End Property
#End Region

End Class
