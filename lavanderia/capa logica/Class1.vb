Imports System.Data
Imports System.Data.OleDb

Public Class i
    'Instancia de la clase de conexión
    Dim cnx As New conexionBD

    'Método para listar las especialidades
    Public Function listar() As DataTable
        Dim tabla As New DataTable
        cnx.conectar()
        Dim da As New OleDbDataAdapter("select * from Inventario", cnx.CNN())
        da.Fill(tabla)
        cnx.desconectar()
        listar = tabla
    End Function


    'Método para insertar nuevos servicios
    Public Sub insertar(ByVal gatubela As String, ByVal batman As String, ByVal joder As String, ByVal guazon As String)
        Dim consulta As String = "insert into Servicios (Codservicio,Servicio,Precio,Fecha) values('" & gatubela & "','" & joder & "','" & batman & "','" & guazon & "')"
        cnx.conectar()
        Dim comando As New OleDbCommand(consulta, cnx.CNN())
        comando.ExecuteNonQuery()

        cnx.desconectar()
    End Sub
    'Método para insertar nuevas prendas
    Public Sub innint(ByVal codigo As String, ByVal prendad As String, ByVal fecha As String)

        Dim consulta As String = "insert into Prendas (Codprenda,Prenda,fecha) values('" & codigo & "','" & prendad & "','" & fecha & "')"
        cnx.conectar()
        Dim comando As New OleDbCommand(consulta, cnx.CNN())
        comando.ExecuteNonQuery()

        cnx.desconectar()
    End Sub
    'Método para insertarimpuesto
    Public Sub imput(ByVal iva As String)

        Dim consulta As String = "insert into impuesto (impuestos) values('" & iva & "')"
        cnx.conectar()
        Dim comando As New OleDbCommand(consulta, cnx.CNN())
        comando.ExecuteNonQuery()

        cnx.desconectar()
    End Sub
    'Método para Clientes
    Public Sub clin(ByVal one As String, ByVal two As String, ByVal thre As String, ByVal fol As String, ByVal five As String, ByVal six As String)

        Dim consulta As String = "insert into Cliente (Cedula,Nombre,Apellido,Telefono,Direccion,fecha) values('" & one & "','" & two & "','" & thre & "','" & fol & "','" & five & "','" & six & "')"
        cnx.conectar()
        Dim comando As New OleDbCommand(consulta, cnx.CNN())
        comando.ExecuteNonQuery()

        cnx.desconectar()
    End Sub


    Public Sub modificar(ByVal id As String, ByVal txtcedula As String, ByVal txtnombre As String, ByVal txtapellido As String, ByVal txttelefono As String, ByVal txtdireccion As String)
        Dim consulta As String = "update Cliente set " &
                                 "Cedula = '" & txtcedula & "',Nombre='" & txtnombre & "',Apellido='" & txtapellido & "'," &
                                 "Telefono='" & txttelefono & "',Direccion='" & txtdireccion & "' "

        cnx.conectar()
        Dim comando As New OleDbCommand(consulta, cnx.CNN())
        comando.ExecuteNonQuery()

        cnx.desconectar()
    End Sub











End Class
