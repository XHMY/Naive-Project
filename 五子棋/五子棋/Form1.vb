Public Class Form1
    Dim x As Integer
    Dim z As Long
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click, Label14.Click, Label15.Click, Label16.Click, Label17.Click, Label18.Click, Label19.Click, Label20.Click, Label21.Click, Label22.Click, Label23.Click, Label24.Click, Label25.Click, Label26.Click, Label27.Click, Label28.Click, Label29.Click, Label30.Click, Label31.Click, Label32.Click, Label33.Click, Label34.Click, Label35.Click, Label36.Click, Label37.Click, Label38.Click, Label39.Click, Label40.Click, Label41.Click, Label42.Click, Label43.Click, Label44.Click, Label45.Click, Label46.Click, Label47.Click, Label48.Click, Label49.Click, Label50.Click, Label51.Click, Label52.Click, Label53.Click, Label54.Click, Label55.Click, Label56.Click, Label57.Click, Label58.Click, Label59.Click, Label60.Click, Label61.Click, Label62.Click, Label63.Click, Label64.Click
        Dim label As Label = CType(sender, Label)
        If z = 0 Then
            z = 1
            Label65.BackColor = Color.Yellow
        Else
            z = 0
            Label65.BackColor = Color.Blue
        End If
        If z = 1 Then
            label.BackColor = Color.Blue
        Else
            label.BackColor = Color.Yellow
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        For x = 0 To 63
            Panel1.Controls.Item(x).BackColor = Color.White
        Next
        Label65.BackColor = Color.White
    End Sub
End Class
