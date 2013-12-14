Public Class ListViewManager
    ' This class is used to manage the ListView Control
    ' Any functions that make using the controll faster or easier should be\
    ' added in here

    Private _parent As ListView
    Private _items() As ListViewItem

    Public Sub New(ByVal parent As ListView)
        _parent = parent
    End Sub

    ''' <summary>
    ''' Add a item to the ListView control
    ''' </summary>
    ''' <param name="key">The key used to identify the item</param>
    ''' <param name="subItems">The values to display. Index 0 is the first sub item</param>
    ''' <remarks></remarks>
    Public Sub AddItem(ByRef key As String, ByRef subItems() As String)

        Dim item As New ListViewItem

        item.Name = key

        ' Add all the sub items to the item
        For i As Integer = 0 To subItems.GetUpperBound(0)

            If i = 0 Then
                ' The value in the first column

                ' The first value can be accessed with
                '   ListView.Items(i).Text
                ' OR
                '   ListView.Items(i).SubItems(0).Text
                ' However you can not set the first value using a subitem

                item.SubItems(0).Text = subItems(0)
            Else
                ' Values in the other columns
                item.SubItems.Add(subItems(i))
            End If

        Next

        ' Add the item to the control
        _parent.Items.Add(item)

    End Sub

#Region "Properties"
    ''' <summary>
    ''' The ListView control this class is to manage
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Parent() As ListView

        Get
            Return _parent
        End Get

        Set(ByVal value As ListView)
            _parent = value
        End Set

    End Property
#End Region

End Class
