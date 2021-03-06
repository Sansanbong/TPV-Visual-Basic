﻿Imports Biblioteca_TPV.negocio
Imports Biblioteca_TPV.ficheros
Imports Utiles.util
Public Class Login

    Private usuario As Usuario
    Private mainForm As Inicio
    Private acceso As AccesoFicheros
    Private validator As Validator

    Public Sub New(ByRef mainForm As Inicio)
        InitializeComponent()
        Me.mainForm = mainForm
        acceso = New AccesoFicheros
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(275, 0)
        panelLogin.BackColor = Color.FromArgb(150, Color.Black)
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click

        usuario = New Usuario(txtUsuario.Text.Trim, txtContrasenya.Text.Trim).iniciarSesion

        If usuario IsNot Nothing Then

            MsgBox("¡Bienvenido!")
            mainForm.usuario = usuario

            mainForm.btnFacturas.Enabled = True
            mainForm.btnProductos.Enabled = True
            mainForm.btnSesion.Enabled = True
            mainForm.btnCaja.Enabled = True

            mainForm.formSesion = New Sesion(mainForm)
            mainForm.formSesion.MdiParent = mainForm
            mainForm.formSesion.Show()

            If usuario.getDatos.rol = 1 Then

                '   GestionUsuariosToolStripMenuItem.Enabled = True
                ' cargarUsuarios()


            End If



            ' cargarInfoUsuario()


            Hide()
        Else
            MsgBox("Nombre de usuario o contraseña incorrectos.")
        End If
    End Sub

    Function getUsuarioLoggeado() As Usuario
        Return usuario
    End Function

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.Location = New Point(275, 0)
    End Sub
End Class