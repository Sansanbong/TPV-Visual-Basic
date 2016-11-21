Imports Biblioteca_TPV.negocio
Public Class Inicio
    Public usuario As Usuario
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New Login(Me)
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Dim form As New Facturas()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        Dim form As New Sesion(usuario)
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        Dim form As New GestionUsuarios(usuario)
        form.MdiParent = Me
        form.Show()

    End Sub
End Class
