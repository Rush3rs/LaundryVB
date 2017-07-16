Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Imports MetroFramework
Public Class kardex
    Dim con As Double
    Dim tooltip1 As New ToolTip
    Dim A_precio As Long
    Dim iva, suma, r, pp As Long
    Dim Conexion As New OleDbConnection ' para la conexión
    Dim Comando As New OleDbCommand ' para el comando
    Dim Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Dim Lector As OleDbDataReader ' para realizar la lectura.
    Dim Consulta As String ' para realizar la consulta en la BD
    Dim sumar As Integer
    Dim cnx As New conexionBD
    Dim objEsp As New i
    Private Sub cargaservi()
        Dim MyCommand As OleDb.OleDbCommand
        Dim MyAdapter As New OleDb.OleDbDataAdapter
        Dim MyConexion As New OleDb.OleDbConnection
        MyConexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=Lavanderia.accdb;Persist Security Info=fALSE"
        MyCommand = MyConexion.CreateCommand
        MyCommand.CommandText = "SELECT * FROM Servicios"
        MyAdapter.SelectCommand = MyCommand
        Dim Dt_Cliente As New DataTable
        MyAdapter.Fill(Dt_Cliente)
        Servicio.DataSource = Dt_Cliente
        Servicio.DisplayMember = "Servicios"
        Servicio.ValueMember = "Servicio"
        Servicio.Text = "Seleccione un Nombre..."
    End Sub
    Private Sub kardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False" 'Le decimos donde está la base de datos.
            Conexion.Open() '  
            cargaservi()
            ivas()
            MetroGrid1.ReadOnly = True
            txtcantidad.MaxLength = 5
            okkk()
        Catch ex As Exception
            MsgBox("Error critico contacte al administrador (//04163263438)", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") 'Si no se puede advertimos al usuario.
        End Try
    End Sub
    Private Sub okkk()
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 10
        toolTip1.ReshowDelay = 100
        'Forzar el texto de información sobre herramientas que se mostrará si el formulario está activo. 
        toolTip1.ShowAlways = True

        'Establecer el texto de información sobre herramientas para el botón y la casilla de verificación. 
        tooltip1.SetToolTip(Me.btnelimnar, "Botón que sirve para eliminar Filas en la factura a generar. Su tecla Atajo es: (Botón SUPR o DEL)")
        tooltip1.SetToolTip(Me.btncal, "Botón que sirve para abrir la calculadora de windows. Su tecla Atajo es: (F1)")
        tooltip1.SetToolTip(Me.btncancelar, "Botón que sirve para Cancelar un pedido completo. Su tecla Atajo es: (F2)")
        tooltip1.SetToolTip(Me.btninsertar, "Botón que sirve para insertar un pedido. Su tecla Atajo es: (Tecla ENTER o INTRO)")
        tooltip1.SetToolTip(Me.MetroGrid1, "Este es el metrogriv, la forma en la que se puede apreciar lo que contiene tu factura")
        tooltip1.SetToolTip(Me.ee, "Información de Facilidad")
        tooltip1.SetToolTip(Me.eeee, "Información de Facilidad")
    End Sub
    Private Sub ivas()
        Dim da As New OleDb.OleDbDataAdapter("SELECT impuestos FROM impuesto", Conexion)
        Dim dt As New DataTable
        da.Fill(dt)
        txtiva.Text = dt.Rows(0)("impuestos").ToString()
    End Sub
    Private Sub txtcantidad_Click(sender As Object, e As EventArgs) Handles txtcantidad.Click

        txtcantidad.BackColor = Color.White
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub Servicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Servicio.SelectedIndexChanged
        If Not TypeOf Servicio.SelectedValue Is DataRowView Then
            ' Referenciando el objeto DataRowView correspondiente
            ' al elemento seleccionado en el control ComboBox.
            Dim row As DataRowView = DirectCast(Servicio.SelectedItem, DataRowView)
            txtprecioservicio.Text = row.Item("Precio").ToString


        End If
        '   copia.Text = txtprecioservicio.Text
        txtservicio.Text = Servicio.Text
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        Dim sumar As Long
        sumar = Val(txtprecioservicio.Text) * Val(txtcantidad.Text)

        txtsubtotal.Text = sumar
    End Sub

    Private Sub txtsubtotal_Click(sender As Object, e As EventArgs) Handles txtsubtotal.Click

    End Sub

    Private Sub txtcostototal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcostototal_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtiva_Click(sender As Object, e As EventArgs) Handles txtiva.Click

    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim Proceso As New Process()

        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()

    End Sub

    Private Sub btninsertar_Click(sender As Object, e As EventArgs) Handles btninsertar.Click

        If txtcantidad.Text = "" Or txtcantidad.Text = "0" Or txtprenda.Text = "" Or txtservicio.Text = "" Or txtsubtotal.Text = "0" Then
            MessageBox.Show(Me, "Rellene todos los Campos", "Atencion - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcantidad.BackColor = Color.Red
        Else
            Dim values() As Object = {txtprenda.Text, txtcantidad.Text, txtservicio.Text, txtprecioservicio.Text, txtsubtotal.Text}

            ' Añadimos una nueva fila al control DataGridView
            '
            Dim index As Integer = MetroGrid1.Rows.Add()

            ' Referenciamos la nueva fila
            '
            Dim currentRow As DataGridViewRow = MetroGrid1.Rows(index)

            ' Añadimos los valores a las celdas de la fila
            '
            currentRow.SetValues(values)


            Dim iva, suma, r, pp As Long



            '12 x Subtotal / 100
            pp = txtsubtotal.Text
            iva = txtiva.Text

            r = (iva * pp) / 100

            suma = r + pp

            A_precio = suma + A_precio
            txttotalpagar.Text = A_precio.ToString

            limp()
        End If

    End Sub
    Private Sub limp()
        txtprecioservicio.Clear()
        txtcantidad.Clear()
        txtsubtotal.Clear()
        txtservicio.Clear()
        txtprenda.Clear()

        txtprecioservicio.Enabled = False
        txtsubtotal.Enabled = False
        btninsertar.Enabled = False
    End Sub
    Private Sub Servicio_TextUpdate(sender As Object, e As EventArgs) Handles Servicio.TextUpdate
    End Sub
    Private Sub prenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prenda.SelectedIndexChanged
        txtprenda.Text = prenda.Text
    End Sub
    Private Sub MetroLink3_Click(sender As Object, e As EventArgs) Handles btnelimnar.Click
        Try
            If txtdevolucion.Text = "" Then
                MessageBox.Show(Me, "Seleccione el precio del articulo a eliminar o el DataGriv esta Vacío", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Dim value As DataGridViewSelectedRowCollection
                value = MetroGrid1.SelectedRows
                For Each vfila As DataGridViewRow In value
                    Dim ñelda, oto, oka As Long
                    ñelda = txtdevolucion.Text
                    iva = txtiva.Text
                    oto = (iva * ñelda) / 100
                    oka = oto + ñelda

                    A_precio = txttotalpagar.Text - oka

                    MetroGrid1.Rows.Remove(vfila)
                    txttotalpagar.Text = A_precio.ToString
                    txtdevolucion.Clear()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "Seleccione el precio del articulo a eliminar o el DataGriv esta Vacío", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs)
        MetroGrid1.ReadOnly = False
    End Sub

    Private Sub edit_DoubleClick(sender As Object, e As EventArgs)
        MetroGrid1.ReadOnly = True
    End Sub

    Private Sub txtprecioservicio_Click(sender As Object, e As EventArgs) Handles txtprecioservicio.Click

    End Sub
    Public Sub nariz(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txttotalpagar_Click(sender As Object, e As EventArgs) Handles txttotalpagar.Click

    End Sub

    Private Sub txttotalpagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotalpagar.KeyPress, txtsubtotal.KeyPress, txtprecioservicio.KeyPress, txtiva.KeyPress, txtcantidad.KeyPress

        nariz(e)
    End Sub

    Private Sub txtsubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal.TextChanged
        btninsertar.Enabled = True
    End Sub

    Private Sub txtprecioservicio_DoubleClick(sender As Object, e As EventArgs) Handles txtprecioservicio.DoubleClick
        txtprecioservicio.Enabled = True
    End Sub

    Private Sub btnelimnar_KeyDown(sender As Object, e As KeyEventArgs) Handles btnelimnar.KeyDown

    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles btncancelar.Click

    End Sub

    Private Sub MetroLink2_KeyDown(sender As Object, e As KeyEventArgs) Handles btncancelar.KeyDown

    End Sub

    Private Sub btncal_KeyDown(sender As Object, e As KeyEventArgs) Handles btncal.KeyDown




    End Sub

    Private Sub txtcantidad_ForeColorChanged(sender As Object, e As EventArgs) Handles txtcantidad.ForeColorChanged

    End Sub

    Private Sub cant_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        Dim row As DataGridViewRow = MetroGrid1.CurrentRow

        txtdevolucion.Text = CStr(row.Cells("Column5").Value)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles eeee.TextChanged


    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub MetroGrid1_Click(sender As Object, e As EventArgs) Handles MetroGrid1.Click

    End Sub

    Private Sub btnssalir_Click(sender As Object, e As EventArgs) Handles btnssalir.Click
        Me.hide
    End Sub

    Private Sub txtdevolucion_Click(sender As Object, e As EventArgs) Handles txtdevolucion.Click

    End Sub

    Private Sub txtservicio_Click(sender As Object, e As EventArgs) Handles txtservicio.Click

    End Sub

    Private Sub kardex_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case (e.KeyCode)
            Case Keys.F2

            Case Keys.F1
                Dim Proceso As New Process()
                Proceso.StartInfo.FileName = "calc.exe"
                Proceso.StartInfo.Arguments = ""
                Proceso.Start()
            Case Keys.Delete
                Try
                    If txtdevolucion.Text = "" Then
                        MessageBox.Show(Me, "Seleccione el precio del articulo a eliminar o el DataGriv esta Vacío", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim value As DataGridViewSelectedRowCollection
                        value = MetroGrid1.SelectedRows
                        For Each vfila As DataGridViewRow In value
                            MetroGrid1.Rows.Remove(vfila)
                            txtdevolucion.Clear()
                        Next
                    End If
                Catch ex As Exception
                    MessageBox.Show(Me, "Seleccione el precio del articulo a eliminar o el DataGriv esta Vacío", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End Try
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MetroLink1_Click_1(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Form1.Show()
        Me.Hide()

        Form1.Servicio = Me.Servicio.SelectedValue

    End Sub

    Private Sub eeee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles eeee.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtservicio_TextChanged(sender As Object, e As EventArgs) Handles txtservicio.TextChanged

    End Sub

    Private Sub txtprecioservicio_TextChanged(sender As Object, e As EventArgs) Handles txtprecioservicio.TextChanged

    End Sub
End Class