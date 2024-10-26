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

        'probamos la conexión a la DB'
        NegocioEmpleado.pruebaMySql()

        If (empleado.Id = 0) Then 'revisar validaciones, no permite insertar nuevos empleados
            'insertamos los datos en la DB'
            NegocioEmpleado.InsertarEmpleado(empleado)
        Else
            NegocioEmpleado.ModificarEmpleado(empleado)
        End If


        'actualizamos el dataGrid
        gridDatos.DataSource = NegocioEmpleado.ListarEmpleados().Tables("empleados")

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load, txtNombre.TextChanged, txtApellido.TextChanged, txtId.TextChanged, openFoto.FileOk
        'controlamos que sólo se activen los botones de guardar y eliminar si están los campos rellenos'
        If txtNombre.Text Is "" Or txtApellido.Text Is "" Or String.IsNullOrEmpty(picFoto.ImageLocation) Then
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

    Private Sub frEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'al cargar el formulario se rellenan los datos procedentes de la DB
        gridDatos.DataSource = NegocioEmpleado.ListarEmpleados().Tables("empleados")
    End Sub

    Private Sub gridDatos_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridDatos.RowHeaderMouseDoubleClick
        'tras hacer doble click en una fila se modificarán los datos
        ReviewBackColor()
        'vaciamos el formulario'
        txtNombre.Text = gridDatos.CurrentRow.Cells("nombre").Value
        txtApellido.Text = gridDatos.CurrentRow.Cells("apellido").Value
        txtId.Value = gridDatos.CurrentRow.Cells("id").Value

        If gridDatos.CurrentRow.Cells("foto").Value <> "" Then
            If System.IO.File.Exists(gridDatos.CurrentRow.Cells("foto").Value) Then 'revisamos si la ruta es válida aún
                picFoto.BackColor = whiteColor 'aseguramos que el fondo sea blanco, por si hay imágenes sin fondo
                picFoto.SizeMode = PictureBoxSizeMode.StretchImage 'ajustamos la imagen al contenedor
                picFoto.Load(gridDatos.CurrentRow.Cells("foto").Value)
            End If
        End If

        btnGuardar.Enabled = True
    End Sub
End Class
