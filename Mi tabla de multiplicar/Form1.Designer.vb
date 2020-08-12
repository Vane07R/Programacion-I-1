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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optmodulo = New System.Windows.Forms.RadioButton()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(96, 75)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(41, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "Num 1:"
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(384, 75)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(41, 13)
        Me.lblnum2.TabIndex = 1
        Me.lblnum2.Text = "Num 2:"
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Location = New System.Drawing.Point(266, 75)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(61, 17)
        Me.optSuma.TabIndex = 2
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "Suma +"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(266, 144)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(70, 17)
        Me.optDividir.TabIndex = 3
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "Division /"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(266, 121)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(96, 17)
        Me.optMultiplicar.TabIndex = 4
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "Multiplicacion *"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(266, 167)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(87, 17)
        Me.optPorcentaje.TabIndex = 5
        Me.optPorcentaje.TabStop = True
        Me.optPorcentaje.Text = "Porcentaje %"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(266, 194)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(110, 17)
        Me.optExponenciacion.TabIndex = 6
        Me.optExponenciacion.TabStop = True
        Me.optExponenciacion.Text = "Exponenciacion ^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(266, 98)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(59, 17)
        Me.optResta.TabIndex = 3
        Me.optResta.TabStop = True
        Me.optResta.Text = "Resta -"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optmodulo
        '
        Me.optmodulo.AutoSize = True
        Me.optmodulo.Location = New System.Drawing.Point(266, 217)
        Me.optmodulo.Name = "optmodulo"
        Me.optmodulo.Size = New System.Drawing.Size(46, 17)
        Me.optmodulo.TabIndex = 7
        Me.optmodulo.TabStop = True
        Me.optmodulo.Text = "Mod"
        Me.optmodulo.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(141, 75)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 8
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(431, 68)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 60)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(549, 71)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblrespuesta.TabIndex = 11
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.optmodulo)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form1"
        Me.Text = "Tabla de Multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum1 As Label
    Friend WithEvents lblnum2 As Label
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optmodulo As RadioButton
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblrespuesta As Label
End Class
