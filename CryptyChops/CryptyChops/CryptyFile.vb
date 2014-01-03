Imports System.IO
Imports System.Security.Cryptography

Public Class CryptyFile

    ' TODO:
    ' Paths for encryption and compression
    ' Using a file as the key
    ' Move Hash function to a separate class
    ' Implement Encryption and Decryption
    ' Break up Encryption and Decryption into more separate functions

    Private _name As String ' The name of the object, not the actual file name.
    Private _fileInfo As FileInfo
    Private _key As String
    Private _status As String = ""
    Private _path As String
    Private _header As CryptyHeader
    Private _compress As Boolean

    Const BUFFER_SIZE As Integer = 1024
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
    ''' Gets the new File Information
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshInfo()
        _fileInfo = New FileInfo(_path)
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

        fs.Close()

        Return bytes

    End Function

    ''' <summary>
    ''' Encrypt this file with the key property
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Encrypt()
        ' Process:

        ' Hash original data
        ' Compress if Compress = true
        ' Hash compressed data
        ' Set header values
        ' Write header to file
        ' Encrypt File.

        ' Set the original name in the Header
        Header.FileName = _fileInfo.Name

        ' Open FileStream of original data file (Plain-text)
        Dim fsOrig As New FileStream(_path, FileMode.Open)

        ' Hash the original data
        Dim SHA1obj As New SHA1CryptoServiceProvider
        Header.Hash = SHA1obj.ComputeHash(fsOrig)

        fsOrig.Close()

        ' Compress the original data
        If _compress = True Then
            Header.Compressed = True
            ' !! COMPRESS DATA !!
            ' _path is now the compressed data

            ' Hash the compressed data
            Header.HashCompressed = GetSHA1(_path)
        Else
            Header.Compressed = False
        End If

        ' Write header to the file at _path
        Header.Write()

        ' !! ENCRYPT DATA !!

        Status = "Encrypted"
    End Sub

    ''' <summary>
    ''' Decrypt this file using the key
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Decrypt()
        ' Process:

        ' Decrypt Data
        ' Move data to tmpFile
        ' Get hash of tmpFile
        ' If Header.compressed = true then 
        '   Compare hash of tmpData with header.CompressedHash
        '       If the hash matches then extract the tmpFile, -> tmpFile2
        ' Compare the hash of the tmpFile2 with header.Hash
        ' If they match replace the original file

        ' !! Decrypt Data !!

        ' Get header values
        Header.Read()

        ' Move data to tmpFile
        Dim tmpFile As String = IO.Path.GetTempFileName

        Dim fReader As New FileReader(_path, BUFFER_SIZE)

        ' Move the position of the FileReader to past the header bytes
        fReader.fileStream.Seek(CryptyHeader.DATA_OFFSET, SeekOrigin.Begin)

        Dim fsTmp As New FileStream(tmpFile, FileMode.Create)

        Dim b() As Byte

        ' Copy the data from the original file to the tmp file
        While fReader.Finished = False
            b = fReader.ReadBlock
            fsTmp.Write(b, 0, b.Length)
        End While

        fsTmp.Close()
        fReader.Close()

        If Header.Compressed = True Then
            ' Compare the Compressed Hash from the header with the has of the compressed data
            If CompareByteArray(Header.HashCompressed, GetSHA1(tmpFile)) = True Then

                ' Hashes match, handle it here

                ' !! EXTRACT tmpFile -> tmpFile
            Else
                ' hashes do not match, something went wring. hanld here

                Status = "Error"

            End If
        End If

        ' At this point tmpFile should be the original data.

        ' Compare hashses again
        If CompareByteArray(Header.Hash, GetSHA1(tmpFile)) = True Then

            ' Hashes match, handle it here

            ' We can now replace the original file with the tmpFile
            fReader = New FileReader(tmpFile, BUFFER_SIZE)
            Dim fsOrig As New FileStream(_path, FileMode.Truncate)

            While fReader.Finished = False
                b = fReader.ReadBlock
                fsOrig.Write(b, 0, b.Length)
            End While

            fReader.Close()
            fsOrig.Close()

            Status = "Decrypted"
        Else
            ' hashes do not match, something went wring. hanld here
            Status = "Error"
        End If


    End Sub

    ''' <summary>
    ''' Compares two arrays of Byte
    ''' </summary>
    ''' <param name="arrayA">The first array</param>
    ''' <param name="arrayB">The second array</param>
    ''' <returns>True if the array values are the same, otherwise False</returns>
    ''' <remarks></remarks>
    Private Function CompareByteArray(arrayA() As Byte, arrayB() As Byte) As Boolean

        ' If they are not the same length, the cannot be the same
        If arrayA.Length <> arrayB.Length Then
            Return False
        End If

        ' Compare each byte of each array with the corresponding byte of the other.
        For i As Integer = 0 To arrayA.Length - 1
            If arrayA(i) <> arrayB(i) Then
                Return False
            End If
        Next

        ' If we have reached this point, both arrays are the same
        Return True

    End Function
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

