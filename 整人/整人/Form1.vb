Public Class Form1
    Dim tim As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = My.Computer.Screen.Bounds.Height
        Me.Width = My.Computer.Screen.Bounds.Width
        tim = 10
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim x1 As Int16
        x1 = MsgBox("自毁模式已成功激活"， 48, “警告”)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tim = 0 Then
            Timer1.Enabled = False
            Dim x2 As Int16
            x2 = MsgBox("自毁模式已成功激活"， 48, “警告”)
            Me.Hide()
            Form2.Show()
        Else
            tim = tim - 1
            Label2.Text = "警告：自毁程序将于" & tim & "秒后准备就绪。"
            ProgressBar1.Value = tim
        End If
    End Sub
End Class
