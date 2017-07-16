<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newservi
    Inherits MetroFramework.Forms.MetroForm


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
        Me.servicio = New MetroFramework.Controls.MetroLabel()
        Me.txtservi = New MetroFramework.Controls.MetroTextBox()
        Me.txtprecio = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Guardar = New MetroFramework.Controls.MetroButton()
        Me.txtcod = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Cerrar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.SuspendLayout()
        '
        'servicio
        '
        Me.servicio.AutoSize = True
        Me.servicio.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.servicio.Location = New System.Drawing.Point(34, 130)
        Me.servicio.Name = "servicio"
        Me.servicio.Size = New System.Drawing.Size(71, 25)
        Me.servicio.TabIndex = 0
        Me.servicio.Text = "Servicio"
        '
        'txtservi
        '
        '
        '
        '
        Me.txtservi.CustomButton.Image = Nothing
        Me.txtservi.CustomButton.Location = New System.Drawing.Point(193, 1)
        Me.txtservi.CustomButton.Name = ""
        Me.txtservi.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtservi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtservi.CustomButton.TabIndex = 1
        Me.txtservi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtservi.CustomButton.UseSelectable = True
        Me.txtservi.CustomButton.Visible = False
        Me.txtservi.Lines = New String(-1) {}
        Me.txtservi.Location = New System.Drawing.Point(34, 158)
        Me.txtservi.MaxLength = 32767
        Me.txtservi.Name = "txtservi"
        Me.txtservi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtservi.PromptText = "Ingrese Nuevo Servicio"
        Me.txtservi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtservi.SelectedText = ""
        Me.txtservi.SelectionLength = 0
        Me.txtservi.SelectionStart = 0
        Me.txtservi.ShortcutsEnabled = True
        Me.txtservi.Size = New System.Drawing.Size(215, 23)
        Me.txtservi.TabIndex = 1
        Me.txtservi.UseSelectable = True
        Me.txtservi.WaterMark = "Ingrese Nuevo Servicio"
        Me.txtservi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtservi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtprecio
        '
        '
        '
        '
        Me.txtprecio.CustomButton.Image = Nothing
        Me.txtprecio.CustomButton.Location = New System.Drawing.Point(193, 1)
        Me.txtprecio.CustomButton.Name = ""
        Me.txtprecio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtprecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtprecio.CustomButton.TabIndex = 1
        Me.txtprecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtprecio.CustomButton.UseSelectable = True
        Me.txtprecio.CustomButton.Visible = False
        Me.txtprecio.Lines = New String(-1) {}
        Me.txtprecio.Location = New System.Drawing.Point(34, 212)
        Me.txtprecio.MaxLength = 32767
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprecio.PromptText = "Ingrese Nuevo Precio sin puntos"
        Me.txtprecio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtprecio.SelectedText = ""
        Me.txtprecio.SelectionLength = 0
        Me.txtprecio.SelectionStart = 0
        Me.txtprecio.ShortcutsEnabled = True
        Me.txtprecio.Size = New System.Drawing.Size(215, 23)
        Me.txtprecio.TabIndex = 3
        Me.txtprecio.UseSelectable = True
        Me.txtprecio.WaterMark = "Ingrese Nuevo Precio sin puntos"
        Me.txtprecio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtprecio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(34, 184)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Precio"
        '
        'Guardar
        '
        Me.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar.Location = New System.Drawing.Point(23, 329)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(121, 34)
        Me.Guardar.TabIndex = 4
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseSelectable = True
        '
        'txtcod
        '
        '
        '
        '
        Me.txtcod.CustomButton.Image = Nothing
        Me.txtcod.CustomButton.Location = New System.Drawing.Point(193, 1)
        Me.txtcod.CustomButton.Name = ""
        Me.txtcod.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtcod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcod.CustomButton.TabIndex = 1
        Me.txtcod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcod.CustomButton.UseSelectable = True
        Me.txtcod.CustomButton.Visible = False
        Me.txtcod.Lines = New String(-1) {}
        Me.txtcod.Location = New System.Drawing.Point(34, 104)
        Me.txtcod.MaxLength = 32767
        Me.txtcod.Name = "txtcod"
        Me.txtcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcod.PromptText = "Código del Servicio"
        Me.txtcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcod.SelectedText = ""
        Me.txtcod.SelectionLength = 0
        Me.txtcod.SelectionStart = 0
        Me.txtcod.ShortcutsEnabled = True
        Me.txtcod.Size = New System.Drawing.Size(215, 23)
        Me.txtcod.TabIndex = 6
        Me.txtcod.UseSelectable = True
        Me.txtcod.WaterMark = "Código del Servicio"
        Me.txtcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(34, 76)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(131, 25)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Código Servicio"
        '
        'Cerrar
        '
        Me.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cerrar.Location = New System.Drawing.Point(161, 329)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(121, 34)
        Me.Cerrar.TabIndex = 5
        Me.Cerrar.Text = "Salir"
        Me.Cerrar.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(34, 238)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(146, 25)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Fecha de Registro"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(34, 266)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(110, 29)
        Me.MetroDateTime1.TabIndex = 10
        '
        'newservi
        '
        Me.AcceptButton = Me.Guardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cerrar
        Me.ClientSize = New System.Drawing.Size(294, 452)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtservi)
        Me.Controls.Add(Me.servicio)
        Me.MaximizeBox = False
        Me.Name = "newservi"
        Me.Resizable = False
        Me.Text = "Nuevo servicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents servicio As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Guardar As MetroFramework.Controls.MetroButton
    Public WithEvents txtservi As MetroFramework.Controls.MetroTextBox
    Public WithEvents txtprecio As MetroFramework.Controls.MetroTextBox
    Public WithEvents txtcod As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Cerrar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
End Class
