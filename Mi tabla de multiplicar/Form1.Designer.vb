<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRespuestaRomano = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRespuestaRomano
        '
        Me.lblRespuestaRomano.AutoSize = True
        Me.lblRespuestaRomano.Location = New System.Drawing.Point(215, 51)
        Me.lblRespuestaRomano.Name = "lblRespuestaRomano"
        Me.lblRespuestaRomano.Size = New System.Drawing.Size(99, 13)
        Me.lblRespuestaRomano.TabIndex = 11
        Me.lblRespuestaRomano.Text = "Numero Romano: ?"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(107, 48)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(102, 20)
        Me.txtnumero.TabIndex = 10
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(62, 51)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(42, 13)
        Me.lblnumero.TabIndex = 9
        Me.lblnumero.Text = "Capital:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(85, 117)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(148, 47)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 213)
        Me.Controls.Add(Me.lblRespuestaRomano)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Tabla de Multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRespuestaRomano As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lblnumero As Label
    Friend WithEvents btnCalcular As Button
End Class
