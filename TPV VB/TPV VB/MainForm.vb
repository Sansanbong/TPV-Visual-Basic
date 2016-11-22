Imports Biblioteca_TPV.negocio
Imports Biblioteca_TPV.ficheros
Public Class Inicio

    Public usuario As Usuario
    Private acceso As AccesoFicheros
    Public formLogin As Login
    Public formSesion As Sesion

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acceso = New AccesoFicheros
        acceso.crearFicheroUsuarios()
        formLogin = New Login(Me)

        formLogin.MdiParent = Me
        formLogin.Show()

    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Dim form As New Facturas()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click


        formSesion.Show()
    End Sub

    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        Dim form As New GestionUsuarios(usuario)
        form.MdiParent = Me
        form.Show()
        form.cargarUsuarios()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

        If MsgBox("¿Está seguro de que desea salir de su cuenta?", 52, "Cerrar sesión.") = MsgBoxResult.Yes Then
            usuario = New Usuario
            formLogin.Show()



        End If
    End Sub
End Class
