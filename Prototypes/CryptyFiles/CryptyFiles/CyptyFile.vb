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

    Public Property Name
        Set(ByVal value)
            _name = value

        End Set

        Get
            Return _name

        End Get
    End Property

    Public Property Path
        Set(ByVal value)
            _path = value

        End Set

        Get
            Return _path
        End Get
    End Property

    Public ReadOnly Property Hash
        Get
            Return _hash

        End Get
    End Property

    Public ReadOnly Property Size

        Get
            Return _size

        End Get
    End Property

    Public ReadOnly Property Status
        Get
            Return _status

        End Get
    End Property

    ' TODO: Throw exception and observer results
    Private Sub CheckInput(ByVal text As String)

    End Sub
End Class
