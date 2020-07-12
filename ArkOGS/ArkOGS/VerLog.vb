Imports MySql.Data.MySqlClient
Public Class VerLog
    Dim mysql As New MySQL
    Dim img As Bitmap
    Dim sesubio As Boolean = False
    Dim mover As Boolean = False

    Dim lstr As New System.IO.MemoryStream()
    Sub DescargarImagen()
        mysql.Conectar()
        Dim bmap As Bitmap
        Dim cmd As New MySqlCommand("Select imagen from logenvivo where idusuario=?idusuario", mysql.oConexion)
        cmd.Parameters.AddWithValue("?idusuario", "1")
        Dim adapter As New MySqlDataAdapter
        adapter.SelectCommand = cmd

        Dim Data = New DataTable

        adapter = New MySqlDataAdapter("Select imagen from logenvivo where idusuario=1", mysql.oConexion)
        Dim commandbuild = New MySqlCommandBuilder(adapter)
        adapter.Fill(Data)

        Dim lb() As Byte = Data.Rows(0).Item("imagen")
        lstr = New System.IO.MemoryStream(lb)
        bmap = Image.FromStream(lstr)
        PictureBox1.Image = bmap
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        lstr.Close()
        mysql.oConexion.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim screenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        img = New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(img)
        g.CopyFromScreen(New Point(1341, 182), New Point(1341, 182), New Point(440, 816))

        PictureBox1.Image = img
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        mover = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'VISUALIZAR LA IMAGEN LOAD from MySQL db Back
        DescargarImagen()
    End Sub
End Class