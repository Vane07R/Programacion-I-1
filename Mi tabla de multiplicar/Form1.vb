Public Class Form1

    Private Sub Convertidor_Click(sender As Object, e As EventArgs) Handles Convertidor.Click
        'la caja equivale 25 kilogramo'
        'la caja equivale 55 libras'
        If cbxentrada.Text = "Cajas" And cbxsalida.Text = "Cajas" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "C"
        ElseIf cbxentrada.Text = "Cajas" And cbxsalida.Text = "Unidades" Then
            lblr.Text = Val(txtcodigo.Text) * 25
            lblnum.Text = "U"
        ElseIf cbxentrada.Text = "Cajas" And cbxsalida.Text = "Saco" Then
            lblr.Text = Val(txtcodigo.Text) * 0.5
            lblnum.Text = "S"
        ElseIf cbxentrada.Text = "Cajas" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtcodigo.Text) * 55
            lblnum.Text = "L"


        ElseIf cbxentrada.Text = "Unidades" And cbxsalida.Text = "Cajas" Then
            lblr.Text = Val(txtcodigo.Text) / 25
            lblnum.Text = "C"
        ElseIf cbxentrada.Text = "Unidades" And cbxsalida.Text = "Unidades" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "U"
        ElseIf cbxentrada.Text = "Unidades" And cbxsalida.Text = "Saco" Then
            lblr.Text = Val(txtcodigo.Text) * 1
            lblnum.Text = "S"
        ElseIf cbxentrada.Text = "Unidades" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtcodigo.Text) / 0.001
            lblnum.Text = "L"


        ElseIf cbxentrada.Text = "Saco" And cbxsalida.Text = "Cajas" Then
            lblr.Text = Val(txtcodigo.Text) * 0.1
            lblnum.Text = "C"
        ElseIf cbxentrada.Text = "Saco" And cbxsalida.Text = "Unidades" Then
            lblr.Text = Val(txtcodigo.Text) * 12
            lblnum.Text = "U"
        ElseIf cbxentrada.Text = "Saco" And cbxsalida.Text = "Saco" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "S"
        ElseIf cbxentrada.Text = "Saco" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtcodigo.Text) / 0.01
            lblnum.Text = "L"


        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Cajas" Then
            lblr.Text = Val(txtcodigo.Text) * 5
            lblnum.Text = "C"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Unidades" Then
            lblr.Text = Val(txtcodigo.Text) / 0.1
            lblnum.Text = "U"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Saco" Then
            lblr.Text = Val(txtcodigo.Text) / 0.01
            lblnum.Text = "S"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "L"
        End If

    End Sub

    Private Sub btnarea_Click(sender As Object, e As EventArgs) Handles btnarea.Click
        If cbxentrada3.Text = "Pie cuadrado" And cbxsalida3.Text = "Pie cuadrado" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "PC"
        ElseIf cbxentrada3.Text = "Pie cuadrado" And cbxsalida3.Text = "Vara cuadrada" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.13223088
            lblnum3.Text = "VC"
        ElseIf cbxentrada3.Text = "Pie cuadrado" And cbxsalida3.Text = "Yarda cuadrada" Then
            lblr3.Text = Val(txtcodigo3.Text) / 9
            lblnum3.Text = "YC"
        ElseIf cbxentrada3.Text = "Pie cuadrado" And cbxsalida3.Text = "Metro cuadrado" Then
            lblr3.Text = Val(txtcodigo3.Text) / 10.764
            lblnum3.Text = "MC"
        ElseIf cbxentrada3.Text = "Pie cuadrado" And cbxsalida3.Text = "Tareas" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.00014775
            lblnum3.Text = "T"
        ElseIf cbxentrada3.Text = "Pie cuadrado" And cbxsalida3.Text = "Manzana" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.00001319
            lblnum3.Text = "M"
        ElseIf cbxentrada3.Text = "Pie cuadrado" And cbxsalida3.Text = "Hectárea" Then
            lblr3.Text = Val(txtcodigo3.Text) / 107639
            lblnum3.Text = "HECT"
        End If
        If cbxentrada3.Text = "Manzana" And cbxsalida3.Text = "Manzana" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "M"
        ElseIf cbxentrada3.Text = "Manzana" And cbxsalida3.Text = "Pie cuadrado" Then
            lblr3.Text = Val(txtcodigo3.Text) * 75820.9849753
            lblnum3.Text = "PC"
        ElseIf cbxentrada3.Text = "Manzana" And cbxsalida3.Text = "Vara cuadrada" Then
            lblr3.Text = Val(txtcodigo3.Text) * 10000
            lblnum3.Text = "VC"
        ElseIf cbxentrada3.Text = "Manzana" And cbxsalida3.Text = "Yarda cuadrada" Then
            lblr3.Text = Val(txtcodigo3.Text) * 8424.5538861
            lblnum3.Text = "YC"
        ElseIf cbxentrada3.Text = "Manzana" And cbxsalida3.Text = "Metro cuadrado" Then
            lblr3.Text = Val(txtcodigo3.Text) * 6987.3878
            lblnum3.Text = "MC"
        ElseIf cbxentrada3.Text = "Manzana" And cbxsalida3.Text = "Tareas" Then
            lblr3.Text = Val(txtcodigo3.Text) * 16
            lblnum3.Text = "T"
        ElseIf cbxentrada3.Text = "Manzana" And cbxsalida3.Text = "Hectárea" Then
            lblr3.Text = Val(txtcodigo3.Text) * 0.705
            lblnum3.Text = "HECT"

        End If
        If cbxentrada3.Text = "Hectárea" And cbxsalida3.Text = "Hectárea" Then
            lblr3.Text = Val(txtcodigo3.Text)
            lblnum3.Text = "HECT"
        ElseIf cbxentrada3.Text = "Hectárea" And cbxsalida3.Text = "Pie cuadrado" Then
            lblr3.Text = Val(txtcodigo3.Text) * 107639
            lblnum3.Text = "PC"
        ElseIf cbxentrada3.Text = "Hectárea" And cbxsalida3.Text = "Vara cuadrada" Then
            lblr3.Text = Val(txtcodigo3.Text) * 7000
            lblnum3.Text = "VC"
        ElseIf cbxentrada3.Text = "Hectárea" And cbxsalida3.Text = "Yarda cuadrada" Then
            lblr3.Text = Val(txtcodigo3.Text) * 11959.9
            lblnum3.Text = "YC"
        ElseIf cbxentrada3.Text = "Hectárea" And cbxsalida3.Text = "Metro cuadrado" Then
            lblr3.Text = Val(txtcodigo3.Text) * 10000
            lblnum3.Text = "MC"
        ElseIf cbxentrada3.Text = "Hectárea" And cbxsalida3.Text = "Tareas" Then
            lblr3.Text = Val(txtcodigo3.Text) * 15.90330789
            lblnum3.Text = "T"
        ElseIf cbxentrada3.Text = "Hectárea" And cbxsalida3.Text = "Manzana" Then
            lblr3.Text = Val(txtcodigo3.Text) * 1.4184
            lblnum3.Text = "M"

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(1)
    End Sub
End Class
