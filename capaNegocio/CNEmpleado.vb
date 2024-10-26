Imports capaEntidad
Imports capaDatos

Public Class CNEmpleado

    Dim DatosEmpleado As New CDEmpleado
    Public Function ValidarDatos(ByVal empleado As CEEmpleado) As Boolean
        'devolverá true o false según se validen los datos del objeto CEEmpleado pasado'
        Dim Resultado As Boolean = True

        If empleado.Nombre = "" Or empleado.Apellido = "" Or empleado.Foto = "" Then
            Resultado = False
            MessageBox.Show("Todos los datos son obligatorios", "Error", MessageBoxButtons.OK)
        End If

        Return Resultado
    End Function

    Public Sub pruebaMySql()
        DatosEmpleado.ProbarConexion()
    End Sub

    Public Sub InsertarEmpleado(ByVal empleado As CEEmpleado)
        DatosEmpleado.Insertar(empleado)
    End Sub

    Public Sub ModificarEmpleado(ByVal empleado As CEEmpleado)
        DatosEmpleado.Modificar(empleado)
    End Sub

    Public Sub EliminarEmpleado(ByVal empleado As CEEmpleado)
        DatosEmpleado.Eliminar(empleado)
    End Sub

    Public Function ListarEmpleados() As DataSet
        Return DatosEmpleado.Listar()

    End Function

End Class
