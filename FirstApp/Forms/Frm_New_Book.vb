Imports Bl.BL
Imports DA

Public Class Frm_New_Book


    Private Sub Frm_New_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim M As New BL_Frm_New_Book
        DataGridView1.DataSource = M.SelectDataSub()
        Dim i
        For i = 0 To DataGridView1.Rows.Count - 1
            ComboBox1.Items.Add(DataGridView1.Item(1, i).Value)
        Next

    End Sub


End Class