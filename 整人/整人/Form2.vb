Public Class Form2
    Dim tim1 As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = My.Computer.Screen.Bounds.Height
        Me.Width = My.Computer.Screen.Bounds.Width
        Timer1.Enabled = True
        tim1 = 10
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tim1 = tim1 - 1
        If tim1 = 0 Then
            Timer1.Enabled = False
            Me.Hide()
            Form3.Show()
        Else
            Label3.Text = "计算机将于" & tim1 & "秒后引爆！"
        End If
    End Sub
End Class