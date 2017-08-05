Public Class Form1
    Dim x As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength = 4 Then
            TextBox2.ReadOnly = False
            TextBox1.ReadOnly = True
            TextBox2.Focus()
        End If
        x = x + 1
        ProgressBar1.Value = x
        TextBox5.Text = x
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength = 4 Then
            TextBox3.ReadOnly = False
            TextBox2.ReadOnly = True
            TextBox3.Focus()
        End If
        x = x + 1
        ProgressBar1.Value = x
        TextBox5.Text = x
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength = 4 Then
            TextBox4.ReadOnly = False
            TextBox3.ReadOnly = True
            TextBox4.Focus()
        End If
        x = x + 1
        ProgressBar1.Value = x
        TextBox5.Text = x
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.TextLength = 4 Then
            TextBox4.ReadOnly = True
        End If
        x = x + 1
        ProgressBar1.Value = x
        TextBox5.Text = x
    End Sub
End Class
