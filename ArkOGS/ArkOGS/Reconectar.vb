Public Class Reconectar


    Dim CP As New ChequeoPixeles() 'LLAMAR LA OTRA CLASE
    Declare Sub mouse_event Lib "user32" (ByVal dwFlags As UInteger, ByVal dx As UInteger, ByVal dy As UInteger, ByVal dwData As UInteger, ByVal dwExtraInfo As Integer)
    Const MOUSEEVENTF_LEFTDOWN As UInteger = &H2
    Const MOUSEEVENTF_LEFTUP As UInteger = &H4

    Dim cintentos As Integer
    Dim booleanBuscarServidorYEntrar, b, c, d As Boolean

    Async Function ClickIzq() As Task 'REALIZAR CLICK IZQUIERDO
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Await Task.Delay(100)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Function

    Public Async Function csicae() As Task 'CHEQUEA SI ESTA EN EL MENU Y SI DA ERROR DE CONEXION EN EL MENU CUANDO SE CAE, ESTE METODO SE LLAMA EN EL TIMER
        Await Task.Delay(3000)
        CP.X = 126
        CP.Y = 513
        CP.Screen()
        If CP.ColorPixel.R = 135 And CP.ColorPixel.G = 233 And CP.ColorPixel.B = 255 Then 'CHEQUEAR SI ESTA EN EL MENU PRINCIPAL
            Reconectar()
        Else
            CP.X = 762
            CP.Y = 381
            CP.Screen()
            If CP.ColorPixel.R = 136 And CP.ColorPixel.G = 233 And CP.ColorPixel.B = 255 Then 'CHEQUEAR SI ESTA EL CARTEL DE LOST CONEXION
                SaberSiEsLostConection()
                Reconectar()
            End If
        End If
    End Function
    Async Function SaberSiEsLostConection() As Task 'LOST CONEXION, ACEPTAR AL CARTEL
        Dim Principal As New Form1()
        Principal.Cursor = New Cursor(Cursor.Current.Handle)
        Await Task.Delay(1000)
        Cursor.Position = New Point(792, 596)
        Await Task.Delay(100)
        ClickIzq()
    End Function
    Async Function Reconectar() As Task
        Dim Principal As New Form1()
        'BUSCA EL SERVIDOR
        cintentos = 0
        booleanBuscarServidorYEntrar = True
        b = True
        c = True
        d = True
        Principal.Cursor = New Cursor(Cursor.Current.Handle)
        Await Task.Delay(1000)
        Cursor.Position = New Point(126, 513)
        Await Task.Delay(100)
        ClickIzq()
        Await Task.Delay(300)
        Cursor.Position = New Point(674, 137)
        Await Task.Delay(100)
        ClickIzq()
        Await Task.Delay(1000)
        SendKeys.Send("s56")
        BuscarServidorYEntrar()

    End Function
    Async Function BuscarServidorYEntrar() As Task
        'ENTRAR AL SERVIDOR Y SI NO APARECE ACTUALIZAR
        While (booleanBuscarServidorYEntrar = True)
            Await Task.Delay(800)
            CP.X = CInt(134)
            CP.Y = CInt(239)
            CP.X2 = CInt(1231)
            CP.Y2 = CInt(943)
            CP.Screen()
            If CP.ColorPixel.R = 255 And CP.ColorPixel.G = 255 And CP.ColorPixel.B = 186 Then 'CHEQUEAR SI EL SERVIDOR ESTA ENCONTRADO
                booleanBuscarServidorYEntrar = False
            ElseIf CP.ColorPixel2.R = 35 And CP.ColorPixel2.G = 125 And CP.ColorPixel2.B = 149 Then 'CHEQUEAR SI HAY QUE ACTUALIZAR
                Await Task.Delay(100)
                Cursor.Position = New Point(1154, 940)
                Await Task.Delay(100)
                ClickIzq()
            End If
        End While
        SiDaErrorOSiEntro()
    End Function
    Async Function SiDaErrorOSiEntro() As Task
        'CHEQUEA SI YA ESTA DENTRO O SI DIO ERROR DE CONEXION CON SERVIDOR
        Cursor.Position = New Point(752, 939)
        Await Task.Delay(100)
        ClickIzq()
        Dim i As Integer
        While (c = True)
            Await Task.Delay(3000)
            SendKeys.Send("{l}")
            CP.X = 924
            CP.Y = 43
            CP.X2 = 877
            CP.Y2 = 383
            CP.Screen()
            If CP.ColorPixel.R = 127 And CP.ColorPixel.G = 230 And CP.ColorPixel.B = 255 Then 'SI YA ESTA ADENTRO CON EL LOG
                c = False
            ElseIf CP.ColorPixel2.R = 255 And CP.ColorPixel2.G = 0 And CP.ColorPixel2.B = 0 Then 'SI DA ERROR AL CONECTAR
                cintentos = cintentos + 1
                If cintentos < 5 Then
                    Cursor.Position = New Point(959, 622)
                    Await Task.Delay(300)
                    ClickIzq()
                    Await Task.Delay(300)
                    BuscarServidorYEntrar()
                Else 'SI DIO ERROR 5 VECES SEGUIDAS
                    c = False
                    'CERRAR EL JUEGO
                    For Each prog As Process In Process.GetProcesses
                        If prog.ProcessName = "ShooterGame" Then
                            prog.Kill()
                        End If
                    Next
                    Await Task.Delay(15000)
                    'ABRIR EL JUEGO
                    System.Diagnostics.Process.Start("steam://rungameid/346110")
                End If
            End If
        End While
    End Function
End Class
