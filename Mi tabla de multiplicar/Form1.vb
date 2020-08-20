Public Class Form1
    Private Sub btnlongitud_Click(sender As Object, e As EventArgs) Handles btnlongitud.Click
        If cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) / 10
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 1000
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 1000000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0394
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 0.00328084
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 0.00109361
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) * 0.000000621371
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0001
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.01
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 100000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 0.393701
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0328084
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 0.0109361
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) * 0.00000621371
            lblnum.Text = "Milla"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.001
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.1
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 1000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 39.3701
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 3.28084
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 1.09361
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) * 0.000621371
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 0.1
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000000.0
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 100000
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 39370
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 3281
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 1094
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 1.609
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 10000
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 25.4
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 2.54
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 39.97
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 39370
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) / 12
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) / 36
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 63360
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 394
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) / 3.937
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 305
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 30.48
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 3.281
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 3281
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 12
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) / 3
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 5280
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 32.808
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 3.048
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 914
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 91.44
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 1.094
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 1094
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 36
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 3
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 1760
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 10.936
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 9.144
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1609000.0
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 160934
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) * 1609
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) * 1.609
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 63360
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 5280
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 1760
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) * 161
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 16093
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 10000
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 394
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) * 32.808
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) * 10.936
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 161
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtcodigo.Text) / 10
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtcodigo.Text) / 10000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Pulgada" Then
            lblr.Text = Val(txtcodigo.Text) * 3.937
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Pie" Then
            lblr.Text = Val(txtcodigo.Text) / 3.048
            lblnum.Text = "pie"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtcodigo.Text) / 9.144
            lblnum.Text = "yard"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtcodigo.Text) / 16093
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Decámetro" Then
            lblr.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "dam"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Decímetro" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "dm"
        End If
    End Sub

    Private Sub btnalmacenamiento_Click(sender As Object, e As EventArgs) Handles btnalmacenamiento.Click
        If cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.001
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000001
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000000001
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000000000001
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 0.000000000000001
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E-18
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E-21
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Kilobyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7.8125
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1.0E+15
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1.0E+18
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8000000.0
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Megabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7813
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000000.0
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1.0E+15
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8000000000.0
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Gigabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7812000.0
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000000.0
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8000000000000.0
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Terabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7812000000.0
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000000.0
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8.0E+15
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Petabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7812000000000.0
            lblnum1.Text = "KBB"

        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+15
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000000.0
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 8.0E+18
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Exabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7.812E+15
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+18
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+15
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1000
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Zettabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 7.812E+18
            lblnum1.Text = "KBB"

        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+18
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1.0E+15
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1000
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Yottabyte" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 9.223E+18
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000000.0
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000000000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8000000000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8.0E+15
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 8.0E+18
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 9.223E+18
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 9.223E+18
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Bit" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text) / 1024
            lblnum1.Text = "KBB"


        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Kilobyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7.812
            lblnum1.Text = "KB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Megabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7813
            lblnum1.Text = "MB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Gigabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7812000.0
            lblnum1.Text = "GB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Terabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7812000000.0
            lblnum1.Text = "TB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Petabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7812000000000.0
            lblnum1.Text = "PB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Exabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 976600000000000.0
            lblnum1.Text = "EB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Zettabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 7.813E+18
            lblnum1.Text = "ZB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Yottabyte" Then
            lblr1.Text = Val(txtcodigo1.Text) / 9.223E+18
            lblnum1.Text = "YB"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Bit" Then
            lblr1.Text = Val(txtcodigo1.Text) * 1024
            lblnum1.Text = "Bit"
        ElseIf cbxentrada1.Text = "Kibibit" And cbxsalida1.Text = "Kibibit" Then
            lblr1.Text = Val(txtcodigo1.Text)
            lblnum1.Text = "KBB"
        End If
    End Sub

    Private Sub btntiempo_Click(sender As Object, e As EventArgs) Handles btntiempo.Click
        If cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000000.0
            lblnum2.Text = "Seng"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60000000000.0
            lblnum2.Text = "Min"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600000000000.0
            lblnum2.Text = "Hora"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400000000000.0
            lblnum2.Text = "Dia"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800000000000.0
            lblnum2.Text = "Smn"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2.628E+15
            lblnum2.Text = "Mes"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3.154E+16
            lblnum2.Text = "A.N"


        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 0.001
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000.0
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60000000.0
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600000000.0
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400000000.0
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800000000.0
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2628000000000.0
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Microsegundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 31540000000000.0
            lblnum2.Text = "A N"

        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60000
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600000.0
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400000.0
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800000.0
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2628000000.0
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Milisegundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 31540000000.0
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1000
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2628000.0
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Segundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 31540000.0
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60000
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1440
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 10080
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 43800
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Minuto" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 525600
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3600
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 60
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 24
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 168
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 730
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Hora" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 8760
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 86400
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 1440
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 24
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 7
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 30.417
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Día" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 365
            lblnum2.Text = "A N"



        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800000000000.0
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 604800
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 10080
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 168
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) * 7
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 4.345
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Semana" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 52.143
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2.628E+15
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2628000000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2628000000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 2628000.0
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 43800
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 730
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) * 30.417
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) * 4.345
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 4.345
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Mes" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 52.143
            lblnum2.Text = "A N"


        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Nanosegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 3.154E+16
            lblnum2.Text = "NS"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 31540000000000.0
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 31540000000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) * 31540000.0
            lblnum2.Text = "Segundos"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) * 525600
            lblnum2.Text = "Minutos"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) * 8760
            lblnum2.Text = "Horas"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) * 365
            lblnum2.Text = "Dias"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) * 52.143
            lblnum2.Text = "Semanas"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 12
            lblnum2.Text = "Meses"
        ElseIf cbxentrada2.Text = "Año natural" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text)
            lblnum2.Text = "A N"
        End If
    End Sub

    Private Sub btnmoneda_Click(sender As Object, e As EventArgs) Handles btnmoneda.Click
        If cbxentrada3.Text = "Nanosegundo" And cbxsalida3.Text = "Nanosegundo" Then
            lblr3.Text = Val(txtcodigo2.Text)
            lblnum3.Text = "NS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Microsegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000
            lblnum2.Text = "MS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Milisegundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000.0
            lblnum2.Text = "MLS"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Segundo" Then
            lblr2.Text = Val(txtcodigo2.Text) / 1000000000.0
            lblnum2.Text = "Seng"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Minuto" Then
            lblr2.Text = Val(txtcodigo2.Text) / 60000000000.0
            lblnum2.Text = "Min"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Hora" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3600000000000.0
            lblnum2.Text = "Hora"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Día" Then
            lblr2.Text = Val(txtcodigo2.Text) / 86400000000000.0
            lblnum2.Text = "Dia"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Semana" Then
            lblr2.Text = Val(txtcodigo2.Text) / 604800000000000.0
            lblnum2.Text = "Smn"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Mes" Then
            lblr2.Text = Val(txtcodigo2.Text) / 2.628E+15
            lblnum2.Text = "Mes"
        ElseIf cbxentrada2.Text = "Nanosegundo" And cbxsalida2.Text = "Año natural" Then
            lblr2.Text = Val(txtcodigo2.Text) / 3.154E+16
            lblnum2.Text = "A.N"
        End If
    End Sub
End Class
