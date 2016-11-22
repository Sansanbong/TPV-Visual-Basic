Imports Biblioteca_TPV.ficheros

Namespace negocio

    Public Class Factura

        Private idFactura As Integer
        'Private mesa As Mesa
        Private fecha As Date
        'TODO: private cabecera as X -> Esto puede hacerlo la clase Ficheros directamente
        Private importeTotal As Single
        Private lineasFactura As ArrayList

        'El constructor coge la fecha del sistema e inicia la colección de líneas
        Public Sub New()
            Me.fecha = Date.Now
            Me.lineasFactura = New ArrayList
        End Sub

        '-------------Getters y setters----------------
        'TODO: En principio sólo veo que se vayan a llamar a esto, si hace falta más se programan aquí
        'ID
        Public Function getID() As Integer
            Return Me.idFactura
        End Function

        'LineasPedido
        Public Function getLineasPedido() As ArrayList
            Return Me.lineasFactura
        End Function

        'Get del importe total
        Function getTotal() As Integer
            Return importeTotal
        End Function

        '------------Funcionalidades-------------------

        'Agrega una línea a la factura. Si existe le suma uno a la cantidad.
        Public Sub addLinea(ByVal linea As LineaFactura)
            Dim existe As Boolean = False

            For i = 0 To lineasFactura.Count - 1
                Dim lineaBuscada As LineaFactura = CType(lineasFactura.Item(i), LineaFactura)
                If (lineaBuscada.getProducto.getStructure.id = linea.getProducto.getStructure.id) Then
                    lineaBuscada.incrementarCantidad()
                    lineasFactura.Item(i) = lineaBuscada
                    existe = True
                    Exit For
                End If
            Next

            If Not existe Then
                lineasFactura.Add(linea)
            End If

        End Sub

        'Quita una línea de la colección de líneas (si la cantidad de la línea es de más de uno, la decrementa, no la quita)
        Public Sub quitarLinea(ByVal linea As LineaFactura)

            For i = 0 To lineasFactura.Count - 1
                Dim lineaBuscada As LineaFactura = CType(lineasFactura.Item(i), LineaFactura)
                If (lineaBuscada.getProducto.getStructure.id = linea.getProducto.getStructure.id) Then
                    If lineaBuscada.getCantidad > 1 Then
                        lineaBuscada.decrementarCantidad()
                        lineasFactura.Item(i) = lineaBuscada
                        Exit For
                    Else
                        lineasFactura.RemoveAt(i)
                        Exit For
                    End If
                End If

            Next

        End Sub

        'Genera el importe total a partir de las líneas que formen la factura
        Public Function obtenerImporte() As Single

            If (lineasFactura.Count = 0) Then
                Throw New Exception
            End If

            importeTotal = 0
            For i = 0 To lineasFactura.Count - 1
                Dim linea As LineaFactura = CType(lineasFactura.Item(i), LineaFactura)
                'Importe total = SUMATORIO(precio producto x cantidad)
                importeTotal = importeTotal + (linea.getProducto.getStructure.precio * linea.getCantidad)
            Next

            Return importeTotal
        End Function

        'Llamar al método correspondiente de ficheros pasándole Me
        Public Sub guardarImporte()
            Dim acceso As New AccesoFicheros
            acceso.guardarImportePedido(Me)
        End Sub



    End Class

End Namespace