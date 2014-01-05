Imports System.IO
Imports System.Text

Public Class CryptyHeader

    ' This class is used to read and write Crypty Headers.

    ' TODO:
    ' Return the properties as strings and integers. Convert Bytes to appropriate types

    Private _fileName() As Byte
    Private _hash() As Byte
    Private _hashCompressed() As Byte
    Private _path As String
    Private _partNum() As Byte
    Private _partsTotal() As Byte
    Private _compressed() As Byte
    Private _version() As Byte = {&H1, &H0, &H0, &H0}

    Const BUFFER_SIZE As Integer = 1024

#Region "Header Constants"

    Const FILE_NAME_OFFSET = 0
    Const FILE_NAME_COUNT = 64

    Const HASH_OFFSET = FILE_NAME_OFFSET + FILE_NAME_COUNT
    Const HASH_COUNT = 20

    Const HASH_C_OFFSET = HASH_OFFSET + HASH_COUNT
    Const HASH_C_COUNT = 20

    Const PART_NUM_OFFSET = HASH_C_OFFSET + HASH_C_COUNT
    Const PART_NUM_COUNT = 4
    Const PART_TOTAL_OFFSET = PART_NUM_OFFSET + PART_NUM_COUNT
    Const PART_TOTAL_COUNT = 4

    Const COMPRESSED_OFFSET = PART_TOTAL_OFFSET + PART_TOTAL_COUNT
    Const COMPRESSED_COUNT = 1

    Const VERSION_OFFSET = COMPRESSED_OFFSET + COMPRESSED_COUNT
    Const VERSION_COUNT = 4

    Public Const DATA_OFFSET = VERSION_OFFSET + VERSION_COUNT
