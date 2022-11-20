Imports Bl.BL
Imports DA

Public Class Frm_Users

    Private Sub Frm_All_Users(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim M As New BL_Frm_All_Users

        DataGridView1.DataSource = M.SelectDataSub()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Fo3 As New Frm_New_User
        Fo3.ShowDialog()


    End Sub
End Class