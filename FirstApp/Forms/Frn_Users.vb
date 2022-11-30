Imports Bl.BL
Imports DA

Public Class Frn_Users


    Private Sub Frm_All_Users(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim M As New BL_Frm_All_Users

        DataGridView1.DataSource = M.SelectDataSub()
    End Sub


End Class