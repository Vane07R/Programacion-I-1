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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lstejercicios = New System.Windows.Forms.ListBox()
        Me.btnparimpar = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(448, 265)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(162, 35)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Numeros pares e Impares"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lstejercicios
        '
        Me.lstejercicios.FormattingEnabled = True
        Me.lstejercicios.Location = New System.Drawing.Point(448, 60)
        Me.lstejercicios.Name = "lstejercicios"
        Me.lstejercicios.Size = New System.Drawing.Size(162, 199)
        Me.lstejercicios.TabIndex = 1
        '
        'btnparimpar
        '
        Me.btnparimpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnparimpar.Location = New System.Drawing.Point(12, 223)
        Me.btnparimpar.Name = "btnparimpar"
        Me.btnparimpar.Size = New System.Drawing.Size(127, 51)
        Me.btnparimpar.TabIndex = 2
        Me.btnparimpar.Text = "Par o Impar?"
        Me.btnparimpar.UseVisualStyleBackColor = True
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(157, 148)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(115, 20)
        Me.txtnum.TabIndex = 3
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(101, 148)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(50, 13)
        Me.lblnum.TabIndex = 4
        Me.lblnum.Text = "Numero: "
        '
        'btnPrimo
        '
        Me.btnPrimo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimo.Location = New System.Drawing.Point(145, 223)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(127, 51)
        Me.btnPrimo.TabIndex = 5
        Me.btnPrimo.Text = "Primo?"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnCajero
        '
        Me.btnCajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.Location = New System.Drawing.Point(278, 223)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(127, 51)
        Me.btnCajero.TabIndex = 6
        Me.btnCajero.Text = "Cajero"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnparimpar)
        Me.Controls.Add(Me.lstejercicios)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "Form1"
        Me.Text = "Estructuras de control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents lstejercicios As ListBox
    Friend WithEvents btnparimpar As Button
    Friend WithEvents txtnum As TextBox
    Friend WithEvents lblnum As Label
    Friend WithEvents btnPrimo As Button
    Friend WithEvents btnCajero As Button
End Class
