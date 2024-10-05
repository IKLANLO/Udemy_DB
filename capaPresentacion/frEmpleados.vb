Imports System.Runtime.CompilerServices
Imports capaEntidad
Imports capaNegocio

Public Class frEmpleados
    Dim NegocioEmpleado As New CNEmpleado
    Dim redColor As Color = Color.FromArgb(238, 210, 206)
    Dim whiteColor As Color = Color.White

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'vaciamos el formulario'
        txtNombre.Clear()
        txtApellido.Clear()
        txtId.Value = 0
        picFoto.Image = Nothing
    End Sub

    Private Sub lnkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFoto.LinkClicked
        'indicamos los tipos de archivo admitidos en el cuadro de diálogo'
        openFoto.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|all files|*.png;*.jpg"

        'abrimos el cuadro'
        openFoto.ShowDialog()

        If openFoto.FileName IsNot "" Then
            'ajustamos el tamaño de la foto al tamaño del componente picFoto'
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage

            'si se ha seleccionado alguna foto la cargamos en picFoto'
            picFoto.Load(openFoto.FileName)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'creamos una instancia de CEEmpleado'
        Dim empleado As New CEEmpleado()

        'guardamos los datos del formulario en esa instancia'
        empleado.Id = txtId.Value
        empleado.Nombre = txtNombre.Text
        empleado.Apellido = txtApellido.Text
        empleado.Foto = picFoto.ImageLocation

        NegocioEmpleado.ValidarDatos(empleado)
        NegocioEmpleado.pruebaMySql()

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load, txtNombre.TextChanged, txtApellido.TextChanged, txtId.TextChanged, openFoto.FileOk
        'controlamos que sólo se activen los botones de guardar y eliminar si están los campos rellenos'
        If txtId.Value = 0 Or txtNombre.Text Is "" Or txtApellido.Text Is "" Or String.IsNullOrEmpty(openFoto.FileName) Then
            btnGuardar.Enabled = False
            btnEliminar.Enabled = False

            ReviewBackColor()
        Else
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True

            ReviewBackColor()
        End If
    End Sub

    Private Function ReviewBackColor()
        'establecemos los valores de cada control en un array'
        Dim contentReview() As String = {txtId.Value.ToString(), txtNombre.Text, txtApellido.Text, openFoto.FileName}

        'establecemos un diccionario para identificar cada par valor:clave'
        Dim controls As New Dictionary(Of String, Control) From {
            {"txtId", txtId},
            {"txtNombre", txtNombre},
            {"txtApellido", txtApellido},
            {"picFoto", picFoto}
        }
        'establecemos el color de fondo de cada control según si está rellenado o no'
        Dim i As Integer = 0
        For Each value As String In contentReview
            If value Is "" Or value.ToString = "0" Then
                If i < controls.Count Then
                    controls.ElementAt(i).Value.BackColor = redColor
                End If

            ElseIf i < controls.Count Then
                controls.ElementAt(i).Value.BackColor = whiteColor
            End If

            i += 1
        Next
    End Function
End Class
