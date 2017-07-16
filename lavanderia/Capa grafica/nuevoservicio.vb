Imports System.Data.OleDb
Imports MetroFramework
Public Class newservi
    Dim objEsp As New i
    Dim idEspecialidad As String
    Dim toolTip1 As New ToolTip()
    Dim con As Double
    Dim Conexion As New OleDbConnection ' para la conexión
    Dim Comando As New OleDbCommand ' para el comando
    Dim Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Dim Lector As OleDbDataReader ' para realizar la lectura.
    Dim Consulta As String ' para realizar la consulta en la BD
    Private Sub MetroUserControl1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles txtservi.Click

    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim fecha As String
        fecha = Date.Now().ToShortDateString
        If (txtcod.Text.Trim = "" Or txtservi.Text.Trim = "" Or txtprecio.Text.Trim = "") Then
            MetroMessageBox.Show(Me, "Escriba el Nombre del Servicio  - Lavanderia Predilecta?", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                If (Guardar.Text = "Guardar") Then
                    objEsp.insertar(txtcod.Text.Trim(), txtservi.Text.Trim(), txtprecio.Text.Trim, fecha.Trim)
                Else
                    'objEsp.modificar( Servicte.Text.Trim(), Precio.Text.Trim(), Prenda.Text.Trim)
                    Guardar.Text = "Guardar"
                    'btnEliminar.Text = "Eliminar"
                End If

                txtservi.Clear()
                txtprecio.Clear()
                txtcod.Clear()
                txtservi.Focus()

            Catch ex As Exception
                MetroMessageBox.Show(Me, "Verifique el nombre   - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
    Private Sub ayuda()

        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 10
        toolTip1.ReshowDelay = 100
        'Forzar el texto de información sobre herramientas que se mostrará si el formulario está activo. 
        toolTip1.ShowAlways = True

        'Establecer el texto de información sobre herramientas para el botón y la casilla de verificación. 
        '  toolTip1.SetToolTip(Me.btnadd, "Abre una nueva ventana para agregar nuevos tipos de prendas")
        toolTip1.SetToolTip(Me.Guardar, "Ejecuta la acción de guardar la información escrita en la Base de datos")
        toolTip1.SetToolTip(Me.Cerrar, "Ejecuta la acción de cerrar la ventana Nuevo Servicios")
        ' tooltip1.SetToolTip(Me.btnfacturacion, "Ventana de para ver facturas y editarlas(Antes de imprimir)")
        ' toolTip1.SetToolTip(Me.btncliente, "Ventana de Clientes Registrados")
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        newprenda.Show()
    End Sub

    Private Sub newservi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False" 'Le decimos donde está la base de datos.
            Conexion.Open() ' La abrimos...
            ayuda()
            cbo()

        Catch ex As Exception
            MsgBox("Error contacte al administrador (LYONS SOFTWARE//04163263438)", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") 'Si no se puede advertimos al usuario.
        End Try


    End Sub
    Private Sub cbo()
        '      Using Lector
        'Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=LavanderiaNarizlan.accdb;Persist Security Info=fALSE" 'Le decimos donde está la base de datos.
        'Conexion.Open()
        '     Me.Prenda.Items.Clear()
        '      Consulta = "SELECT prendas FROM Prenda "
        '      Comando.CommandType = CommandType.Text
        '      Comando.Connection = Conexion
        '     Comando.CommandText = Consulta

        '     Lector = Comando.ExecuteReader
        ' 
        '     If Lector.HasRows = True Then
        '     While Lector.Read()
        '    Me.Prenda.Items.Add(Lector.GetValue(0))
        '    End While
        '     End If
        '   End Using
    End Sub

    Private Sub txtprecio_Click(sender As Object, e As EventArgs) Handles txtprecio.Click

    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        nariz(e)
    End Sub
End Class