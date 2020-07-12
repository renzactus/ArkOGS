Imports MySql.Data.MySqlClient
Public Class Form1

    Dim Reconectar As New Reconectar()
    Dim CP As New ChequeoPixeles() 'LLAMAR LA OTRA CLASE
    Dim mysql As New MySQL
    Dim img As Bitmap
    Dim sesubio As Boolean = False
    Dim mover As Boolean = False
    Dim imgg As Bitmap

    Dim cpr, cpp As Integer
    Dim ChequeandoSiSeCae As Boolean = True

    Sub PixelesRojosLog()
        'chequear si pixeles estan rojos en la zona | X 1342 a 1778 | Y 183 a 313 |
        For x As Integer = 0 To 435
            For y As Integer = 0 To 130
                Dim ColorPixel As Color = img.GetPixel(1342 + x, 183 + y)
                'MsgBox(" R:" & ColorPixel.R & " G:" & ColorPixel.G & " B:" & ColorPixel.B)
                If ColorPixel.R >= 230 And ColorPixel.G <= 1 And ColorPixel.B <= 1 Then
                    cpr = cpr + 1
                End If
            Next
        Next
        If cpr > 300 Then
            MsgBox("(ATACAN)pixeles rojos " & cpr)
        Else
            MsgBox("(NO ATACAN)pixeles rojos " & cpr)
            MsgBox("(NO ATACAN)pixeles rojos " & cpr)
            MsgBox("(NO ATACAN)pixeles rojos " & cpr)
            MsgBox("(NO ATACAN)pixeles rojos " & cpr)
        End If

    End Sub
    Sub Parasaurio()
        'chequear si pixeles estan cianes en la zona | X 108 a 1738 | Y 10 a 61 |
        For x As Integer = 0 To 1629
            For y As Integer = 0 To 50
                Dim ColorPixel As Color = img.GetPixel(108 + x, 10 + y)
                If ColorPixel.R = 0 And ColorPixel.G >= 250 And ColorPixel.B >= 220 Then
                    cpp = cpp + 1
                End If
            Next
        Next
        If cpp > 500 Then
            MsgBox("(PARASAUR DETECTING)pixeles cian " & cpp)
        Else
            MsgBox("(PARASAUR NOT DETECTING)pixeles cian " & cpp)
        End If
    End Sub
    Sub SubirImagen()
        sesubio = True
        'SACAR CAPTURA DE TODO EL LOG
        Dim screenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        imgg = New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(imgg)
        g.CopyFromScreen(New Point(1341, 182), New Point(1341, 182), New Point(440, 816))

        'Transformando imagen a "blob"
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        imgg.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        Dim insertarimagen, borrarimagen As New MySqlCommand
        mstream.Close()
        'SUBIR LA IMAGEN
        Try
            mysql.Conectar()
            With insertarimagen
                .CommandText = "insert into logenvivo (idusuario, imagen, tam) VALUES(@idusuario, @imagen, @tam)"
                .Connection = mysql.oConexion
                .Parameters.AddWithValue("@idusuario", "1")
                .Parameters.AddWithValue("@imagen", arrImage)
                .Parameters.AddWithValue("@tam", FileSize)

                .ExecuteNonQuery()
            End With
            mysql.oConexion.Close()
        Catch ex As Exception
            If ex.Message = "Fatal error encountered during command execution." Then
                'MsgBox("la imagen ya esta")
                'BORRAR LA IMAGEN QUE ESTA
                mysql.Consulta = "delete from logenvivo where idusuario=1"
                mysql.tabla = "logenvivo"
                mysql.Consultar()
                mysql.oConexion.Close()
                SubirImagen()
            Else
                MsgBox(ex.Message & "pp")
            End If
            sesubio = False
        Finally
            mysql.oConexion.Close()
        End Try
        If sesubio = True Then
            MsgBox("se subio subio correctamente")
            imgg.Dispose()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End If
    End Sub
    Private Sub chequeo_Tick(sender As Object, e As EventArgs) Handles TimerChequeo.Tick 'TIMER
        If ChequeandoSiSeCae = True Then
            Reconectar.csicae()
        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.Hide()
        Dim verLog As New VerLog
        verLog.Show()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Await Task.Delay(2000)
        cpr = 0
        cpp = 0
        'Screen()
        PixelesRojosLog()
        Parasaurio()

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SubirImagen()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'INICIAR CHEQUEO CON LABEL Q CAMBIA
        If TimerChequeo.Enabled = False Then
            Me.TimerChequeo.Enabled = True
            lsiestaactivado.Text = "Activado"
            lsiestaactivado.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Me.TimerChequeo.Enabled = False
            lsiestaactivado.Text = "Desactivado"
            lsiestaactivado.ForeColor = Color.FromArgb(255, 0, 0)
        End If
    End Sub
End Class