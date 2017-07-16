Imports System.Data
Imports System.Data.OleDb

Public Class conexionBD

    'Instancia de la conexión
    Dim conexion As New OleDbConnection("Provider=microsoft.ace.oledb.12.0;Data Source=lavanderia.accdb;Persist Security Info=False")

    'Método que devuelve la conexión
    Public Function CNN() As OleDbConnection
        CNN = conexion
    End Function

    'Método que abre la conexión
    Public Sub conectar()
        conexion.Open()
    End Sub

    'Método que cierra la conexión
    Public Sub desconectar()
        conexion.Close()
    End Sub

End Class
Public Class Class2

End Class
