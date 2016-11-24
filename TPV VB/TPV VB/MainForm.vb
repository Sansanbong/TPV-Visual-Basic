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

    Private Sub ConsultarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCajaToolStripMenuItem.Click
        Try
            MsgBox("Importe recaudado hoy " & acceso.consultarCaja())
        Catch ex As Exception
            'log errores
        End Try

    End Sub

    Private Sub HacerCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HacerCajaToolStripMenuItem.Click

        Dim consultado As Single
        Try
            consultado = acceso.consultarCaja()
        Catch ex As Exception
            'log errores
        End Try

        If MsgBox("Importe del día: " & consultado & vbNewLine & "El importe del día volverá a ser 0. ¿Está seguro de que desea hacer caja?", 52, "Total recaudado - " & Date.Now.ToString) = MsgBoxResult.Yes Then

            Try
                acceso.hacerCaja()
                MsgBox("Importe total del día " & Date.Now.ToString & "  (" & consultado & ") guardado con éxito.", , "Haciendo caja")
            Catch ex As Exception
                'log errores
            End Try



        End If
    End Sub

    Public Sub activarFuncionesEmpleado()
        btnFacturas.Enabled = True
        btnProductos.Enabled = True
        btnSesion.Enabled = True
        btnAyuda.Enabled = True

        CerrarSesiónToolStripMenuItem.Enabled = True
    End Sub

    Public Sub desactivarFuncionesEmpleado()
        btnFacturas.Enabled = False
        btnProductos.Enabled = False
        btnSesion.Enabled = False
        btnAyuda.Enabled = False

        CerrarSesiónToolStripMenuItem.Enabled = False
    End Sub


    Public Sub activarFuncionesAdmin()
        GestionUsuariosToolStripMenuItem.Enabled = True
        HacerCajaToolStripMenuItem.Enabled = True
        ConsultarCajaToolStripMenuItem.Enabled = True


    End Sub

    Public Sub desactivarFuncionesAdmin()
        GestionUsuariosToolStripMenuItem.Enabled = False
        HacerCajaToolStripMenuItem.Enabled = False
        ConsultarCajaToolStripMenuItem.Enabled = False
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click

    End Sub
End Class
