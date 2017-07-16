<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Agregar = New MetroFramework.Controls.MetroLink()
        Me.pag3 = New MetroFramework.Controls.MetroLink()
        Me.btncomprobar = New MetroFramework.Controls.MetroLink()
        Me.pag1 = New MetroFramework.Controls.MetroLink()
        Me.pag2 = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtfecha = New System.Windows.Forms.TextBox()
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
        Me.btnsalir = New MetroFramework.Controls.MetroLink()
        Me.datagrib1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagrib1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(486, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 231)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles Compras"
        '
        'Button6
        '
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(442, 16)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 23)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Ver Detallado"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"V", "E", "P"})
        Me.ComboBox4.Location = New System.Drawing.Point(152, 16)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(237, 23)
        Me.ComboBox4.TabIndex = 16
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 42)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(657, 180)
        Me.DataGridView2.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(87, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Facturas"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Enabled = False
        Me.MetroDateTime1.Location = New System.Drawing.Point(486, 18)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(207, 29)
        Me.MetroDateTime1.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView3)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(470, 231)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial Compra"
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 24)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(458, 198)
        Me.DataGridView3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Agregar)
        Me.GroupBox1.Controls.Add(Me.pag3)
        Me.GroupBox1.Controls.Add(Me.btncomprobar)
        Me.GroupBox1.Controls.Add(Me.pag1)
        Me.GroupBox1.Controls.Add(Me.pag2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtcedula)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 207)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Agregar
        '
        Me.Agregar.BackColor = System.Drawing.Color.White
        Me.Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Agregar.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.Agregar.ForeColor = System.Drawing.Color.Black
        Me.Agregar.Location = New System.Drawing.Point(308, 161)
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
        'pag3
        '
        Me.pag3.BackColor = System.Drawing.Color.White
        Me.pag3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pag3.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.pag3.ForeColor = System.Drawing.Color.Black
        Me.pag3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.pag3.Location = New System.Drawing.Point(308, 35)
        Me.pag3.Name = "pag3"
        Me.pag3.Size = New System.Drawing.Size(132, 36)
        Me.pag3.Style = MetroFramework.MetroColorStyle.Blue
        Me.pag3.TabIndex = 82
        Me.pag3.Text = "Editar"
        Me.pag3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pag3.UseCustomBackColor = True
        Me.pag3.UseCustomForeColor = True
        Me.pag3.UseSelectable = True
        '
        'btncomprobar
        '
        Me.btncomprobar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btncomprobar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncomprobar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncomprobar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncomprobar.Location = New System.Drawing.Point(221, 17)
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
        'pag1
        '
        Me.pag1.BackColor = System.Drawing.Color.White
        Me.pag1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pag1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.pag1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.pag1.Location = New System.Drawing.Point(308, 77)
        Me.pag1.Name = "pag1"
        Me.pag1.Size = New System.Drawing.Size(132, 36)
        Me.pag1.Style = MetroFramework.MetroColorStyle.Blue
        Me.pag1.TabIndex = 80
        Me.pag1.Text = "Actualizar"
        Me.pag1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pag1.UseCustomBackColor = True
        Me.pag1.UseCustomForeColor = True
        Me.pag1.UseSelectable = True
        '
        'pag2
        '
        Me.pag2.BackColor = System.Drawing.Color.Firebrick
        Me.pag2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pag2.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.pag2.ForeColor = System.Drawing.Color.White
        Me.pag2.Location = New System.Drawing.Point(308, 119)
        Me.pag2.Name = "pag2"
        Me.pag2.Size = New System.Drawing.Size(132, 36)
        Me.pag2.Style = MetroFramework.MetroColorStyle.Blue
        Me.pag2.TabIndex = 81
        Me.pag2.Text = "Eliminar"
        Me.pag2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pag2.UseCustomBackColor = True
        Me.pag2.UseCustomForeColor = True
        Me.pag2.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(4, 164)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(128, 19)
        Me.MetroLabel8.TabIndex = 29
        Me.MetroLabel8.Text = "Fecha de Registro"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel8.UseCustomForeColor = True
        Me.MetroLabel8.UseStyleColors = True
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(138, 161)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(125, 22)
        Me.txtfecha.TabIndex = 25
        '
        'txttelefono
        '
        Me.txttelefono.Enabled = False
        Me.txttelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(91, 133)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(172, 22)
        Me.txttelefono.TabIndex = 24
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(91, 105)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(172, 22)
        Me.txtdireccion.TabIndex = 15
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 136)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel3.TabIndex = 26
        Me.MetroLabel3.Text = "Telefono"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(13, 108)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel6.TabIndex = 26
        Me.MetroLabel6.Text = "Dirección"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 77)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel4.TabIndex = 26
        Me.MetroLabel4.Text = "Apellido"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'txtapellido
        '
        Me.txtapellido.Enabled = False
        Me.txtapellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(91, 74)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(172, 22)
        Me.txtapellido.TabIndex = 14
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(91, 46)
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
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(20, 49)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel2.TabIndex = 25
        Me.MetroLabel2.Text = "Nombre"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 21)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel1.TabIndex = 24
        Me.MetroLabel1.Text = "Cedula"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsalir.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(1076, 76)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(90, 23)
        Me.btnsalir.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnsalir.TabIndex = 84
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnsalir.UseCustomBackColor = True
        Me.btnsalir.UseCustomForeColor = True
        Me.btnsalir.UseSelectable = True
        '
        'datagrib1
        '
        Me.datagrib1.AllowUserToAddRows = False
        Me.datagrib1.AllowUserToDeleteRows = False
        Me.datagrib1.AllowUserToResizeColumns = False
        Me.datagrib1.AllowUserToResizeRows = False
        Me.datagrib1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrib1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrib1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrib1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrib1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrib1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrib1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrib1.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagrib1.EnableHeadersVisualStyles = False
        Me.datagrib1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrib1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrib1.Location = New System.Drawing.Point(486, 53)
        Me.datagrib1.Name = "datagrib1"
        Me.datagrib1.ReadOnly = True
        Me.datagrib1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrib1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagrib1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrib1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrib1.Size = New System.Drawing.Size(575, 202)
        Me.datagrib1.TabIndex = 85
        '
        'MetroLink3
        '
        Me.MetroLink3.BackColor = System.Drawing.Color.DarkBlue
        Me.MetroLink3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink3.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink3.ForeColor = System.Drawing.Color.White
        Me.MetroLink3.Location = New System.Drawing.Point(1076, 48)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(90, 22)
        Me.MetroLink3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLink3.TabIndex = 86
        Me.MetroLink3.Text = "ACT"
        Me.MetroLink3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLink3.UseCustomBackColor = True
        Me.MetroLink3.UseCustomForeColor = True
        Me.MetroLink3.UseSelectable = True
        '
        'cliente
        '
        Me.AcceptButton = Me.btncomprobar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btnsalir
        Me.ClientSize = New System.Drawing.Size(1214, 562)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.MetroLink3)
        Me.Controls.Add(Me.datagrib1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "cliente"
        Me.Text = "Clientes Registrados - Lavanderia Predilecta"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagrib1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btncomprobar As MetroFramework.Controls.MetroLink
    Friend WithEvents Agregar As MetroFramework.Controls.MetroLink
    Friend WithEvents pag3 As MetroFramework.Controls.MetroLink
    Friend WithEvents pag1 As MetroFramework.Controls.MetroLink
    Friend WithEvents pag2 As MetroFramework.Controls.MetroLink
    Friend WithEvents btnsalir As MetroFramework.Controls.MetroLink
    Friend WithEvents datagrib1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLink3 As MetroFramework.Controls.MetroLink
End Class
