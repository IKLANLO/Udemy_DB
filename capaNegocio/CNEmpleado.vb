﻿Imports capaEntidad
Imports capaDatos

Public Class CNEmpleado

    Dim DatosEmpleado As New CDEmpleado
    Public Function ValidarDatos(ByVal empleado As CEEmpleado) As Boolean
        'devolverá true o false según se validen los datos del objeto CEEmpleado pasado'
        Dim Resultado As Boolean = True

        If empleado.Id = 0 Or empleado.Nombre = "" Or empleado.Apellido = "" Or empleado.Foto = "" Then
            Resultado = False
            MessageBox.Show("Todos los datos son obligatorios", "Error", MessageBoxButtons.OK)
        End If

        Return Resultado
    End Function

    Public Sub pruebaMySql()
        DatosEmpleado.ProbarConexion()
    End Sub

End Class