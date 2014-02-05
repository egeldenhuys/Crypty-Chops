Imports System.IO
Public Class Compression

    '' This class is used for comressing and decompressing files

    Private _path As String '' Path of the file to compress
    Private _destPath As String '' Where the newly compressed file will be saved

    ''' <summary>
    ''' Create a new compression object
    ''' </summary>
    ''' <param name="path">Path to the uncompressed file.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal path As String)
        _path = path
    End Sub

    Dim fInfo As FileInfo
    Dim proc As New Process
    Dim arguments As ProcessStartInfo = New ProcessStartInfo()

    ''' <summary>
    ''' Compress the file
    ''' </summary>
    ''' <remarks></remarks>
    Sub Compress()

        fInfo = New FileInfo(_path)
        Dim newFileName As String = System.IO.Path.GetFileNameWithoutExtension(_path)

        Dim destPath As String = """" & fInfo.DirectoryName & "\" & newFileName & ".7z"""

        With proc.StartInfo
            If (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypt-Chops\7za920")) Then
                .FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypt-Chops\7za920\7za.exe"
            Else
                .FileName = CurDir() & "\7za920\7za.exe"
            End If
            .Arguments = "a " & destPath & " """ & _path & """"
            .CreateNoWindow = True
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
