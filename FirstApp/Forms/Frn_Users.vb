Imports Bl.BL
Imports DA
Imports System.Data.SqlClient


Public Class Frn_Users
    Dim Con = New SqlConnection("Data Source=.;Initial Catalog=Beshel_EmptyData;Integrated Security=True")

    Private Sub Frm_All_Users(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim M As New BL_Frm_All_Users

        DataGridView1.DataSource = M.SelectDataSub()
    End Sub


    Public Function Save_User(ByVal )

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PersonName.Text = "" Or PersonNameLatin.Text = "" Or PersonalityCode.Text = "" Or PersonEconomy.Text = "" Or PersonShortName.Text = "" Then
            MsgBox("اطلاعات ناقص است")
        Else
            Try
                Con.Open()
                Dim query = "insert into Persons values"
                Con.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim result = MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "اخطار", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class