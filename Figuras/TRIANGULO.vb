Public Class TRIANGULO

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text
        TextBox2.Text = TextBox2.Text
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text) / 2
        TextBox4.Text = Val(TextBox1.Text * 3)

    End Sub
End Class