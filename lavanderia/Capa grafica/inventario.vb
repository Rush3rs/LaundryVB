Imports System.Data.OleDb
Imports MetroFramework

Public Class inventario
    Dim con As Double
    Dim Conexion As New OleDbConnection ' para la conexión
    Dim Comando As New OleDbCommand ' para el comando
    Dim Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Dim Lector As OleDbDataReader ' para realizar la lectura.
    Dim Consulta As String ' para realizar la consulta en la BD
    Dim toolTip1 As New ToolTip()
    Dim registro As New DataSet
    Dim objEsp As New i
    Private Sub CargarInfo2()
        Dim coco As New DataGridViewComboBoxColumn


        Dim dset As New DataSet
        Dim dtabla As New DataTable
        Dim ver As String = "SELECT id, categoria, nombreservi, tiposervi, precio, fecha FROM inventario "
        Dim adp As New OleDbDataAdapter(ver, Conexion)
         dset.Tables.Add("tabla")
        adp.Fill(dset.Tables("tabla"))
        metro1.DataSource = dset.Tables("tabla")




    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False" 'Le decimos donde está la base de datos.
            Conexion.Open() ' La abrimos...
            CargarInfo2()
            '  combollenas()
        Catch ex As Exception
            MsgBox("Error contacte al administrador (LYONS SOFTWARE//04163263438)", MsgBoxStyle.Critical, "Advertencia - Lavanderia Predilecta") 'Si no se puede advertimos al usuario.
        End Try

    End Sub
    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub combollenas()
        Dim engorilao As new DataGridViewComboBoxColumn
        metro1.Rows.Add(engorilao)




    End Sub
    Private Sub MetroLink2_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click

    End Sub

    Private Sub metro1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles metro1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    ' Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs)
    'Dim filt
    '  filt = String.Format("nombre Like '{0}%'", txtbuscar.Text)

    'metro1.Rows = filt

    'End Sub
End Class