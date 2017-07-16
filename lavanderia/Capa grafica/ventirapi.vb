Imports System.Data.OleDb

Public Class ventirapi
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
    Public Sub nariz(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
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
    Private Sub ventirapi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False" 'Le decimos donde está la base de datos.
            Conexion.Open() ' La abrimos...

        Catch ex As Exception
            MsgBox("Error contacte al administrador (LYONS SOFTWARE//04163263438)", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") 'Si no se puede advertimos al usuario.
        End Try
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
                    txtfecha.Visible = True
                    MetroDateTime1.Visible = False
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
                        txtfecha.Visible = False
                        MetroDateTime1.Visible = True
                    End If

                    Lector.Close()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtcedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress, txtcedula.KeyPress
        nariz(e)
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If txtcedula.Text = "" Or txtnombre.Text = "" Or txtapellido.Text = "" Then
            MessageBox.Show(Me, "¡Campo Cedula, Nombre y Apellido no pueden estar Vacío! ", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txttelefono.Text = "" And txtdireccion.Text = "" Then
            txtdireccion.Text = "Sin descripción"
            txttelefono.Text = "Sin descripción"
            Int()
            limpio()
        ElseIf txtdireccion.Text = "" Then
            txtdireccion.Text = "Sin descripción"
            Int()
            limpio()
        Else
            If txttelefono.Text = "" Then
                txttelefono.Text = "Sin descripción"
                Int()
                limpio()
            Else

                Int()
                limpio()
            End If
        End If
    End Sub
End Class