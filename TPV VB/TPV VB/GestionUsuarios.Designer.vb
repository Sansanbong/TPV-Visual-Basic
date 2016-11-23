<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grupoBorradoUsuario = New System.Windows.Forms.GroupBox()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnBorrarModificar = New System.Windows.Forms.Button()
        Me.comboUsuarios = New System.Windows.Forms.ComboBox()
        Me.grupoInsercionUsuario = New System.Windows.Forms.GroupBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasenya = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.grupoBorradoUsuario.SuspendLayout()
        Me.grupoInsercionUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoBorradoUsuario
        '
        Me.grupoBorradoUsuario.BackColor = System.Drawing.Color.Coral
        Me.grupoBorradoUsuario.Controls.Add(Me.btnRefrescar)
        Me.grupoBorradoUsuario.Controls.Add(Me.btnBorrarModificar)
        Me.grupoBorradoUsuario.Controls.Add(Me.comboUsuarios)
        Me.grupoBorradoUsuario.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoBorradoUsuario.Location = New System.Drawing.Point(185, 368)
        Me.grupoBorradoUsuario.Name = "grupoBorradoUsuario"
        Me.grupoBorradoUsuario.Size = New System.Drawing.Size(445, 98)
        Me.grupoBorradoUsuario.TabIndex = 21
        Me.grupoBorradoUsuario.TabStop = False
        Me.grupoBorradoUsuario.Text = "Borrado de usuarios"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackgroundImage = Global.TPV_VB.My.Resources.Resources.refrescar
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Location = New System.Drawing.Point(32, 45)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(36, 31)
        Me.btnRefrescar.TabIndex = 9
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnBorrarModificar
        '
        Me.btnBorrarModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarModificar.Location = New System.Drawing.Point(297, 50)
        Me.btnBorrarModificar.Name = "btnBorrarModificar"
        Me.btnBorrarModificar.Size = New System.Drawing.Size(67, 23)
        Me.btnBorrarModificar.TabIndex = 8
        Me.btnBorrarModificar.Text = "Borrar"
        Me.btnBorrarModificar.UseVisualStyleBackColor = True
        '
        'comboUsuarios
        '
        Me.comboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboUsuarios.FormattingEnabled = True
        Me.comboUsuarios.Location = New System.Drawing.Point(74, 50)
        Me.comboUsuarios.Name = "comboUsuarios"
        Me.comboUsuarios.Size = New System.Drawing.Size(208, 23)
        Me.comboUsuarios.TabIndex = 7
        '
        'grupoInsercionUsuario
        '
        Me.grupoInsercionUsuario.BackColor = System.Drawing.Color.Coral
        Me.grupoInsercionUsuario.Controls.Add(Me.lblNombreUsuario)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtNombreUsuario)
        Me.grupoInsercionUsuario.Controls.Add(Me.Label20)
        Me.grupoInsercionUsuario.Controls.Add(Me.lblContrasenya)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtPass)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtMail)
        Me.grupoInsercionUsuario.Controls.Add(Me.btnInsertar)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtTelefono)
        Me.grupoInsercionUsuario.Controls.Add(Me.lblTelefono)
        Me.grupoInsercionUsuario.Controls.Add(Me.lblRol)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtDNI)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtApellidos)
        Me.grupoInsercionUsuario.Controls.Add(Me.lblDNI)
        Me.grupoInsercionUsuario.Controls.Add(Me.lblApellidos)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtRol)
        Me.grupoInsercionUsuario.Controls.Add(Me.txtNombreEmpleado)
        Me.grupoInsercionUsuario.Controls.Add(Me.lblNombreEmpleado)
        Me.grupoInsercionUsuario.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoInsercionUsuario.Location = New System.Drawing.Point(31, 7)
        Me.grupoInsercionUsuario.Name = "grupoInsercionUsuario"
        Me.grupoInsercionUsuario.Size = New System.Drawing.Size(824, 317)
        Me.grupoInsercionUsuario.TabIndex = 20
        Me.grupoInsercionUsuario.TabStop = False
        Me.grupoInsercionUsuario.Text = "Inserción de un nuevo usuario"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(39, 49)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(123, 16)
        Me.lblNombreUsuario.TabIndex = 0
        Me.lblNombreUsuario.Text = "Nombre de usuario"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(183, 48)
        Me.txtNombreUsuario.MaxLength = 10
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreUsuario.TabIndex = 1
        '
        'lblContrasenya
        '
        Me.lblContrasenya.AutoSize = True
        Me.lblContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenya.Location = New System.Drawing.Point(85, 76)
        Me.lblContrasenya.Name = "lblContrasenya"
        Me.lblContrasenya.Size = New System.Drawing.Size(77, 16)
        Me.lblContrasenya.TabIndex = 2
        Me.lblContrasenya.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(183, 75)
        Me.txtPass.MaxLength = 11
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 3
        '
        'btnInsertar
        '
        Me.btnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar.Location = New System.Drawing.Point(584, 190)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(84, 33)
        Me.btnInsertar.TabIndex = 18
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(186, 257)
        Me.txtMail.MaxLength = 50
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(317, 20)
        Me.txtMail.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(62, 261)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 16)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Correo electrónico"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(186, 228)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTelefono.Size = New System.Drawing.Size(70, 20)
        Me.txtTelefono.TabIndex = 13
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(54, 231)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(126, 16)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Número de teléfono"
        '
        'txtDNI
        '
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(186, 198)
        Me.txtDNI.MaxLength = 9
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(70, 20)
        Me.txtDNI.TabIndex = 11
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(149, 201)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(31, 16)
        Me.lblDNI.TabIndex = 10
        Me.lblDNI.Text = "DNI"
        '
        'txtRol
        '
        Me.txtRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRol.Location = New System.Drawing.Point(186, 168)
        Me.txtRol.MaxLength = 1
        Me.txtRol.Name = "txtRol"
        Me.txtRol.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRol.Size = New System.Drawing.Size(26, 20)
        Me.txtRol.TabIndex = 9
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(39, 111)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(141, 16)
        Me.lblNombreEmpleado.TabIndex = 4
        Me.lblNombreEmpleado.Text = "Nombre de empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(186, 108)
        Me.txtNombreEmpleado.MaxLength = 25
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(170, 20)
        Me.txtNombreEmpleado.TabIndex = 5
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.Location = New System.Drawing.Point(151, 171)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(29, 16)
        Me.lblRol.TabIndex = 8
        Me.lblRol.Text = "Rol"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(115, 141)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(65, 16)
        Me.lblApellidos.TabIndex = 6
        Me.lblApellidos.Text = "Apellidos"
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(186, 138)
        Me.txtApellidos.MaxLength = 26
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(170, 20)
        Me.txtApellidos.TabIndex = 7
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TPV_VB.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(882, 612)
        Me.Controls.Add(Me.grupoBorradoUsuario)
        Me.Controls.Add(Me.grupoInsercionUsuario)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionUsuarios"
        Me.Text = "GestionUsuarios"
        Me.grupoBorradoUsuario.ResumeLayout(False)
        Me.grupoInsercionUsuario.ResumeLayout(False)
        Me.grupoInsercionUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoBorradoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents btnBorrarModificar As System.Windows.Forms.Button
    Friend WithEvents comboUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents grupoInsercionUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenya As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
End Class
