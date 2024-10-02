Imports capaEntidad

Public Class frEmpleados
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'vaciamos el formulario'
        txtNombre.Clear()
        txtApellido.Clear()
        txtId.Value = 0
        picFoto.Image = Nothing
    End Sub

    Private Sub lnkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFoto.LinkClicked
        'indicamos los tipos de archivo admitidos en el cuadro de diálogo'
        openFoto.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png"

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
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load, txtNombre.TextChanged, txtApellido.TextChanged, txtId.TextChanged, picFoto.TextChanged
        'controlamos que sólo se activen los botones de guardar y eliminar si están los campos rellenos'
        If txtId.Value = 0 Or txtNombre.Text Is "" Or txtApellido.Text Is "" Or picFoto.Image Is "" Then
            btnGuardar.Enabled = False
            btnEliminar.Enabled = False
        Else
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub
End Class
