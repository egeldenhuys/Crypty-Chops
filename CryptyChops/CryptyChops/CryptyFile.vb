Imports System.IO

Public Class CryptyFile

    Private _name As String ' The name of the object, not the actual file name.
    Private _fileInfo As FileInfo
    Private _key As String


    Public Sub Encrypt()

    End Sub

    Public Sub Decrypt()

    End Sub

    Public Sub Compress()

    End Sub

    Public Sub Extract()

    End Sub

#Region "Properties"

    Public Property Key() As String
        Get
            Return _key
        End Get
        Set(ByVal value As String)
            _key = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public ReadOnly Property FileInfo() As FileInfo
        Get
            Return _fileInfo
        End Get
    End Property

#End Region

End Class
