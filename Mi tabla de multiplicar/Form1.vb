Public Class Form1

    Private Sub Convertidor_Click(sender As Object, e As EventArgs) Handles Convertidor.Click
        If cbxentrada.Text = "Cajas" And cbxsalida.Text = "Cajas" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "C"
        ElseIf cbxentrada.Text = "Cajas" And cbxsalida.Text = "Unidades" Then
            lblr.Text = Val(txtcodigo.Text) * 5
            lblnum.Text = "U"
        ElseIf cbxentrada.Text = "Cajas" And cbxsalida.Text = "Saco" Then
            lblr.Text = Val(txtcodigo.Text) * 0.5
            lblnum.Text = "S"
        ElseIf cbxentrada.Text = "Cajas" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtcodigo.Text) * 2205
            lblnum.Text = "L"


        ElseIf cbxentrada.Text = "Unidades" And cbxsalida.Text = "Cajas" Then
            lblr.Text = Val(txtcodigo.Text) * 1
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
            lblr.Text = Val(txtcodigo.Text) * 2
            lblnum.Text = "C"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Unidades" Then
            lblr.Text = Val(txtcodigo.Text) / 0.1
            lblnum.Text = "U"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Saco" Then
            lblr.Text = Val(txtcodigo.Text) * 2
            lblnum.Text = "S"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtcodigo.Text)
            lblnum.Text = "L"
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(1)
    End Sub


End Class
