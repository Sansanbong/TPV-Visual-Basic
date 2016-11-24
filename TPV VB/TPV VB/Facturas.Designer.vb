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
        Me.printer = New System.Drawing.Printing.PrintDocument()
        Me.printPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.lbError = New System.Windows.Forms.Label()
        Me.lbCalcBot = New System.Windows.Forms.Label()
        Me.lbCalcTop = New System.Windows.Forms.Label()
        Me.panelCalculadora = New System.Windows.Forms.Panel()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcPasoAtras = New System.Windows.Forms.Button()
        Me.btnCalcDiv = New System.Windows.Forms.Button()
        Me.btnCalcComa = New System.Windows.Forms.Button()
        Me.btnCalc0 = New System.Windows.Forms.Button()
        Me.btnCalc00 = New System.Windows.Forms.Button()
        Me.btnCalcMult = New System.Windows.Forms.Button()
        Me.btnCalc3 = New System.Windows.Forms.Button()
        Me.btnCalc2 = New System.Windows.Forms.Button()
        Me.btnCalc1 = New System.Windows.Forms.Button()
        Me.btnCalcRestar = New System.Windows.Forms.Button()
        Me.btnCalc6 = New System.Windows.Forms.Button()
        Me.btnCalc5 = New System.Windows.Forms.Button()
        Me.btnCalc4 = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnCalc9 = New System.Windows.Forms.Button()
        Me.btnCalc8 = New System.Windows.Forms.Button()
        Me.btnCalc7 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.btnBorrarFactura = New System.Windows.Forms.Button()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCan = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.ListBox()
        Me.lbPrecio = New System.Windows.Forms.ListBox()
        Me.lbProducto = New System.Windows.Forms.ListBox()
        Me.lbCantidad = New System.Windows.Forms.ListBox()
        Me.lbCodProd = New System.Windows.Forms.ListBox()
        Me.btnQuitarLineas = New System.Windows.Forms.Button()
        Me.btnQuitarLinea = New System.Windows.Forms.Button()
        Me.lblCodProd = New System.Windows.Forms.Label()
        Me.panelCategorias = New System.Windows.Forms.Panel()
        Me.lblCat15 = New System.Windows.Forms.Label()
        Me.btnCat15 = New System.Windows.Forms.Button()
        Me.lblCat14 = New System.Windows.Forms.Label()
        Me.btnCat14 = New System.Windows.Forms.Button()
        Me.lblCat13 = New System.Windows.Forms.Label()
        Me.btnCat13 = New System.Windows.Forms.Button()
        Me.lblCat12 = New System.Windows.Forms.Label()
        Me.btnCat12 = New System.Windows.Forms.Button()
        Me.lblCat11 = New System.Windows.Forms.Label()
        Me.btnCat11 = New System.Windows.Forms.Button()
        Me.lblCat10 = New System.Windows.Forms.Label()
        Me.btnCat10 = New System.Windows.Forms.Button()
        Me.lblCat9 = New System.Windows.Forms.Label()
        Me.btnCat9 = New System.Windows.Forms.Button()
        Me.lblCat8 = New System.Windows.Forms.Label()
        Me.btnCat8 = New System.Windows.Forms.Button()
        Me.lblCat7 = New System.Windows.Forms.Label()
        Me.btnCat7 = New System.Windows.Forms.Button()
        Me.lblCat6 = New System.Windows.Forms.Label()
        Me.btnCat6 = New System.Windows.Forms.Button()
        Me.lblCat5 = New System.Windows.Forms.Label()
        Me.btnCat5 = New System.Windows.Forms.Button()
        Me.lblCat4 = New System.Windows.Forms.Label()
        Me.btnCat4 = New System.Windows.Forms.Button()
        Me.lblCat3 = New System.Windows.Forms.Label()
        Me.btnCat3 = New System.Windows.Forms.Button()
        Me.lblCat2 = New System.Windows.Forms.Label()
        Me.btnCat2 = New System.Windows.Forms.Button()
        Me.lblCat1 = New System.Windows.Forms.Label()
        Me.btnCat1 = New System.Windows.Forms.Button()
        Me.timerFactura = New System.Windows.Forms.Timer(Me.components)
        Me.ttProductos = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblTotalPedido = New System.Windows.Forms.Label()
        Me.panelCalculadora.SuspendLayout()
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
        'printer
        '
        '
        'printPreview
        '
        Me.printPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreview.Enabled = True
        Me.printPreview.Icon = CType(resources.GetObject("printPreview.Icon"), System.Drawing.Icon)
        Me.printPreview.Name = "printPreview"
        Me.printPreview.Visible = False
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Font = New System.Drawing.Font("Calibri", 16.25!, System.Drawing.FontStyle.Bold)
        Me.btnCobrar.Location = New System.Drawing.Point(609, 500)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(104, 97)
        Me.btnCobrar.TabIndex = 69
        Me.btnCobrar.Text = "COBRAR"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'lbError
        '
        Me.lbError.AutoSize = True
        Me.lbError.BackColor = System.Drawing.Color.Transparent
        Me.lbError.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbError.ForeColor = System.Drawing.Color.Red
        Me.lbError.Location = New System.Drawing.Point(398, 348)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(38, 17)
        Me.lbError.TabIndex = 68
        Me.lbError.Text = "Error"
        Me.lbError.Visible = False
        '
        'lbCalcBot
        '
        Me.lbCalcBot.BackColor = System.Drawing.Color.AliceBlue
        Me.lbCalcBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCalcBot.Font = New System.Drawing.Font("Calibri", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCalcBot.Location = New System.Drawing.Point(609, 429)
        Me.lbCalcBot.Name = "lbCalcBot"
        Me.lbCalcBot.Size = New System.Drawing.Size(104, 44)
        Me.lbCalcBot.TabIndex = 67
        Me.lbCalcBot.Text = "9999,99"
        Me.lbCalcBot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCalcTop
        '
        Me.lbCalcTop.BackColor = System.Drawing.Color.AliceBlue
        Me.lbCalcTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCalcTop.Font = New System.Drawing.Font("Calibri", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCalcTop.Location = New System.Drawing.Point(609, 378)
        Me.lbCalcTop.Name = "lbCalcTop"
        Me.lbCalcTop.Size = New System.Drawing.Size(104, 43)
        Me.lbCalcTop.TabIndex = 66
        Me.lbCalcTop.Text = "9999,99"
        Me.lbCalcTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelCalculadora
        '
        Me.panelCalculadora.BackColor = System.Drawing.Color.Transparent
        Me.panelCalculadora.Controls.Add(Me.btnVerde)
        Me.panelCalculadora.Controls.Add(Me.btnLimpiar)
        Me.panelCalculadora.Controls.Add(Me.btnCalcPasoAtras)
        Me.panelCalculadora.Controls.Add(Me.btnCalcDiv)
        Me.panelCalculadora.Controls.Add(Me.btnCalcComa)
        Me.panelCalculadora.Controls.Add(Me.btnCalc0)
        Me.panelCalculadora.Controls.Add(Me.btnCalc00)
        Me.panelCalculadora.Controls.Add(Me.btnCalcMult)
        Me.panelCalculadora.Controls.Add(Me.btnCalc3)
        Me.panelCalculadora.Controls.Add(Me.btnCalc2)
        Me.panelCalculadora.Controls.Add(Me.btnCalc1)
        Me.panelCalculadora.Controls.Add(Me.btnCalcRestar)
        Me.panelCalculadora.Controls.Add(Me.btnCalc6)
        Me.panelCalculadora.Controls.Add(Me.btnCalc5)
        Me.panelCalculadora.Controls.Add(Me.btnCalc4)
        Me.panelCalculadora.Controls.Add(Me.btnSumar)
        Me.panelCalculadora.Controls.Add(Me.btnCalc9)
        Me.panelCalculadora.Controls.Add(Me.btnCalc8)
        Me.panelCalculadora.Controls.Add(Me.btnCalc7)
        Me.panelCalculadora.Location = New System.Drawing.Point(401, 373)
        Me.panelCalculadora.Name = "panelCalculadora"
        Me.panelCalculadora.Size = New System.Drawing.Size(202, 232)
        Me.panelCalculadora.TabIndex = 65
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.GreenYellow
        Me.btnVerde.BackgroundImage = Global.TPV_VB.My.Resources.Resources.send_button
        Me.btnVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerde.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnVerde.Location = New System.Drawing.Point(101, 181)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(95, 43)
        Me.btnVerde.TabIndex = 61
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLimpiar.BackgroundImage = Global.TPV_VB.My.Resources.Resources.delete
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnLimpiar.Location = New System.Drawing.Point(53, 181)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(47, 43)
        Me.btnLimpiar.TabIndex = 60
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCalcPasoAtras
        '
        Me.btnCalcPasoAtras.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCalcPasoAtras.BackgroundImage = Global.TPV_VB.My.Resources.Resources.go_back_left_arrow
        Me.btnCalcPasoAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalcPasoAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcPasoAtras.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalcPasoAtras.Location = New System.Drawing.Point(5, 181)
        Me.btnCalcPasoAtras.Name = "btnCalcPasoAtras"
        Me.btnCalcPasoAtras.Size = New System.Drawing.Size(47, 43)
        Me.btnCalcPasoAtras.TabIndex = 59
        Me.btnCalcPasoAtras.UseVisualStyleBackColor = False
        '
        'btnCalcDiv
        '
        Me.btnCalcDiv.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCalcDiv.BackgroundImage = Global.TPV_VB.My.Resources.Resources.divide
        Me.btnCalcDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalcDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcDiv.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalcDiv.Location = New System.Drawing.Point(149, 137)
        Me.btnCalcDiv.Name = "btnCalcDiv"
        Me.btnCalcDiv.Size = New System.Drawing.Size(47, 43)
        Me.btnCalcDiv.TabIndex = 58
        Me.btnCalcDiv.UseVisualStyleBackColor = False
        '
        'btnCalcComa
        '
        Me.btnCalcComa.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCalcComa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalcComa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcComa.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalcComa.Location = New System.Drawing.Point(101, 137)
        Me.btnCalcComa.Name = "btnCalcComa"
        Me.btnCalcComa.Size = New System.Drawing.Size(47, 43)
        Me.btnCalcComa.TabIndex = 57
        Me.btnCalcComa.Text = ","
        Me.btnCalcComa.UseVisualStyleBackColor = False
        '
        'btnCalc0
        '
        Me.btnCalc0.BackColor = System.Drawing.Color.White
        Me.btnCalc0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc0.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc0.Location = New System.Drawing.Point(53, 137)
        Me.btnCalc0.Name = "btnCalc0"
        Me.btnCalc0.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc0.TabIndex = 56
        Me.btnCalc0.Text = "0"
        Me.btnCalc0.UseVisualStyleBackColor = False
        '
        'btnCalc00
        '
        Me.btnCalc00.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCalc00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc00.Font = New System.Drawing.Font("Calibri", 16.25!)
        Me.btnCalc00.Location = New System.Drawing.Point(5, 137)
        Me.btnCalc00.Name = "btnCalc00"
        Me.btnCalc00.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc00.TabIndex = 55
        Me.btnCalc00.Text = "00"
        Me.btnCalc00.UseVisualStyleBackColor = False
        '
        'btnCalcMult
        '
        Me.btnCalcMult.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCalcMult.BackgroundImage = Global.TPV_VB.My.Resources.Resources.cross
        Me.btnCalcMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalcMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcMult.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalcMult.Location = New System.Drawing.Point(149, 93)
        Me.btnCalcMult.Name = "btnCalcMult"
        Me.btnCalcMult.Size = New System.Drawing.Size(47, 43)
        Me.btnCalcMult.TabIndex = 54
        Me.btnCalcMult.UseVisualStyleBackColor = False
        '
        'btnCalc3
        '
        Me.btnCalc3.BackColor = System.Drawing.Color.White
        Me.btnCalc3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc3.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc3.Location = New System.Drawing.Point(101, 93)
        Me.btnCalc3.Name = "btnCalc3"
        Me.btnCalc3.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc3.TabIndex = 53
        Me.btnCalc3.Text = "3"
        Me.btnCalc3.UseVisualStyleBackColor = False
        '
        'btnCalc2
        '
        Me.btnCalc2.BackColor = System.Drawing.Color.White
        Me.btnCalc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc2.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc2.Location = New System.Drawing.Point(53, 93)
        Me.btnCalc2.Name = "btnCalc2"
        Me.btnCalc2.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc2.TabIndex = 52
        Me.btnCalc2.Text = "2"
        Me.btnCalc2.UseVisualStyleBackColor = False
        '
        'btnCalc1
        '
        Me.btnCalc1.BackColor = System.Drawing.Color.White
        Me.btnCalc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc1.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc1.Location = New System.Drawing.Point(5, 93)
        Me.btnCalc1.Name = "btnCalc1"
        Me.btnCalc1.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc1.TabIndex = 51
        Me.btnCalc1.Text = "1"
        Me.btnCalc1.UseVisualStyleBackColor = False
        '
        'btnCalcRestar
        '
        Me.btnCalcRestar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCalcRestar.BackgroundImage = Global.TPV_VB.My.Resources.Resources.minus
        Me.btnCalcRestar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalcRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcRestar.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalcRestar.Location = New System.Drawing.Point(149, 49)
        Me.btnCalcRestar.Name = "btnCalcRestar"
        Me.btnCalcRestar.Size = New System.Drawing.Size(47, 43)
        Me.btnCalcRestar.TabIndex = 50
        Me.btnCalcRestar.UseVisualStyleBackColor = False
        '
        'btnCalc6
        '
        Me.btnCalc6.BackColor = System.Drawing.Color.White
        Me.btnCalc6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc6.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc6.Location = New System.Drawing.Point(101, 49)
        Me.btnCalc6.Name = "btnCalc6"
        Me.btnCalc6.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc6.TabIndex = 49
        Me.btnCalc6.Text = "6"
        Me.btnCalc6.UseVisualStyleBackColor = False
        '
        'btnCalc5
        '
        Me.btnCalc5.BackColor = System.Drawing.Color.White
        Me.btnCalc5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc5.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc5.Location = New System.Drawing.Point(53, 49)
        Me.btnCalc5.Name = "btnCalc5"
        Me.btnCalc5.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc5.TabIndex = 48
        Me.btnCalc5.Text = "5"
        Me.btnCalc5.UseVisualStyleBackColor = False
        '
        'btnCalc4
        '
        Me.btnCalc4.BackColor = System.Drawing.Color.White
        Me.btnCalc4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc4.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc4.Location = New System.Drawing.Point(5, 49)
        Me.btnCalc4.Name = "btnCalc4"
        Me.btnCalc4.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc4.TabIndex = 47
        Me.btnCalc4.Text = "4"
        Me.btnCalc4.UseVisualStyleBackColor = False
        '
        'btnSumar
        '
        Me.btnSumar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSumar.BackgroundImage = Global.TPV_VB.My.Resources.Resources.add
        Me.btnSumar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumar.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnSumar.Location = New System.Drawing.Point(149, 5)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(47, 43)
        Me.btnSumar.TabIndex = 46
        Me.btnSumar.UseVisualStyleBackColor = False
        '
        'btnCalc9
        '
        Me.btnCalc9.BackColor = System.Drawing.Color.White
        Me.btnCalc9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc9.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc9.Location = New System.Drawing.Point(101, 5)
        Me.btnCalc9.Name = "btnCalc9"
        Me.btnCalc9.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc9.TabIndex = 45
        Me.btnCalc9.Text = "9"
        Me.btnCalc9.UseVisualStyleBackColor = False
        '
        'btnCalc8
        '
        Me.btnCalc8.BackColor = System.Drawing.Color.White
        Me.btnCalc8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc8.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc8.Location = New System.Drawing.Point(53, 5)
        Me.btnCalc8.Name = "btnCalc8"
        Me.btnCalc8.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc8.TabIndex = 44
        Me.btnCalc8.Text = "8"
        Me.btnCalc8.UseVisualStyleBackColor = False
        '
        'btnCalc7
        '
        Me.btnCalc7.BackColor = System.Drawing.Color.White
        Me.btnCalc7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc7.Font = New System.Drawing.Font("Calibri", 18.25!)
        Me.btnCalc7.Location = New System.Drawing.Point(5, 5)
        Me.btnCalc7.Name = "btnCalc7"
        Me.btnCalc7.Size = New System.Drawing.Size(47, 43)
        Me.btnCalc7.TabIndex = 43
        Me.btnCalc7.Text = "7"
        Me.btnCalc7.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.AliceBlue
        Me.btnImprimir.BackgroundImage = Global.TPV_VB.My.Resources.Resources.print
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(401, 254)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 70)
        Me.btnImprimir.TabIndex = 64
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.BackColor = System.Drawing.Color.AliceBlue
        Me.btnVistaPrevia.BackgroundImage = Global.TPV_VB.My.Resources.Resources.document
        Me.btnVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVistaPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVistaPrevia.Location = New System.Drawing.Point(401, 198)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(75, 38)
        Me.btnVistaPrevia.TabIndex = 63
        Me.btnVistaPrevia.UseVisualStyleBackColor = False
        '
        'btnBorrarFactura
        '
        Me.btnBorrarFactura.BackColor = System.Drawing.Color.AliceBlue
        Me.btnBorrarFactura.BackgroundImage = Global.TPV_VB.My.Resources.Resources.deleteAll
        Me.btnBorrarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarFactura.Location = New System.Drawing.Point(401, 144)
        Me.btnBorrarFactura.Name = "btnBorrarFactura"
        Me.btnBorrarFactura.Size = New System.Drawing.Size(75, 38)
        Me.btnBorrarFactura.TabIndex = 62
        Me.btnBorrarFactura.UseVisualStyleBackColor = False
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.BackColor = System.Drawing.Color.Transparent
        Me.lblTot.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTot.Location = New System.Drawing.Point(754, 19)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(112, 17)
        Me.lblTot.TabIndex = 57
        Me.lblTot.Text = "TOTAL PRODUCTO"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.BackColor = System.Drawing.Color.Transparent
        Me.lblProd.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblProd.Location = New System.Drawing.Point(635, 19)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(73, 17)
        Me.lblProd.TabIndex = 56
        Me.lblProd.Text = "PRODUCTO"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.Location = New System.Drawing.Point(579, 19)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(50, 17)
        Me.lblPrecio.TabIndex = 55
        Me.lblPrecio.Text = "PRECIO"
        '
        'lblCan
        '
        Me.lblCan.AutoSize = True
        Me.lblCan.BackColor = System.Drawing.Color.Transparent
        Me.lblCan.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCan.Location = New System.Drawing.Point(541, 19)
        Me.lblCan.Name = "lblCan"
        Me.lblCan.Size = New System.Drawing.Size(32, 17)
        Me.lblCan.TabIndex = 54
        Me.lblCan.Text = "CAN"
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.AliceBlue
        Me.lbTotal.FormattingEnabled = True
        Me.lbTotal.Location = New System.Drawing.Point(808, 37)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(49, 290)
        Me.lbTotal.TabIndex = 53
        '
        'lbPrecio
        '
        Me.lbPrecio.BackColor = System.Drawing.Color.AliceBlue
        Me.lbPrecio.FormattingEnabled = True
        Me.lbPrecio.Location = New System.Drawing.Point(579, 37)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(49, 290)
        Me.lbPrecio.TabIndex = 52
        '
        'lbProducto
        '
        Me.lbProducto.BackColor = System.Drawing.Color.AliceBlue
        Me.lbProducto.FormattingEnabled = True
        Me.lbProducto.Location = New System.Drawing.Point(627, 37)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(182, 290)
        Me.lbProducto.TabIndex = 51
        '
        'lbCantidad
        '
        Me.lbCantidad.BackColor = System.Drawing.Color.AliceBlue
        Me.lbCantidad.FormattingEnabled = True
        Me.lbCantidad.Location = New System.Drawing.Point(535, 37)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(45, 290)
        Me.lbCantidad.TabIndex = 50
        '
        'lbCodProd
        '
        Me.lbCodProd.BackColor = System.Drawing.Color.AliceBlue
        Me.lbCodProd.FormattingEnabled = True
        Me.lbCodProd.Location = New System.Drawing.Point(491, 37)
        Me.lbCodProd.Name = "lbCodProd"
        Me.lbCodProd.Size = New System.Drawing.Size(45, 290)
        Me.lbCodProd.TabIndex = 58
        '
        'btnQuitarLineas
        '
        Me.btnQuitarLineas.BackColor = System.Drawing.Color.AliceBlue
        Me.btnQuitarLineas.BackgroundImage = Global.TPV_VB.My.Resources.Resources.delete
        Me.btnQuitarLineas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarLineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarLineas.Location = New System.Drawing.Point(401, 91)
        Me.btnQuitarLineas.Name = "btnQuitarLineas"
        Me.btnQuitarLineas.Size = New System.Drawing.Size(75, 38)
        Me.btnQuitarLineas.TabIndex = 61
        Me.btnQuitarLineas.UseVisualStyleBackColor = False
        '
        'btnQuitarLinea
        '
        Me.btnQuitarLinea.BackColor = System.Drawing.Color.AliceBlue
        Me.btnQuitarLinea.BackgroundImage = Global.TPV_VB.My.Resources.Resources.signo_de_negacion
        Me.btnQuitarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarLinea.Location = New System.Drawing.Point(401, 37)
        Me.btnQuitarLinea.Name = "btnQuitarLinea"
        Me.btnQuitarLinea.Size = New System.Drawing.Size(75, 38)
        Me.btnQuitarLinea.TabIndex = 60
        Me.btnQuitarLinea.UseVisualStyleBackColor = False
        '
        'lblCodProd
        '
        Me.lblCodProd.AutoSize = True
        Me.lblCodProd.BackColor = System.Drawing.Color.Transparent
        Me.lblCodProd.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblCodProd.Location = New System.Drawing.Point(496, 19)
        Me.lblCodProd.Name = "lblCodProd"
        Me.lblCodProd.Size = New System.Drawing.Size(33, 17)
        Me.lblCodProd.TabIndex = 59
        Me.lblCodProd.Text = "COD"
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
        Me.panelCategorias.Location = New System.Drawing.Point(25, 23)
        Me.panelCategorias.Name = "panelCategorias"
        Me.panelCategorias.Size = New System.Drawing.Size(347, 552)
        Me.panelCategorias.TabIndex = 49
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
        'timerFactura
        '
        Me.timerFactura.Interval = 3000
        '
        'ttProductos
        '
        Me.ttProductos.AutomaticDelay = 0
        Me.ttProductos.BackColor = System.Drawing.Color.LemonChiffon
        Me.ttProductos.IsBalloon = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(706, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "TOTAL PEDIDO:"
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.BackColor = System.Drawing.Color.Transparent
        Me.lblEuro.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblEuro.Location = New System.Drawing.Point(855, 347)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(18, 17)
        Me.lblEuro.TabIndex = 72
        Me.lblEuro.Text = " €"
        '
        'lblTotalPedido
        '
        Me.lblTotalPedido.BackColor = System.Drawing.Color.AliceBlue
        Me.lblTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPedido.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPedido.Location = New System.Drawing.Point(808, 343)
        Me.lblTotalPedido.Name = "lblTotalPedido"
        Me.lblTotalPedido.Size = New System.Drawing.Size(49, 22)
        Me.lblTotalPedido.TabIndex = 73
        Me.lblTotalPedido.Text = "0"
        Me.lblTotalPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TPV_VB.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(882, 612)
        Me.Controls.Add(Me.lblTotalPedido)
        Me.Controls.Add(Me.lblEuro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.lbError)
        Me.Controls.Add(Me.lbCalcBot)
        Me.Controls.Add(Me.lbCalcTop)
        Me.Controls.Add(Me.panelCalculadora)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVistaPrevia)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.panelCalculadora.ResumeLayout(False)
        Me.panelCategorias.ResumeLayout(False)
        Me.panelCategorias.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents il_Categorias As System.Windows.Forms.ImageList
    Friend WithEvents printer As System.Drawing.Printing.PrintDocument
    Friend WithEvents printPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents lbError As System.Windows.Forms.Label
    Friend WithEvents lbCalcBot As System.Windows.Forms.Label
    Friend WithEvents lbCalcTop As System.Windows.Forms.Label
    Friend WithEvents panelCalculadora As System.Windows.Forms.Panel
    Friend WithEvents btnVerde As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnCalcPasoAtras As System.Windows.Forms.Button
    Friend WithEvents btnCalcDiv As System.Windows.Forms.Button
    Friend WithEvents btnCalcComa As System.Windows.Forms.Button
    Friend WithEvents btnCalc0 As System.Windows.Forms.Button
    Friend WithEvents btnCalc00 As System.Windows.Forms.Button
    Friend WithEvents btnCalcMult As System.Windows.Forms.Button
    Friend WithEvents btnCalc3 As System.Windows.Forms.Button
    Friend WithEvents btnCalc2 As System.Windows.Forms.Button
    Friend WithEvents btnCalc1 As System.Windows.Forms.Button
    Friend WithEvents btnCalcRestar As System.Windows.Forms.Button
    Friend WithEvents btnCalc6 As System.Windows.Forms.Button
    Friend WithEvents btnCalc5 As System.Windows.Forms.Button
    Friend WithEvents btnCalc4 As System.Windows.Forms.Button
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents btnCalc9 As System.Windows.Forms.Button
    Friend WithEvents btnCalc8 As System.Windows.Forms.Button
    Friend WithEvents btnCalc7 As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents btnBorrarFactura As System.Windows.Forms.Button
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
    Friend WithEvents timerFactura As System.Windows.Forms.Timer
    Friend WithEvents ttProductos As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEuro As System.Windows.Forms.Label
    Friend WithEvents lblTotalPedido As System.Windows.Forms.Label
End Class
