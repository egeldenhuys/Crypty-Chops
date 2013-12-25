﻿Public Class CryptyList
    ' This class stores a List of CryptyFiles and manages a ListView control

    Private _listView As ListView
    Private _fileList As New List(Of CryptyFile)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ownerList">The ListView control this object is responsible to manage</param>
    ''' <remarks></remarks>
    Sub New(ownerList As ListView)
        _listView = ownerList

    End Sub

    ''' <summary>
    ''' Adds the given object to the list
    ''' </summary>
    ''' <param name="item">The CryptyFile object to add to the list</param>
    ''' <remarks></remarks>
    Public Sub Add(item As CryptyFile)

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
    Public Sub Remove(itemName As String)

        ' Remove the item from the List
        For i As Integer = 0 To _fileList.Count - 1
            If _fileList.Item(i).Name = itemName Then
                _fileList.RemoveAt(i)

                ' Exit the loop, as the number of indices in _fileList has now changed.
                Exit For
            End If
        Next

        ' Add all items from the fileList to the ListView
        Refresh()

    End Sub

    ''' <summary>
    ''' Removes the specified object from the list
    ''' </summary>
    ''' <param name="index">The index of the item in the list to remove</param>
    ''' <remarks></remarks>
    Public Sub Remove(index As Integer)

        ' Remove the item from the List
        _fileList.RemoveAt(index)

        ' Add all items from the fileList to the ListView
        Refresh()

    End Sub

    ''' <summary>
    ''' Refreshes the ListView control, with the items from the FileList
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Refresh()

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

#Region "Properties"
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
