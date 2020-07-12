Public Class ChequeoPixeles
    Public X, Y, X2, Y2 As Integer
    Public ColorPixel, ColorPixel2 As Color

    Public Sub Screen()
        'Sacar captura
        If X <> Nothing And Y <> Nothing Then
            Dim img As Bitmap
            Dim screenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            img = New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Dim g As Graphics = Graphics.FromImage(img)
            g.CopyFromScreen(New Point(0, 0), New Point(0, 0), screenSize)
            ColorPixel = img.GetPixel(X, Y)
            If X2 <> Nothing And Y2 <> Nothing Then
                ColorPixel2 = img.GetPixel(X2, Y2)
                X2 = Nothing
                Y2 = Nothing
            End If
            img.Dispose()
                GC.Collect()
                GC.WaitForPendingFinalizers()
                Y = Nothing
                X = Nothing
            Else
                MsgBox("LOS EJES DE RESOLUCION NO FUERON ASIGNADOS")
        End If


    End Sub
End Class