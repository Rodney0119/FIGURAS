Public Class RECTANGULO
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
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox4.Text = Val(2 * TextBox1.Text) + Val(2 * TextBox2.Text)
    End Sub
End Class