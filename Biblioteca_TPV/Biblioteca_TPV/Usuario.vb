Namespace negocio

    Public Class Usuario
        Private Const LENGTH_NICK As Integer = 10
        Private Const LENGTH_PASS As Integer = 11
        Private Const LENGTH_ROL As Integer = Integer.MaxValue
        Private Const LENGTH_NOMBRE As Integer = 25
        Private Const LENGTH_APELLIDOS As Integer = 26
        Private Const LENGTH_DNI As Integer = 15
        Private Const LENGTH_TELEFONO As Long = Long.MaxValue
        Private Const LENGTH_CORREO As Integer = 50
        Structure stUsuario
            'Nombre del usuario
            <VBFixedString(LENGTH_NICK)> Dim nick As String

            'Clave de acceso del usuario en cuestión.
            <VBFixedString(LENGTH_PASS)> Dim contrasenya As String

            'Rol del usuario. Admin o camarero
            Dim rol As Integer

            'Nombre real del empleado
            <VBFixedString(LENGTH_NOMBRE)> Dim nombreEmpleado As String

            'Apellidos del empleado
            <VBFixedString(LENGTH_APELLIDOS)> Dim apellidos As String

            'DNI del empleado
            <VBFixedString(LENGTH_DNI)> Dim dni As String

            'Teléfono del empleado
            Dim telefono As Long

            'Correo electrónico del empleado
            <VBFixedString(LENGTH_CORREO)> Dim correo As String

        End Structure

        'datos es el resultado de instanciar una estructura con los datos del usuario.
        Private datos As New stUsuario

        'Método constructor de la clase Usuario
        Sub New()

        End Sub

        Sub New(ByVal estructuraUsuario As Usuario.stUsuario)
            Me.datos.dni = estructuraUsuario.dni.Trim
            Me.datos.apellidos = estructuraUsuario.apellidos.Trim
            Me.datos.contrasenya = estructuraUsuario.contrasenya.Trim
            Me.datos.correo = estructuraUsuario.correo.Trim
            Me.datos.nick = estructuraUsuario.nick.Trim
            Me.datos.nombreEmpleado = estructuraUsuario.nombreEmpleado.Trim
            Me.datos.rol = estructuraUsuario.rol
            Me.datos.telefono = estructuraUsuario.telefono
        End Sub
        Sub New(ByVal nombre As String)
            Me.datos.nick = nombre
        End Sub

        Sub New(ByVal nick As String, ByVal contrasenya As String)
            Me.datos.nick = nick
            Me.datos.contrasenya = contrasenya
        End Sub
        Sub New(ByVal nick As String, ByVal contrasenya As String, ByVal rol As Integer, ByVal nombreEmpleado As String, ByVal apellidos As String, ByVal dni As String, ByVal telefono As Long, ByVal correo As String)
            Me.datos.nick = nick.Trim
            Me.datos.contrasenya = contrasenya.Trim
            Me.datos.rol = rol
            Me.datos.nombreEmpleado = nombreEmpleado.Trim
            Me.datos.apellidos = apellidos.Trim
            Me.datos.dni = dni.Trim
            Me.datos.telefono = telefono
            Me.datos.correo = correo.Trim
        End Sub

        'Función que devuelve el usuario resultado de
        'verificar si  el login es correcto o no.
        'De no serlo, devuelve nothing.
        Function iniciarSesion() As Usuario

            Dim acceso As New ficheros.AccesoFicheros

            Return acceso.login(Me)



        End Function

        Function borrarUsuario() As Integer
            Dim acceso As New ficheros.AccesoFicheros

            Return acceso.borrarUsuario(Me)
        End Function

        Function modificarPass(ByVal newPass As String) As Integer
            Dim acceso As New ficheros.AccesoFicheros

            Return acceso.modificarPass(Me, newPass)
        End Function
        'Método getter del atributo datos
        Function getDatos() As stUsuario
            Return Me.datos
        End Function

        Function getNickLength() As Integer

            Return LENGTH_NICK

        End Function
        Function getApellidosLength() As Integer

            Return LENGTH_APELLIDOS

        End Function
        Function getNombreLength() As Integer

            Return LENGTH_NOMBRE

        End Function
        Function getDNILength() As Integer

            Return LENGTH_DNI

        End Function
        Function getTelefonoLength() As Long

            Return LENGTH_TELEFONO

        End Function
        Function getPassLength() As Integer

            Return LENGTH_PASS

        End Function
        Function getRolLength() As Integer

            Return LENGTH_ROL

        End Function

        Sub setNombre(ByVal nick As String)
            Me.datos.nick = nick

        End Sub
        Sub setPass(ByVal pass As String)
            Me.datos.contrasenya = pass
        End Sub
    End Class

End Namespace
