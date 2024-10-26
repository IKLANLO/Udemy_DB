Imports MySql.Data.MySqlClient
Imports capaEntidad
Imports Mysqlx.Crud

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
            Exit Sub 'cerramos el evento'
        End Try

        conexion.Close()
    End Sub

    Public Sub Insertar(ByVal empleado As CEEmpleado)
        'guardamos en empleado en la DB'
        Dim conexion As New MySqlConnection(_cadenaConexion)

        Try
            conexion.Open()
            'empleado.Foto se guarda así en la query para añadir los / en la ruta'
            Dim empleadoFoto As String = MySql.Data.MySqlClient.MySqlHelper.EscapeString(empleado.Foto)
            Dim query As String = $"INSERT INTO `empleados` (`nombre`, `apellido`, `foto`) VALUES ('{empleado.Nombre}', '{empleado.Apellido}', '{empleadoFoto}');"
            Dim comando As New MySqlCommand(query, conexion)
            comando.ExecuteReader() 'ejecutamos el comando insert'
            MessageBox.Show("Contacto guardado correctamente", "Info", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK)
            Exit Sub 'cerramos el evento'
        End Try

        conexion.Close()
    End Sub

    Public Sub Modificar(ByVal empleado As CEEmpleado)
        'guardamos en empleado en la DB'
        Dim conexion As New MySqlConnection(_cadenaConexion)

        Try
            conexion.Open()
            'empleado.Foto se guarda así en la query para añadir los / en la ruta'
            Dim empleadoFoto As String = MySql.Data.MySqlClient.MySqlHelper.EscapeString(empleado.Foto)
            Dim query As String = "UPDATE `empleados` SET `nombre`='" & empleado.Nombre & "', `apellido`='" & empleado.Apellido & "', `foto`='" & empleadoFoto & "' WHERE  `id`=" & empleado.Id & ";"
            Dim comando As New MySqlCommand(query, conexion)
            comando.ExecuteReader() 'ejecutamos el comando insert'
            MessageBox.Show("Contacto editado correctamente", "Info", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK)
            Exit Sub 'cerramos el evento'
        End Try

        conexion.Close()
    End Sub

    Public Function Listar() As DataSet
        'guardamos la lista de empleados de la DB'
        Dim conexion As New MySqlConnection(_cadenaConexion)

        Try
            conexion.Open()
            Dim query As String = "SELECT * FROM `empleados` LIMIT 1000;"
            Dim adaptador As New MySqlDataAdapter(query, conexion)
            Dim dataSet As New DataSet

            adaptador.Fill(dataSet, "empleados") 'llenamos el dataSet con los datos del adaptador, y lo identificamos como tabla empleados
            Return dataSet

        Catch ex As Exception
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK)
        End Try

        conexion.Close()
    End Function

End Class
