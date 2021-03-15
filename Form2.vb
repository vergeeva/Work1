Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Right1.Checked = True Then
            If Right2.Checked = True Then
                If Right3.Checked = True Then
                    Message.Text = "Ваш результат очень хороший!"
                Else Message.Text = "Ваш результат средний"
                End If
            ElseIf Right3.Checked = True Then
                Message.Text = "Ваш результат средний"
            Else Message.Text = "Ваш результат не такой уж и плохой"

            End If
        ElseIf Right2.Checked = True Then
            If Right3.Checked = True Then
                Message.Text = "Ваш результат средний!"
            Else Message.Text = "Ваш результат не такой уж и плохой"
            End If
        ElseIf Right3.Checked = True Then
            Message.Text = "Ваш результат не такой уж и плохой"
        Else Message.Text = "Ваш результат очень плохой:("
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Frm As Form3 = New Form3
        Frm.ShowDialog()
    End Sub
End Class