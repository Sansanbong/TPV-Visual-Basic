Imports Biblioteca_TPV.ficheros
Imports Biblioteca_TPV.negocio
Imports Utiles.util
Public Class Sesion

    Private usuario As Usuario
    Sub New(ByRef usuario As Usuario)
        Me.usuario = usuario
        InitializeComponent()

    End Sub
    Private Sub Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(275, 0)
        panelDatosUsuario.BackColor = Color.FromArgb(150, Color.Black)
        cargarInfoUsuario()
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPass.Click
        Dim modificado As Integer
        If txtPassActual.Text.Trim = usuario.getDatos.contrasenya.Trim Then
            modificado = usuario.modificarPass(txtPassNueva.Text.Trim)
            If modificado = 0 Then
                MsgBox("¡Contraseña modificada!")
            Else
                MsgBox("Ha ocurrido un error.", 48, "Error")
            End If
        Else
            MsgBox("Contraseña incorrecta.", 48, "Error")
        End If
    End Sub

    Private Sub cargarInfoUsuario()
        lblDatoApellidos.Text = "Apellidos: " & usuario.getDatos.apellidos.Trim
        lblDatoCorreo.Text = "Correo electrónico: " & usuario.getDatos.correo.Trim
        lblDatoDNI.Text = "DNI: " & usuario.getDatos.dni.Trim
        lblDatoNick.Text = "Nombre de usuario: " & usuario.getDatos.nick.Trim
        lblDatoNombre.Text = "Nombre del empleado: " & usuario.getDatos.nombreEmpleado.Trim
        lblDatoTelefono.Text = "Teléfono: " & usuario.getDatos.telefono

        If usuario.getDatos.rol = 1 Then
            lblDatoRol.Text = "Rol: Administrador"
            lblDatoRol.ForeColor = Color.Yellow
        Else
            lblDatoRol.Text = "Rol: Camarero"
        End If

    End Sub
End Class