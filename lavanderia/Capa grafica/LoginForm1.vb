Imports System.Data.OleDb
Imports MetroFramework

Public Class Login
    Dim con As Double
    Dim Conexion As New OleDbConnection ' para la conexión
    Dim Comando As New OleDbCommand ' para el comando
    Dim Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Dim Lector As OleDbDataReader ' para realizar la lectura.
    Dim Consulta As String ' para realizar la consulta en la BD
    Public Sub nariz(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            lab2.Text = "Solo se permiten NÚMEROS"
        End If

    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub limpiar()
        txtpass.Clear()
        txtpass.Focus()


    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub user_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False" 'Le decimos donde está la base de datos.
            Conexion.Open() ' La abrimos...
        Catch ex As Exception
            MsgBox("Error contacte al administrador (LYONS SOFTWARE//04163263438)", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") 'Si no se puede advertimos al usuario.
        End Try
    End Sub

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        nariz(e)

    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub btnacep_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncalcel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Consulta = "SELECT usuario, clave FROM loginn WHERE usuario='" & txtuser.Text & "'AND clave= '" & txtpass.Text & "'" 'Condición para buscar los usuarios que se han puesto en txtuser, txtpass en la BD
        Comando = New OleDbCommand(Consulta, Conexion) ' Hacemos consulta en la variable conexión.
        Adapter.SelectCommand = Comando ' Al adaptador le asignamos un comando, nuestra variable.
        Lector = Comando.ExecuteReader ' El lector ejecuta una lectura en las columnas.
        If Lector.HasRows = True Then ' Condición de si existen o no esos datos en la BD.
            MessageBox.Show(Me, "Bienvenido a Lavanderia Predilecta", "Acceso permitido - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar() ' Focaliza el guión en txtuser.

            menuprin.Show()
            Me.Hide()
        Else
            MsgBox("Usuario i/o contraseña incorrectos", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") ' Si falla nos advierte que no son correctos.
            limpiar() ' Vacia y Focaliza.
            con = con + 1
            If con = 3 Then
                MessageBox.Show(Me, "Superaste el numero de intentos, se cerrara la aplicacion", "Advertencia - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show(Me, "¿Estas seguro de salir - Lavanderia Predilecta?", "Atención - Lavanderia Predilecta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        Else
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End


    End Sub
End Class
