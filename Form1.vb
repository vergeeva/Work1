Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim pn As String = "C:\\Users\\nastya\\Desktop\\пары\\Информационные системы\\ЛР1\\bin\\Debug\\фото\\Лев1.jpg"
        PictureBox1.ImageLocation = pn
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim pn As String = "C:\\Users\\nastya\\Desktop\\пары\\Информационные системы\\ЛР1\\bin\\Debug\\фото\\Осел.jpg"
        PictureBox1.ImageLocation = pn
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim pn As String = "C:\\Users\\nastya\\Desktop\\пары\\Информационные системы\\ЛР1\\bin\\Debug\\фото\\Кролик.jpg"
        PictureBox1.ImageLocation = pn
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Frm As Form = New Form2
        Frm.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
