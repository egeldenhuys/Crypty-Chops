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
    Public algorithm As String

    Const BUFFER_SIZE As Integer = 1024
    ''' <summary>
    ''' Create a new CryptyFile object
    ''' </summary>
    ''' <param name="path">The path of the crypty File</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal path As String)
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
    Public Function GetSHA1(ByVal path As String) As Byte()
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

        ' Set the original name in the Header
        'Header.FileName = _fileInfo.Name

        ' Hash the original data
        Header.Hash = GetSHA1(_path)

        ' Compress the original data
        If _compress = True Then
            Header.Compressed = True
            CompressData()

            ' Hash the compressed data
            Header.HashCompressed = GetSHA1(_path)
        Else
            Header.Compressed = False
        End If

        ' Encrypt the data

        Select Case algorithm.ToLower
            Case "crypty encrypt"
                ' Write header to the file at _path
                Header.Write()

                CryptyEncrypt()

            Case "no password"
                Header.Write()
            Case "reverse"
                ReverseEncrypt()
            Case "aes"
                Header.Write()
        End Select

        RefreshInfo()
        Status = "Encrypted"
    End Sub

    ''' <summary>
    ''' Decrypt this file using the key
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Decrypt()

        ' Create backup

        Dim backupPath As String = System.IO.Path.GetTempFileName

        My.Computer.FileSystem.CopyFile(_path, backupPath, True)

        Select Case algorithm.ToLower
            Case "crypty encrypt"
                CryptyEncrypt()
            Case "no password"
            Case "reverse"
                ReverseEncrypt()
            Case "aes"
        End Select

        ' Get header values
        Header.Read()

        ' Move data to a tmpFile so we can get the hash
        Dim tmpFile As String = IO.Path.GetTempFileName

        Dim fReader As New FileReader(_path, BUFFER_SIZE)

        ' Move the position of the FileReader to past the header bytes
        fReader.fileStream.Seek(CryptyHeader.DATA_OFFSET, SeekOrigin.Begin)

        fReader.ReplaceFile(tmpFile)

        If algorithm <> "reverse" Then
            If Header.Compressed = True Then

                ' Compare hash of compressed data
                If CompareByteArray(Header.HashCompressed, GetSHA1(tmpFile)) = True Then

                    ExtractData()
                Else
                    Status = "Error"

                End If
            End If

            ' Compare hash of original data
            If CompareByteArray(Header.Hash, GetSHA1(tmpFile)) = True Then

                ' Replace the original file with the tmpFile by using the FileReader class
                fReader = New FileReader(tmpFile, BUFFER_SIZE)
                fReader.ReplaceFile(_path)

                Status = "Decrypted"
            Else
                Status = "Error"
                My.Computer.FileSystem.MoveFile(backupPath, _path, True)
            End If

            Status = "Decrypted"
        Else
            Status = "Error"
        End If

        RefreshInfo()

    End Sub

    ''' <summary>
    ''' Compares two arrays of Byte
    ''' </summary>
    ''' <param name="arrayA">The first array</param>
    ''' <param name="arrayB">The second array</param>
    ''' <returns>True if the array values are the same, otherwise False</returns>
    ''' <remarks></remarks>
    Private Function CompareByteArray(ByVal arrayA() As Byte, ByVal arrayB() As Byte) As Boolean

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
        Dim compressor As New Compression(_path)

        compressor.Compress()
    End Sub

    ''' <summary>
    ''' Extract this file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ExtractData()

        ' TODO:
        ' Implement Extraction
    End Sub

    Private Sub CryptyEncrypt()
        ' Create new instance of the cryptogtaphy class for encrypting
        Dim cryptyObj As New Cryptography.CryptyEncrypt

        ' For hashing the password to be used as the key
        Dim hasher As New System.Security.Cryptography.SHA1Managed

        ' Set the key for encryption
        cryptyObj.key = hasher.ComputeHash(System.Text.UnicodeEncoding.UTF8.GetBytes(_key))

        ' original plaintext file stream
        Dim fReaderOrig As New FileReader(_path, BUFFER_SIZE)

        ' tmp path for encrypted file
        Dim tmpPath As String = System.IO.Path.GetTempFileName()

        ' Encrypted file stream
        Dim fStreamCrypt As New FileStream(tmpPath, FileMode.Truncate, FileAccess.Write)

        Dim b() As Byte ' byte array for storing encrypted bytes

        While fReaderOrig.Finished = False

            ' Get bytes from original file
            b = fReaderOrig.ReadBlock()

            ' Encrypt the bytes
            b = cryptyObj.ApplyAlgorithm(b)

            ' Write the bytes to the tmp file
            fStreamCrypt.Write(b, 0, b.Length)

        End While

        fStreamCrypt.Close()
        fReaderOrig.Close()

        ' Replace the original file
        Dim fReaderTmp As New FileReader(tmpPath, BUFFER_SIZE)
        fReaderTmp.ReplaceFile(_path)
        fReaderTmp.Close()
    End Sub


    Private Sub ReverseEncrypt()
        ' Create new instance of the cryptogtaphy class for encrypting
        Dim cryptyObj As New Cryptography.Reverse

        ' original plaintext file stream
        Dim fReaderOrig As New FileReader(_path, BUFFER_SIZE)

        ' tmp path for encrypted file
        Dim tmpPath As String = System.IO.Path.GetTempFileName()

        ' Encrypted file stream
        Dim fStreamCrypt As New FileStream(tmpPath, FileMode.Truncate, FileAccess.Write)

        Dim b() As Byte ' byte array for storing encrypted bytes

        While fReaderOrig.Finished = False

            ' Get bytes from original file
            b = fReaderOrig.ReadBlock()

            ' Encrypt the bytes
            b = cryptyObj.ApplyAlgorithm(b)

            ' Write the bytes to the tmp file
            fStreamCrypt.Write(b, 0, b.Length)

        End While

        fStreamCrypt.Close()
        fReaderOrig.Close()

        ' Replace the original file
        Dim fReaderTmp As New FileReader(tmpPath, BUFFER_SIZE)
        fReaderTmp.ReplaceFile(_path)
        fReaderTmp.Close()

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

