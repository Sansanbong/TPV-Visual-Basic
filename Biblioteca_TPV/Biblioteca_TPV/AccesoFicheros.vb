Imports Biblioteca_TPV.negocio

Namespace ficheros

    Public Class AccesoFicheros

        'Constantes que definen el número de identificación de cada fichero
        Private Const FICH_USUARIOS As Integer = 1
        Private Const FICH_PRODUCTOS As Integer = 2
        Private Const FICH_FACTURAS As Integer = 3
        Private Const FICH_CAJA As Integer = 4
        Private Const FICH_LOG_ERRORES As Integer = 5

        'Constantes que definen las rutas de los ficheros que utiliza la aplicación
        Private Const PATH_USUARIOS As String = "usuarios.txt"
        Private Const PATH_PRODUCTOS As String = "productos.txt"
        Private Const PATH_FACTURAS As String = "facturas.txt"
        Private Const PATH_CAJA As String = "caja.txt"
        Private Const PATH_LOG_ERRORES As String = "log.txt"


        '---------------GESTIÓN USUARIOS-----------------

        'Login de usuario, devuelve nothing si no encuentra al usuario
        'De lo contrario devuelve el usuario con todos sus datos.
        Public Function login(ByVal usuario As Usuario) As Usuario
            Dim estructura As New Usuario.stUsuario
            Dim posicion As Integer = buscarUsuario(usuario)

            If posicion > -1 Then


                FileOpen(FICH_USUARIOS, PATH_USUARIOS, OpenMode.Random, OpenAccess.Read, , Len(usuario.getDatos()))
                Seek(FICH_USUARIOS, posicion)
                FileGet(FICH_USUARIOS, estructura)

                If usuario.getDatos.contrasenya = estructura.contrasenya.Trim Then
                    Return New Usuario(estructura)
                Else
                    Return Nothing
                End If
                FileClose(FICH_USUARIOS)
            Else
                Return Nothing
            End If

        End Function

        'Añadir usuario
        ' Función que agrega usuarios al fichero usuarios.txt
        '
        ' Devuelve:
        ' 0 si el usuario se ha creado.
        ' 1 si ya existe. 
        ' 2 si ha ocurrido un error.
        Public Function addUsuario(ByVal usuario As Usuario) As Integer
            Dim estructura As New Usuario.stUsuario
            Dim posicion As Integer = buscarUsuario(usuario)

            If posicion = -1 Then

                FileOpen(FICH_USUARIOS, PATH_USUARIOS, OpenMode.Random, OpenAccess.ReadWrite, , Len(usuario.getDatos()))
                posicion = 0
                Try
                    While True
                        posicion = posicion + 1
                        FileGet(FICH_USUARIOS, estructura, posicion)



                    End While
                Catch ex As IO.IOException

                    FilePut(FICH_USUARIOS, usuario.getDatos, posicion)
                    FileClose(FICH_USUARIOS)

                    Return 0

                End Try



            Else

                Return 1
            End If

            Return 2

        End Function

        'Método que compara el nombre a agregar con los nombres del fichero
        ' con el fin de determinar si es posible agregar o no.
        'Devuelve la posicion del usuario si existe. Si no existe devuelve -1
        Private Function buscarUsuario(ByVal usuario As Usuario) As Integer
            Dim estructura As New Usuario.stUsuario


            Dim posicion As Integer = 1

            Try
                FileOpen(FICH_USUARIOS, PATH_USUARIOS, OpenMode.Random, OpenAccess.Read, , Len(estructura))

                While True

                    FileGet(FICH_USUARIOS, estructura, posicion)

                    If estructura.nick.Trim = usuario.getDatos.nick Then
                        FileClose(FICH_USUARIOS)
                        Return posicion



                    End If

                    posicion = posicion + 1
                End While

            Catch ex As IO.IOException



            End Try
            FileClose(FICH_USUARIOS)

            Return -1

        End Function


        'Borrar usuario
        'Función encargada de borrar usuarios.
        '
        'Devuelve un valor Integer:
        '  0 si se ha modificado con éxito.
        '  1 si el usuario no existe.
        '  2 si se ha producido algún error.
        Public Function borrarUsuario(ByVal usuario As Usuario) As Integer

            Dim estructura As New Usuario.stUsuario
            estructura.nick = ""
            estructura.dni = ""

            Dim posicion As Integer
            Try
                posicion = buscarUsuario(usuario)
                FileOpen(FICH_USUARIOS, PATH_USUARIOS, OpenMode.Random, OpenAccess.ReadWrite, , Len(usuario.getDatos()))
                If posicion = -1 Then
                    Return 1
                Else

                    FilePut(FICH_USUARIOS, estructura, posicion)

                    FileClose(FICH_USUARIOS)
                    Return 0
                End If
            Catch ex As Exception

                Return 2
            End Try



        End Function

        'Función encargada de modificar la contraseña de un Usuario
        'por una contraseña nueva, ambos pasados por parámetro.
        'Copia el registro de nuevo con la nueva contraseña.
        '
        'Devuelve un valor Integer:
        '  0 si se ha modificado con éxito.
        '  1 si el usuario no existe.
        '  2 si se ha producido algún error.

        Public Function modificarPass(ByVal usuario As Usuario, ByVal newPass As String) As Integer
            Dim estructura As New Usuario.stUsuario

            Dim comprobante As Integer = 0
            Dim posicion As Integer

            Try
                posicion = buscarUsuario(usuario)
                If posicion = -1 Then
                    Return 1
                Else
                    FileOpen(FICH_USUARIOS, PATH_USUARIOS, OpenMode.Random, OpenAccess.ReadWrite, , Len(usuario.getDatos()))

                    FileGet(FICH_USUARIOS, estructura, posicion)
                    estructura.contrasenya = newPass

                    FilePut(FICH_USUARIOS, estructura, posicion)

                    FileClose(FICH_USUARIOS)
                    Return 0
                End If
            Catch ex As Exception
                Return 2

            End Try

        End Function

        'Función que lee los usuarios del fichero usuarios.txt.
        'Devuelve un arraylist de usuarios.
        'Si ocurre un error devuelve null (nothing)


        Public Function leerUsuarios() As List(Of Usuario)
            Dim estructura As New Usuario.stUsuario
            Dim usuarios As New List(Of Usuario)
            Dim posicion As Integer = 1
            Try

                FileOpen(FICH_USUARIOS, PATH_USUARIOS, OpenMode.Random, OpenAccess.Read, , Len(estructura))

                While True

                    FileGet(FICH_USUARIOS, estructura, posicion)

                    If esValido(estructura.nick.Trim.ToUpper) Then
                        usuarios.Add(New Usuario(estructura))
                    End If

                    posicion = posicion + 1

                End While
            Catch ex As Exception
                FileClose(FICH_USUARIOS)
                Return usuarios

            End Try

            Return Nothing
        End Function

        'Función que se encarga verificar si una cadena contiene caracteres típicos
        'de un usuario o no.
        'Devuelve true si la cadena es válida y false si no lo es.
        Private Function esValido(ByVal cadena As String) As Boolean
            Dim caracteres As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890"
            For i = 0 To caracteres.Length - 1

                If cadena.Contains(caracteres(i)) Then
                    Return True
                End If
            Next
            Return False



        End Function


        '--------------GESTIÓN PRODUCTOS---------------
        'Lectura de todos los productos
        Public Function leerProductos() As ArrayList

            Dim listProductos As New ArrayList
            Dim estructura As New Producto.st_Producto

            FileOpen(FICH_PRODUCTOS, PATH_PRODUCTOS, OpenMode.Random, OpenAccess.Read, , Len(estructura))
            Dim i As Integer = 1

            While Not EOF(FICH_PRODUCTOS)
                'estructura = producto.getStructure
                FileGet(FICH_PRODUCTOS, estructura, i)

                If estructura.id.Trim <> "0" Then
                    listProductos.Add(New Producto(estructura.id.Trim,
                                              estructura.nombre.Trim,
                                              estructura.precio,
                                              estructura.categoria.Trim))
                End If

                i = i + 1
            End While

            FileClose(FICH_PRODUCTOS)

            Return listProductos
        End Function

        'Búsqueda de un producto por ID, si no lo encuentra devuelve Nothing, si lo encuentra devuelve el producto
        Public Function buscarProducto(ByVal id As String) As Producto

            id = id.ToUpper
            Dim listProductos As New ArrayList
            Dim estructura As New Producto.st_Producto

            FileOpen(FICH_PRODUCTOS, PATH_PRODUCTOS, OpenMode.Random, OpenAccess.Read, , Len(estructura))

            If (IsNumeric(id)) Then
                FileGet(FICH_PRODUCTOS, estructura, Val(id))
                FileClose(FICH_PRODUCTOS)
                If estructura.id.Trim = id Then
                    Dim producto As New Producto(estructura.id.Trim,
                                              estructura.nombre.Trim,
                                              estructura.precio,
                                              estructura.categoria.Trim)
                    Return producto
                Else
                    Return Nothing
                End If

            Else
                Dim posicion As Integer = 1000
                Try
                    While True
                        FileGet(FICH_PRODUCTOS, estructura, posicion)
                        posicion = posicion + 1
                        If estructura.id.Trim = id Then
                            FileClose(FICH_PRODUCTOS)
                            Dim producto As New Producto(estructura)
                            Return producto
                        End If
                    End While
                Catch ex As IO.IOException
                    FileClose(FICH_PRODUCTOS)
                    Return Nothing
                End Try
            End If

            Return Nothing
        End Function

        'Modificar el precio de un producto
        Public Sub modificarPrecioProducto(producto As Producto, precio As Single)

            Dim posicion As Integer = getPosicion(producto)

            If posicion <> -1 Then

                producto.setPrecio(precio)
                Dim estructura As Producto.st_Producto = producto.getStructure
                FileOpen(FICH_PRODUCTOS, PATH_PRODUCTOS, OpenMode.Random, OpenAccess.Write, , Len(estructura))
                FilePut(FICH_PRODUCTOS, estructura, posicion)

                FileClose(FICH_PRODUCTOS)

            Else
                Throw New Exception
            End If

        End Sub

        'Devuelve la posición en la que está guardado un producto en el fichero.
        Private Function getPosicion(ByVal producto As Producto) As Integer

            If IsNumeric(producto.getStructure.id) Then
                Return producto.getStructure.id
            Else
                Dim posicion As Integer = 1000
                Dim estructura As New Producto.st_Producto
                FileOpen(FICH_PRODUCTOS, PATH_PRODUCTOS, OpenMode.Random, OpenAccess.Read, , Len(estructura))
                Try
                    While True

                        FileGet(FICH_PRODUCTOS, estructura, posicion)
                        If (estructura.id.Trim = producto.getStructure.id.Trim) Then
                            FileClose()
                            Return posicion
                        End If

                        posicion = posicion + 1
                    End While
                Catch ex As Exception
                    FileClose(FICH_PRODUCTOS)
                End Try
            End If

            Return -1
        End Function

        '--------------GESTIÓN PEDIDOS-------------------
        'Consulta la cantidad de dinero que hay en la caja, es decir, suma todos los importes
        'añadidos al fichero diario
        Public Function consultarCaja() As Single
            FileOpen(FICH_CAJA, PATH_CAJA, OpenMode.Input)

            Dim total As Single = 0
            Dim i As Single = 0
            
            Dim tokens() As String = LineInput(FICH_CAJA).Split(",")
            For i = 0 To tokens.Length - 2
                total = total + CSng(tokens(i))
            Next

            FileClose(FICH_CAJA)

            Return total
        End Function

        'Consulta la caja y la cierra, es decir, limpia los registros de ese día.
        Public Function hacerCaja() As Single
            Dim cajaTotal As Single = consultarCaja()
            My.Computer.FileSystem.DeleteFile(PATH_CAJA)

            FileOpen(FICH_FACTURAS, PATH_FACTURAS, OpenMode.Append)
            WriteLine(FICH_FACTURAS, Date.Now.ToString & " -> " & "CAJA TOTAL: " & cajaTotal & "€")
            FileClose(FICH_FACTURAS)

            Return cajaTotal
        End Function

        'Guarda el importe de una factura en el fichero diario (la caja, la caja)
        Public Sub guardarImportePedido(ByVal factura As Factura)
            FileOpen(FICH_CAJA, PATH_CAJA, OpenMode.Append, OpenAccess.Write)

            Dim linea As Single = factura.getTotal
            Write(FICH_CAJA, linea)

            FileClose(FICH_CAJA)
        End Sub

        '--------------LOG DE ERRORES--------------------
        'Escribir una línea de error en el LOG
        Public Sub escribirError(ByVal ex As Exception, ByVal mensaje As String)

            FileOpen(FICH_LOG_ERRORES, PATH_LOG_ERRORES, OpenMode.Append, OpenAccess.Write)
            WriteLine(FICH_LOG_ERRORES, Date.Now.ToString() + ": " + ex.Message + " - " + mensaje)
            FileClose(FICH_LOG_ERRORES)

        End Sub

    End Class
End Namespace