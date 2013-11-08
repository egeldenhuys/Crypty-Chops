Public Class CyptyFile

    ' Name
    ' Path
    ' Hash
    ' Size
    ' Status

    Private _name As String
    Private _path As String
    Private _hash As String
    Private _size As Integer
    Private _status As String

    Public Property Name As String
        Set(ByVal value As String)
            _name = value

        End Set

        Get
            Return _name

        End Get
    End Property

    Public Property Path As String
        Set(ByVal value As String)
            _path = value

        End Set

        Get
            Return _path
        End Get
    End Property

    Public ReadOnly Property Hash As String
        Get
            Return _hash

        End Get
    End Property

    Public ReadOnly Property Size As Integer

        Get
            Return _size

        End Get
    End Property

    Public ReadOnly Property Status As String
        Get
            Return _status

        End Get
    End Property

    ' TODO: Throw exception and observer results
    Private Sub CheckInput(ByVal text As String)

    End Sub
End Class
