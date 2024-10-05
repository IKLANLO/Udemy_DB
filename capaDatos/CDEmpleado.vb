Imports MySql.Data.MySqlClient
Imports capaEntidad

Public Class CDEmpleado
    'importamos las variables de entorno guardadas en las propiedades de capaDatos'
    Private MY_SERVER As String = Environment.GetEnvironmentVariable("MY_SERVER")
    Private MY_USER As String = Environment.GetEnvironmentVariable("MY_USER")
    Private MY_PASSWORD As String = Environment.GetEnvironmentVariable("MY_PASSWORD")
    Private MY_PORT As String = Environment.GetEnvironmentVariable("MY_PORT")
    Private MY_DB As String = Environment.GetEnvironmentVariable("MY_DB")

    'creamos el string de conexión a la DB'
    Private _cadenaConexion As String = $"Server={MY_SERVER};User={MY_USER};Password={MY_PASSWORD};Port={MY_PORT};Database={MY_DB}"

    Public Sub ProbarConexion()
        Dim conexion As New MySqlConnection(_cadenaConexion)

        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show($"Error de conexión. {ex.Message}", "Error", MessageBoxButtons.OK)
        End Try

        conexion.Close()
    End Sub

End Class
