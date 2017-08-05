Public Class Form1
    Private der As Single
    Private x1 As Single
    Private x2 As Single
    Private a As Long
    Private b As Long
    Private c As Long
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        If a = 0 Then
            MsgBox("二次项系数不得为零，请更正错误后重试。"， 48， "警告")
        Else
            der = b ^ (2) - 4 * a * c
            TextBox6.Text = der
            If der >= 0 Then
                x1 = (-b + Math.Sqrt(der)) / 2 * a
                x2 = (-b - Math.Sqrt(der)) / 2 * a
                TextBox4.Text = x1
                TextBox5.Text = x2
            Else
                MsgBox("方程无实数根", 64, "提示")
            End If
        End If



    End Sub
End Class
