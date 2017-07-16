<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventirapi
    Inherits MetroFramework.Forms.MetroForm

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Agregar = New MetroFramework.Controls.MetroLink()
        Me.btncomprobar = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.txtfecha = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.MetroDateTime1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.btncomprobar)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtcedula)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 207)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Agregar
        '
        Me.Agregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Agregar.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.Agregar.ForeColor = System.Drawing.Color.White
        Me.Agregar.Location = New System.Drawing.Point(99, 282)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(132, 36)
        Me.Agregar.Style = MetroFramework.MetroColorStyle.Blue
        Me.Agregar.TabIndex = 83
        Me.Agregar.Text = "Agregar"
        Me.Agregar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Agregar.UseCustomBackColor = True
        Me.Agregar.UseCustomForeColor = True
        Me.Agregar.UseSelectable = True
        '
        'btncomprobar
        '
        Me.btncomprobar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btncomprobar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncomprobar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncomprobar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncomprobar.Location = New System.Drawing.Point(221, 18)
        Me.btncomprobar.Name = "btncomprobar"
        Me.btncomprobar.Size = New System.Drawing.Size(76, 23)
        Me.btncomprobar.Style = MetroFramework.MetroColorStyle.Blue
        Me.btncomprobar.TabIndex = 30
        Me.btncomprobar.Text = "Comprobar"
        Me.btncomprobar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btncomprobar.UseCustomBackColor = True
        Me.btncomprobar.UseCustomForeColor = True
        Me.btncomprobar.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.White
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel8.Location = New System.Drawing.Point(16, 171)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(128, 19)
        Me.MetroLabel8.TabIndex = 29
        Me.MetroLabel8.Text = "Fecha de Registro"
        Me.MetroLabel8.UseCustomForeColor = True
        Me.MetroLabel8.UseStyleColors = True
        '
        'txttelefono
        '
        Me.txttelefono.Enabled = False
        Me.txttelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(110, 133)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(172, 22)
        Me.txttelefono.TabIndex = 24
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(110, 105)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(172, 22)
        Me.txtdireccion.TabIndex = 15
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.White
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel3.Location = New System.Drawing.Point(37, 136)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel3.TabIndex = 26
        Me.MetroLabel3.Text = "Telefono"
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.White
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel6.Location = New System.Drawing.Point(32, 108)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel6.TabIndex = 26
        Me.MetroLabel6.Text = "Dirección"
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.White
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel4.Location = New System.Drawing.Point(38, 77)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel4.TabIndex = 26
        Me.MetroLabel4.Text = "Apellido"
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'txtapellido
        '
        Me.txtapellido.Enabled = False
        Me.txtapellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(110, 74)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(172, 22)
        Me.txtapellido.TabIndex = 14
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(110, 46)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(172, 22)
        Me.txtnombre.TabIndex = 13
        '
        'txtcedula
        '
        Me.txtcedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.Location = New System.Drawing.Point(80, 18)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(135, 22)
        Me.txtcedula.TabIndex = 12
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.White
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel2.Location = New System.Drawing.Point(39, 49)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel2.TabIndex = 25
        Me.MetroLabel2.Text = "Nombre"
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.White
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 21)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel1.TabIndex = 24
        Me.MetroLabel1.Text = "Cedula"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Enabled = False
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(150, 161)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(91, 29)
        Me.MetroDateTime1.TabIndex = 31
        Me.MetroDateTime1.Visible = False
        '
        'txtfecha
        '
        '
        '
        '
        Me.txtfecha.CustomButton.Image = Nothing
        Me.txtfecha.CustomButton.Location = New System.Drawing.Point(69, 1)
        Me.txtfecha.CustomButton.Name = ""
        Me.txtfecha.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtfecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfecha.CustomButton.TabIndex = 1
        Me.txtfecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfecha.CustomButton.UseSelectable = True
        Me.txtfecha.CustomButton.Visible = False
        Me.txtfecha.Lines = New String(-1) {}
        Me.txtfecha.Location = New System.Drawing.Point(150, 167)
        Me.txtfecha.MaxLength = 32767
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfecha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfecha.SelectedText = ""
        Me.txtfecha.SelectionLength = 0
        Me.txtfecha.SelectionStart = 0
        Me.txtfecha.ShortcutsEnabled = True
        Me.txtfecha.Size = New System.Drawing.Size(91, 23)
        Me.txtfecha.TabIndex = 84
        Me.txtfecha.UseSelectable = True
        Me.txtfecha.Visible = False
        Me.txtfecha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfecha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ventirapi
        '
        Me.AcceptButton = Me.btncomprobar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 341)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ventirapi"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Nuevo Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Agregar As MetroFramework.Controls.MetroLink
    Friend WithEvents btncomprobar As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtfecha As MetroFramework.Controls.MetroTextBox
End Class
