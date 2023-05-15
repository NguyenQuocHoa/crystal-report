Public Class CustomerDTO
    Private _Address As String
    Private _Code As String
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property
    Public Property Code() As String
        Get
            Return _Code
        End Get
        Set(value As String)
            _Code = value
        End Set
    End Property
End Class
