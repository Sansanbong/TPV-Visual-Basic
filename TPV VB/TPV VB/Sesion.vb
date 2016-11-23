Imports Biblioteca_TPV.ficheros
Imports Biblioteca_TPV.negocio
Imports Utiles.util
Public Class Sesion
    Private validator As Validator

    Private mainForm As Inicio
    Sub New(ByRef mainForm As Inicio)
        Me.mainForm = mainForm

        InitializeComponent()
        validator = New Validator

    End Sub
    Private Sub Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(275, 0)
        panelDatosUsuario.BackColor = Color.FromArgb(150, Color.Black)

        cargarInfoUsuario()

        If mainForm.usuario.getDatos.rol = 1 Then
            grupoModificarPass.Enabled = False
        End If
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPass.Click
        Dim modificado As Integer
        Dim mensaje As String = ""
        Dim newPass As String = txtPassNueva.Text.Trim

        If txtPassActual.Text.Trim = mainForm.usuario.getDatos.contrasenya.Trim Then



            modificado = mainForm.usuario.modificarPass(newPass)


            If Not validator.validarTexto(txtPassActual.Text) Or Not validator.validarTexto(txtPassNueva.Text) Then
                mensaje = vbNewLine & "   - La contraseña debe contener sólo letras"
            End If



            If modificado = 0 And mensaje.Length = 0 Then
                mainForm.usuario.setPass(newPass)
                MsgBox("¡Contraseña modificada!")
            Else
                MsgBox("Ha ocurrido un error." & modificado, 48, "Error")
            End If
        Else
            MsgBox("Contraseña incorrecta.", 48, "Error")
        End If
    End Sub

    Private Sub cargarInfoUsuario()
        lblDatoApellidos.Text = "Apellidos: " & mainForm.usuario.getDatos.apellidos.Trim
        lblDatoCorreo.Text = "Correo electrónico: " & mainForm.usuario.getDatos.correo.Trim
        lblDatoDNI.Text = "DNI: " & mainForm.usuario.getDatos.dni.Trim
        lblDatoNick.Text = "Nombre de usuario: " & mainForm.usuario.getDatos.nick.Trim
        lblDatoNombre.Text = "Nombre del empleado: " & mainForm.usuario.getDatos.nombreEmpleado.Trim
        lblDatoTelefono.Text = "Teléfono: " & mainForm.usuario.getDatos.telefono

        If mainForm.usuario.getDatos.rol = 1 Then
            lblDatoRol.Text = "Rol: Administrador"
            lblDatoRol.ForeColor = Color.Yellow
        Else
            lblDatoRol.Text = "Rol: Camarero"
        End If

    End Sub

    Private Sub lblCerrarSesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCerrarSesion.LinkClicked
        If MsgBox("¿Está seguro de que desea salir de su cuenta?", 52, "Cerrar sesión.") = MsgBoxResult.Yes Then
            mainForm.usuario = New Usuario
            mainForm.formLogin.Show()
            Dispose()
        End If
    End Sub
End Class