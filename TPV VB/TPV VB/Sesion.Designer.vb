<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sesion
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
        Me.grupoModificarPass = New System.Windows.Forms.GroupBox()
        Me.btnCambiarPass = New System.Windows.Forms.Button()
        Me.lblPassNueva = New System.Windows.Forms.Label()
        Me.txtPassNueva = New System.Windows.Forms.TextBox()
        Me.lblPassActual = New System.Windows.Forms.Label()
        Me.txtPassActual = New System.Windows.Forms.TextBox()
        Me.panelDatosUsuario = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDatosUser = New System.Windows.Forms.Label()
        Me.lblDatoRol = New System.Windows.Forms.Label()
        Me.lblDatoApellidos = New System.Windows.Forms.Label()
        Me.lblDatoDNI = New System.Windows.Forms.Label()
        Me.lblDatoTelefono = New System.Windows.Forms.Label()
        Me.lblDatoCorreo = New System.Windows.Forms.Label()
        Me.lblDatoNombre = New System.Windows.Forms.Label()
        Me.lblDatoNick = New System.Windows.Forms.Label()
        Me.lblCerrarSesion = New System.Windows.Forms.LinkLabel()
        Me.grupoModificarPass.SuspendLayout()
        Me.panelDatosUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoModificarPass
        '
        Me.grupoModificarPass.BackColor = System.Drawing.Color.Transparent
        Me.grupoModificarPass.Controls.Add(Me.btnCambiarPass)
        Me.grupoModificarPass.Controls.Add(Me.lblPassNueva)
        Me.grupoModificarPass.Controls.Add(Me.txtPassNueva)
        Me.grupoModificarPass.Controls.Add(Me.lblPassActual)
        Me.grupoModificarPass.Controls.Add(Me.txtPassActual)
        Me.grupoModificarPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoModificarPass.Location = New System.Drawing.Point(484, 143)
        Me.grupoModificarPass.Name = "grupoModificarPass"
        Me.grupoModificarPass.Size = New System.Drawing.Size(298, 287)
        Me.grupoModificarPass.TabIndex = 3
        Me.grupoModificarPass.TabStop = False
        Me.grupoModificarPass.Text = "Modificar contraseña"
        '
        'btnCambiarPass
        '
        Me.btnCambiarPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCambiarPass.Location = New System.Drawing.Point(175, 242)
        Me.btnCambiarPass.Name = "btnCambiarPass"
        Me.btnCambiarPass.Size = New System.Drawing.Size(75, 23)
        Me.btnCambiarPass.TabIndex = 4
        Me.btnCambiarPass.Text = "Cambiar"
        Me.btnCambiarPass.UseVisualStyleBackColor = True
        '
        'lblPassNueva
        '
        Me.lblPassNueva.AutoSize = True
        Me.lblPassNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPassNueva.Location = New System.Drawing.Point(20, 161)
        Me.lblPassNueva.Name = "lblPassNueva"
        Me.lblPassNueva.Size = New System.Drawing.Size(128, 18)
        Me.lblPassNueva.TabIndex = 3
        Me.lblPassNueva.Text = "Contraseña nueva"
        '
        'txtPassNueva
        '
        Me.txtPassNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPassNueva.Location = New System.Drawing.Point(41, 192)
        Me.txtPassNueva.Name = "txtPassNueva"
        Me.txtPassNueva.Size = New System.Drawing.Size(100, 24)
        Me.txtPassNueva.TabIndex = 2
        '
        'lblPassActual
        '
        Me.lblPassActual.AutoSize = True
        Me.lblPassActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPassActual.Location = New System.Drawing.Point(21, 49)
        Me.lblPassActual.Name = "lblPassActual"
        Me.lblPassActual.Size = New System.Drawing.Size(128, 18)
        Me.lblPassActual.TabIndex = 1
        Me.lblPassActual.Text = "Contraseña actual"
        '
        'txtPassActual
        '
        Me.txtPassActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPassActual.Location = New System.Drawing.Point(41, 74)
        Me.txtPassActual.Name = "txtPassActual"
        Me.txtPassActual.Size = New System.Drawing.Size(100, 24)
        Me.txtPassActual.TabIndex = 0
        '
        'panelDatosUsuario
        '
        Me.panelDatosUsuario.BackColor = System.Drawing.Color.Transparent
        Me.panelDatosUsuario.Controls.Add(Me.Label1)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatosUser)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatoRol)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatoApellidos)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatoDNI)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatoTelefono)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatoCorreo)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatoNombre)
        Me.panelDatosUsuario.Controls.Add(Me.lblDatoNick)
        Me.panelDatosUsuario.Location = New System.Drawing.Point(85, 143)
        Me.panelDatosUsuario.Name = "panelDatosUsuario"
        Me.panelDatosUsuario.Size = New System.Drawing.Size(251, 280)
        Me.panelDatosUsuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 26)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "_______________"
        '
        'lblDatosUser
        '
        Me.lblDatosUser.AutoSize = True
        Me.lblDatosUser.BackColor = System.Drawing.Color.Transparent
        Me.lblDatosUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDatosUser.Location = New System.Drawing.Point(19, 15)
        Me.lblDatosUser.Name = "lblDatosUser"
        Me.lblDatosUser.Size = New System.Drawing.Size(198, 26)
        Me.lblDatosUser.TabIndex = 22
        Me.lblDatosUser.Text = "Datos del usuario"
        '
        'lblDatoRol
        '
        Me.lblDatoRol.AutoSize = True
        Me.lblDatoRol.BackColor = System.Drawing.Color.Transparent
        Me.lblDatoRol.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDatoRol.Location = New System.Drawing.Point(21, 233)
        Me.lblDatoRol.Name = "lblDatoRol"
        Me.lblDatoRol.Size = New System.Drawing.Size(0, 13)
        Me.lblDatoRol.TabIndex = 20
        '
        'lblDatoApellidos
        '
        Me.lblDatoApellidos.AutoSize = True
        Me.lblDatoApellidos.BackColor = System.Drawing.Color.Transparent
        Me.lblDatoApellidos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDatoApellidos.Location = New System.Drawing.Point(21, 159)
        Me.lblDatoApellidos.Name = "lblDatoApellidos"
        Me.lblDatoApellidos.Size = New System.Drawing.Size(0, 13)
        Me.lblDatoApellidos.TabIndex = 17
        '
        'lblDatoDNI
        '
        Me.lblDatoDNI.AutoSize = True
        Me.lblDatoDNI.BackColor = System.Drawing.Color.Transparent
        Me.lblDatoDNI.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDatoDNI.Location = New System.Drawing.Point(19, 119)
        Me.lblDatoDNI.Name = "lblDatoDNI"
        Me.lblDatoDNI.Size = New System.Drawing.Size(0, 13)
        Me.lblDatoDNI.TabIndex = 15
        '
        'lblDatoTelefono
        '
        Me.lblDatoTelefono.AutoSize = True
        Me.lblDatoTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblDatoTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDatoTelefono.Location = New System.Drawing.Point(21, 177)
        Me.lblDatoTelefono.Name = "lblDatoTelefono"
        Me.lblDatoTelefono.Size = New System.Drawing.Size(0, 13)
        Me.lblDatoTelefono.TabIndex = 18
        '
        'lblDatoCorreo
        '
        Me.lblDatoCorreo.AutoSize = True
        Me.lblDatoCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblDatoCorreo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDatoCorreo.Location = New System.Drawing.Point(19, 195)
        Me.lblDatoCorreo.Name = "lblDatoCorreo"
        Me.lblDatoCorreo.Size = New System.Drawing.Size(0, 13)
        Me.lblDatoCorreo.TabIndex = 19
        '
        'lblDatoNombre
        '
        Me.lblDatoNombre.AutoSize = True
        Me.lblDatoNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblDatoNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDatoNombre.Location = New System.Drawing.Point(19, 139)
        Me.lblDatoNombre.Name = "lblDatoNombre"
        Me.lblDatoNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblDatoNombre.TabIndex = 16
        '
        'lblDatoNick
        '
        Me.lblDatoNick.AutoSize = True
        Me.lblDatoNick.BackColor = System.Drawing.Color.Transparent
        Me.lblDatoNick.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDatoNick.Location = New System.Drawing.Point(19, 97)
        Me.lblDatoNick.Name = "lblDatoNick"
        Me.lblDatoNick.Size = New System.Drawing.Size(0, 13)
        Me.lblDatoNick.TabIndex = 14
        '
        'lblCerrarSesion
        '
        Me.lblCerrarSesion.AutoSize = True
        Me.lblCerrarSesion.Location = New System.Drawing.Point(578, 99)
        Me.lblCerrarSesion.Name = "lblCerrarSesion"
        Me.lblCerrarSesion.Size = New System.Drawing.Size(59, 13)
        Me.lblCerrarSesion.TabIndex = 4
        Me.lblCerrarSesion.TabStop = True
        Me.lblCerrarSesion.Text = "LinkLabel1"
        '
        'Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TPV_VB.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(882, 612)
        Me.Controls.Add(Me.lblCerrarSesion)
        Me.Controls.Add(Me.grupoModificarPass)
        Me.Controls.Add(Me.panelDatosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sesion"
        Me.Text = "Sesion"
        Me.grupoModificarPass.ResumeLayout(False)
        Me.grupoModificarPass.PerformLayout()
        Me.panelDatosUsuario.ResumeLayout(False)
        Me.panelDatosUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoModificarPass As System.Windows.Forms.GroupBox
    Friend WithEvents btnCambiarPass As System.Windows.Forms.Button
    Friend WithEvents lblPassNueva As System.Windows.Forms.Label
    Friend WithEvents txtPassNueva As System.Windows.Forms.TextBox
    Friend WithEvents lblPassActual As System.Windows.Forms.Label
    Friend WithEvents txtPassActual As System.Windows.Forms.TextBox
    Friend WithEvents panelDatosUsuario As System.Windows.Forms.Panel
    Friend WithEvents lblDatoRol As System.Windows.Forms.Label
    Friend WithEvents lblDatoApellidos As System.Windows.Forms.Label
    Friend WithEvents lblDatoCorreo As System.Windows.Forms.Label
    Friend WithEvents lblDatoNick As System.Windows.Forms.Label
    Friend WithEvents lblDatoTelefono As System.Windows.Forms.Label
    Friend WithEvents lblDatoDNI As System.Windows.Forms.Label
    Friend WithEvents lblDatoNombre As System.Windows.Forms.Label
    Friend WithEvents lblDatosUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCerrarSesion As System.Windows.Forms.LinkLabel
End Class
