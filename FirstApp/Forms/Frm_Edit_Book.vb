Imports DA.DA
Imports Bl.BL



Public Class Frm_Edit_Book
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim M As New BL_Frm_Edit_Book

        M.ISBN = TextBox1.Text
        M.Title = TextBox2.Text
        M.Subject = Val(ComboBox1.SelectedIndex) + 1
        M.Wirter = TextBox3.Text
        M.Publishers = TextBox4.Text
        M.YearDate = TextBox5.Text
        M.NumPage = Val(TextBox6.Text)
        M.Price = Val(TextBox7.Text)

        M.UpdateData()

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
        TextBox1.Text = ISBN_Code
        TextBox2.Text = DataGridView2.Item(1, 0).Value
        ComboBox1.SelectedIndex = Val(DataGridView2.Item(2, 0).Value) - 1
        TextBox3.Text = DataGridView2.Item(3, 0).Value
        TextBox4.Text = DataGridView2.Item(4, 0).Value
        TextBox5.Text = DataGridView2.Item(5, 0).Value
        TextBox6.Text = DataGridView2.Item(6, 0).Value
        TextBox7.Text = DataGridView2.Item(7, 0).Value


    End Sub
End Class