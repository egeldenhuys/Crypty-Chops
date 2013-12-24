Public Class CryptyList
    ' This class stores a List of CryptyFiles and manages a ListView control

    Private _listView As ListView
    Private _fileList As List(Of CryptyFile)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ownerList">The ListView control this object is responsible to manage</param>
    ''' <remarks></remarks>
    Sub New(ownerList As ListView)

    End Sub

    ''' <summary>
    ''' Adds the given object to the list
    ''' </summary>
    ''' <param name="item">The CryptyFile object to add to the list</param>
    ''' <remarks></remarks>
    Public Sub Add(item As CryptyFile)

        _fileList.Add(item)

    End Sub

    ''' <summary>
    ''' Removes the specified object from the list
    ''' </summary>
    ''' <param name="itemName"></param>
    ''' <remarks></remarks>
    Public Sub Remove(itemName As String)

    End Sub

    ''' <summary>
    ''' Refreshes the ListView control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Refresh()




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
