<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HacerCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnSesion = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip.SuspendLayout()
        Me.panelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SesiónToolStripMenuItem, Me.CajaToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProductosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1161, 24)
        Me.menuStrip.TabIndex = 8
        Me.menuStrip.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'GestionUsuariosToolStripMenuItem
        '
        Me.GestionUsuariosToolStripMenuItem.Enabled = False
        Me.GestionUsuariosToolStripMenuItem.Name = "GestionUsuariosToolStripMenuItem"
        Me.GestionUsuariosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GestionUsuariosToolStripMenuItem.Text = "Gestión de usuarios"
        '
        'SesiónToolStripMenuItem
        '
        Me.SesiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.SesiónToolStripMenuItem.Name = "SesiónToolStripMenuItem"
        Me.SesiónToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SesiónToolStripMenuItem.Text = "Sesión"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarCajaToolStripMenuItem, Me.HacerCajaToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'ConsultarCajaToolStripMenuItem
        '
        Me.ConsultarCajaToolStripMenuItem.Enabled = False
        Me.ConsultarCajaToolStripMenuItem.Name = "ConsultarCajaToolStripMenuItem"
        Me.ConsultarCajaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarCajaToolStripMenuItem.Text = "Consultar caja"
        '
        'HacerCajaToolStripMenuItem
        '
        Me.HacerCajaToolStripMenuItem.Enabled = False
        Me.HacerCajaToolStripMenuItem.Name = "HacerCajaToolStripMenuItem"
        Me.HacerCajaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HacerCajaToolStripMenuItem.Text = "Hacer caja"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'panelBotones
        '
        Me.panelBotones.BackColor = System.Drawing.Color.SteelBlue
        Me.panelBotones.Controls.Add(Me.btnAyuda)
        Me.panelBotones.Controls.Add(Me.btnSesion)
        Me.panelBotones.Controls.Add(Me.btnProductos)
        Me.panelBotones.Controls.Add(Me.btnFacturas)
        Me.panelBotones.Location = New System.Drawing.Point(0, 25)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(275, 615)
        Me.panelBotones.TabIndex = 9
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAyuda.Enabled = False
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.Location = New System.Drawing.Point(13, 458)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(249, 143)
        Me.btnAyuda.TabIndex = 3
        Me.btnAyuda.Text = "AYUDA"
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'btnSesion
        '
        Me.btnSesion.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSesion.Enabled = False
        Me.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSesion.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSesion.Location = New System.Drawing.Point(13, 309)
        Me.btnSesion.Name = "btnSesion"
        Me.btnSesion.Size = New System.Drawing.Size(249, 143)
        Me.btnSesion.TabIndex = 2
        Me.btnSesion.Text = "SESIÓN"
        Me.btnSesion.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.AliceBlue
        Me.btnProductos.Enabled = False
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.Location = New System.Drawing.Point(13, 160)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(249, 143)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "NUESTROS PLATOS"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnFacturas
        '
        Me.btnFacturas.BackColor = System.Drawing.Color.AliceBlue
        Me.btnFacturas.Enabled = False
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturas.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.Location = New System.Drawing.Point(13, 11)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(249, 143)
        Me.btnFacturas.TabIndex = 0
        Me.btnFacturas.Text = "PEDIDOS"
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'GestiónDeProductosToolStripMenuItem
        '
        Me.GestiónDeProductosToolStripMenuItem.Enabled = False
        Me.GestiónDeProductosToolStripMenuItem.Name = "GestiónDeProductosToolStripMenuItem"
        Me.GestiónDeProductosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GestiónDeProductosToolStripMenuItem.Text = "Gestión de productos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = Global.TPV_VB.My.Resources.Resources.fondolargo
        Me.ClientSize = New System.Drawing.Size(1161, 641)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.panelBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.panelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents panelBotones As System.Windows.Forms.Panel
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents btnSesion As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents btnFacturas As System.Windows.Forms.Button
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HacerCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
