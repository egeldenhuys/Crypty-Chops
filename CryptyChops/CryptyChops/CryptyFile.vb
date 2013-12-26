Imports System.IO

Public Class CryptyFile

    ' TODO:
    ' Paths for encryption and compression
    ' Using a file as the key

    Private _name As String ' The name of the object, not the actual file name.
    Private _fileInfo As FileInfo
    Private _key As String
    Private _status As String = ""
    Private _path As String
    Private _header As CryptyHeader

    Public Sub New(path As String)
        Me.Path = path
        _header = New CryptyHeader(path)

    End Sub

    ''' <summary>
    ''' Encrypt this file with the key property
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Encrypt()

    End Sub

    ''' <summary>
    ''' Decrypt this file using the key
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Decrypt()

    End Sub

    ''' <summary>
    ''' Compress this file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Compress()

    End Sub

    ''' <summary>
    ''' Extract this file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Extract()

    End Sub

#Region "Properties"

    Public Property Header() As CryptyHeader
        Get
            Return _header
        End Get
        Set(ByVal value As CryptyHeader)
            _header = value
        End Set
    End Property

    ''' <summary>
    ''' The Key that will be used to encrypt and decrypt the file
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Key() As String
        Get
            Return _key
        End Get
        Set(ByVal value As String)
            _key = value
        End Set
    End Property

    ''' <summary>
    ''' The name used to identifty the file
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    ''' <summary>
    ''' Information on the file on disk
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FileInfo() As FileInfo
        Get
            Return _fileInfo
        End Get
    End Property

    ''' <summary>
    ''' The status of the file. Encrypted or Decrypted
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Public Property Path() As String
        Get
            Return _path
        End Get
        Set(ByVal value As String)
            _path = value

            ' Get FileInfo
            _fileInfo = New FileInfo(_path)

        End Set
    End Property

#End Region


End Class

