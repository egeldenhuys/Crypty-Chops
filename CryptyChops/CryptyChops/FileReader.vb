﻿Imports System.IO

Public Class FileReader

    ' This class is used to read blocks of bytes from a file

    ' Usage:

    ''Dim fReader As New FileReader("C:\MyFile.exe", 1024)

    'Dim b() As Byte ' Array to store the read bytes

    '' Read and write blocks until there are no more bytes left
    'While fReader.Finished = False
    '    b = fReader.ReadBlock ' Read the block of bytes into b()

    '    ' Use the bytes here...
    'End While

    '' Close the file
    'fReader.Close()

    Private _bufferSize As Integer = 1024
    Private _finished As Boolean = False
    Private _bytesleft As Long
    Private _path As String

    Private fs As FileStream

    ''' <summary>
    ''' Create a new
    ''' </summary>
    ''' <param name="path">The path of the file to read from</param>
    ''' <param name="bufferSize">The size of the buffer to use</param>
    ''' <remarks></remarks>
    Public Sub New(path As String, bufferSize As Integer)
        _path = path
        _bufferSize = bufferSize

        ' Initialize FileStream
        fs = New FileStream(path, FileMode.Open)
        _bytesleft = fs.Length

    End Sub

    ''' <summary>
    ''' Close the FileStream
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Close()
        fs.Close()

    End Sub

    Public Function ReadBlock() As Byte()
        Dim n As Integer = 0 ' Integer to store how many bytes was read

        Dim b(_bufferSize - 1) As Byte ' Buffer where bytes will be read into

        ' n is how many bytes was read
        ' Read the block of bytes into b()
        n = fs.Read(b, 0, _bufferSize)

        ' No bytes were read, so we are at the end of the file
        If n = 0 Then
            _finished = True
        End If

        ' No more bytes left
        If BytesLeft = 0 Then
            _finished = True
        End If

        ' if n is less than the buffer size it means we have reached the end of the file
        If n < _bufferSize Then
            ' Resize the array, to avoid empty bytes
            ReDim Preserve b(n - 1)
        End If

        _bytesleft -= n

        Return b

    End Function

#Region "Properties"

    ''' <summary>
    ''' The size of the buffer to use
    ''' </summary>
    ''' <remarks></remarks>
    Public Property BufferSize() As Integer
        Get
            Return _bufferSize
        End Get
        Set(ByVal value As Integer)
            _bufferSize = value
        End Set
    End Property

    ''' <summary>
    ''' The path of the file
    ''' </summary>
    ''' <remarks></remarks>
    Public Property Path() As String
        Get
            Return _path
        End Get
        Set(ByVal value As String)
            _path = value
        End Set
    End Property

    ''' <summary>
    ''' Indicates if all the blocks has been read
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly Property Finished() As Boolean
        Get
            Return _finished
        End Get
    End Property

    ''' <summary>
    ''' How many bytes still ahve to be read
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property BytesLeft() As Long
        Get
            Return _bytesleft
        End Get

    End Property

#End Region

End Class
