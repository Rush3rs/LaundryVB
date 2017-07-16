Imports System.Data.OleDb
Imports MetroFramework
Public Class impuestoed
    Dim Conexion As New OleDbConnection ' para la conexión
    Dim Comando As New OleDbCommand ' para el comando
    Dim Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Dim Lector As OleDbDataReader ' para realizar la lectura.
    Dim Consulta As String ' para realizar la consulta en la BD

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        act()
        ok()

    End Sub
    Private Sub act()
        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=Lavanderia.accdb;Persist Security Info=fALSE" 'Le decimos donde está la base de datos.
            Conexion.Open() ' La abrimos...
            ok()
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error en la base de datos ""Contacte a su administrador 04163263438"" - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles Guardar.Click



        Dim actualizar As String
        Dim fecha As String
        fecha = Date.Now.ToShortDateString
        If txtiva.Text = "" Then
            MetroMessageBox.Show(Me, "Rellene el campo impuesto - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                actualizar = "UPDATE Impuesto SET Impuestos='" & txtiva.Text & "',fecha='" & fecha & "'"
                Comando = New OleDb.OleDbCommand(actualizar, Conexion)
                Comando.ExecuteNonQuery()
                MetroMessageBox.Show(Me, "El registro se ha actualizado Correctamente - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtiva.Clear()

            Catch ex As Exception
                MetroMessageBox.Show(Me, "Error en la base de datos ""Contacte a su administrador 04163263438"" - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

        End If

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
    Private Sub ok()
        Try
            Consulta = "SELECT Impuestos,Fecha FROM Impuesto WHERE Impuestos='" & txtiva.Text & "'" 'Condición para buscar los usuarios que se han puesto en txtuser, txtpass en la BD
            Comando = New OleDbCommand(Consulta, Conexion) ' Hacemos consulta en la variable conexión.
            Adapter.SelectCommand = Comando ' Al adaptador le asignamos un comando, nuestra variable.
            Lector = Comando.ExecuteReader ' El lector ejecuta una lectura en las columnas.
            If Lector.Read Then ' Condición de si existen o no esos datos en la BD.
                MessageBox.Show(Me, "Cliente Registrado", "Atención . Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtiva.Text = Lector(1).ToString
                txtfecha.Text = Lector(2).ToString
                Lector.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtiva_Click(sender As Object, e As EventArgs) Handles txtiva.Click

    End Sub

    Private Sub txtiva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtiva.KeyPress
        nariz(e)
    End Sub
End Class