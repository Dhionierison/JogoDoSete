Public Class Form1
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles num2.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles num1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles num3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        End
    End Sub

    Private Sub btnjogar_Click(sender As Object, e As EventArgs) Handles btnjogar.Click
        imagemresultado.Visible = False
        Randomize()
        num1.Text = CStr(Int(Rnd() * 10))
        num2.Text = CStr(Int(Rnd() * 10))
        num3.Text = CStr(Int(Rnd() * 10))
        'Se todos os números forem iguais a 7
        If (num1.Text = "7") And (num2.Text = "7") And (num3.Text = "7") Then
            imagemresultado.Image = Image.FromFile("C:\Users\Dhyony\projetosc#\JogoDosSete\ganhoumax.png")
            imagemresultado.Visible = True
            Beep()
        ElseIf (num1.Text = "7") Or (num2.Text = "7") Or (num3.Text = "7") Then
            imagemresultado.Image = Image.FromFile("C:\Users\Dhyony\projetosc#\JogoDosSete\ganhou.png")
            imagemresultado.Visible = True
            Beep()
        Else
            imagemresultado.Image = Image.FromFile("C:\Users\Dhyony\projetosc#\JogoDosSete\gameover.png")
            imagemresultado.Visible = True

        End If
    End Sub
End Class
