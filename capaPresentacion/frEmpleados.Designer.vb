<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtId = New NumericUpDown()
        picFoto = New PictureBox()
        lnkFoto = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnNuevo = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        openFoto = New OpenFileDialog()
        gridDatos = New DataGridView()
        CNEmpleadoBindingSource = New BindingSource(components)
        CType(txtId, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(gridDatos, ComponentModel.ISupportInitialize).BeginInit()
        CType(CNEmpleadoBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(87, 58)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(225, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(87, 92)
        txtApellido.Margin = New Padding(3, 2, 3, 2)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(225, 23)
        txtApellido.TabIndex = 1
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(87, 26)
        txtId.Margin = New Padding(3, 2, 3, 2)
        txtId.Name = "txtId"
        txtId.Size = New Size(54, 23)
        txtId.TabIndex = 2
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = SystemColors.ActiveBorder
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(87, 125)
        picFoto.Margin = New Padding(3, 2, 3, 2)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(123, 97)
        picFoto.TabIndex = 3
        picFoto.TabStop = False
        ' 
        ' lnkFoto
        ' 
        lnkFoto.AutoSize = True
        lnkFoto.Location = New Point(88, 226)
        lnkFoto.Name = "lnkFoto"
        lnkFoto.Size = New Size(67, 15)
        lnkFoto.TabIndex = 4
        lnkFoto.TabStop = True
        lnkFoto.Text = "Seleccionar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 15)
        Label1.TabIndex = 5
        Label1.Text = "Id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 7
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 8
        Label4.Text = "Foto"
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(25, 268)
        btnNuevo.Margin = New Padding(3, 2, 3, 2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(82, 22)
        btnNuevo.TabIndex = 9
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(127, 268)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(82, 22)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(229, 268)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(82, 22)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' openFoto
        ' 
        ' 
        ' gridDatos
        ' 
        gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridDatos.Location = New Point(346, 26)
        gridDatos.Margin = New Padding(3, 2, 3, 2)
        gridDatos.Name = "gridDatos"
        gridDatos.ReadOnly = True
        gridDatos.RowHeadersWidth = 51
        gridDatos.RowTemplate.Height = 29
        gridDatos.Size = New Size(442, 263)
        gridDatos.TabIndex = 12
        ' 
        ' CNEmpleadoBindingSource
        ' 
        CNEmpleadoBindingSource.DataSource = GetType(capaNegocio.CNEmpleado)
        ' 
        ' frEmpleados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 322)
        Controls.Add(gridDatos)
        Controls.Add(btnGuardar)
        Controls.Add(btnEliminar)
        Controls.Add(btnNuevo)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lnkFoto)
        Controls.Add(picFoto)
        Controls.Add(txtId)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frEmpleados"
        Text = "Form1"
        CType(txtId, ComponentModel.ISupportInitialize).EndInit()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(gridDatos, ComponentModel.ISupportInitialize).EndInit()
        CType(CNEmpleadoBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lnkFoto As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents openFoto As OpenFileDialog
    Friend WithEvents gridDatos As DataGridView
    Friend WithEvents CNEmpleadoBindingSource As BindingSource

End Class
