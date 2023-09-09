Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MessageBox.Show("Login Berhasil Selamat datang Admin")
        Else MessageBox.Show("Password atau Username salah. Coba Lagi")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()

    End Sub
End Class
