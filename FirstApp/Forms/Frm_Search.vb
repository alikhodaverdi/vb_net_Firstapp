Imports Bl.BL

Public Class Frm_Search


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim M As New BL_Frm_Search
        M.renge = ComboBox1.SelectedIndex
        M.TextCommand = TextBox1.Text

        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = M.Select_Data_A()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If DataGridView1.CurrentRow.Index <> -1 And DataGridView1.CurrentCell.ColumnIndex = 0 Then
            ISBN_Code = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            Dim Fo4 As New Frm_Edit_Book
            Fo4.ShowDialog()
        ElseIf DataGridView1.CurrentRow.Index <> -1 And DataGridView1.CurrentCell.ColumnIndex = 1 Then
            Select Case MessageBox.Show("آیا از حذف اطلاعات اطمنیان دارید ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    Dim M As New BL_Frm_Search
                    M.Isbn = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
                    M.DeleteData()

                    DataGridView1.DataBindings.Clear()
                    DataGridView1.DataSource = M.Select_Data
                Case DialogResult.No
            End Select


        End If

    End Sub

    Private Sub Frm_Search_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ComboBox1.SelectedIndex = 1
        Dim M As New BL_Frm_Search
        DataGridView1.DataSource = M.Select_Data
    End Sub
End Class