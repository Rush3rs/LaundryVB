Imports System.Data.OleDb
Imports MetroFramework
Public Class newprenda
    Dim con As Double
    Dim Conexion As New OleDbConnection ' para la conexión
    Dim Comando As New OleDbCommand ' para el comando
    Dim Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Dim Lector As OleDbDataReader ' para realizar la lectura.
    Dim Consulta As String ' para realizar la consulta en la BD
    Dim toolTip1 As New ToolTip()
    Dim objEsp As New i
    Private Sub llena()
        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False" 'Le decimos donde está la base de datos.
            Conexion.Open() ' La abrimos...

        Catch ex As Exception
            MsgBox("Error contacte al administrador (LYONS SOFTWARE//04163263438)", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") 'Si no se puede advertimos al usuario.
        End Try


    End Sub
    Private Sub newprenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llena()
    End Sub
    Private Sub ayuda()

        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 10
        toolTip1.ReshowDelay = 100
        'Forzar el texto de información sobre herramientas que se mostrará si el formulario está activo. 
        toolTip1.ShowAlways = True

        'Establecer el texto de información sobre herramientas para el botón y la casilla de verificación. 
        toolTip1.SetToolTip(Me.Guardar, "Ejecuta la acción de guardar la información escrita en la Base de datos")
        toolTip1.SetToolTip(Me.btncerrar, "Ejecuta la acción de cerrar la ventana Nuevas Prendas")
        ' tooltip1.SetToolTip(Me.btnfacturacion, "Ventana de para ver facturas y editarlas(Antes de imprimir)")
        ' toolTip1.SetToolTip(Me.btncliente, "Ventana de Clientes Registrados")
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim fecha As String
        fecha = Date.Now().ToShortDateString
        If (txtcod.Text.Trim = "" Or txtprenda.Text.Trim = "") Then
            MetroMessageBox.Show(Me, "Escriba el Nombre del Servicio  - Lavanderia Predilecta?", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                If (Guardar.Text = "Guardar") Then
                    objEsp.innint(txtcod.Text.Trim(), txtprenda.Text.Trim(), fecha.Trim())

                Else
                    'objEsp.modificar( Servicte.Text.Trim(), Precio.Text.Trim(), Prenda.Text.Trim)
                    Guardar.Text = "Guardar"

                    'btnEliminar.Text = "Eliminar"
                End If

                txtcod.Clear()
                txtprenda.Clear()
                txtcod.Focus()

            Catch ex As Exception
                MetroMessageBox.Show(Me, "Verifique el nombre   - Lavanderia Predilecta", "Atención - Lavanderia Predilecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub metro_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs)


    End Sub

    Private Sub metro_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub metro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class