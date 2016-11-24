Imports Biblioteca_TPV.ficheros
Imports Biblioteca_TPV.negocio

Public Class Facturas
    Private factura As Factura
    Private acceso As AccesoFicheros
    Private productos As ArrayList
    Private panelBtnProductos As Panel

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(275, 0)

        factura = New Factura
        acceso = New AccesoFicheros
        productos = acceso.leerProductos

        btnVistaPrevia.Enabled = False
        btnImprimir.Enabled = False
        'panelCalculadora.Enabled = False
        lbCalcTop.Text = ""
        lbCalcBot.Text = "0,00"

    End Sub

    'Búsqueda de producto por ID en la colección de productos guardada en memoria
    Public Function buscarProducto(ByVal id As String)
        Dim producto As Producto

        For i = 0 To productos.Count - 1
            producto = CType(productos.Item(i), Producto)
            If (producto.getStructure.id.Trim = id) Then
                Return producto
            End If
        Next

        Return Nothing
    End Function

    'Función privada que convierte un valor de tipo Single a un String con formato de dos decimales.
    Private Function parsearSingle(ByVal valor As Single) As String
        Dim cadena As String = ""
        cadena = Math.Round(valor, 2)

        Dim tokens() As String = cadena.Split(",")
        Try
            If tokens(1).Count = 1 Then
                cadena = cadena + "0"
            End If
        Catch ex As IndexOutOfRangeException
            cadena = cadena + ",00"
        End Try

        Return cadena
    End Function

    'Lee los productos de una categoría
    Private Function leerProductosCategoria(categoria As String) As ArrayList
        Dim prodsCat As New ArrayList
        Dim producto As Producto
        For i = 0 To productos.Count - 1
            producto = CType(productos.Item(i), Producto)
            If (producto.getStructure.categoria = categoria) Then
                prodsCat.Add(producto)
            End If
        Next

        Return prodsCat
    End Function

    '-------------------------- PANELES DE CATEGORÍA Y PRODUCTOS ----------------------------------
    '----------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------

    'Listener para los botones de las categorías
    Private Sub botonesCat_Click(sender As Object, e As EventArgs) Handles btnCat1.Click, btnCat2.Click,
    btnCat3.Click, btnCat4.Click, btnCat5.Click, btnCat6.Click, btnCat7.Click, btnCat8.Click,
    btnCat9.Click, btnCat10.Click, btnCat11.Click, btnCat12.Click, btnCat13.Click, btnCat14.Click,
    btnCat15.Click

        Dim categoria As String = ""

        Select Case CType(sender, Button).Name
            Case "btnCat1"
                categoria = "ARROCES Y NOODLES"
            Case "btnCat2"
                categoria = "AVES"
            Case "btnCat3"
                categoria = "CARNES"
            Case "btnCat4"
                categoria = "ENSALADAS"
            Case "btnCat5"
                categoria = "ENTRANTES"
            Case "btnCat6"
                categoria = "GUNKAN"
            Case "btnCat7"
                categoria = "MAKI"
            Case "btnCat8"
                categoria = "NIGIRI"
            Case "btnCat9"
                categoria = "PESCADOS Y MARISCOS"
            Case "btnCat10"
                categoria = "POSTRES"
            Case "btnCat11"
                categoria = "ROLLS"
            Case "btnCat12"
                categoria = "SASHIMI"
            Case "btnCat13"
                categoria = "SOPAS"
            Case "btnCat14"
                categoria = "TARTAR"
            Case "btnCat15"
                categoria = "VERDURAS"
        End Select

        generarBotonesProducto(categoria)
    End Sub

    'Genera los botones de los productos de una categoría
    Private Sub generarBotonesProducto(ByVal categoria As String)
        Dim prodsCat As ArrayList = leerProductosCategoria(categoria)
        Dim producto As Producto

        Dim x As Integer = 20
        Dim y As Integer = 20

        'Generación del panel
        panelBtnProductos = New Panel
        With panelBtnProductos
            .Name = "panelPodructos"
            .Location = panelCategorias.Location
            .Size = panelCategorias.Size
            .BackColor = Color.Azure
            .BorderStyle = BorderStyle.FixedSingle
        End With

        AddHandler panelBtnProductos.Click, AddressOf Facturas_Click

        'Generación de botones
        For i = 0 To prodsCat.Count - 1
            producto = CType(prodsCat.Item(i), Producto)

            Dim boton As New Button
            With boton
                .Name = "btn" & producto.getStructure.id
                .Location = New Point(x, y)
                .Size = New Size(75, 75)
                .Text = producto.getStructure.id
                .Parent = panelBtnProductos
                .BringToFront()
                .BackColor = Color.LightCyan
            End With

            ttProductos.SetToolTip(boton, producto.getStructure.nombre)
            AddHandler boton.Click, AddressOf btnProducto_Click
            panelBtnProductos.Controls.Add(boton)

            'Condición salto de línea
            If (i + 1) Mod 4 = 0 Then
                x = 20
                y = y + 100
            Else
                x = x + 75
            End If
        Next

        'Generación botón back
        Dim botonBack As New Button
        With botonBack
            .Location = New Point(255, 460)
            .Size = New Size(75, 75)
            .Parent = panelBtnProductos
            .Name = "btnVolverProds"
            .BringToFront()
            .BackColor = Color.LightCyan
            .BackgroundImage = il_Categorias.Images.Item(15)
            .BackgroundImageLayout = ImageLayout.Center
        End With

        AddHandler botonBack.Click, AddressOf btnVolverProds_Click
        panelBtnProductos.Controls.Add(botonBack)
        Me.Controls.Add(panelBtnProductos)

        mostrarBotones()
    End Sub

    'BACK -> Botón volver del panel de productos generados
    Private Sub btnVolverProds_Click(sender As Object, e As EventArgs)
        panelBtnProductos.Dispose()
        panelCategorias.Show()
    End Sub

    Public Sub mostrarBotones()
        panelCategorias.Hide()
        panelBtnProductos.Show()
    End Sub

    'Listener para los botones de producto generados
    Private Sub btnProducto_Click(sender As Object, e As EventArgs)
        Dim boton As Button = CType(sender, Button)
        Dim nombreBoton As String = boton.Text

        Dim producto As Producto = acceso.buscarProducto(nombreBoton)
        Dim linea As New LineaFactura(producto)
        factura.addLinea(linea)
        actualizarListsFactura()
    End Sub

    '------------------------------- LISTAS CAJA -----------------------------------
    '-------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------

    'Limpia la selección de los lists box al hacer click en otra parte
    Private Sub Facturas_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbCodProd.SelectedIndex = -1
        lbPrecio.SelectedIndex = -1
        lbTotal.SelectedIndex = -1
        lbProducto.SelectedIndex = -1
        lbCantidad.SelectedIndex = -1
    End Sub

    'Actualiza la lista de líneas
    Private Sub actualizarListsFactura()
        limpiarListas()
        Dim linea As LineaFactura
        Dim precio As String = ""
        Dim total As String = ""


        For i = 0 To factura.getLineasPedido.Count - 1
            linea = factura.getLineasPedido.Item(i)
            lbCodProd.Items.Add(linea.getProducto.getStructure.id)
            lbCantidad.Items.Add(linea.getCantidad)
            lbPrecio.Items.Add(linea.getProducto.getStructure.precio)
            lbProducto.Items.Add(linea.getProducto.getStructure.nombre)
            total = linea.getProducto.getStructure.precio * linea.getCantidad
            lbTotal.Items.Add(total)

        Next

        If factura.getLineasPedido.Count <> 0 Then
            btnImprimir.Enabled = True
            btnVistaPrevia.Enabled = True
        Else
            btnImprimir.Enabled = False
            btnVistaPrevia.Enabled = False
        End If

        Try
            lblTotalPedido.Text = factura.obtenerImporte
        Catch ex As Exception
            lblTotalPedido.Text = 0
        End Try


    End Sub

    'LIMPIAR LISTAS
    Private Sub limpiarListas()
        lbCodProd.Items.Clear()
        lbCantidad.Items.Clear()
        lbPrecio.Items.Clear()
        lbProducto.Items.Clear()
        lbTotal.Items.Clear()
    End Sub

    'BOTÓN ELIMINAR FACTURA
    Private Sub btnBorrarFactura_Click(sender As Object, e As EventArgs) Handles btnBorrarFactura.Click
        eliminarFactura()
    End Sub

    'BOTÓN BORRAR CONJUNTO DE LÍNEAS
    Private Sub btnLimpiarLista_Click(sender As Object, e As EventArgs) Handles btnQuitarLineas.Click
        borrarConjuntoLineas()
    End Sub

    Public Sub eliminarFactura()
        If MsgBox("Esta acción borrará la factura, ¿está seguro de ello?", 36, "Borrar factura") = 6 Then
            factura = New Factura()
            actualizarListsFactura()
        End If
    End Sub

    'BOTON QUITAR LÍNEA
    Private Sub btnQuitarLinea_Click(sender As Object, e As EventArgs) Handles btnQuitarLinea.Click

        If lbCodProd.SelectedIndex <> -1 Then
            Dim index As Integer = lbCodProd.SelectedIndex
            Dim prod As Producto = buscarProducto(lbCodProd.SelectedItem.ToString.Trim)
            Dim linea As New LineaFactura(prod)
            factura.quitarLinea(linea)
            actualizarListsFactura()

            Try
                lbCodProd.SelectedIndex = index
            Catch ex As Exception
                lbCodProd.SelectedIndex = index - 1
            End Try

        End If
    End Sub

    'LISTENER PARA BORRAR LÍNEAS CUANDO PULSAS SUPRIMIR
    Private Sub list_KeyDown(sender As Object, e As KeyEventArgs) Handles lbCodProd.KeyDown, lbPrecio.KeyDown,
        lbCantidad.KeyDown, lbTotal.KeyDown, lbProducto.KeyDown
        If lbCodProd.SelectedIndex <> -1 Then
            If e.KeyValue = Keys.Delete Then
                borrarConjuntoLineas()
            End If
        End If
    End Sub

    'MÉTODO QUE BORRA UN CONJUNTO DE LÍNEAS
    Private Sub borrarConjuntoLineas()
        If lbCodProd.SelectedIndex <> -1 Then
            Dim index As Integer = lbCodProd.SelectedIndex
            Dim cantidad As Integer = Val(lbCantidad.SelectedItem.ToString)
            Dim prod As Producto
            Dim linea As LineaFactura
            prod = buscarProducto(lbCodProd.SelectedItem.ToString.Trim)
            linea = New LineaFactura(prod)
            'En función de la cantidad seleccionada, itero hasta borrar todas las líneas de ese producto
            For i = 0 To cantidad - 1
                factura.quitarLinea(linea)
            Next

            actualizarListsFactura()
        End If
    End Sub

    'Listener para que un campo seleccionado en uno de los cuatro ListBox selecciones el mismo para todos los demás
    Private Sub lbCantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCantidad.SelectedIndexChanged,
        lbPrecio.SelectedIndexChanged, lbProducto.SelectedIndexChanged, lbTotal.SelectedIndexChanged,
        lbCodProd.SelectedIndexChanged

        Dim selectedIndex As Integer = CType(sender, ListBox).SelectedIndex

        lbCodProd.SelectedIndex = selectedIndex
        lbCantidad.SelectedIndex = selectedIndex
        lbPrecio.SelectedIndex = selectedIndex
        lbProducto.SelectedIndex = selectedIndex
        lbTotal.SelectedIndex = selectedIndex

    End Sub

    

    '------------------------------------- IMPRESIÓN ----------------------------------------------
    '----------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------


    Private Sub printer_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printer.PrintPage
        'Listener para PrintDocument

        Dim x As Integer = 120
        Dim y As Integer = 120

        Dim random As New Random

        Dim numFactura As Integer = random.Next(10000, 99999)
        Dim numMesa As Integer = 16
        Dim numPersonas As Integer = 4

        e.Graphics.DrawImage(My.Resources.logoTicket, x, y)
        e.Graphics.DrawString("RESTAURANTE LUOS S.L", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, 220, y)
        y = y + 40
        e.Graphics.DrawString("LUOS", New Font("Arial", 22, FontStyle.Bold), Brushes.Black, 260, y)
        y = y + 40
        e.Graphics.DrawString("C/ ANDRES MELLADO 5", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, 200, y)
        y = y + 25
        e.Graphics.DrawString("28015 MADRID", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, 230, y)
        y = y + 25
        e.Graphics.DrawString("TELE: 915495211  915430332", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, 180, y)
        y = y + 25
        e.Graphics.DrawString("CIF/NIF: B86860293", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, 215, y)
        y = y + 25

        e.Graphics.FillRectangle(Brushes.Black, x, y, 330, 5)
        y = y + 5
        e.Graphics.DrawString("Fac.     " & numFactura & "  Fecha:    " & Date.Now, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x, y)
        y = y + 25
        e.Graphics.DrawString("Mesa.           " & numMesa & "  Personas:                                   " & numPersonas, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, x, y)
        y = y + 5
        e.Graphics.DrawString("------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x, y)
        y = y + 12
        e.Graphics.DrawString("CAN.", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x, y)
        e.Graphics.DrawString("PRE.", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x + 50, y)
        e.Graphics.DrawString("CONCEPTO.", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x + 100, y)
        e.Graphics.DrawString("SUM.", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x + 290, y)
        y = y + 6
        e.Graphics.DrawString("------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x, y)
        y = y + 20

        'IMPRESIÓN LÍNEAS
        For i = 0 To lbCodProd.Items.Count - 1

            e.Graphics.DrawString(lbCantidad.Items.Item(i) & " x", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, x, y)

            Dim precio As String = parsearSingle(CSng(lbPrecio.Items.Item(i)))
            e.Graphics.DrawString(precio, New Font("Arial", 11, FontStyle.Bold), Brushes.Black, x + 50, y)

            Dim nombre As String = lbProducto.Items.Item(i).ToString.Trim

            If nombre.Count <= 16 Then
                e.Graphics.DrawString(nombre.ToUpper, New Font("Arial", 11, FontStyle.Bold), Brushes.Black, x + 100, y)
            Else
                Dim aux As String = ""
                For j = 0 To 15
                    aux = aux + nombre(j)
                Next
                aux = aux + "..."
                e.Graphics.DrawString(aux.ToUpper, New Font("Arial", 11, FontStyle.Bold), Brushes.Black, x + 100, y)
            End If

            Dim precioTotal As String = parsearSingle(CSng(lbTotal.Items.Item(i)))
            e.Graphics.DrawString(precioTotal, New Font("Arial", 11, FontStyle.Bold), Brushes.Black, x + 290, y)
            y = y + 20
        Next

        y = y + 10
        e.Graphics.DrawString("------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, x, y)

        y = y + 20

        e.Graphics.DrawString("Total:", New Font("Arial", 15, FontStyle.Bold), Brushes.Black, 160, y)
        Dim totalFinal As String = parsearSingle(factura.obtenerImporte)
        e.Graphics.DrawString(totalFinal & "  €", New Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, y)

        y = y + 50
        e.Graphics.DrawString("IVA INCLUIDO", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 240, y)
        y = y + 20
        e.Graphics.DrawString("GRACIAS POR SU VISITA", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 200, y)
        y = y + 20
        e.Graphics.DrawString("WWW.RESTAURANTELUOS.COM", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 170, y)

    End Sub

    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click
        printPreview.Document = printer
        printPreview.ShowDialog()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        printer.Print()
    End Sub


    '------------------------------- CALCULADORA ---------------------------------------------------
    '------------------------------- ----------- ---------------------------------------------------
    '------------------------------- ----------- ---------------------------------------------------

    'Listener de botones numéricos de la calculadora
    Private Sub btnCalc0_Click(sender As Object, e As EventArgs) Handles btnCalc0.Click, btnCalc1.Click,
        btnCalc2.Click, btnCalc3.Click, btnCalc4.Click, btnCalc5.Click, btnCalc6.Click, btnCalc7.Click,
        btnCalc8.Click, btnCalc9.Click, btnCalcComa.Click, btnCalc00.Click

        Dim botonPulsado As Button = CType(sender, Button)
        pulsarNumCalculadora(botonPulsado.Text)
    End Sub

    'Según el nº pulsado escribe en el label de arriba
    Private Sub pulsarNumCalculadora(ByVal num As String)
        If (lbCalcTop.Text.Count <= 6) Then
            lbCalcTop.Text = lbCalcTop.Text & num

            If num = "," Then
                btnCalcComa.Enabled = False
            End If
        End If
    End Sub

    'Listener para los botones no numéricos de la calculadora
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click, btnCalcRestar.Click,
        btnCalcDiv.Click, btnCalcMult.Click, btnVerde.Click, btnLimpiar.Click, btnCalcPasoAtras.Click
        Dim boton As Button = CType(sender, Button)
        If (lbCalcTop.Text <> "" And lbCalcTop.Text <> ",") Then

            Select Case boton.Name

                Case "btnVerde"
                    botonVerde()
                Case "btnSumar"
                    sumar()
                Case "btnCalcRestar"
                    restar()
                Case "btnCalcMult"
                    multiplicar()
                Case "btnCalcDiv"
                    dividir()
            End Select

            If boton.Name = "btnCalcPasoAtras" Then
                pasoAtras()
            Else
                btnCalcComa.Enabled = True
                lbCalcTop.Text = ""
            End If
        End If

        If boton.Name = "btnLimpiar" Then
            limpiarCalculadora()
        End If

    End Sub

    'Paso atrás, borra el último caracter
    Public Sub pasoAtras()
        Dim aux As String = ""
        For i = 0 To lbCalcTop.Text.Count - 2
            aux = aux + lbCalcTop.Text(i)
        Next

        lbCalcTop.Text = aux
        If Not lbCalcTop.Text.Contains(",") Then
            btnCalcComa.Enabled = True
        End If
    End Sub

    'Borra todo el label
    Private Sub limpiarCalculadora()
        btnCalcComa.Enabled = True
        lbCalcTop.Text = ""
        lbCalcBot.Text = "0,00"
    End Sub



    Private Sub botonVerde()
        If lbCodProd.SelectedIndex <> -1 Then
            Dim producto As Producto = buscarProducto(lbCodProd.SelectedItem)
            Dim linea As New LineaFactura(producto)

            For i = 0 To Val(lbCantidad.Text) - 1
                factura.quitarLinea(linea)
            Next

            For i = 0 To Val(lbCalcTop.Text) - 1
                factura.addLinea(linea)
            Next

            actualizarListsFactura()
        Else
            lbCalcBot.Text = parsearSingle(CSng(lbCalcTop.Text))
        End If
        lbCalcTop.Text = ""
    End Sub

    Public Sub sumar()
        Dim res As Single = CSng(lbCalcBot.Text) + CSng(lbCalcTop.Text)
        If (res < 10000) Then
            lbCalcBot.Text = parsearSingle(res)
        Else
            limpiarCalculadora()
            lbError.Text = "(*) Ese número es demasiado grande para mí"
            lbError.Visible = True
            timerFactura.Start()
        End If
    End Sub

    Public Sub restar()
        Dim res As Single = CSng(lbCalcBot.Text) - CSng(lbCalcTop.Text)
        If (res > -10000) Then
            lbCalcBot.Text = parsearSingle(res)
        Else
            limpiarCalculadora()
            lbError.Text = "(*) Ese número es demasiado grande para mí"
            lbError.Visible = True
            timerFactura.Start()
        End If
    End Sub

    Public Sub multiplicar()
        Dim res As Single = CSng(lbCalcBot.Text) * CSng(lbCalcTop.Text)
        If (res < 10000 And res > -10000) Then
            lbCalcBot.Text = parsearSingle(res)
        Else
            limpiarCalculadora()
            lbError.Text = "(*) Ese número es demasiado grande para mí"
            lbError.Visible = True
            timerFactura.Start()
        End If

    End Sub

    Public Sub dividir()
        If CSng(lbCalcTop.Text) <> 0 Then
            lbCalcBot.Text = parsearSingle(CSng(lbCalcBot.Text) / CSng(lbCalcTop.Text))
        Else
            limpiarCalculadora()
            lbError.Text = "(*) No es recomendable intentar dividir por 0"
            lbError.Visible = True
            timerFactura.Start()
        End If

    End Sub

    Private Sub timerFactura_Tick(sender As Object, e As EventArgs) Handles timerFactura.Tick
        lbError.Visible = False
        timerFactura.Stop()
    End Sub


    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Try

            factura.guardarImporte()

        Catch ex As Exception
            'Log errores.txt
        End Try

    End Sub

   
End Class
