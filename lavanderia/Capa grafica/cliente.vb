Imports System.Data.OleDb

Public Class cliente
    Dim con As Double
    Dim Conexion As New OleDbConnection ' para la conexión
    Dim Comando As New OleDbCommand ' para el comando
    Dim Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Dim Lector As OleDbDataReader ' para realizar la lectura.
    Dim objEsp As New i
    Dim Consulta As String ' para realizar la consulta en la BD
    Dim idIE As String
    Dim hola As String
    Dim proceso As String
    Private Sub CargarInfo()
        Dim dset As New DataSet
        Dim dtabla As New DataTable
        Dim ver As String = "SELECT Cedula, Nombre, Apellido, Telefono, Direccion, Fecha FROM Cliente "
        Dim adp As New OleDbDataAdapter(ver, Conexion)
        dset.Tables.Add("coño")
        adp.Fill(dset.Tables("coño"))
        datagrib1.DataSource = dset.Tables("coño")
        datagrib1.Columns(0).HeaderText = "Cedula"
        datagrib1.Columns(1).HeaderText = "Nombre"
        datagrib1.Columns(2).HeaderText = "Apellido"
        datagrib1.Columns(3).HeaderText = "Telefono"
        datagrib1.Columns(4).HeaderText = "Dirección"
        datagrib1.Columns(5).HeaderText = "Fecha de Registro"

    End Sub
    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False" 'Le decimos donde está la base de datos.
            Conexion.Open() ' La abrimos...
        Catch ex As Exception
            MsgBox("Error contacte al administrador (LYONS SOFTWARE//04163263438)", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") 'Si no se puede advertimos al usuario.
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If txtcedula.Text = "" Or txtnombre.Text = "" Or txtapellido.Text = "" Then
            MessageBox.Show(Me, "¡Campo Cedula, Nombre y Apellido no pueden estar Vacío! ", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txttelefono.Text = "" And txtdireccion.Text = "" Then
            txtdireccion.Text = "Sin descripción"
            txttelefono.Text = "Sin descripción"
            int()
            limpio()
        ElseIf txtdireccion.Text = "" Then
            txtdireccion.Text = "Sin descripción"
            int()
            limpio()
        Else
            If txttelefono.Text = "" Then
                txttelefono.Text = "Sin descripción"
                int()
                limpio()
            Else
                CargarInfo()
                int()
                limpio()
            End If
        End If
    End Sub
    Private Sub int()
        Dim Fecha As String
        Fecha = Date.Now().ToShortDateString
        Try
            If (Agregar.Text = "Agregar") Then
                objEsp.clin(txtcedula.Text.Trim(), txtnombre.Text.Trim(), txtapellido.Text.Trim, txttelefono.Text.Trim, txtdireccion.Text.Trim, Fecha.Trim)

                MessageBox.Show(Me, "Nuevo Cliente Registrado", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(Me, "Error al Agregar Cliente - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub
    Private Sub limpio()
        txtnombre.Clear()
        txtapellido.Clear()
        txttelefono.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs)
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
    Private Sub txtcedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcedula.KeyPress
        nariz(e)
    End Sub

    Private Sub txtcedula_TextChanged(sender As Object, e As EventArgs) Handles txtcedula.TextChanged

    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrib1.CellContentClick
        txtcedula.Text = datagrib1.CurrentRow.Cells(0).Value.ToString()

        'Al pulsar clic sobre una fila, el registro aparece en las cajas de texto
        txtnombre.Text = datagrib1.CurrentRow.Cells(1).Value.ToString()
        txtapellido.Text = datagrib1.CurrentRow.Cells(2).Value.ToString()
        txttelefono.Text = datagrib1.CurrentRow.Cells(3).Value.ToString()
        txtdireccion.Text = datagrib1.CurrentRow.Cells(4).Value.ToString()
        txtfecha.Text = datagrib1.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub MetroLink3_Click(sender As Object, e As EventArgs) Handles MetroLink3.Click
        CargarInfo()
    End Sub

    Private Sub pag1_Click(sender As Object, e As EventArgs) Handles pag1.Click
        Dim cnd As New OleDbCommand
        cnd.Connection = Conexion
        cnd.CommandText = "UPDATE Cliente SET Cedula = '" & txtcedula.Text & "'," _
                & "Nombre ='" & txtnombre.Text & "'," _
                & "Apellido ='" & txtapellido.Text & "'," _
                & "Telefono ='" & txttelefono.Text & "'," _
                & "Direccion ='" & txtdireccion.Text & "'," _
                & "Fecha ='" & txtfecha.Text & "'," _
                & "WHERE cedula = " & txtcedula.Text & ""

        cnd.ExecuteNonQuery()

    End Sub

    Private Sub pag2_Click(sender As Object, e As EventArgs) Handles pag2.Click

        If txtcedula.Text = "" Or txtnombre.Text = "" Or txtapellido.Text = "" Then
            MessageBox.Show(Me, "Campo Cedula, Nombre, Apellido no puede estar Vacío", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try

                If MessageBox.Show("¿Estas seguro de eliminar el registro seleccionado?", "Atención - Lavanderia Predilecta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim eliminar As String = "DELETE FROM Cliente WHERE Cedula='" & txtcedula.Text & "'"
                    Comando = New OleDbCommand(eliminar, Conexion)
                    Comando.ExecuteNonQuery()
                    Conexion.Close()
                    MsgBox("El registro se ha eliminado", vbInformation, "Actualizado")
                    limpio()
                    txtcedula.Clear()
                    CargarInfo()
                Else

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If txtcedula.Text = "" Or txtnombre.Text = "" Or txtapellido.Text = "" Then
            MessageBox.Show(Me, "¡Campo Cedula, Nombre y Apellido no pueden estar Vacío! ", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txttelefono.Text = "" And txtdireccion.Text = "" Then
            txtdireccion.Text = "Sin descripción"
            txttelefono.Text = "Sin descripción"
            int()
            limpio()
        ElseIf txtdireccion.Text = "" Then
            txtdireccion.Text = "Sin descripción"
            int()
            limpio()
        Else
            If txttelefono.Text = "" Then
                txttelefono.Text = "Sin descripción"
                int()
                limpio()
            Else
                CargarInfo()
                int()
                limpio()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Hide()
    End Sub

    Private Sub btncomprobar_Click(sender As Object, e As EventArgs) Handles btncomprobar.Click

        If txtcedula.Text = "" Then
            MessageBox.Show(Me, "¡Campo Cedula no puede estar Vacío! ", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim Fecha As String
            Fecha = Date.Now().ToShortDateString
        Else
            Try
                Consulta = "SELECT Cedula,Nombre, Apellido, Telefono, Direccion,Fecha FROM Cliente WHERE Cedula='" & txtcedula.Text & "'" 'Condición para buscar los usuarios que se han puesto en txtuser, txtpass en la BD
                Comando = New OleDbCommand(Consulta, Conexion) ' Hacemos consulta en la variable conexión.
                Adapter.SelectCommand = Comando ' Al adaptador le asignamos un comando, nuestra variable.
                Lector = Comando.ExecuteReader ' El lector ejecuta una lectura en las columnas.
                If Lector.Read Then ' Condición de si existen o no esos datos en la BD.
                    MessageBox.Show(Me, "Cliente Registrado", "Atención . Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtnombre.Text = Lector(1).ToString
                    txtapellido.Text = Lector(2).ToString
                    txttelefono.Text = Lector(3).ToString
                    txtdireccion.Text = Lector(4).ToString
                    txtfecha.Text = Lector(5).ToString

                Else
                    If MessageBox.Show(Me, "El Cliente No Registrado, ¿Deseas Registrarlo?", "Atención . Lavanderia Predilecta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        txtnombre.Enabled = True
                        txtapellido.Enabled = True
                        txttelefono.Enabled = True
                        txtdireccion.Enabled = True
                        txtnombre.Focus()
                        Agregar.Enabled = True
                    End If

                    Lector.Close()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub pag3_Click(sender As Object, e As EventArgs) Handles pag3.Click
        Dim dset As New DataSet
        Dim dtabla As New DataTable
        Dim ver As String = "SELECT Cedula, Nombre, Apellido, Telefono, Direccion, Fecha FROM Cliente "
        Dim adp As New OleDbDataAdapter(ver, Conexion)
        dset.Tables.Add("coño")
        adp.Fill(dset.Tables("coño"))
        datagrib1.DataSource = dset.Tables("coño")
        datagrib1.Columns(0).HeaderText = "Cedula"
        datagrib1.Columns(1).HeaderText = "Nombre"
        datagrib1.Columns(2).HeaderText = "Apellido"
        datagrib1.Columns(3).HeaderText = "Telefono"
        datagrib1.Columns(4).HeaderText = "Dirección"
        datagrib1.Columns(5).HeaderText = "Fecha de Registro"
    End Sub
End Class

