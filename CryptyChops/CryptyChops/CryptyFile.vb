Imports System.IO
Imports System.Security.Cryptography

Public Class CryptyFile

    ' TODO:
    ' Paths for encryption and compression
    ' Using a file as the key
    ' Move Hash function to a separate class


    Private _name As String ' The name of the object, not the actual file name.
    Private _fileInfo As FileInfo
    Private _key As String
    Private _status As String = ""
    Private _path As String
    Private _header As CryptyHeader
    Private _compress As Boolean

    ''' <summary>
    ''' Create a new CryptyFile object
    ''' </summary>
    ''' <param name="path">The path of the crypty File</param>
    ''' <remarks></remarks>
    Public Sub New(path As String)
        Me.Path = path
        _header = New CryptyHeader(path)

    End Sub

    ''' <summary>
    ''' Get the SHA1 Hash of the file at the given path
    ''' </summary>
    ''' <param name="path">The path of the file to hash</param>
    ''' <returns>Byte array of the Hash</returns>
    ''' <remarks></remarks>
    Public Function GetSHA1(path As String) As Byte()
        Dim sha1Obj As New SHA1CryptoServiceProvider
        Dim bytes() As Byte

        Dim fs As New FileStream(path, FileMode.Open)

        ' Get hash
        bytes = sha1Obj.ComputeHash(fs)

        Return bytes

    End Function

    ''' <summary>
    ''' Encrypt this file with the key property
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Encrypt()

        ' TODO:
        ' Implement Encryption

    End Sub

    ''' <summary>
    ''' Decrypt this file using the key
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Decrypt()

        ' TODO:
        ' Implement Decryption

    End Sub

    ''' <summary>
    ''' Compress this file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CompressData()

        ' TODO:
        ' Implement Compression
    End Sub

    ''' <summary>
    ''' Extract this file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ExtractData()

        ' TODO:
        ' Implement Extraction
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Should the file be compressed before encryption
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Compress() As Boolean
        Get
            Return _compress
        End Get
        Set(ByVal value As Boolean)
            _compress = value
        End Set
    End Property

    ''' <summary>
    ''' The header associated with the Crypty File
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' The path of the Crypty File
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

