<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class impuestoed
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtiva = New MetroFramework.Controls.MetroTextBox()
        Me.Guardar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.txtfecha = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(51, 89)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(101, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Impuesto %"
        '
        'txtiva
        '
        '
        '
        '
        Me.txtiva.CustomButton.Image = Nothing
        Me.txtiva.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtiva.CustomButton.Name = ""
        Me.txtiva.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtiva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtiva.CustomButton.TabIndex = 1
        Me.txtiva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtiva.CustomButton.UseSelectable = True
        Me.txtiva.CustomButton.Visible = False
        Me.txtiva.Lines = New String(-1) {}
        Me.txtiva.Location = New System.Drawing.Point(158, 89)
        Me.txtiva.MaxLength = 32767
        Me.txtiva.Name = "txtiva"
        Me.txtiva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtiva.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtiva.SelectedText = ""
        Me.txtiva.SelectionLength = 0
        Me.txtiva.SelectionStart = 0
        Me.txtiva.ShortcutsEnabled = True
        Me.txtiva.Size = New System.Drawing.Size(118, 23)
        Me.txtiva.TabIndex = 1
        Me.txtiva.UseSelectable = True
        Me.txtiva.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtiva.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(84, 206)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(171, 36)
        Me.Guardar.TabIndex = 2
        Me.Guardar.Text = "Actualizar"
        Me.Guardar.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(109, 144)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Fecha"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Enabled = False
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(234, 22)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(97, 29)
        Me.MetroDateTime1.TabIndex = 4
        '
        'txtfecha
        '
        '
        '
        '
        Me.txtfecha.CustomButton.Image = Nothing
        Me.txtfecha.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtfecha.CustomButton.Name = ""
        Me.txtfecha.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtfecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfecha.CustomButton.TabIndex = 1
        Me.txtfecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfecha.CustomButton.UseSelectable = True
        Me.txtfecha.CustomButton.Visible = False
        Me.txtfecha.Lines = New String(-1) {}
        Me.txtfecha.Location = New System.Drawing.Point(158, 140)
        Me.txtfecha.MaxLength = 32767
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfecha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfecha.SelectedText = ""
        Me.txtfecha.SelectionLength = 0
        Me.txtfecha.SelectionStart = 0
        Me.txtfecha.ShortcutsEnabled = True
        Me.txtfecha.Size = New System.Drawing.Size(118, 23)
        Me.txtfecha.TabIndex = 5
        Me.txtfecha.UseSelectable = True
        Me.txtfecha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfecha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'impuestoed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(338, 296)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "impuestoed"
        Me.Style = MetroFramework.MetroColorStyle.Lime
        Me.Text = "Editor del Impuesto "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtiva As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Guardar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtfecha As MetroFramework.Controls.MetroTextBox
End Class
