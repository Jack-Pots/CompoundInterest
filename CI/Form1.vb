Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P, N As Integer
        Dim R As Double
        P = TextBox1.Text
        R = TextBox2.Text
        N = TextBox3.Text
        TextBox4.Text = Math.Round(((P * (1 + (R / 100)) ^ N - 1) - P), 2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
