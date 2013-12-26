Imports System.IO
Imports System.Text

Public Class CryptyHeader

    Public fileName As String
    Public hash As String
    Public path As String
    Public partNum As Integer
    Public partsTotal As Integer
    Public compressed As Boolean
    Public version As Integer

    ' Header Constants
    Const FILE_NAME_OFFSET = 0
    Const FILE_NAME_COUNT = 64

    Const HASH_OFFSET = FILE_NAME_OFFSET + FILE_NAME_COUNT
    Const HASH_COUNT = 20

    Const PART_NUM_OFFSET = HASH_OFFSET + HASH_COUNT
    Const PART_NUM_COUNT = 4

    Const PART_TOTAL_OFFSET = PART_NUM_OFFSET + PART_NUM_COUNT
    Const PART_TOTAL_COUNT = 4

    Const COMPRESSED_OFFSET = PART_TOTAL_OFFSET + PART_TOTAL_COUNT
    Const COMPRESSED_COUNT = 1

    Const VERSION_OFFSET = COMPRESSED_OFFSET + COMPRESSED_COUNT
    Const VERSION_COUNT = 3

    Const DATA_OFFSET = VERSION_OFFSET + VERSION_COUNT


    Public Sub New(filePath As String)

        path = filePath

    End Sub

    ''' <summary>
    ''' Read the values from the header
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadHeader()
        Dim fs As New FileStream(path, FileMode.Open)

        Dim b(63) As Byte

        ' File Name
        fs.Read(b, 0, FILE_NAME_COUNT)
        fileName = UTF8Encoding.UTF8.GetString(b)

        ReDim b(19)
        ' Hash
        fs.Read(b, 0, HASH_COUNT)
        hash = BitConverter.ToString(b)

        ReDim b(3)
        ' Part Num
        fs.Read(b, 0, PART_NUM_COUNT)
        partNum = BitConverter.ToInt32(b, 0)

        ReDim b(3)
        ' Parts Total
        fs.Read(b, 0, PART_TOTAL_COUNT)
        partsTotal = BitConverter.ToInt32(b, 0)

        ReDim b(0)
        ' Compressed
        fs.Read(b, 0, COMPRESSED_COUNT)
        compressed = Convert.ToBoolean(b(0))

        ReDim b(3)
        ' Version
        fs.Read(b, 0, VERSION_COUNT)
        version = BitConverter.ToInt32(b, 0)

        fs.Close()

    End Sub

    Public Sub ShowHeader()
        MsgBox(fileName)
        MsgBox(hash)
        MsgBox(partNum)
        MsgBox(partsTotal)
        MsgBox(compressed)
        MsgBox(version)

    End Sub


End Class

