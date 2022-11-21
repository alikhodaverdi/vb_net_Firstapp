Imports DA.DA
Imports Bl.BL



Public Class Frm_Edit_Book
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Frm_Edit_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim M As New BL_Frm_Edit_Book

        DataGridView1.DataSource = M.SelectDataSub()
        Dim i
        For i = 0 To DataGridView1.Rows.Count - 2
            ComboBox1.Items.Add(DataGridView1.Item(1, i).Value)
        Next

        M.ISBN = ISBN_Code
        DataGridView2.DataSource = M.SelectDataSub_A()
    End Sub
End Class