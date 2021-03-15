Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem.ToString() Is "Бегун" Then
            If TextBox1.Text.Equals("Певец") Or TextBox1.Text.Equals("певец") Then
                Label5.Text = "Число правильных ответов: 2/2"
            Else Label5.Text = "Число правильных ответов: 1/2"
            End If
        ElseIf TextBox1.Text.Equals("Певец") Or TextBox1.Text.Equals("певец") Then
            Label5.Text = "Число правильных ответов: 1/2"
        Else
            Label5.Text = "Число правильных ответов: 0/2"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Frm As Form4 = New Form4
        Frm.ShowDialog()
    End Sub
End Class