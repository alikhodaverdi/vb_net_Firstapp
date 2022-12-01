Public Class Home



    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Dim Fo2 As New Frm_New_Book
        Fo2.ShowDialog()
    End Sub



    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Fo3 As New Frn_Users
        Fo3.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim result = MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "اخطار", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Application.Exit()

        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
