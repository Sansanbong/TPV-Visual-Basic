
Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New Login
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Dim form As New Facturas()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        Dim form As New GestionUsuarios
        form.MdiParent = Me
        form.Show()
    End Sub

End Class
