Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DA.DA



Namespace BL
    Public Class BL_Frm_New_Book
        Inherits DataAccess

        Public ISBN As String
        Public Title As String
        Public Subject As Integer
        Public Wirter As String
        Public Publishers As String
        Public YearDate As String
        Public NumPage As Integer
        Public Price As Integer

        Public Function SelectDataSub() As DataTable
            MyBase.Link()
            Dim Query As String = "select * from Tb_Subject"
            Dim Output_Q As DataTable = MyBase.SelectData(Query)
            MyBase.UnLik()
            Return Output_Q
        End Function

        Public Sub Insertdata()
            MyBase.Link()
            Dim Query As String = "insert into Tb_Book (ISBN,Title,[Subject],wirter,publishers,YearDate,NumPage,Price)values(N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}','{6}','{7}')"
            Query = String.Format(Query, ISBN, Title, Subject, Wirter, Publishers, YearDate, NumPage, Price)

            MyBase.CommandText(Query)
            MyBase.UnLik()
            MessageBox.Show("Done !")


        End Sub




        'Public Sub Insertdata()
        '    MyBase.Link()
        '    Dim Query As String = "INSERT INTO Tb_Book (ISBN,Title,[Subject],wirter,publishers,YearDate,NumPage,Price)values(N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}','{6}','{7}')"
        '    Query = String.Format(Query, ISBN, Title, Subject, wirter, publishers, YearDate, NumPage, Price)
        '    MyBase.CommandText(Query)
        '    MyBase.UnLink()
        'End Sub

        'Public Sub Insertdata()
        '    'Dim Query As String = "INSERT INTO Tb_Book (ISBN,Title,[Subject],wirter,publishers,YearDate,NumPage,Price)values(N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}','{6}','{7}')"
        '    MyBase.Link()

        '    Dim Query As String = "INSERT INTO Tb_Book (ISBN,Title,[Subject],wirter,publishers,YearDate,NumPage,Price) VALUES (@C1, @C2,@C3,@C4,@C5,@C6,@C7)"


        '    com.Parameters.AddWithValue("@C1", ISBN)
        '    com.Parameters.AddWithValue("@C2", Title)
        '    com.Parameters.AddWithValue("@C3", Subject)
        '    com.Parameters.AddWithValue("@C4", wirter)
        '    com.Parameters.AddWithValue("@C5", publishers)
        '    com.Parameters.AddWithValue("@C6", YearDate)
        '    com.Parameters.AddWithValue("@C7", NumPage)
        '    com.Parameters.AddWithValue("@C8", Price)

        '    MyBase.CommandText(Query)
        '    MyBase.UnLink()

        'End Sub



        'Dim query As String = String.Empty("INSERT INTO Tb_Book (ISBN,Title,[Subject],wirter,publishers,YearDate,NumPage,Price) VALUES (@C1, @C2,@C3,@C4,@C5,@C6,@C7)")





        'Dim insertSql As String = "INSERT INTO StudentTable VALUES (?, ?, ?, ?, ?, ?, ?)"

        'Using conn As New OleDbConnection(connStr),
        '      cmd As New OleDbCommand(insertSql, conn)

        '    ''# I had to guess at types and lengths here. 
        '    ''# Adjust this to use actual types and lengths in your database
        '    cmd.Parameters.Add("?", OleDbType.Integer).Value = CInt(BadgeNoTextBox.Text)
        '    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = FirstNameTextBox.Text
        '    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = LastNameTextBox.Text
        '    cmd.Parameters.Add("?", OleDbType.Integer).Value = CInt(SAPSIDTextBox.Text)
        '    cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = EmailTextBox.Text
        '    cmd.Parameters.Add("?", OleDbType.VarChar, 20).Value = PhoneTextBox.Text
        '    cmd.Parameters.Add("?", OleDbType.VarWChar, 35).Value = CollegeComboBox.Text

        '    conn.Open()
        '    cmd.ExecuteNonQuery()
        'End Using


        'Using conn As New SqlConnection("connectionStringHere")
        'Using comm As New SqlCommand()
        'With comm
        '.Connection = conn
        '.CommandType = CommandType.Text
        '.CommandText = query
        '.Parameters.AddWithValue("@colName", strName)
        '.Parameters.AddWithValue("@colID", strId)
        '.Parameters.AddWithValue("@colPhone", strPhone)
        '.Parameters.AddWithValue("@colBranch", strBranch)
        '.Parameters.AddWithValue("@colCourse", strCourse)
        '.Parameters.AddWithValue("@coldblFee", dblFee)
        'End With
        'Try
        '    conn.open()
        '    comm.ExecuteNonQuery()
        'Catch(ex As SqlException)
        '    MessageBox.Show(ex.Message.ToString(), "Error Message")
        'End Try
        'End Using
        'End Using

        '       Using con As New MySqlConnection(strConnect)
        '    con.Open()
        '    Using com As New MySqlCommand("INSERT INTO myTable (myColumn1, myColumn2) VALUES (@C1, @C2)", con)
        '	com.Parameters.AddWithValue("@C1", myValueForColumn1)
        '	com.Parameters.AddWithValue("@C2", myValueForColumn2)
        '	com.ExecuteNonQuery()
        'End Using
        '       End Using




    End Class

End Namespace
