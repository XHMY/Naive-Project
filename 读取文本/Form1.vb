Public Class Form1
    Dim oapp As Object
    Dim odoc As Object
    Dim content As Object
    Dim tex As String
    Dim s As String '文档中的内容
    Dim length As Long '整个文档的长度
    Dim lj As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load '窗体加载入内存的事件
        '此过程用于加载word入内存并为几个常用变量赋值
        lj = InputBox("请输入需要读写的Word文档路径", "路径")
        oapp = CreateObject("Word.Application") '创建并返回一个对 Word.Application 对象的引用
        oapp.Visible = False
        odoc = oapp.Documents.Open(lj) '可以更改目录名
        '将word在后台打开，并赋值给对象型变量“odoc”
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '2号按钮被单击事件
        '此过程用于读取word中原有的内容
        content = odoc.Content.Text '将word内容读取出来并赋值给对象型变量content
        s = content '将对象性变量赋值给字符串变量
        TextBox2.Text = "以下是原有内容： " + vbNewLine + s
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '1号按钮单击事件
        '此过程用于写入文本
        If TextBox1.Text = "" Then
            MsgBox("此处不能为空，请输入文本后重试。", 48, "警告")
        Else
            tex = TextBox1.Text
            content = odoc.Content.Text '将word内容读取出来并赋值给对象型变量content
                s = content '将对象性变量赋值给字符串变量
            odoc.content.text = s & tex '在不删除原来文本的基础上加入文本
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '3号按钮单击事件
        '此过程用于关闭已打开的word并结束程序
        On Error Resume Next '强制跳过运行时错误
        odoc.close(True) '此处有一个未知错误
        oapp.quit(False) '这一句与上一句都是关闭word文档用的
        End '结束程序
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)
        content = odoc.Content.Text '将word内容读取出来并赋值给对象型变量content
        s = content '将对象性变量赋值给字符串变量
        TextBox2.Text = "以下是原有内容： " + vbNewLine + s
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        odoc.content.text = ""
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Dim he As Int16
        he = MsgBox("此软件由曾委员长制作,如果本软件有不足之处请理解,本人初学编程.欢迎交流QQ:2521909657",, "关于")
    End Sub
End Class