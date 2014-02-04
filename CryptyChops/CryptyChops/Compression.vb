Imports System.IO
Public Class Compression

    '' This class is used for comressing and decompressing files

    Private _path As String '' Path of the file to compress
    Private _destPath As String '' Where the newly compressed file will be saved

    ''' <summary>
    ''' Create a new compression object
    ''' </summary>
    ''' <param name="path">Path to the uncompressed file.</param>
    ''' <param name="dest">Where the newly compressed file with be saved.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal path As String, ByVal dest As String)
        _path = path
        _destPath = dest
    End Sub

    Dim proc As New Process
    Dim arguments As ProcessStartInfo = New ProcessStartInfo()

    ''' <summary>
    ''' Compress the file
    ''' </summary>
    ''' <remarks></remarks>
    Sub Compress()
        _destPath = """" & _destPath & "\test2.7z"""
        With proc.StartInfo
            .FileName = "7za920\7za.exe"
            .Arguments = "a " & _destPath & " """ & _path & """"
            .CreateNoWindow = False
        End With

        proc.Start()

    End Sub


#Region "Properties"

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

#End Region
End Class
