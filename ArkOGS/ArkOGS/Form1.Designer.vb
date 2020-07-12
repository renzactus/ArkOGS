<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TimerChequeo = New System.Windows.Forms.Timer(Me.components)
        Me.CX = New System.Windows.Forms.TextBox()
        Me.CY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsiestaactivado = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(779, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CHEQUEAR "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 72)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "saber color de un pixel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(409, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 72)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "chequear si se cae"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TimerChequeo
        '
        Me.TimerChequeo.Interval = 3000
        '
        'CX
        '
        Me.CX.Location = New System.Drawing.Point(130, 39)
        Me.CX.Name = "CX"
        Me.CX.Size = New System.Drawing.Size(100, 20)
        Me.CX.TabIndex = 5
        '
        'CY
        '
        Me.CY.Location = New System.Drawing.Point(130, 65)
        Me.CY.Name = "CY"
        Me.CY.Size = New System.Drawing.Size(100, 20)
        Me.CY.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "GAMMA 2 Y COMPARTIR PANTALLA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(656, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CHEQUEO:"
        '
        'lsiestaactivado
        '
        Me.lsiestaactivado.AutoSize = True
        Me.lsiestaactivado.Font = New System.Drawing.Font("Noto Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsiestaactivado.ForeColor = System.Drawing.Color.Red
        Me.lsiestaactivado.Location = New System.Drawing.Point(788, 10)
        Me.lsiestaactivado.Name = "lsiestaactivado"
        Me.lsiestaactivado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lsiestaactivado.Size = New System.Drawing.Size(164, 28)
        Me.lsiestaactivado.TabIndex = 9
        Me.lsiestaactivado.Text = "DESACTIVADO"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 70)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "verLog"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(491, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 70)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "SACAR CAP Y SUBIR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 557)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lsiestaactivado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CY)
        Me.Controls.Add(Me.CX)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TimerChequeo As Timer
    Friend WithEvents CX As TextBox
    Friend WithEvents CY As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lsiestaactivado As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
End Class
