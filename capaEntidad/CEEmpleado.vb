Public Class CEEmpleado

    Private _id As Integer
    Private _nombre As Integer
    Private _apellido As Integer
    Private _foto As Integer

    'creamos el constructor sin ningún valor aún'
    Public Sub New()
    End Sub

    'creamos getters y setters para las variables privadas'
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombre As Integer
        Get
            Return _nombre
        End Get
        Set(value As Integer)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As Integer
        Get
            Return _apellido
        End Get
        Set(value As Integer)
            _apellido = value
        End Set
    End Property

    Public Property Foto As Integer
        Get
            Return _foto
        End Get
        Set(value As Integer)
            _foto = value
        End Set
    End Property
End Class
