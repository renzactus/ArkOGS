Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim mysql As New MySQL
    Sub Login()
        mysql.Conectar()
        mysql.Consulta = "Select * from usuarios where usuario='" & cusuario.Text & "' and contraseña='" & ccontraseña.Text & "'"
        mysql.tabla = "usuarios"
        mysql.Consultar()
        If mysql.consultado = True Then
            If mysql.oDataSet.Tables("usuarios").Rows.Count() <> 0 Then 'Saber si nos responde con mas de 0 filas para saber si coinciden los datos
                MessageBox.Show("Bienvenido al Sistema", "Sistema")
                mysql.oConexion.Close()
                Me.Hide()
                Dim Principal As New Form1
                Principal.Show()
            Else
                MessageBox.Show("datos invalidos", "Sistema")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Login As New LoginForm
        Me.Hide()
        Dim Principal As New Form1
        Principal.Show()
        'Dim verlog As New VerLog
        'VerLog.Show()
    End Sub
End Class