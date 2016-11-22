Imports Biblioteca_TPV.negocio
Imports Biblioteca_TPV.ficheros
Imports Utiles.util

Public Class GestionUsuarios

    Private acceso As AccesoFicheros
    Private usuario As Usuario
    Private usuarios As List(Of Usuario)
    Private validator As Validator

    Sub New(ByRef usuario As Usuario)
        InitializeComponent()

        acceso = New AccesoFicheros

        validator = New Validator
    End Sub
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(275, 0)
        cargarUsuarios()

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim user As Usuario
        Dim mensaje As String = validarInsercion()
        Dim resultadoPass As String


        'Si el mensaje de error no ha sido modificado (no ha habido errores),
        'creamos el usuario. De lo contrario, exponemos el mensaje de error.
        If mensaje = "" Then

            user = New Usuario(txtNombreUsuario.Text, txtPass.Text, txtRol.Text, txtNombreEmpleado.Text, txtApellidos.Text, txtDNI.Text, txtTelefono.Text, txtMail.Text)

            resultadoPass = InputBox("Por medidas de seguridad, por favor: Introduzca la clave de administrador.")

            ' If resultadoPass.Trim = Usuario.getDatos.contrasenya.Trim Then

            If acceso.addUsuario(user) = 1 Then
                MsgBox(mensaje, 48, "Usuario ya existente")
            Else
                MsgBox("¡Usuario insertado con éxito!")
                cargarUsuarios()
            End If

            'Else
            '     MsgBox("Contraseña incorrecta.")
            '  End If


        Else

            MsgBox(mensaje, 48, "Usuario no insertado")
        End If

    End Sub

    Private Function validarInsercion() As String
        Dim mensaje As String = ""
        If Not validator.validarTexto(txtNombreUsuario.Text) Then
            mensaje = vbNewLine & "   - El usuario debe contener sólo letras"
        End If

        If Not validator.validarTexto(txtNombreEmpleado.Text) Then
            mensaje = vbNewLine & "   - El nombre debe contener sólo letras"
        End If

        If Not validator.validarNumeroLimites(txtRol.Text, 1, 2) Then
            mensaje = vbNewLine & "   - El rol debe ser 1 (Administrador) ó 2 (Camarero)"
        End If

        If Not validator.validarDni(txtDNI.Text) Then
            mensaje = mensaje & vbNewLine & "   - El DNI introducido no es válido"
        End If

        If Not validator.validarTelefono(txtTelefono.Text) Then
            mensaje = mensaje & vbNewLine & "   - El número de teléfono introducido no es válido"
        End If

        If Not validator.validarEmail(txtMail.Text) Then
            mensaje = mensaje & vbNewLine & "   - El correo electrónico introducido no es válido"
        End If

        Return mensaje
    End Function
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrarModificar.Click
        Dim resultado As Integer
        Dim resultadoPass As String
        Dim user As Usuario

        If comboUsuarios.Items IsNot Nothing And comboUsuarios.Items.Count > 0 Then

            user = obtenerUsuarioDeCombobox()
            resultadoPass = InputBox("Por medidas de seguridad, por favor: Introduzca la clave de administrador.")

            If resultadoPass.Trim = usuario.getDatos.contrasenya.Trim Then
                resultado = user.borrarUsuario()

                If resultado = 0 Then
                    MsgBox("Usuario eliminado")
                ElseIf resultado = 1 Then
                    MsgBox("Usuario no existe.", 48, "Error")
                Else
                    MsgBox("Ha ocurrido un error.", 48, "Error")
                End If
                comboUsuarios.Items.Remove(comboUsuarios.SelectedItem)

                If usuarios IsNot Nothing And comboUsuarios.Items.Count > 0 Then
                    comboUsuarios.SelectedItem = comboUsuarios.Items.Item(0)
                End If
            Else
                MsgBox("Contraseña incorrecta.", 48, "Error")
            End If


        End If

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        cargarUsuarios()
    End Sub
    'Función encargada de leer los usuarios del fichero usuarios.txt y
    'cargarlos en el combobox excepto si son admins.
    Private Sub cargarUsuarios()
        comboUsuarios.Items.Clear()

        usuarios = acceso.leerUsuarios

        If usuarios IsNot Nothing And usuarios.Count > 0 Then

            For i = 0 To usuarios.Count - 1
                If usuarios(i).getDatos.rol > 1 Then
                    comboUsuarios.Items.Add(usuarios(i).getDatos.dni & " " & usuarios(i).getDatos.nick)
                End If


            Next
            If usuarios IsNot Nothing And comboUsuarios.Items.Count > 0 Then
                comboUsuarios.SelectedItem = comboUsuarios.Items.Item(0)
            End If

        End If


    End Sub

    'Función encargada de obtener el usuario seleccionado del combobox.
    '
    'Devuelve el usuario seleccionado.
    Function obtenerUsuarioDeCombobox() As Usuario

        Dim estructura As New Usuario.stUsuario
        estructura.nick = comboUsuarios.SelectedItem.ToString.Substring(usuario.getDNILength + 1)


        usuario.setNombre(estructura.nick.Trim)
        Return usuario
    End Function

End Class