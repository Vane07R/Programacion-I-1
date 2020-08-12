Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla As SByte
        ntabla = txtntabla.Text

        lstTabla.Items.Clear()
        For i = 1 To 9
            lstTabla.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
        Next
    End Sub
End Class
