<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newprenda

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
        Me.Guardar = New MetroFramework.Controls.MetroButton()
        Me.txtcod = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtprenda = New MetroFramework.Controls.MetroTextBox()
        Me.servicio = New MetroFramework.Controls.MetroLabel()
        Me.btncerrar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.fecha = New MetroFramework.Controls.MetroDateTime()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(23, 281)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 31)
        Me.Guardar.TabIndex = 0
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
        Me.txtcod.Location = New System.Drawing.Point(36, 102)
        Me.txtcod.MaxLength = 32767
        Me.txtcod.Name = "txtcod"
        Me.txtcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcod.PromptText = "Código de la Prenda"
        Me.txtcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcod.SelectedText = ""
        Me.txtcod.SelectionLength = 0
        Me.txtcod.SelectionStart = 0
        Me.txtcod.ShortcutsEnabled = True
        Me.txtcod.Size = New System.Drawing.Size(215, 23)
        Me.txtcod.TabIndex = 12
        Me.txtcod.UseSelectable = True
        Me.txtcod.WaterMark = "Código de la Prenda"
        Me.txtcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(36, 74)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(126, 25)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Código Prenda"
        '
        'txtprenda
        '
        '
        '
        '
        Me.txtprenda.CustomButton.Image = Nothing
        Me.txtprenda.CustomButton.Location = New System.Drawing.Point(193, 1)
        Me.txtprenda.CustomButton.Name = ""
        Me.txtprenda.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtprenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtprenda.CustomButton.TabIndex = 1
        Me.txtprenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtprenda.CustomButton.UseSelectable = True
        Me.txtprenda.CustomButton.Visible = False
        Me.txtprenda.Lines = New String(-1) {}
        Me.txtprenda.Location = New System.Drawing.Point(36, 156)
        Me.txtprenda.MaxLength = 32767
        Me.txtprenda.Name = "txtprenda"
        Me.txtprenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprenda.PromptText = "Ingrese Nueva Prenda"
        Me.txtprenda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtprenda.SelectedText = ""
        Me.txtprenda.SelectionLength = 0
        Me.txtprenda.SelectionStart = 0
        Me.txtprenda.ShortcutsEnabled = True
        Me.txtprenda.Size = New System.Drawing.Size(215, 23)
        Me.txtprenda.TabIndex = 8
        Me.txtprenda.UseSelectable = True
        Me.txtprenda.WaterMark = "Ingrese Nueva Prenda"
        Me.txtprenda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtprenda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'servicio
        '
        Me.servicio.AutoSize = True
        Me.servicio.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.servicio.Location = New System.Drawing.Point(36, 128)
        Me.servicio.Name = "servicio"
        Me.servicio.Size = New System.Drawing.Size(66, 25)
        Me.servicio.TabIndex = 7
        Me.servicio.Text = "Prenda"
        '
        'btncerrar
        '
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(176, 281)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 31)
        Me.btncerrar.TabIndex = 14
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(36, 191)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(146, 25)
        Me.MetroLabel1.TabIndex = 15
        Me.MetroLabel1.Text = "Fecha de Registro"
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(48, 219)
        Me.fecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(95, 29)
        Me.fecha.TabIndex = 16
        '
        'newprenda
        '
        Me.AcceptButton = Me.Guardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncerrar
        Me.ClientSize = New System.Drawing.Size(275, 360)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtprenda)
        Me.Controls.Add(Me.servicio)
        Me.Controls.Add(Me.Guardar)
        Me.MaximizeBox = False
        Me.Name = "newprenda"
        Me.Resizable = False
        Me.Text = "Nuevas Prendas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guardar As MetroFramework.Controls.MetroButton
    Public WithEvents txtcod As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtprenda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents servicio As MetroFramework.Controls.MetroLabel
    Friend WithEvents btncerrar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents fecha As MetroFramework.Controls.MetroDateTime
End Class
