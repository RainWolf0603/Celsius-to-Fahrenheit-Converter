Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F As Single
        F = c2f(Val(TextBox1.Text))
        TextBox2.Text = Math.Round(F, 2)
    End Sub

    Function c2f(ByVal n) As Single
        c2f = n * (9 / 5) + 32
    End Function
End Class
