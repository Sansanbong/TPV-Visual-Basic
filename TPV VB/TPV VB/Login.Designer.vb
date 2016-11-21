<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContrasenya = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picPanelDescripcion = New System.Windows.Forms.PictureBox()
        Me.panelLogin.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanelDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.Transparent
        Me.panelLogin.Controls.Add(Me.lblLogin)
        Me.panelLogin.Controls.Add(Me.lblUsuario)
        Me.panelLogin.Controls.Add(Me.btnAcceder)
        Me.panelLogin.Controls.Add(Me.Label2)
        Me.panelLogin.Controls.Add(Me.txtContrasenya)
        Me.panelLogin.Controls.Add(Me.txtUsuario)
        Me.panelLogin.Location = New System.Drawing.Point(95, 304)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(257, 242)
        Me.panelLogin.TabIndex = 11
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLogin.Location = New System.Drawing.Point(98, 19)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(77, 26)
        Me.lblLogin.TabIndex = 21
        Me.lblLogin.Text = "Log in"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsuario.Location = New System.Drawing.Point(67, 71)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 20
        Me.lblUsuario.Text = "Usuario"
        '
        'btnAcceder
        '
        Me.btnAcceder.Location = New System.Drawing.Point(85, 201)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceder.TabIndex = 19
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(69, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Contraseña"
        '
        'txtContrasenya
        '
        Me.txtContrasenya.Location = New System.Drawing.Point(70, 158)
        Me.txtContrasenya.MaxLength = 11
        Me.txtContrasenya.Name = "txtContrasenya"
        Me.txtContrasenya.Size = New System.Drawing.Size(101, 20)
        Me.txtContrasenya.TabIndex = 18
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(70, 87)
        Me.txtUsuario.MaxLength = 10
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(131, 20)
        Me.txtUsuario.TabIndex = 17
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = Global.TPV_VB.My.Resources.Resources.logo
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(110, 51)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(170, 150)
        Me.picLogo.TabIndex = 9
        Me.picLogo.TabStop = False
        '
        'picPanelDescripcion
        '
        Me.picPanelDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.picPanelDescripcion.BackgroundImage = Global.TPV_VB.My.Resources.Resources.panelbamboo
        Me.picPanelDescripcion.Location = New System.Drawing.Point(449, -23)
        Me.picPanelDescripcion.Name = "picPanelDescripcion"
        Me.picPanelDescripcion.Size = New System.Drawing.Size(381, 603)
        Me.picPanelDescripcion.TabIndex = 10
        Me.picPanelDescripcion.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(882, 612)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picPanelDescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPanelDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelLogin As System.Windows.Forms.Panel
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnAcceder As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContrasenya As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picPanelDescripcion As System.Windows.Forms.PictureBox
End Class
