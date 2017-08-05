Public Class Form1
    Dim w As Double
    Dim x As Double
    Dim es As Date
    Dim s As Date
    Dim t As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("在计算过程中如出现程序未响应为正常现象，请勿强制结束此程序。", 48, "提示")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w = Val(TextBox1.Text)
        MsgBox("现在开始计算由1循环至" & w & "所用时间。", 64, "提示")
        s = TimeOfDay
        Label2.Text = s
        Do Until x = w
            x = x + 1
        Loop
        es = TimeOfDay
        Label4.Text = es
        t = DateDiff(DateInterval.Second, s, es)
        TextBox2.Text = t & "秒"
        MsgBox("您的计算机由1循环至" & w & "共花费" & t & "秒。", 64, "已完成计算")
        If t = 0 Then
            MsgBox("请增大循环位数的值", 48, "提示")
        End If
    End Sub
End Class
