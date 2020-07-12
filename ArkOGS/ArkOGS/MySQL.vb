Imports MySql.Data.MySqlClient
Public Class MySQL
    Public oConexion As New MySqlConnection
    Public Consulta, tabla As String
    Public oDataSet As New DataSet
    Public consultado As Boolean
    Public oComando As New MySqlCommand
    Public Sub Conectar() 'Conectar con la base de datos

        Dim oDataAdapter As New MySqlDataAdapter
        Dim sw As Boolean = False

        Try
            oConexion.ConnectionString = "server=localhost;database=ArkOGS;user=root;password=root;"
            oConexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
        End Try
    End Sub
    Public Sub Consultar()
        consultado = True
        Dim oDataAdapter As New MySqlDataAdapter
        Try
            oDataAdapter = New MySqlDataAdapter(Consulta, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, tabla)


        Catch ex As Exception
            MsgBox("error al consultar")
            consultado = False
        End Try
    End Sub
    Public Sub Insertar()
        oComando = New MySqlCommand("a")

    End Sub

End Class
