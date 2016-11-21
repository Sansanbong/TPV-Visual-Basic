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
    End Sub

    '--------------------------FACTURAS----------------------------------

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
            .Location = New Point(46, 58)
            .Size = New Size(347, 552)
            .BackColor = Color.Azure
            .BorderStyle = BorderStyle.FixedSingle
        End With

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

    'Actualiza la lista de líneas
    Private Sub actualizarListsFactura()
        limpiarListas()
        Dim linea As LineaFactura

        For i = 0 To factura.getLineasPedido.Count - 1
            linea = factura.getLineasPedido.Item(i)
            lbCodProd.Items.Add(linea.getProducto.getStructure.id)
            lbCantidad.Items.Add(linea.getCantidad)
            lbPrecio.Items.Add(linea.getProducto.getStructure.precio)
            lbProducto.Items.Add(linea.getProducto.getStructure.nombre)
            Dim total As Single = linea.getProducto.getStructure.precio * linea.getCantidad
            lbTotal.Items.Add(total)
        Next

    End Sub

    'LIMPIAR LISTAS
    Private Sub limpiarListas()
        lbCodProd.Items.Clear()
        lbCantidad.Items.Clear()
        lbPrecio.Items.Clear()
        lbProducto.Items.Clear()
        lbTotal.Items.Clear()
    End Sub


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

    'BOTÓN ELIMINAR FACTURA
    Private Sub btnBorrarFactura_Click(sender As Object, e As EventArgs) Handles btnBorrarFactura.Click
        eliminarFactura()
    End Sub

    'BOTÓN BORRAR CONJUNTO DE LÍNEAS
    Private Sub btnLimpiarLista_Click(sender As Object, e As EventArgs) Handles btnQuitarLineas.Click

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
            Dim prod As Producto = acceso.buscarProducto(lbCodProd.SelectedItem.ToString.Trim)
            Dim linea As New LineaFactura(prod)
            factura.quitarLinea(linea)
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

End Class