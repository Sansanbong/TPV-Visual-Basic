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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.btnSesion = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.panelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1161, 24)
        Me.menuStrip.TabIndex = 8
        Me.menuStrip.Text = "MenuStrip1"
        '
        'panelBotones
        '
        Me.panelBotones.BackColor = System.Drawing.Color.SteelBlue
        Me.panelBotones.Controls.Add(Me.btnCaja)
        Me.panelBotones.Controls.Add(Me.btnSesion)
        Me.panelBotones.Controls.Add(Me.btnProductos)
        Me.panelBotones.Controls.Add(Me.btnFacturas)
        Me.panelBotones.Location = New System.Drawing.Point(0, 25)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(275, 615)
        Me.panelBotones.TabIndex = 9
        '
        'btnCaja
        '
        Me.btnCaja.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.Location = New System.Drawing.Point(13, 458)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(249, 143)
        Me.btnCaja.TabIndex = 3
        Me.btnCaja.Text = "CAJA REGISTRADORA"
        Me.btnCaja.UseVisualStyleBackColor = False
        '
        'btnSesion
        '
        Me.btnSesion.BackColor = System.Drawing.Color.AliceBlue
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
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturas.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.Location = New System.Drawing.Point(13, 11)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(249, 143)
        Me.btnFacturas.TabIndex = 0
        Me.btnFacturas.Text = "PEDIDOS"
        Me.btnFacturas.UseVisualStyleBackColor = False
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.panelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents panelBotones As System.Windows.Forms.Panel
    Friend WithEvents btnCaja As System.Windows.Forms.Button
    Friend WithEvents btnSesion As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents btnFacturas As System.Windows.Forms.Button

End Class
