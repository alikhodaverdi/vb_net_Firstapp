Imports Bl.BL
Imports DA

Public Class Frm_New_Book


    Private Sub Frm_New_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim M As New BL_Frm_New_Book

        DataGridView1.DataSource = M.SelectDataSub()
        Dim i
        For i = 0 To DataGridView1.Rows.Count - 2
            ComboBox1.Items.Add(DataGridView1.Item(1, i).Value)
        Next

    End Sub

    Private Sub Save_Books()
        Dim M As New BL_Frm_New_Book
        M.ISBN = TextBox1.Text
        M.Title = TextBox2.Text
        M.Subject = ComboBox1.SelectedIndex + 1
        M.Wirter = TextBox3.Text
        M.Publishers = TextBox4.Text
        M.YearDate = TextBox5.Text
        M.NumPage = Val(TextBox6.Text)
        M.Price = Val(TextBox7.Text)
        M.Insertdata()

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                If ComboBox1.SelectedIndex <> -1 Then
                    If TextBox3.Text <> "" Then
                        If TextBox4.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox6.Text <> "" Then
                                    If TextBox7.Text <> "" Then
                                        Call Save_Books()

                                    Else
                                        MessageBox.Show("نام انتشارات کتاب را وارد نمایید", "خطا")
                                        TextBox4.Focus()
                                    End If
                                Else
                                    MessageBox.Show("سال انتشار کتاب را وارد نمایید", "خطا")
                                    TextBox4.Focus()
                                End If
                            Else
                                MessageBox.Show("تعداد صفحه کتاب را وارد نمایید", "خطا")
                                TextBox3.Focus()
                            End If
                        Else
                            MessageBox.Show("قیمت کتاب را وارد نمایید", "خطا")
                            TextBox4.Focus()
                        End If
                    Else
                        MessageBox.Show("نام نویسنده کتاب را وارد نمایید", "خطا")
                        TextBox3.Focus()
                    End If
                Else
                    MessageBox.Show("موضوع کتاب را وارد نمایید", "خطا")
                    ComboBox1.Focus()
                End If
            Else
                MessageBox.Show("عنوان کتاب را وارد کنید", "خطا")
                TextBox2.Focus()
            End If
        Else
            MessageBox.Show("کد کتاب را وارد نمایید", "خطا")
            TextBox1.Focus()
        End If
    End Sub


End Class