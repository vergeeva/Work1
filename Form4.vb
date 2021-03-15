Public Class Form4
    Dim Count As Integer = 0
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem.ToString Is "Проказница Мартышка" Then
            If PictureBox1.ImageLocation = Nothing Then
                Dim pn As String = "C:\\Users\\nastya\\Desktop\\пары\\Информационные системы\\ЛР1\\bin\\Debug\\фото\\мартышка.jpg"
                PictureBox1.ImageLocation = pn
                Count += 1
            End If
        End If

        If ListBox1.SelectedItem.ToString Is "Осел" Then
            If PictureBox2.ImageLocation = Nothing Then
                Dim pn As String = "C:\\Users\\nastya\\Desktop\\пары\\Информационные системы\\ЛР1\\bin\\Debug\\фото\\Осел1.jpg"
                PictureBox2.ImageLocation = pn
                Count += 1
            End If
        End If

        If ListBox1.SelectedItem.ToString Is "Козел" Then
            If PictureBox3.ImageLocation = Nothing Then
                Dim pn As String = "C:\\Users\\nastya\\Desktop\\пары\\Информационные системы\\ЛР1\\bin\\Debug\\фото\\Козел.jpg"
                PictureBox3.ImageLocation = pn
                Count += 1
            End If
        End If

        If ListBox1.SelectedItem.ToString Is "Косолапый Мишка" Then
            If PictureBox4.ImageLocation = Nothing Then
                Dim pn As String = "C:\\Users\\nastya\\Desktop\\пары\\Информационные системы\\ЛР1\\bin\\Debug\\фото\\медведь.jpg"
                PictureBox4.ImageLocation = pn
                Count += 1
            End If
        End If
        If Count = 4 Then
            RichTextBox1.Text = "КВАРТЕТ"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub
End Class