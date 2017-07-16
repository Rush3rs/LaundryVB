<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtcedula = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtnombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtapellido = New MetroFramework.Controls.MetroTextBox()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.btncomprobar = New MetroFramework.Controls.MetroLink()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comnu1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtdevolucion = New MetroFramework.Controls.MetroTextBox()
        Me.txttotalpagar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtiva = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtprecioservicio = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.Servicio = New MetroFramework.Controls.MetroComboBox()
        Me.btninsertar = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.prenda = New MetroFramework.Controls.MetroComboBox()
        Me.btncancelar = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtsubtotal = New MetroFramework.Controls.MetroTextBox()
        Me.txtprenda = New MetroFramework.Controls.MetroTextBox()
        Me.txtservicio = New MetroFramework.Controls.MetroTextBox()
        Me.btnssalir = New MetroFramework.Controls.MetroLink()
        Me.ee = New MetroFramework.Controls.MetroLink()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnelimnar = New MetroFramework.Controls.MetroLink()
        Me.btncal = New MetroFramework.Controls.MetroLink()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.eeee = New System.Windows.Forms.TextBox()
        Me.MetroDateTime2 = New MetroFramework.Controls.MetroDateTime()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txttipo = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pag1 = New MetroFramework.Controls.MetroLink()
        Me.pag2 = New MetroFramework.Controls.MetroLink()
        Me.pag3 = New MetroFramework.Controls.MetroLink()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcedula
        '
        '
        '
        '
        Me.txtcedula.CustomButton.Image = Nothing
        Me.txtcedula.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.txtcedula.CustomButton.Name = ""
        Me.txtcedula.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtcedula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcedula.CustomButton.TabIndex = 1
        Me.txtcedula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcedula.CustomButton.UseSelectable = True
        Me.txtcedula.CustomButton.Visible = False
        Me.txtcedula.Lines = New String(-1) {}
        Me.txtcedula.Location = New System.Drawing.Point(223, 72)
        Me.txtcedula.MaxLength = 32767
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcedula.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcedula.SelectedText = ""
        Me.txtcedula.SelectionLength = 0
        Me.txtcedula.SelectionStart = 0
        Me.txtcedula.ShortcutsEnabled = True
        Me.txtcedula.Size = New System.Drawing.Size(177, 23)
        Me.txtcedula.TabIndex = 0
        Me.txtcedula.UseSelectable = True
        Me.txtcedula.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcedula.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(71, 72)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(146, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Cedula de Cliente"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(34, 111)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(80, 25)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Nombre "
        '
        'txtnombre
        '
        '
        '
        '
        Me.txtnombre.CustomButton.Image = Nothing
        Me.txtnombre.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.txtnombre.CustomButton.Name = ""
        Me.txtnombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtnombre.CustomButton.TabIndex = 1
        Me.txtnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtnombre.CustomButton.UseSelectable = True
        Me.txtnombre.CustomButton.Visible = False
        Me.txtnombre.Enabled = False
        Me.txtnombre.Lines = New String(-1) {}
        Me.txtnombre.Location = New System.Drawing.Point(110, 111)
        Me.txtnombre.MaxLength = 32767
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtnombre.SelectedText = ""
        Me.txtnombre.SelectionLength = 0
        Me.txtnombre.SelectionStart = 0
        Me.txtnombre.ShortcutsEnabled = True
        Me.txtnombre.Size = New System.Drawing.Size(218, 23)
        Me.txtnombre.TabIndex = 3
        Me.txtnombre.UseSelectable = True
        Me.txtnombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtnombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(344, 111)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(74, 25)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Apellido"
        '
        'txtapellido
        '
        '
        '
        '
        Me.txtapellido.CustomButton.Image = Nothing
        Me.txtapellido.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.txtapellido.CustomButton.Name = ""
        Me.txtapellido.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtapellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtapellido.CustomButton.TabIndex = 1
        Me.txtapellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtapellido.CustomButton.UseSelectable = True
        Me.txtapellido.CustomButton.Visible = False
        Me.txtapellido.Enabled = False
        Me.txtapellido.Lines = New String(-1) {}
        Me.txtapellido.Location = New System.Drawing.Point(415, 111)
        Me.txtapellido.MaxLength = 32767
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtapellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtapellido.SelectedText = ""
        Me.txtapellido.SelectionLength = 0
        Me.txtapellido.SelectionStart = 0
        Me.txtapellido.ShortcutsEnabled = True
        Me.txtapellido.Size = New System.Drawing.Size(218, 23)
        Me.txtapellido.TabIndex = 5
        Me.txtapellido.UseSelectable = True
        Me.txtapellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtapellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroDateTime1.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.MetroDateTime1.Enabled = False
        Me.MetroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(1058, 33)
        Me.MetroDateTime1.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(4, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(101, 29)
        Me.MetroDateTime1.TabIndex = 31
        Me.MetroDateTime1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroDateTime1.UseCustomBackColor = True
        Me.MetroDateTime1.UseCustomForeColor = True
        Me.MetroDateTime1.UseStyleColors = True
        '
        'btncomprobar
        '
        Me.btncomprobar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btncomprobar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncomprobar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncomprobar.Location = New System.Drawing.Point(419, 72)
        Me.btncomprobar.Name = "btncomprobar"
        Me.btncomprobar.Size = New System.Drawing.Size(76, 23)
        Me.btncomprobar.Style = MetroFramework.MetroColorStyle.Blue
        Me.btncomprobar.TabIndex = 2
        Me.btncomprobar.Text = "Comprobar"
        Me.btncomprobar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btncomprobar.UseCustomBackColor = True
        Me.btncomprobar.UseCustomForeColor = True
        Me.btncomprobar.UseSelectable = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeColumns = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.Silver
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.comnu1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(22, 271)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(819, 422)
        Me.MetroGrid1.TabIndex = 36
        Me.MetroGrid1.UseCustomBackColor = True
        Me.MetroGrid1.UseCustomForeColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Prendas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad de Prendas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio de Cada Servicio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'comnu1
        '
        Me.comnu1.HeaderText = "Costo Total "
        Me.comnu1.Name = "comnu1"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(7, 16)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel9.TabIndex = 55
        Me.MetroLabel9.Text = "Devolución"
        Me.MetroLabel9.UseCustomBackColor = True
        Me.MetroLabel9.UseCustomForeColor = True
        '
        'txtdevolucion
        '
        '
        '
        '
        Me.txtdevolucion.CustomButton.Image = Nothing
        Me.txtdevolucion.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtdevolucion.CustomButton.Name = ""
        Me.txtdevolucion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtdevolucion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdevolucion.CustomButton.TabIndex = 1
        Me.txtdevolucion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdevolucion.CustomButton.UseSelectable = True
        Me.txtdevolucion.CustomButton.Visible = False
        Me.txtdevolucion.Lines = New String(-1) {}
        Me.txtdevolucion.Location = New System.Drawing.Point(7, 38)
        Me.txtdevolucion.MaxLength = 32767
        Me.txtdevolucion.Name = "txtdevolucion"
        Me.txtdevolucion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdevolucion.ReadOnly = True
        Me.txtdevolucion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdevolucion.SelectedText = ""
        Me.txtdevolucion.SelectionLength = 0
        Me.txtdevolucion.SelectionStart = 0
        Me.txtdevolucion.ShortcutsEnabled = True
        Me.txtdevolucion.Size = New System.Drawing.Size(162, 23)
        Me.txtdevolucion.TabIndex = 54
        Me.txtdevolucion.UseSelectable = True
        Me.txtdevolucion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdevolucion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txttotalpagar
        '
        '
        '
        '
        Me.txttotalpagar.CustomButton.Image = Nothing
        Me.txttotalpagar.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.txttotalpagar.CustomButton.Name = ""
        Me.txttotalpagar.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txttotalpagar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttotalpagar.CustomButton.TabIndex = 1
        Me.txttotalpagar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttotalpagar.CustomButton.UseSelectable = True
        Me.txttotalpagar.CustomButton.Visible = False
        Me.txttotalpagar.Lines = New String(-1) {}
        Me.txttotalpagar.Location = New System.Drawing.Point(712, 772)
        Me.txttotalpagar.MaxLength = 32767
        Me.txttotalpagar.Name = "txttotalpagar"
        Me.txttotalpagar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotalpagar.ReadOnly = True
        Me.txttotalpagar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttotalpagar.SelectedText = ""
        Me.txttotalpagar.SelectionLength = 0
        Me.txttotalpagar.SelectionStart = 0
        Me.txttotalpagar.ShortcutsEnabled = True
        Me.txttotalpagar.Size = New System.Drawing.Size(129, 23)
        Me.txttotalpagar.TabIndex = 40
        Me.txttotalpagar.UseCustomBackColor = True
        Me.txttotalpagar.UseCustomForeColor = True
        Me.txttotalpagar.UseSelectable = True
        Me.txttotalpagar.UseStyleColors = True
        Me.txttotalpagar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttotalpagar.WaterMarkFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.BackColor = System.Drawing.Color.Wheat
        Me.MetroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel17.Location = New System.Drawing.Point(582, 770)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(123, 25)
        Me.MetroLabel17.TabIndex = 39
        Me.MetroLabel17.Text = "Total a Pagar"
        Me.MetroLabel17.UseCustomBackColor = True
        Me.MetroLabel17.UseCustomForeColor = True
        Me.MetroLabel17.UseStyleColors = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel16.Location = New System.Drawing.Point(666, 739)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(39, 25)
        Me.MetroLabel16.TabIndex = 38
        Me.MetroLabel16.Text = "IVA"
        Me.MetroLabel16.UseCustomBackColor = True
        Me.MetroLabel16.UseCustomForeColor = True
        Me.MetroLabel16.UseStyleColors = True
        '
        'txtiva
        '
        '
        '
        '
        Me.txtiva.CustomButton.Image = Nothing
        Me.txtiva.CustomButton.Location = New System.Drawing.Point(21, 1)
        Me.txtiva.CustomButton.Name = ""
        Me.txtiva.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtiva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtiva.CustomButton.TabIndex = 1
        Me.txtiva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtiva.CustomButton.UseSelectable = True
        Me.txtiva.CustomButton.Visible = False
        Me.txtiva.Lines = New String(-1) {}
        Me.txtiva.Location = New System.Drawing.Point(712, 741)
        Me.txtiva.MaxLength = 32767
        Me.txtiva.Name = "txtiva"
        Me.txtiva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtiva.ReadOnly = True
        Me.txtiva.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtiva.SelectedText = ""
        Me.txtiva.SelectionLength = 0
        Me.txtiva.SelectionStart = 0
        Me.txtiva.ShortcutsEnabled = True
        Me.txtiva.Size = New System.Drawing.Size(43, 23)
        Me.txtiva.TabIndex = 37
        Me.txtiva.UseCustomBackColor = True
        Me.txtiva.UseCustomForeColor = True
        Me.txtiva.UseSelectable = True
        Me.txtiva.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtiva.WaterMarkFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.MetroLabel13)
        Me.GroupBox2.Controls.Add(Me.txtprecioservicio)
        Me.GroupBox2.Controls.Add(Me.MetroLabel12)
        Me.GroupBox2.Controls.Add(Me.MetroLabel8)
        Me.GroupBox2.Controls.Add(Me.Servicio)
        Me.GroupBox2.Controls.Add(Me.btninsertar)
        Me.GroupBox2.Controls.Add(Me.MetroLabel7)
        Me.GroupBox2.Controls.Add(Me.prenda)
        Me.GroupBox2.Controls.Add(Me.btncancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 114)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcantidad.CustomButton.Image = Nothing
        Me.txtcantidad.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.txtcantidad.CustomButton.Name = ""
        Me.txtcantidad.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtcantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcantidad.CustomButton.TabIndex = 1
        Me.txtcantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcantidad.CustomButton.UseSelectable = True
        Me.txtcantidad.CustomButton.Visible = False
        Me.txtcantidad.Lines = New String(-1) {}
        Me.txtcantidad.Location = New System.Drawing.Point(283, 71)
        Me.txtcantidad.MaxLength = 32767
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcantidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcantidad.SelectedText = ""
        Me.txtcantidad.SelectionLength = 0
        Me.txtcantidad.SelectionStart = 0
        Me.txtcantidad.ShortcutsEnabled = True
        Me.txtcantidad.Size = New System.Drawing.Size(97, 23)
        Me.txtcantidad.TabIndex = 3
        Me.txtcantidad.UseCustomBackColor = True
        Me.txtcantidad.UseCustomForeColor = True
        Me.txtcantidad.UseSelectable = True
        Me.txtcantidad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcantidad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(268, 54)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(116, 15)
        Me.MetroLabel13.TabIndex = 28
        Me.MetroLabel13.Text = "Cantidad de Prendas"
        Me.MetroLabel13.UseCustomBackColor = True
        Me.MetroLabel13.UseCustomForeColor = True
        '
        'txtprecioservicio
        '
        '
        '
        '
        Me.txtprecioservicio.CustomButton.Image = Nothing
        Me.txtprecioservicio.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.txtprecioservicio.CustomButton.Name = ""
        Me.txtprecioservicio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtprecioservicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtprecioservicio.CustomButton.TabIndex = 1
        Me.txtprecioservicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtprecioservicio.CustomButton.UseSelectable = True
        Me.txtprecioservicio.CustomButton.Visible = False
        Me.txtprecioservicio.Enabled = False
        Me.txtprecioservicio.Lines = New String(-1) {}
        Me.txtprecioservicio.Location = New System.Drawing.Point(283, 28)
        Me.txtprecioservicio.MaxLength = 32767
        Me.txtprecioservicio.Name = "txtprecioservicio"
        Me.txtprecioservicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprecioservicio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtprecioservicio.SelectedText = ""
        Me.txtprecioservicio.SelectionLength = 0
        Me.txtprecioservicio.SelectionStart = 0
        Me.txtprecioservicio.ShortcutsEnabled = True
        Me.txtprecioservicio.Size = New System.Drawing.Size(97, 23)
        Me.txtprecioservicio.TabIndex = 3
        Me.txtprecioservicio.UseSelectable = True
        Me.txtprecioservicio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtprecioservicio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(268, 10)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(103, 15)
        Me.MetroLabel12.TabIndex = 26
        Me.MetroLabel12.Text = "Precio del Servicio"
        Me.MetroLabel12.UseCustomBackColor = True
        Me.MetroLabel12.UseCustomForeColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(5, 26)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(73, 25)
        Me.MetroLabel8.TabIndex = 16
        Me.MetroLabel8.Text = "Servicio"
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        '
        'Servicio
        '
        Me.Servicio.FormattingEnabled = True
        Me.Servicio.ItemHeight = 23
        Me.Servicio.Items.AddRange(New Object() {"Otros"})
        Me.Servicio.Location = New System.Drawing.Point(85, 22)
        Me.Servicio.Name = "Servicio"
        Me.Servicio.Size = New System.Drawing.Size(164, 29)
        Me.Servicio.TabIndex = 1
        Me.Servicio.UseSelectable = True
        '
        'btninsertar
        '
        Me.btninsertar.BackColor = System.Drawing.Color.Gainsboro
        Me.btninsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninsertar.Enabled = False
        Me.btninsertar.Location = New System.Drawing.Point(397, 22)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(146, 32)
        Me.btninsertar.Style = MetroFramework.MetroColorStyle.Brown
        Me.btninsertar.TabIndex = 4
        Me.btninsertar.Text = "Insertar Venta"
        Me.btninsertar.UseCustomBackColor = True
        Me.btninsertar.UseCustomForeColor = True
        Me.btninsertar.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(11, 71)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(67, 25)
        Me.MetroLabel7.TabIndex = 18
        Me.MetroLabel7.Text = "Prenda"
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'prenda
        '
        Me.prenda.FormattingEnabled = True
        Me.prenda.ItemHeight = 23
        Me.prenda.Items.AddRange(New Object() {"Otros"})
        Me.prenda.Location = New System.Drawing.Point(85, 67)
        Me.prenda.Name = "prenda"
        Me.prenda.Size = New System.Drawing.Size(164, 29)
        Me.prenda.TabIndex = 2
        Me.prenda.UseSelectable = True
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Silver
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.ImageSize = 30
        Me.btncancelar.Location = New System.Drawing.Point(397, 71)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(146, 32)
        Me.btncancelar.TabIndex = 7
        Me.btncancelar.Text = "Cancelar Venta"
        Me.btncancelar.UseCustomBackColor = True
        Me.btncancelar.UseCustomForeColor = True
        Me.btncancelar.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel15.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel15.Location = New System.Drawing.Point(626, 703)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(79, 25)
        Me.MetroLabel15.TabIndex = 36
        Me.MetroLabel15.Text = "Subtotal"
        Me.MetroLabel15.UseCustomBackColor = True
        Me.MetroLabel15.UseCustomForeColor = True
        Me.MetroLabel15.UseStyleColors = True
        '
        'txtsubtotal
        '
        '
        '
        '
        Me.txtsubtotal.CustomButton.Image = Nothing
        Me.txtsubtotal.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.txtsubtotal.CustomButton.Name = ""
        Me.txtsubtotal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtsubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsubtotal.CustomButton.TabIndex = 1
        Me.txtsubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsubtotal.CustomButton.UseSelectable = True
        Me.txtsubtotal.CustomButton.Visible = False
        Me.txtsubtotal.Lines = New String(-1) {}
        Me.txtsubtotal.Location = New System.Drawing.Point(711, 705)
        Me.txtsubtotal.MaxLength = 32767
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsubtotal.SelectedText = ""
        Me.txtsubtotal.SelectionLength = 0
        Me.txtsubtotal.SelectionStart = 0
        Me.txtsubtotal.ShortcutsEnabled = True
        Me.txtsubtotal.Size = New System.Drawing.Size(130, 23)
        Me.txtsubtotal.TabIndex = 24
        Me.txtsubtotal.UseCustomBackColor = True
        Me.txtsubtotal.UseCustomForeColor = True
        Me.txtsubtotal.UseSelectable = True
        Me.txtsubtotal.UseStyleColors = True
        Me.txtsubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsubtotal.WaterMarkFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtprenda
        '
        '
        '
        '
        Me.txtprenda.CustomButton.Image = Nothing
        Me.txtprenda.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.txtprenda.CustomButton.Name = ""
        Me.txtprenda.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtprenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtprenda.CustomButton.TabIndex = 1
        Me.txtprenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtprenda.CustomButton.UseSelectable = True
        Me.txtprenda.CustomButton.Visible = False
        Me.txtprenda.Lines = New String(-1) {}
        Me.txtprenda.Location = New System.Drawing.Point(511, 23)
        Me.txtprenda.MaxLength = 32767
        Me.txtprenda.Name = "txtprenda"
        Me.txtprenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprenda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtprenda.SelectedText = ""
        Me.txtprenda.SelectionLength = 0
        Me.txtprenda.SelectionStart = 0
        Me.txtprenda.ShortcutsEnabled = True
        Me.txtprenda.Size = New System.Drawing.Size(97, 23)
        Me.txtprenda.TabIndex = 50
        Me.txtprenda.UseSelectable = True
        Me.txtprenda.Visible = False
        Me.txtprenda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtprenda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtservicio
        '
        '
        '
        '
        Me.txtservicio.CustomButton.Image = Nothing
        Me.txtservicio.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.txtservicio.CustomButton.Name = ""
        Me.txtservicio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtservicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtservicio.CustomButton.TabIndex = 1
        Me.txtservicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtservicio.CustomButton.UseSelectable = True
        Me.txtservicio.CustomButton.Visible = False
        Me.txtservicio.Lines = New String(-1) {}
        Me.txtservicio.Location = New System.Drawing.Point(406, 23)
        Me.txtservicio.MaxLength = 32767
        Me.txtservicio.Name = "txtservicio"
        Me.txtservicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtservicio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtservicio.SelectedText = ""
        Me.txtservicio.SelectionLength = 0
        Me.txtservicio.SelectionStart = 0
        Me.txtservicio.ShortcutsEnabled = True
        Me.txtservicio.Size = New System.Drawing.Size(97, 23)
        Me.txtservicio.TabIndex = 49
        Me.txtservicio.UseSelectable = True
        Me.txtservicio.Visible = False
        Me.txtservicio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtservicio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnssalir
        '
        Me.btnssalir.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnssalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnssalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnssalir.Location = New System.Drawing.Point(614, 23)
        Me.btnssalir.Name = "btnssalir"
        Me.btnssalir.Size = New System.Drawing.Size(78, 23)
        Me.btnssalir.Style = MetroFramework.MetroColorStyle.Brown
        Me.btnssalir.TabIndex = 51
        Me.btnssalir.Text = "Salir"
        Me.btnssalir.UseCustomBackColor = True
        Me.btnssalir.UseCustomForeColor = True
        Me.btnssalir.UseSelectable = True
        Me.btnssalir.Visible = False
        '
        'ee
        '
        Me.ee.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ee.Cursor = System.Windows.Forms.Cursors.No
        Me.ee.Enabled = False
        Me.ee.Location = New System.Drawing.Point(986, 221)
        Me.ee.Name = "ee"
        Me.ee.Size = New System.Drawing.Size(130, 32)
        Me.ee.Style = MetroFramework.MetroColorStyle.Brown
        Me.ee.TabIndex = 37
        Me.ee.Text = "Atajos Teclas"
        Me.ee.UseCustomBackColor = True
        Me.ee.UseCustomForeColor = True
        Me.ee.UseSelectable = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label13.Cursor = System.Windows.Forms.Cursors.No
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(996, 453)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 15)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = " * Cerrar Ventana"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label14.Cursor = System.Windows.Forms.Cursors.No
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(996, 438)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 15)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Esc "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label4.Cursor = System.Windows.Forms.Cursors.No
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(996, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 15)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = " * Insertar un Pedido"
        '
        'btnelimnar
        '
        Me.btnelimnar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnelimnar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnelimnar.Image = CType(resources.GetObject("btnelimnar.Image"), System.Drawing.Image)
        Me.btnelimnar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnelimnar.ImageSize = 30
        Me.btnelimnar.Location = New System.Drawing.Point(18, 71)
        Me.btnelimnar.Name = "btnelimnar"
        Me.btnelimnar.NoFocusImage = CType(resources.GetObject("btnelimnar.NoFocusImage"), System.Drawing.Image)
        Me.btnelimnar.Size = New System.Drawing.Size(182, 37)
        Me.btnelimnar.TabIndex = 6
        Me.btnelimnar.Text = "Eliminar Registro"
        Me.btnelimnar.UseCustomBackColor = True
        Me.btnelimnar.UseCustomForeColor = True
        Me.btnelimnar.UseSelectable = True
        '
        'btncal
        '
        Me.btncal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btncal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncal.Image = CType(resources.GetObject("btncal.Image"), System.Drawing.Image)
        Me.btncal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncal.ImageSize = 30
        Me.btncal.Location = New System.Drawing.Point(677, 100)
        Me.btncal.Name = "btncal"
        Me.btncal.NoFocusImage = CType(resources.GetObject("btncal.NoFocusImage"), System.Drawing.Image)
        Me.btncal.Size = New System.Drawing.Size(130, 36)
        Me.btncal.TabIndex = 8
        Me.btncal.Text = "Calculadora"
        Me.btncal.UseCustomBackColor = True
        Me.btncal.UseCustomForeColor = True
        Me.btncal.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label5.Cursor = System.Windows.Forms.Cursors.No
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(996, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Enter/Intro"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Cursor = System.Windows.Forms.Cursors.No
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(996, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 41)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = " * Cancelar Pedido Completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Cursor = System.Windows.Forms.Cursors.No
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(996, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "F2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(996, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = " * Calculadora"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.YellowGreen
        Me.Label10.Cursor = System.Windows.Forms.Cursors.No
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(996, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 15)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "F1"
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.BackColor = System.Drawing.Color.LightCyan
        Me.Label12.Cursor = System.Windows.Forms.Cursors.No
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(996, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 51)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = " *Borrar fila del pedido elegido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightCyan
        Me.Label11.Cursor = System.Windows.Forms.Cursors.No
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(996, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 15)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Supr/Del"
        '
        'eeee
        '
        Me.eeee.BackColor = System.Drawing.Color.LightGray
        Me.eeee.Cursor = System.Windows.Forms.Cursors.No
        Me.eeee.Location = New System.Drawing.Point(986, 247)
        Me.eeee.Multiline = True
        Me.eeee.Name = "eeee"
        Me.eeee.Size = New System.Drawing.Size(130, 227)
        Me.eeee.TabIndex = 56
        '
        'MetroDateTime2
        '
        Me.MetroDateTime2.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroDateTime2.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLight
        Me.MetroDateTime2.Enabled = False
        Me.MetroDateTime2.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.MetroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.MetroDateTime2.Location = New System.Drawing.Point(1058, 73)
        Me.MetroDateTime2.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.MetroDateTime2.MinimumSize = New System.Drawing.Size(4, 29)
        Me.MetroDateTime2.Name = "MetroDateTime2"
        Me.MetroDateTime2.Size = New System.Drawing.Size(101, 29)
        Me.MetroDateTime2.TabIndex = 58
        Me.MetroDateTime2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroDateTime2.UseCustomBackColor = True
        Me.MetroDateTime2.UseCustomForeColor = True
        Me.MetroDateTime2.UseStyleColors = True
        '
        'txttipo
        '
        '
        '
        '
        Me.txttipo.CustomButton.Image = Nothing
        Me.txttipo.CustomButton.Location = New System.Drawing.Point(105, 1)
        Me.txttipo.CustomButton.Name = ""
        Me.txttipo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txttipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttipo.CustomButton.TabIndex = 1
        Me.txttipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttipo.CustomButton.UseSelectable = True
        Me.txttipo.CustomButton.Visible = False
        Me.txttipo.Enabled = False
        Me.txttipo.Lines = New String(-1) {}
        Me.txttipo.Location = New System.Drawing.Point(708, 23)
        Me.txttipo.MaxLength = 32767
        Me.txttipo.Name = "txttipo"
        Me.txttipo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttipo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttipo.SelectedText = ""
        Me.txttipo.SelectionLength = 0
        Me.txttipo.SelectionStart = 0
        Me.txttipo.ShortcutsEnabled = True
        Me.txttipo.Size = New System.Drawing.Size(127, 23)
        Me.txttipo.TabIndex = 44
        Me.txttipo.UseSelectable = True
        Me.txttipo.Visible = False
        Me.txttipo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttipo.WaterMarkFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.txtdevolucion)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.btnelimnar)
        Me.GroupBox1.Location = New System.Drawing.Point(586, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 114)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'pag1
        '
        Me.pag1.BackColor = System.Drawing.Color.Crimson
        Me.pag1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pag1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.pag1.ForeColor = System.Drawing.Color.White
        Me.pag1.Location = New System.Drawing.Point(54, 41)
        Me.pag1.Name = "pag1"
        Me.pag1.Size = New System.Drawing.Size(90, 36)
        Me.pag1.Style = MetroFramework.MetroColorStyle.Blue
        Me.pag1.TabIndex = 77
        Me.pag1.Text = "Efectivo"
        Me.pag1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pag1.UseCustomBackColor = True
        Me.pag1.UseCustomForeColor = True
        Me.pag1.UseSelectable = True
        '
        'pag2
        '
        Me.pag2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pag2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pag2.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.pag2.ForeColor = System.Drawing.Color.White
        Me.pag2.Location = New System.Drawing.Point(196, 41)
        Me.pag2.Name = "pag2"
        Me.pag2.Size = New System.Drawing.Size(90, 36)
        Me.pag2.Style = MetroFramework.MetroColorStyle.Blue
        Me.pag2.TabIndex = 78
        Me.pag2.Text = "Tarjeta"
        Me.pag2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pag2.UseCustomBackColor = True
        Me.pag2.UseCustomForeColor = True
        Me.pag2.UseSelectable = True
        '
        'pag3
        '
        Me.pag3.BackColor = System.Drawing.SystemColors.Highlight
        Me.pag3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pag3.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.pag3.ForeColor = System.Drawing.Color.White
        Me.pag3.Location = New System.Drawing.Point(337, 41)
        Me.pag3.Name = "pag3"
        Me.pag3.Size = New System.Drawing.Size(94, 36)
        Me.pag3.Style = MetroFramework.MetroColorStyle.Blue
        Me.pag3.TabIndex = 79
        Me.pag3.Text = "Cheques"
        Me.pag3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pag3.UseCustomBackColor = True
        Me.pag3.UseCustomForeColor = True
        Me.pag3.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.MetroLabel4)
        Me.GroupBox3.Controls.Add(Me.pag3)
        Me.GroupBox3.Controls.Add(Me.pag1)
        Me.GroupBox3.Controls.Add(Me.pag2)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 705)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(485, 88)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(7, 13)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(124, 25)
        Me.MetroLabel4.TabIndex = 77
        Me.MetroLabel4.Text = "Tipo de Pago"
        '
        'Form1
        '
        Me.AcceptButton = Me.btncomprobar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnssalir
        Me.ClientSize = New System.Drawing.Size(868, 803)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txttotalpagar)
        Me.Controls.Add(Me.MetroLabel17)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.ee)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btncomprobar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.MetroDateTime2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnssalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprenda)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtservicio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.eeee)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"

        Me.Text = "Nueva Venta"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcedula As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtnombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtapellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btncomprobar As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents txttotalpagar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtiva As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btninsertar As MetroFramework.Controls.MetroLink
    Friend WithEvents txtcantidad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtprecioservicio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtsubtotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Servicio As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents prenda As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtprenda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtservicio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnssalir As MetroFramework.Controls.MetroLink
    Friend WithEvents ee As MetroFramework.Controls.MetroLink
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents eeee As TextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtdevolucion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnelimnar As MetroFramework.Controls.MetroLink
    Friend WithEvents btncancelar As MetroFramework.Controls.MetroLink
    Friend WithEvents btncal As MetroFramework.Controls.MetroLink
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents comnu1 As DataGridViewTextBoxColumn
    Friend WithEvents MetroDateTime2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txttipo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pag1 As MetroFramework.Controls.MetroLink
    Friend WithEvents pag2 As MetroFramework.Controls.MetroLink
    Friend WithEvents pag3 As MetroFramework.Controls.MetroLink
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
End Class
