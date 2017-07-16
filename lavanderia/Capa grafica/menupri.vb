Imports MetroFramework

Public Class menuprin
    Dim toolTip1 As New ToolTip()
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        ayuda()
    End Sub
    Private Sub ayuda()

        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 10
        toolTip1.ReshowDelay = 100
        'Forzar el texto de información sobre herramientas que se mostrará si el formulario está activo. 
        toolTip1.ShowAlways = True

        'Establecer el texto de información sobre herramientas para el botón y la casilla de verificación. 
        toolTip1.SetToolTip(Me.btncliente, "Ventana de Clientes Registrados")
        toolTip1.SetToolTip(Me.btninventario, "Ventana de Inventario Registrado")
        toolTip1.SetToolTip(Me.btnkardex, "Ventana de servicio de consulta de precios(CARDEX)")
        toolTip1.SetToolTip(Me.btnverfacturacion, "Ventana para editar facturas(Antes de imprimir)")
        toolTip1.SetToolTip(Me.btnfactura, "Ventana de facturación")
        toolTip1.SetToolTip(Me.btnadorno, "Ventana a la espera de función")
        toolTip1.SetToolTip(Me.btnreport, "Ventana para ver reportes de los diferentes modulos")
        ' toolTip1.SetToolTip(Me.btncliente, "Ventana de Clientes Registrados")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        inventario.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        kardex.Show()
    End Sub

    Private Sub cbox_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub btncliente_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnfacturacion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub clickprop_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) 

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub btnfactura_Click(sender As Object, e As EventArgs) Handles btnfactura.Click
        Form1.Show()
    End Sub

    Private Sub btncliente_Click(sender As Object, e As EventArgs) Handles btncliente.Click
        cliente.Show()
    End Sub

    Private Sub btninventario_Click(sender As Object, e As EventArgs) Handles btninventario.Click
        inventario.Show()
    End Sub

    Private Sub btnkardex_Click(sender As Object, e As EventArgs) Handles btnkardex.Click
        kardex.Show()
    End Sub

    Private Sub btnverfacturacion_Click(sender As Object, e As EventArgs) Handles btnverfacturacion.Click
        Form2.Show()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click

    End Sub

    Private Sub btnadorno_Click(sender As Object, e As EventArgs) Handles btnadorno.Click

    End Sub

    Private Sub ReporteDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        reportclien.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) 
        ReportInventario.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' If cbox.Text = "Cerrar Sesion" Then
        ' 
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        cliente.ShowDialog()
    End Sub

    Private Sub FacturasRealizadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasRealizadasToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub menuprin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        If MessageBox.Show(Me, "Se le redirecionara al menu de inicio de sesion - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class