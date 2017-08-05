Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        CheckBox1.Text = "使用现在的时间" & Now & "作为开始时间"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            FlowLayoutPanel1.Visible = True
        End If
        If CheckBox1.Checked = True Then
            FlowLayoutPanel1.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckBox1.Text = "使用现在的时间" & Now & "作为开始时间"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim year As Int32, month As Int32, day As Int32, hour As Int32, min As Int32, second As Int32
        year = TextBox1.Text
        month = TextBox2.Text
        day = TextBox3.Text
        hour = TextBox4.Text
        min = TextBox5.Text
        second = TextBox6.Text
        Dim t As New System.DateTime(year, month, day, hour, min, second)
        t_end = t
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
        Dim a As Int16
        s = t_second Mod 60
        m1 = t_second \ 60
        m = m1 Mod 60
        h1 = m1 \ 60
        h = h1 Mod 60
        d = h1 \ 24
        If x < 0 Then
            a = MsgBox("距离目标时间已经过去" & d & “天” & h & "小时” & m & "分钟" & s & “秒” & vbNewLine & "是否显示计时器", 65)
            MsgBox(s)
        End If
        If x > 0 Then
            MsgBox(s)
            a = MsgBox("距离目标时间还有" & d & “天” & h & "小时” & m & "分钟" & s & “秒” & vbNewLine & "是否显示计时器", 65)
        End If
        If a = 1 Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class