#End Region

    ''' <summary>
    ''' Create new Header Object
    ''' </summary>
    ''' <param name="filePath">The path of the file for writing and reading a Crypty Header</param>
    ''' <remarks></remarks>
    Public Sub New(filePath As String)

        _path = filePath

    End Sub

    ''' <summary>
    ''' Read the values from the header
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Read()
        Dim fs As New FileStream(_path, FileMode.Open)

        Dim b(FILE_NAME_COUNT - 1) As Byte
        ' File Name
        fs.Read(b, 0, FILE_NAME_COUNT)
        _fileName = b

        ReDim b(HASH_COUNT - 1)
        ' plain-text data hash
        fs.Read(b, 0, HASH_COUNT)
        _hash = b

        ReDim b(HASH_C_COUNT - 1)
        ' compressed data hash
        fs.Read(b, 0, HASH_C_COUNT)
        _hashCompressed = b

        ReDim b(PART_NUM_COUNT - 1)
        ' Part Num
        fs.Read(b, 0, PART_NUM_COUNT)
        _partNum = b

        ReDim b(PART_TOTAL_COUNT - 1)
        ' Parts Total
        fs.Read(b, 0, PART_TOTAL_COUNT)
        _partsTotal = b

        ReDim b(COMPRESSED_COUNT - 1)
        ' Compressed
        fs.Read(b, 0, COMPRESSED_COUNT)
        _compressed = b

        ReDim b(VERSION_COUNT - 1)
        ' Version
        fs.Read(b, 0, VERSION_COUNT)
        _version = b

        fs.Close()

    End Sub

    ''' <summary>
    ''' Write the header to the file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Write()

        ' Check values

        If _hashCompressed Is Nothing Then
            ReDim _hashCompressed(HASH_C_COUNT - 1)
        End If

        If _partNum Is Nothing Then
            ReDim _partNum(PART_NUM_COUNT - 1)
        End If

        If _partsTotal Is Nothing Then
            ReDim _partsTotal(PART_TOTAL_COUNT - 1)
        End If

        If _compressed Is Nothing Then
            ReDim _compressed(COMPRESSED_COUNT - 1)
        End If

        ' Process
        ' Write header to tmpFile
        ' Write data to tmpFile
        ' Overwrite original file with tmpFile

        Dim tmpFile As String = System.IO.Path.GetTempFileName

        Dim fsTmp As New FileStream(tmpFile, FileMode.Create)

            ' FileName
            fsTmp.Write(_fileName, 0, FILE_NAME_COUNT)

            ' plain-text Hash
            fsTmp.Write(_hash, 0, HASH_COUNT)

            ' compressed data Hash
            fsTmp.Write(_hashCompressed, 0, HASH_C_COUNT)

            ' Part Num
            fsTmp.Write(_partNum, 0, PART_NUM_COUNT)

            ' Parts Total
            fsTmp.Write(_partsTotal, 0, PART_TOTAL_COUNT)

            ' Compressed
            fsTmp.Write(_compressed, 0, COMPRESSED_COUNT)

            ' Version
            fsTmp.Write(_version, 0, VERSION_COUNT)

            ' Write the plain-text data to the tmp file with the header
            Dim fsOrig As New FileReader(_path, BUFFER_SIZE)

            Dim b() As Byte

            ' Read and write blocks until there are no more bytes left
            While fsOrig.Finished = False
                b = fsOrig.ReadBlock
                fsTmp.Write(b, 0, b.Length)
            End While

            ' Clean up
            fsOrig.Close()
            fsTmp.Close()

            ' Replace Files
        My.Computer.FileSystem.MoveFile(tmpFile, _path, True)


    End Sub

    ''' <summary>
    ''' Remove the header from the current file. Do not use if there is no header.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Remove()

        ' Write data to tmpFile, excluding the header
        ' Replace original file with tmpFile
        Dim tmpFile As String = System.IO.Path.GetTempFileName

        Dim fsTmp As New FileStream(tmpFile, FileMode.Open)

        Dim fReader As New FileReader(_path, BUFFER_SIZE)

        ' Skip the header.
        fReader.fileStream.Seek(DATA_OFFSET, SeekOrigin.Begin)

        Dim b() As Byte

        While fReader.Finished = False
            ' Read block from original file
            b = fReader.ReadBlock()

            ' Write to tmp File
            fsTmp.Write(b, 0, b.Length)

        End While

        ' Clean up
        fsTmp.Close()
        fReader.Close()

        ' Replace files
        System.IO.File.Delete(_path)
        System.IO.File.Move(tmpFile, _path)

    End Sub

    ''' <summary>
    ''' Convert SHA1 hash to an array of bytes
    ''' </summary>
    ''' <param name="value">The hash as a string to convert</param>
    ''' <returns>The hash byte array</returns>
    ''' <remarks>For strings in the format of e05fba3cae3eb002ea8480bc08c1fbc147004abb</remarks>
    Private Function HashToByte(value As String) As Byte()

        Dim bytes(19) As Byte

        For i As Integer = 0 To 19
            bytes(i) = CByte(Convert.ToUInt16(value(i) & value(i + 1), 16))
        Next

        Return bytes

    End Function

#Region "Properties"

    ''' <summary>
    ''' The name of the original file
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FileName() As String
        Get
            Return BitConverter.ToString(_fileName)
        End Get

        Set(ByVal value As String)
            _fileName = Encoding.UTF8.GetBytes(value)

            ' Resize the array to make it the correct length again
            ReDim Preserve _fileName(FILE_NAME_COUNT - 1)

        End Set

    End Property

    ''' <summary>
    ''' Hash of the plain-text data
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Hash() As Byte()
        Get
            'Return BitConverter.ToString(_hash)
            Return _hash
        End Get

        Set(ByVal value As Byte())
            _hash = value
        End Set

    End Property

    ''' <summary>
    ''' Hash of the compressed plain-text data
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HashCompressed() As Byte()
        Get
            'Return BitConverter.ToString(_hashCompressed)
            Return _hashCompressed
        End Get

        Set(ByVal value As Byte())
            _hashCompressed = value
        End Set
    End Property

    ''' <summary>
    ''' The number of this file in the series
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PartNum() As Integer
        Get
            Return Convert.ToInt32(_partNum)
        End Get

        Set(ByVal value As Integer)
            _partNum = BitConverter.GetBytes(value)
            ReDim Preserve _partNum(PART_NUM_COUNT - 1)

        End Set

    End Property

    ''' <summary>
    ''' Total parts in the series
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PartsTotal() As Integer
        Get
            Return Convert.ToInt32(_partsTotal)
        End Get
        Set(ByVal value As Integer)
            _partsTotal = BitConverter.GetBytes(value)
            ReDim Preserve _partsTotal(PART_TOTAL_COUNT - 1)

        End Set
    End Property

    ''' <summary>
    ''' Boolean value to indicate if the plain-text data has been compressed
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Compressed() As Boolean
        Get
            Return Convert.ToBoolean(_compressed(0))
        End Get

        Set(ByVal value As Boolean)
            _compressed = BitConverter.GetBytes(value)

        End Set
    End Property

    ''' <summary>
    ''' Header version number
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Version() As Integer
        Get
            Return Convert.ToInt32(_version)
        End Get
        Set(ByVal value As Integer)
            _version = BitConverter.GetBytes(value)
            ReDim Preserve _version(VERSION_COUNT - 1)

        End Set
    End Property
#End Region

End Class

