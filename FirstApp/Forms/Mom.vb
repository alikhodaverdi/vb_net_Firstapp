Public Class Mom
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim Fo2 As New Frm_New_Book
        Fo2.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim Fo3 As New Frm_Users
        Fo3.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim Fo4 As New Frm_Search
        Fo4.ShowDialog()
    End Sub
End Class
