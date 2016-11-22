Namespace negocio

    Public Class Producto
        
        Structure st_Producto
            <VBFixedString(5)> Dim id As String
            <VBFixedString(60)> Dim nombre As String
            Dim precio As Single
            <VBFixedString(25)> Dim categoria As String
        End Structure

        Private producto As st_Producto

        'Constructor vacío
        Public Sub New()
        End Sub

        'Constructor de estructura
        Public Sub New(ByVal estructura As st_Producto)
            Me.producto = estructura
        End Sub

        'Constructor: recibe todos los atributos que forman un producto, por lo que no habrá setters.
        Public Sub New(ByVal id As String, ByVal nombre As String, ByVal precio As Single, ByVal categoria As String)
            producto.nombre = nombre
            producto.id = id
            producto.precio = precio
            producto.categoria = categoria
        End Sub

        'Función equals que compara el nombre de un producto con el que llama al método
        'con el fin de saber si son iguales por medio del nombre.
        'Devuelve true si los nombres coinciden, o false de lo contrario.
        Function coincideNombre(ByVal oProducto As Producto) As Boolean
            If producto.nombre = oProducto.getStructure.nombre Then
                Return True
            End If
            Return False
        End Function

        'Este getter devuelve la estructura que contiene los campos de un producto.
        Public Function getStructure() As st_Producto
            Return producto
        End Function

            'Aún por planificar. Método encargado de llamar al método modificarPrecio de la clase AccesoDatos
            'que accederá al fichero para actualizarlo. 

        Public Sub modificarPrecio(ByVal precio As Single)
            MsgBox("YO")
            Dim acceso As New ficheros.AccesoFicheros
            acceso.modificarPrecioProducto(Me, precio)    'Me es el equivalente al this de Java

        End Sub

        Public Sub setPrecio(ByVal precio As Single)
            If (precio > 0) Then
                Me.producto.precio = precio
            End If
        End Sub

    End Class

End Namespace


