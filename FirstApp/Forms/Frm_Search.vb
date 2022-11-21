Imports Bl.BL

Public Class Frm_Search
    Private Sub Frm_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 1
        Dim M As New BL_Frm_Search
        DataGridView1.DataSource = M.Select_Data
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim M As New BL_Frm_Search
        M.renge = ComboBox1.SelectedIndex
        M.TextCommand = TextBox1.Text

        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = M.Select_Data_A()

    End Sub
End Class