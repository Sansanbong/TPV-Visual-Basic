<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Me.il_Categorias = New System.Windows.Forms.ImageList(Me.components)
        Me.panelCategorias = New System.Windows.Forms.Panel()
        Me.lblCat15 = New System.Windows.Forms.Label()
        Me.lblCat14 = New System.Windows.Forms.Label()
        Me.lblCat13 = New System.Windows.Forms.Label()
        Me.lblCat12 = New System.Windows.Forms.Label()
        Me.lblCat11 = New System.Windows.Forms.Label()
        Me.lblCat10 = New System.Windows.Forms.Label()
        Me.lblCat9 = New System.Windows.Forms.Label()
        Me.lblCat8 = New System.Windows.Forms.Label()
        Me.lblCat7 = New System.Windows.Forms.Label()
        Me.lblCat6 = New System.Windows.Forms.Label()
        Me.lblCat5 = New System.Windows.Forms.Label()
        Me.lblCat4 = New System.Windows.Forms.Label()
        Me.lblCat3 = New System.Windows.Forms.Label()
        Me.lblCat2 = New System.Windows.Forms.Label()
        Me.lblCat1 = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCan = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.ListBox()
        Me.lbPrecio = New System.Windows.Forms.ListBox()
        Me.lbProducto = New System.Windows.Forms.ListBox()
        Me.lbCantidad = New System.Windows.Forms.ListBox()
        Me.lbCodProd = New System.Windows.Forms.ListBox()
        Me.lblCodProd = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.btnBorrarFactura = New System.Windows.Forms.Button()
        Me.btnQuitarLineas = New System.Windows.Forms.Button()
        Me.btnQuitarLinea = New System.Windows.Forms.Button()
        Me.btnCat15 = New System.Windows.Forms.Button()
        Me.btnCat14 = New System.Windows.Forms.Button()
        Me.btnCat13 = New System.Windows.Forms.Button()
        Me.btnCat12 = New System.Windows.Forms.Button()
        Me.btnCat11 = New System.Windows.Forms.Button()
        Me.btnCat10 = New System.Windows.Forms.Button()
        Me.btnCat9 = New System.Windows.Forms.Button()
        Me.btnCat8 = New System.Windows.Forms.Button()
        Me.btnCat7 = New System.Windows.Forms.Button()
        Me.btnCat6 = New System.Windows.Forms.Button()
        Me.btnCat5 = New System.Windows.Forms.Button()
        Me.btnCat4 = New System.Windows.Forms.Button()
        Me.btnCat3 = New System.Windows.Forms.Button()
        Me.btnCat2 = New System.Windows.Forms.Button()
        Me.btnCat1 = New System.Windows.Forms.Button()
        Me.panelCategorias.SuspendLayout()
        Me.SuspendLayout()
        '
        'il_Categorias
        '
        Me.il_Categorias.ImageStream = CType(resources.GetObject("il_Categorias.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il_Categorias.TransparentColor = System.Drawing.Color.Transparent
        Me.il_Categorias.Images.SetKeyName(0, "arrocesnoodles.png")
        Me.il_Categorias.Images.SetKeyName(1, "aves.png")
        Me.il_Categorias.Images.SetKeyName(2, "carnes.png")
        Me.il_Categorias.Images.SetKeyName(3, "ensalada.png")
        Me.il_Categorias.Images.SetKeyName(4, "entrantes.png")
        Me.il_Categorias.Images.SetKeyName(5, "gunkan.png")
        Me.il_Categorias.Images.SetKeyName(6, "maki.png")
        Me.il_Categorias.Images.SetKeyName(7, "nigiri.png")
        Me.il_Categorias.Images.SetKeyName(8, "pescadosmariscos.png")
        Me.il_Categorias.Images.SetKeyName(9, "postres.png")
        Me.il_Categorias.Images.SetKeyName(10, "rolls.png")
        Me.il_Categorias.Images.SetKeyName(11, "sashimi.png")
        Me.il_Categorias.Images.SetKeyName(12, "sopas.png")
        Me.il_Categorias.Images.SetKeyName(13, "tartar.png")
        Me.il_Categorias.Images.SetKeyName(14, "verduras.png")
        Me.il_Categorias.Images.SetKeyName(15, "back.png")
        '
        'panelCategorias
        '
        Me.panelCategorias.AllowDrop = True
        Me.panelCategorias.BackColor = System.Drawing.Color.AliceBlue
        Me.panelCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCategorias.Controls.Add(Me.lblCat15)
        Me.panelCategorias.Controls.Add(Me.btnCat15)
        Me.panelCategorias.Controls.Add(Me.lblCat14)
        Me.panelCategorias.Controls.Add(Me.btnCat14)
        Me.panelCategorias.Controls.Add(Me.lblCat13)
        Me.panelCategorias.Controls.Add(Me.btnCat13)
        Me.panelCategorias.Controls.Add(Me.lblCat12)
        Me.panelCategorias.Controls.Add(Me.btnCat12)
        Me.panelCategorias.Controls.Add(Me.lblCat11)
        Me.panelCategorias.Controls.Add(Me.btnCat11)
        Me.panelCategorias.Controls.Add(Me.lblCat10)
        Me.panelCategorias.Controls.Add(Me.btnCat10)
        Me.panelCategorias.Controls.Add(Me.lblCat9)
        Me.panelCategorias.Controls.Add(Me.btnCat9)
        Me.panelCategorias.Controls.Add(Me.lblCat8)
        Me.panelCategorias.Controls.Add(Me.btnCat8)
        Me.panelCategorias.Controls.Add(Me.lblCat7)
        Me.panelCategorias.Controls.Add(Me.btnCat7)
        Me.panelCategorias.Controls.Add(Me.lblCat6)
        Me.panelCategorias.Controls.Add(Me.btnCat6)
        Me.panelCategorias.Controls.Add(Me.lblCat5)
        Me.panelCategorias.Controls.Add(Me.btnCat5)
        Me.panelCategorias.Controls.Add(Me.lblCat4)
        Me.panelCategorias.Controls.Add(Me.btnCat4)
        Me.panelCategorias.Controls.Add(Me.lblCat3)
        Me.panelCategorias.Controls.Add(Me.btnCat3)
        Me.panelCategorias.Controls.Add(Me.lblCat2)
        Me.panelCategorias.Controls.Add(Me.btnCat2)
        Me.panelCategorias.Controls.Add(Me.lblCat1)
        Me.panelCategorias.Controls.Add(Me.btnCat1)
        Me.panelCategorias.Location = New System.Drawing.Point(46, 58)
        Me.panelCategorias.Name = "panelCategorias"
        Me.panelCategorias.Size = New System.Drawing.Size(347, 552)
        Me.panelCategorias.TabIndex = 1
        '
        'lblCat15
        '
        Me.lblCat15.AutoSize = True
        Me.lblCat15.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat15.Location = New System.Drawing.Point(237, 433)
        Me.lblCat15.Name = "lblCat15"
        Me.lblCat15.Size = New System.Drawing.Size(65, 15)
        Me.lblCat15.TabIndex = 29
        Me.lblCat15.Text = "VERDURAS"
        '
        'lblCat14
        '
        Me.lblCat14.AutoSize = True
        Me.lblCat14.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblCat14.Location = New System.Drawing.Point(145, 432)
        Me.lblCat14.Name = "lblCat14"
        Me.lblCat14.Size = New System.Drawing.Size(52, 17)
        Me.lblCat14.TabIndex = 27
        Me.lblCat14.Text = "TARTAR"
        '
        'lblCat13
        '
        Me.lblCat13.AutoSize = True
        Me.lblCat13.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat13.Location = New System.Drawing.Point(45, 433)
        Me.lblCat13.Name = "lblCat13"
        Me.lblCat13.Size = New System.Drawing.Size(45, 17)
        Me.lblCat13.TabIndex = 25
        Me.lblCat13.Text = "SOPAS"
        '
        'lblCat12
        '
        Me.lblCat12.AutoSize = True
        Me.lblCat12.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat12.Location = New System.Drawing.Point(241, 330)
        Me.lblCat12.Name = "lblCat12"
        Me.lblCat12.Size = New System.Drawing.Size(59, 17)
        Me.lblCat12.TabIndex = 23
        Me.lblCat12.Text = "SASHIMI"
        '
        'lblCat11
        '
        Me.lblCat11.AutoSize = True
        Me.lblCat11.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblCat11.Location = New System.Drawing.Point(147, 329)
        Me.lblCat11.Name = "lblCat11"
        Me.lblCat11.Size = New System.Drawing.Size(44, 17)
        Me.lblCat11.TabIndex = 21
        Me.lblCat11.Text = "ROLLS"
        '
        'lblCat10
        '
        Me.lblCat10.AutoSize = True
        Me.lblCat10.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat10.Location = New System.Drawing.Point(38, 330)
        Me.lblCat10.Name = "lblCat10"
        Me.lblCat10.Size = New System.Drawing.Size(60, 17)
        Me.lblCat10.TabIndex = 19
        Me.lblCat10.Text = "POSTRES"
        '
        'lblCat9
        '
        Me.lblCat9.AutoSize = True
        Me.lblCat9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat9.Location = New System.Drawing.Point(217, 227)
        Me.lblCat9.Name = "lblCat9"
        Me.lblCat9.Size = New System.Drawing.Size(114, 13)
        Me.lblCat9.TabIndex = 17
        Me.lblCat9.Text = "PESCADOS Y MARISCOS"
        '
        'lblCat8
        '
        Me.lblCat8.AutoSize = True
        Me.lblCat8.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat8.Location = New System.Drawing.Point(148, 225)
        Me.lblCat8.Name = "lblCat8"
        Me.lblCat8.Size = New System.Drawing.Size(46, 17)
        Me.lblCat8.TabIndex = 15
        Me.lblCat8.Text = "NIGIRI"
        '
        'lblCat7
        '
        Me.lblCat7.AutoSize = True
        Me.lblCat7.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat7.Location = New System.Drawing.Point(47, 225)
        Me.lblCat7.Name = "lblCat7"
        Me.lblCat7.Size = New System.Drawing.Size(40, 17)
        Me.lblCat7.TabIndex = 13
        Me.lblCat7.Text = "MAKI"
        '
        'lblCat6
        '
        Me.lblCat6.AutoSize = True
        Me.lblCat6.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat6.Location = New System.Drawing.Point(241, 121)
        Me.lblCat6.Name = "lblCat6"
        Me.lblCat6.Size = New System.Drawing.Size(56, 15)
        Me.lblCat6.TabIndex = 11
        Me.lblCat6.Text = "GUNKAN"
        '
        'lblCat5
        '
        Me.lblCat5.AutoSize = True
        Me.lblCat5.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat5.Location = New System.Drawing.Point(136, 121)
        Me.lblCat5.Name = "lblCat5"
        Me.lblCat5.Size = New System.Drawing.Size(70, 15)
        Me.lblCat5.TabIndex = 9
        Me.lblCat5.Text = "ENTRANTES"
        '
        'lblCat4
        '
        Me.lblCat4.AutoSize = True
        Me.lblCat4.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat4.Location = New System.Drawing.Point(33, 121)
        Me.lblCat4.Name = "lblCat4"
        Me.lblCat4.Size = New System.Drawing.Size(72, 15)
        Me.lblCat4.TabIndex = 7
        Me.lblCat4.Text = "ENSALADAS"
        '
        'lblCat3
        '
        Me.lblCat3.AutoSize = True
        Me.lblCat3.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat3.Location = New System.Drawing.Point(243, 15)
        Me.lblCat3.Name = "lblCat3"
        Me.lblCat3.Size = New System.Drawing.Size(54, 17)
        Me.lblCat3.TabIndex = 5
        Me.lblCat3.Text = "CARNES"
        '
        'lblCat2
        '
        Me.lblCat2.AutoSize = True
        Me.lblCat2.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCat2.Location = New System.Drawing.Point(151, 15)
        Me.lblCat2.Name = "lblCat2"
        Me.lblCat2.Size = New System.Drawing.Size(37, 17)
        Me.lblCat2.TabIndex = 3
        Me.lblCat2.Text = "AVES"
        '
        'lblCat1
        '
        Me.lblCat1.AutoSize = True
        Me.lblCat1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat1.Location = New System.Drawing.Point(19, 18)
        Me.lblCat1.Name = "lblCat1"
        Me.lblCat1.Size = New System.Drawing.Size(102, 13)
        Me.lblCat1.TabIndex = 1
        Me.lblCat1.Text = "ARROCES Y NOODLES"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.BackColor = System.Drawing.Color.Transparent
        Me.lblTot.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTot.Location = New System.Drawing.Point(848, 47)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(44, 17)
        Me.lblTot.TabIndex = 20
        Me.lblTot.Text = "TOTAL"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.BackColor = System.Drawing.Color.Transparent
        Me.lblProd.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblProd.Location = New System.Drawing.Point(678, 47)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(73, 17)
        Me.lblProd.TabIndex = 19
        Me.lblProd.Text = "PRODUCTO"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.Location = New System.Drawing.Point(618, 47)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(50, 17)
        Me.lblPrecio.TabIndex = 18
        Me.lblPrecio.Text = "PRECIO"
        '
        'lblCan
        '
        Me.lblCan.AutoSize = True
        Me.lblCan.BackColor = System.Drawing.Color.Transparent
        Me.lblCan.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCan.Location = New System.Drawing.Point(576, 47)
        Me.lblCan.Name = "lblCan"
        Me.lblCan.Size = New System.Drawing.Size(32, 17)
        Me.lblCan.TabIndex = 17
        Me.lblCan.Text = "CAN"
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.AliceBlue
        Me.lbTotal.FormattingEnabled = True
        Me.lbTotal.Location = New System.Drawing.Point(847, 65)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(49, 329)
        Me.lbTotal.TabIndex = 16
        '
        'lbPrecio
        '
        Me.lbPrecio.BackColor = System.Drawing.Color.AliceBlue
        Me.lbPrecio.FormattingEnabled = True
        Me.lbPrecio.Location = New System.Drawing.Point(618, 65)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(49, 329)
        Me.lbPrecio.TabIndex = 15
        '
        'lbProducto
        '
        Me.lbProducto.BackColor = System.Drawing.Color.AliceBlue
        Me.lbProducto.FormattingEnabled = True
        Me.lbProducto.Location = New System.Drawing.Point(666, 65)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(182, 329)
        Me.lbProducto.TabIndex = 14
        '
        'lbCantidad
        '
        Me.lbCantidad.BackColor = System.Drawing.Color.AliceBlue
        Me.lbCantidad.FormattingEnabled = True
        Me.lbCantidad.Location = New System.Drawing.Point(574, 65)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(45, 329)
        Me.lbCantidad.TabIndex = 13
        '
        'lbCodProd
        '
        Me.lbCodProd.BackColor = System.Drawing.Color.AliceBlue
        Me.lbCodProd.FormattingEnabled = True
        Me.lbCodProd.Location = New System.Drawing.Point(530, 65)
        Me.lbCodProd.Name = "lbCodProd"
        Me.lbCodProd.Size = New System.Drawing.Size(45, 329)
        Me.lbCodProd.TabIndex = 21
        '
        'lblCodProd
        '
        Me.lblCodProd.AutoSize = True
        Me.lblCodProd.BackColor = System.Drawing.Color.Transparent
        Me.lblCodProd.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCodProd.Location = New System.Drawing.Point(532, 47)
        Me.lblCodProd.Name = "lblCodProd"
        Me.lblCodProd.Size = New System.Drawing.Size(33, 17)
        Me.lblCodProd.TabIndex = 22
        Me.lblCodProd.Text = "COD"
        '
        'menuStrip
        '
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1057, 24)
        Me.menuStrip.TabIndex = 26
        Me.menuStrip.Text = "MenuStrip1"
        '
        'btnBorrarFactura
        '
        Me.btnBorrarFactura.BackColor = System.Drawing.Color.AliceBlue
        Me.btnBorrarFactura.BackgroundImage = Global.TPV_VB.My.Resources.Resources.deleteAll
        Me.btnBorrarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarFactura.Location = New System.Drawing.Point(472, 189)
        Me.btnBorrarFactura.Name = "btnBorrarFactura"
        Me.btnBorrarFactura.Size = New System.Drawing.Size(42, 38)
        Me.btnBorrarFactura.TabIndex = 25
        Me.btnBorrarFactura.UseVisualStyleBackColor = False
        '
        'btnQuitarLineas
        '
        Me.btnQuitarLineas.BackColor = System.Drawing.Color.AliceBlue
        Me.btnQuitarLineas.BackgroundImage = Global.TPV_VB.My.Resources.Resources.delete
        Me.btnQuitarLineas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarLineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarLineas.Location = New System.Drawing.Point(472, 130)
        Me.btnQuitarLineas.Name = "btnQuitarLineas"
        Me.btnQuitarLineas.Size = New System.Drawing.Size(42, 38)
        Me.btnQuitarLineas.TabIndex = 24
        Me.btnQuitarLineas.UseVisualStyleBackColor = False
        '
        'btnQuitarLinea
        '
        Me.btnQuitarLinea.BackColor = System.Drawing.Color.AliceBlue
        Me.btnQuitarLinea.BackgroundImage = Global.TPV_VB.My.Resources.Resources.signo_de_negacion
        Me.btnQuitarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarLinea.Location = New System.Drawing.Point(472, 74)
        Me.btnQuitarLinea.Name = "btnQuitarLinea"
        Me.btnQuitarLinea.Size = New System.Drawing.Size(42, 38)
        Me.btnQuitarLinea.TabIndex = 23
        Me.btnQuitarLinea.UseVisualStyleBackColor = False
        '
        'btnCat15
        '
        Me.btnCat15.BackColor = System.Drawing.Color.White
        Me.btnCat15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat15.ImageIndex = 14
        Me.btnCat15.ImageList = Me.il_Categorias
        Me.btnCat15.Location = New System.Drawing.Point(232, 450)
        Me.btnCat15.Name = "btnCat15"
        Me.btnCat15.Size = New System.Drawing.Size(75, 75)
        Me.btnCat15.TabIndex = 28
        Me.btnCat15.UseCompatibleTextRendering = True
        Me.btnCat15.UseVisualStyleBackColor = False
        '
        'btnCat14
        '
        Me.btnCat14.BackColor = System.Drawing.Color.White
        Me.btnCat14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat14.ImageIndex = 13
        Me.btnCat14.ImageList = Me.il_Categorias
        Me.btnCat14.Location = New System.Drawing.Point(133, 450)
        Me.btnCat14.Name = "btnCat14"
        Me.btnCat14.Size = New System.Drawing.Size(75, 75)
        Me.btnCat14.TabIndex = 26
        Me.btnCat14.UseCompatibleTextRendering = True
        Me.btnCat14.UseVisualStyleBackColor = False
        '
        'btnCat13
        '
        Me.btnCat13.BackColor = System.Drawing.Color.White
        Me.btnCat13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat13.ImageIndex = 12
        Me.btnCat13.ImageList = Me.il_Categorias
        Me.btnCat13.Location = New System.Drawing.Point(31, 450)
        Me.btnCat13.Name = "btnCat13"
        Me.btnCat13.Size = New System.Drawing.Size(75, 75)
        Me.btnCat13.TabIndex = 24
        Me.btnCat13.UseCompatibleTextRendering = True
        Me.btnCat13.UseVisualStyleBackColor = False
        '
        'btnCat12
        '
        Me.btnCat12.BackColor = System.Drawing.Color.White
        Me.btnCat12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat12.ImageIndex = 11
        Me.btnCat12.ImageList = Me.il_Categorias
        Me.btnCat12.Location = New System.Drawing.Point(232, 347)
        Me.btnCat12.Name = "btnCat12"
        Me.btnCat12.Size = New System.Drawing.Size(75, 75)
        Me.btnCat12.TabIndex = 22
        Me.btnCat12.UseCompatibleTextRendering = True
        Me.btnCat12.UseVisualStyleBackColor = False
        '
        'btnCat11
        '
        Me.btnCat11.BackColor = System.Drawing.Color.White
        Me.btnCat11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat11.ImageIndex = 10
        Me.btnCat11.ImageList = Me.il_Categorias
        Me.btnCat11.Location = New System.Drawing.Point(133, 347)
        Me.btnCat11.Name = "btnCat11"
        Me.btnCat11.Size = New System.Drawing.Size(75, 75)
        Me.btnCat11.TabIndex = 20
        Me.btnCat11.UseCompatibleTextRendering = True
        Me.btnCat11.UseVisualStyleBackColor = False
        '
        'btnCat10
        '
        Me.btnCat10.BackColor = System.Drawing.Color.White
        Me.btnCat10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat10.ImageIndex = 9
        Me.btnCat10.ImageList = Me.il_Categorias
        Me.btnCat10.Location = New System.Drawing.Point(31, 347)
        Me.btnCat10.Name = "btnCat10"
        Me.btnCat10.Size = New System.Drawing.Size(75, 75)
        Me.btnCat10.TabIndex = 18
        Me.btnCat10.UseCompatibleTextRendering = True
        Me.btnCat10.UseVisualStyleBackColor = False
        '
        'btnCat9
        '
        Me.btnCat9.BackColor = System.Drawing.Color.White
        Me.btnCat9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat9.ImageIndex = 8
        Me.btnCat9.ImageList = Me.il_Categorias
        Me.btnCat9.Location = New System.Drawing.Point(232, 242)
        Me.btnCat9.Name = "btnCat9"
        Me.btnCat9.Size = New System.Drawing.Size(75, 75)
        Me.btnCat9.TabIndex = 16
        Me.btnCat9.UseCompatibleTextRendering = True
        Me.btnCat9.UseVisualStyleBackColor = False
        '
        'btnCat8
        '
        Me.btnCat8.BackColor = System.Drawing.Color.White
        Me.btnCat8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat8.ImageIndex = 7
        Me.btnCat8.ImageList = Me.il_Categorias
        Me.btnCat8.Location = New System.Drawing.Point(133, 242)
        Me.btnCat8.Name = "btnCat8"
        Me.btnCat8.Size = New System.Drawing.Size(75, 75)
        Me.btnCat8.TabIndex = 14
        Me.btnCat8.UseCompatibleTextRendering = True
        Me.btnCat8.UseVisualStyleBackColor = False
        '
        'btnCat7
        '
        Me.btnCat7.BackColor = System.Drawing.Color.White
        Me.btnCat7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat7.ImageIndex = 6
        Me.btnCat7.ImageList = Me.il_Categorias
        Me.btnCat7.Location = New System.Drawing.Point(31, 242)
        Me.btnCat7.Name = "btnCat7"
        Me.btnCat7.Size = New System.Drawing.Size(75, 75)
        Me.btnCat7.TabIndex = 12
        Me.btnCat7.UseCompatibleTextRendering = True
        Me.btnCat7.UseVisualStyleBackColor = False
        '
        'btnCat6
        '
        Me.btnCat6.BackColor = System.Drawing.Color.White
        Me.btnCat6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat6.ImageIndex = 5
        Me.btnCat6.ImageList = Me.il_Categorias
        Me.btnCat6.Location = New System.Drawing.Point(232, 137)
        Me.btnCat6.Name = "btnCat6"
        Me.btnCat6.Size = New System.Drawing.Size(75, 75)
        Me.btnCat6.TabIndex = 10
        Me.btnCat6.UseCompatibleTextRendering = True
        Me.btnCat6.UseVisualStyleBackColor = False
        '
        'btnCat5
        '
        Me.btnCat5.BackColor = System.Drawing.Color.White
        Me.btnCat5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat5.ImageIndex = 4
        Me.btnCat5.ImageList = Me.il_Categorias
        Me.btnCat5.Location = New System.Drawing.Point(133, 137)
        Me.btnCat5.Name = "btnCat5"
        Me.btnCat5.Size = New System.Drawing.Size(75, 75)
        Me.btnCat5.TabIndex = 8
        Me.btnCat5.UseCompatibleTextRendering = True
        Me.btnCat5.UseVisualStyleBackColor = False
        '
        'btnCat4
        '
        Me.btnCat4.BackColor = System.Drawing.Color.White
        Me.btnCat4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat4.ImageIndex = 3
        Me.btnCat4.ImageList = Me.il_Categorias
        Me.btnCat4.Location = New System.Drawing.Point(31, 137)
        Me.btnCat4.Name = "btnCat4"
        Me.btnCat4.Size = New System.Drawing.Size(75, 75)
        Me.btnCat4.TabIndex = 6
        Me.btnCat4.UseCompatibleTextRendering = True
        Me.btnCat4.UseVisualStyleBackColor = False
        '
        'btnCat3
        '
        Me.btnCat3.BackColor = System.Drawing.Color.White
        Me.btnCat3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat3.ImageIndex = 2
        Me.btnCat3.ImageList = Me.il_Categorias
        Me.btnCat3.Location = New System.Drawing.Point(233, 32)
        Me.btnCat3.Name = "btnCat3"
        Me.btnCat3.Size = New System.Drawing.Size(75, 75)
        Me.btnCat3.TabIndex = 4
        Me.btnCat3.UseCompatibleTextRendering = True
        Me.btnCat3.UseVisualStyleBackColor = False
        '
        'btnCat2
        '
        Me.btnCat2.BackColor = System.Drawing.Color.White
        Me.btnCat2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat2.ImageIndex = 1
        Me.btnCat2.ImageList = Me.il_Categorias
        Me.btnCat2.Location = New System.Drawing.Point(134, 32)
        Me.btnCat2.Name = "btnCat2"
        Me.btnCat2.Size = New System.Drawing.Size(75, 75)
        Me.btnCat2.TabIndex = 2
        Me.btnCat2.UseCompatibleTextRendering = True
        Me.btnCat2.UseVisualStyleBackColor = False
        '
        'btnCat1
        '
        Me.btnCat1.BackColor = System.Drawing.Color.White
        Me.btnCat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat1.ImageIndex = 0
        Me.btnCat1.ImageList = Me.il_Categorias
        Me.btnCat1.Location = New System.Drawing.Point(32, 32)
        Me.btnCat1.Name = "btnCat1"
        Me.btnCat1.Size = New System.Drawing.Size(75, 75)
        Me.btnCat1.TabIndex = 0
        Me.btnCat1.UseCompatibleTextRendering = True
        Me.btnCat1.UseVisualStyleBackColor = False
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TPV_VB.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1057, 636)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.btnBorrarFactura)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCan)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.lbProducto)
        Me.Controls.Add(Me.lbCantidad)
        Me.Controls.Add(Me.lbCodProd)
        Me.Controls.Add(Me.btnQuitarLineas)
        Me.Controls.Add(Me.btnQuitarLinea)
        Me.Controls.Add(Me.lblCodProd)
        Me.Controls.Add(Me.panelCategorias)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.panelCategorias.ResumeLayout(False)
        Me.panelCategorias.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents il_Categorias As System.Windows.Forms.ImageList
    Friend WithEvents panelCategorias As System.Windows.Forms.Panel
    Friend WithEvents lblCat15 As System.Windows.Forms.Label
    Friend WithEvents btnCat15 As System.Windows.Forms.Button
    Friend WithEvents lblCat14 As System.Windows.Forms.Label
    Friend WithEvents btnCat14 As System.Windows.Forms.Button
    Friend WithEvents lblCat13 As System.Windows.Forms.Label
    Friend WithEvents btnCat13 As System.Windows.Forms.Button
    Friend WithEvents lblCat12 As System.Windows.Forms.Label
    Friend WithEvents btnCat12 As System.Windows.Forms.Button
    Friend WithEvents lblCat11 As System.Windows.Forms.Label
    Friend WithEvents btnCat11 As System.Windows.Forms.Button
    Friend WithEvents lblCat10 As System.Windows.Forms.Label
    Friend WithEvents btnCat10 As System.Windows.Forms.Button
    Friend WithEvents lblCat9 As System.Windows.Forms.Label
    Friend WithEvents btnCat9 As System.Windows.Forms.Button
    Friend WithEvents lblCat8 As System.Windows.Forms.Label
    Friend WithEvents btnCat8 As System.Windows.Forms.Button
    Friend WithEvents lblCat7 As System.Windows.Forms.Label
    Friend WithEvents btnCat7 As System.Windows.Forms.Button
    Friend WithEvents lblCat6 As System.Windows.Forms.Label
    Friend WithEvents btnCat6 As System.Windows.Forms.Button
    Friend WithEvents lblCat5 As System.Windows.Forms.Label
    Friend WithEvents btnCat5 As System.Windows.Forms.Button
    Friend WithEvents lblCat4 As System.Windows.Forms.Label
    Friend WithEvents btnCat4 As System.Windows.Forms.Button
    Friend WithEvents lblCat3 As System.Windows.Forms.Label
    Friend WithEvents btnCat3 As System.Windows.Forms.Button
    Friend WithEvents lblCat2 As System.Windows.Forms.Label
    Friend WithEvents btnCat2 As System.Windows.Forms.Button
    Friend WithEvents lblCat1 As System.Windows.Forms.Label
    Friend WithEvents btnCat1 As System.Windows.Forms.Button
    Friend WithEvents lblTot As System.Windows.Forms.Label
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblCan As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.ListBox
    Friend WithEvents lbPrecio As System.Windows.Forms.ListBox
    Friend WithEvents lbProducto As System.Windows.Forms.ListBox
    Friend WithEvents lbCantidad As System.Windows.Forms.ListBox
    Friend WithEvents lbCodProd As System.Windows.Forms.ListBox
    Friend WithEvents btnQuitarLineas As System.Windows.Forms.Button
    Friend WithEvents btnQuitarLinea As System.Windows.Forms.Button
    Friend WithEvents lblCodProd As System.Windows.Forms.Label
    Friend WithEvents btnBorrarFactura As System.Windows.Forms.Button
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
End Class
