Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = My.Computer.Screen.Bounds.Width.ToString - Me.Width
        Me.Top = My.Computer.Screen.Bounds.Height.ToString - Me.Height
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t_start = Now
        t_second = DateDiff(DateInterval.Second, t_start, t_end)
        If t_second < 0 Then
            x = 0
            t_second = -t_second
        End If
        If t_second > 0 Then
            x = 1
        End If
        Dim m1 As Integer, s As Integer, m As Integer, h As Integer, d As Integer, h1 As Integer
        s = t_second Mod 60
        m1 = t_second \ 60
        m = m1 Mod 60
        h1 = m1 \ 60
        h = h1 Mod 60
        d = h1 \ 24
        If x < 0 Then
            Label1.Text = "已经过去" & d & “天” & h & "小时” & m & "分钟" & s & “秒”
        End If
        If x > 0 Then
            Label1.Text = "还剩" & d & “天” & h & "小时” & m & "分钟" & s & “秒”
        End If
    End Sub
End Class